using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe PeriodeTemporelle
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe PeriodeTemporelle 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 7, le 09/01/2020
    /// Implémentation des méthodes de récupération de l'Identifiant d'une période temporelle et de création d'une période temporelle</remarks>
    class PeriodeTemporelle : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idPeriodTempo;
        public string libPeriodTempo;

        //--------------------------------Accesseur--------------------------------
        public int AccIdPeriodTempo
        {
            get { return this.idPeriodTempo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la période temporelle ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPeriodTempo = value;
                }
            }
        }

        public string AccLibPeriodTempo
        {
            get { return this.libPeriodTempo; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé de la période temporelle ne peut pas être vide.");
                }
                else if (value.Length > 30)
                {
                    throw new Exception("Le libellé de la période temporelle ne peut pas excédé 30 caractères.");
                }
                else
                {
                    this.libPeriodTempo = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe PeriodeTemporelle</summary>
        public PeriodeTemporelle() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe PeriodeTemporelle</summary>
        public PeriodeTemporelle(int numPeriodTempo, string nomPeriodTempo)
        {
            AccIdPeriodTempo = numPeriodTempo;
            AccLibPeriodTempo = nomPeriodTempo;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe PeriodeTemporelle</summary>
        public PeriodeTemporelle(string nomPeriodTempo)
        {
            AccLibPeriodTempo = nomPeriodTempo;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'une période temporelle
        /// </summary>
        /// <param name="periodeChoisi">Récupère le nom de la période temporelle indiquée par l'utilisateur</param>
        /// <returns>Retourne l'identifiant de la période temporelle</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant de la période temporelle n'a pas pu être trouvé</exception>
        public static int TrouvNumPeriode(PeriodeTemporelle periodeChoisi)
        {
            try
            {
                int numPeriode = 0;
                Connection();
                string cmdNumPeriode = ("select idperiotemp from periode_temporelle where libperiotemp='" + periodeChoisi.AccLibPeriodTempo + "'");
                SqlCommand trouvNumPeriode = new SqlCommand(cmdNumPeriode, maConnexion);
                SqlDataReader lecteurPeriode = trouvNumPeriode.ExecuteReader();

                if (lecteurPeriode.HasRows)
                {
                    while (lecteurPeriode.Read())
                    {
                        numPeriode = int.Parse(lecteurPeriode[0].ToString());
                    }
                    lecteurPeriode.Close();
                }
                else
                {
                    lecteurPeriode.Close();
                    //Appel la méthode de création d'une période temporelle si la période mentionnée n'existe pas en base de données
                    InsertPeriode(periodeChoisi.AccLibPeriodTempo);

                    SqlCommand trouvNumPeriodeCree = new SqlCommand(cmdNumPeriode, maConnexion);
                    SqlDataReader lecteurPeriodeCree = trouvNumPeriodeCree.ExecuteReader();

                    if (lecteurPeriodeCree.HasRows)
                    {
                        while (lecteurPeriodeCree.Read())
                        {
                            numPeriode = int.Parse(lecteurPeriodeCree[0].ToString());
                        }
                    }
                    lecteurPeriodeCree.Close();
                }
                return numPeriode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer une nouvelle période temporelle lorsque l'utilisateur entre un genre inconnu dans l'un des formulaires
        /// </summary>
        /// <param name="appelPeriode">Récupère le nom de la période temporelle entré par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom de la période temporelle qui a été créé</returns>
        /// <exception cref="">Renvoie une erreur si le nom de la période temporelle entré est invalide</exception>
        private static string InsertPeriode(string appelPeriode)
        {
            try
            {
                string libCreaPeriod;
                Connection();
                libCreaPeriod = "Insert into Periode_temporelle (libperiotemp) values (";
                libCreaPeriod += "'" + appelPeriode + "')";
                SqlCommand creaPeriodBdd = new SqlCommand(libCreaPeriod, maConnexion);
                creaPeriodBdd.ExecuteScalar();
                return appelPeriode;
            }
            catch
            {
                throw new Exception("Impossible de créer une nouvelle période temporelle.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom de la période temporelle en fonction de son identifiant
        /// </summary>
        /// <param name="identifiantPeriod">Récupère l'identifiant de la période temporelle</param>
        /// <returns>Retourne le nom de la période temporelle correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si la période temporelle n'a pas pu être trouvé</exception>
        public static string TrouvNomPeriode(int identifiantPeriod)
        {
            try
            {
                string AppelationPeriode = "";
                Connection();
                string cmdNomPeriode = ("select libperiotemp from periode_temporelle where idperiotemp='" + identifiantPeriod + "'");
                SqlCommand trouvNomPeriode = new SqlCommand(cmdNomPeriode, maConnexion);
                SqlDataReader lecteurNomPeriode = trouvNomPeriode.ExecuteReader();

                if (lecteurNomPeriode.HasRows)
                {
                    while (lecteurNomPeriode.Read())
                    {
                        AppelationPeriode = lecteurNomPeriode[0].ToString();
                    }
                }
                lecteurNomPeriode.Close();
                return AppelationPeriode;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom de la période temporelle.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des périodes temporelles existantes en base de données
        /// </summary>
        /// <returns>Retourne la liste des périodes temporelles</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupéré</exception>
        public static ArrayList RecupListePeriode()
        {
            try
            {
                ArrayList listPeriod = new ArrayList();
                Connection();
                string cmdListPeriod = ("select libperiotemp from periode_temporelle");
                SqlCommand trouvListPeriod = new SqlCommand(cmdListPeriod, maConnexion);
                SqlDataReader lecteurListPeriod = trouvListPeriod.ExecuteReader();

                if (lecteurListPeriod.HasRows)
                {
                    while (lecteurListPeriod.Read())
                    {
                        listPeriod.Add(lecteurListPeriod[0].ToString());
                    }
                }
                lecteurListPeriod.Close();
                return listPeriod;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des périodes temporelles.");
            }
        }
    }
}
