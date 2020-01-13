using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe SérieLivre
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe SérieLivre 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 9, le 13/01/2020
    /// Implémentation des méthodes de récupération de l'Identifiant d'une série de livre et de sa création</remarks>
    class SerieLivre : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idSerieLivre;
        public string libSerieLivre;

        //--------------------------------Accesseur--------------------------------
        public int AccIdSerieLivre
        {
            get { return this.idSerieLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la série de livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idSerieLivre = value;
                }
            }
        }

        public string AccLibSerieLivre
        {
            get { return this.libSerieLivre; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé de la série de livre ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le libellé de la série de livre ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libSerieLivre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe SerieLivre</summary>
        public SerieLivre() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe SerieLivre</summary>
        public SerieLivre(int numSerieLivre, string nomSerieLivre)
        {
            AccIdSerieLivre = numSerieLivre;
            AccLibSerieLivre = nomSerieLivre;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe SerieLivre</summary>
        public SerieLivre(string nomSerieLivre)
        {
            AccLibSerieLivre = nomSerieLivre;
        }
        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'une série de livre
        /// </summary>
        /// <param name="serieChoisi">Récupère le nom de la série de livre indiquée par l'utilisateur</param>
        /// <returns>Retourne l'identifiant de la série de livre</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant de la série de livre n'a pas pu être trouvé</exception>
        public static int TrouvNumSerie(SerieLivre serieChoisi)
        {
            try
            {
                int numSerie = 0;
                Connection();
                string cmdNumSerie = ("select idserieliv from serie_de_livre where libserieliv='" + serieChoisi.AccLibSerieLivre + "'");
                SqlCommand trouvNumSerie = new SqlCommand(cmdNumSerie, maConnexion);
                SqlDataReader lecteurSerie = trouvNumSerie.ExecuteReader();

                if (lecteurSerie.HasRows)
                {
                    while (lecteurSerie.Read())
                    {
                        numSerie = int.Parse(lecteurSerie[0].ToString());
                    }
                    lecteurSerie.Close();
                }
                else
                {
                    lecteurSerie.Close();
                    //Appel la méthode de création d'une période temporelle si la période mentionnée n'existe pas en base de données
                    InsertSerie(serieChoisi.AccLibSerieLivre);

                    SqlCommand trouvNumSerieCree = new SqlCommand(cmdNumSerie, maConnexion);
                    SqlDataReader lecteurSerieCree = trouvNumSerieCree.ExecuteReader();

                    if (lecteurSerieCree.HasRows)
                    {
                        while (lecteurSerieCree.Read())
                        {
                            numSerie = int.Parse(lecteurSerieCree[0].ToString());
                        }
                    }
                    lecteurSerieCree.Close();
                }
                return numSerie;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer une nouvelle série de livre lorsque l'utilisateur entre une série inconnue dans l'un des formulaires
        /// </summary>
        /// <param name="appelSerie">Récupère le nom de la série de livre entrée par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom de la série de livre qui a été créée</returns>
        /// <exception cref="">Renvoie une erreur si le nom de la série de livre entrée est invalide</exception>
        private static string InsertSerie(string appelSerie)
        {
            try
            {
                string libCreaSerie;
                Connection();
                libCreaSerie = "Insert into serie_de_livre (libserieliv) values (";
                libCreaSerie += "'" + appelSerie + "')";
                SqlCommand creaSerieBdd = new SqlCommand(libCreaSerie, maConnexion);
                creaSerieBdd.ExecuteScalar();
                return appelSerie;
            }
            catch
            {
                throw new Exception("Impossible de créer une nouvelle série de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom de la série de livre en fonction de son identifiant
        /// </summary>
        /// <param name="identifiantSerie">Récupère l'identifiant de la série de livre</param>
        /// <returns>Retourne le nom de la série de livre correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si la série de livre n'a pas pu être trouvée</exception>
        public static string TrouvNomSerie(int identifiantSerie)
        {
            try
            {
                string AppelationSerie = "";
                Connection();
                string cmdNomSerie = ("select libserieliv from serie_de_livre where idserieliv='" + identifiantSerie + "'");
                SqlCommand trouvNomSerie = new SqlCommand(cmdNomSerie, maConnexion);
                SqlDataReader lecteurNomSerie = trouvNomSerie.ExecuteReader();

                if (lecteurNomSerie.HasRows)
                {
                    while (lecteurNomSerie.Read())
                    {
                        AppelationSerie = lecteurNomSerie[0].ToString();
                    }
                }
                lecteurNomSerie.Close();
                return AppelationSerie;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom de la série de livre.");
            }
        }
    }
}
