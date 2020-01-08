using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe Pays
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Pays 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 2, le 07/01/2020
    /// Implémentation des méthodes de récupération de l'Identifiant d'un pays et de création d'un nouveau pays</remarks>
    class Pays : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idPays;
        public string libPays;

        //--------------------------------Accesseur--------------------------------
        public int AccIdPays
        {
            get { return this.idPays; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du Pays ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPays = value;
                }
            }
        }

        public string AccLibPays
        {
            get { return this.libPays; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé du Pays ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le nom du pays ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libPays = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Pays</summary>
        public Pays() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Pays</summary>
        public Pays(int numPays, string nomPays)
        {
            AccIdPays = numPays;
            AccLibPays = nomPays;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Pays</summary>
        public Pays(string nomPays)
        {
            AccLibPays = nomPays;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de renvoyer le numéro du pays en fonction du nom indiqué. 
        /// </summary>
        /// <param name="nomPays">Nom du pays soumis à la méthode</param>
        /// <returns>Retourne le numéro du pays correspondant</returns>
        /// <exception cref="">Renvoie une erreur si le nom du pays ne correspond à rien dans la base de données</exception>
        public int TrouvNumPays (string nomPays)
        {
            try
            {
                int numPays = 0;
                Connection();
                string comdNumPays = ("select idPays from pays where libpays='" + nomPays + "'");
                SqlCommand trouvNumPays = new SqlCommand(comdNumPays, maConnexion);
                SqlDataReader lecteur = trouvNumPays.ExecuteReader();

                if (lecteur.HasRows)
                {
                    while (lecteur.Read())
                    {
                        numPays = int.Parse(lecteur[0].ToString());
                    }
                    lecteur.Close();
                }
                else
                {
                    lecteur.Close();
                    //Appel la méthode de création d'un pays si le pays mentionné n'existe pas en base de données
                    InsertPays(nomPays);

                    SqlCommand trouvNumPaysCree = new SqlCommand(comdNumPays, maConnexion);
                    SqlDataReader lecteurPaysCree = trouvNumPaysCree.ExecuteReader();

                    if (lecteurPaysCree.HasRows)
                    {
                        while (lecteurPaysCree.Read())
                        {
                            numPays = int.Parse(lecteurPaysCree[0].ToString());
                        }
                    }
                    lecteurPaysCree.Close();
                }
                return numPays;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer un nouveau pays lorsque l'utilisateur entre un pays inconnu dans l'un des formulaires
        /// </summary>
        /// <param name="libPays">Récupère le nom du pays entr par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom du pays qui a été créé</returns>
        /// <exception cref="">Renvoie une erreur si le nom du pays entré est invalide</exception>
        private string InsertPays(string libPays)
        {
            try
            {
                string libCreaPays;
                Connection();
                libCreaPays = "Insert into Pays (libpays) values (";
                libCreaPays += "'" + libPays + "')";
                SqlCommand creaPaysBdd = new SqlCommand(libCreaPays, maConnexion);
                creaPaysBdd.ExecuteScalar();
                return libPays;
            }
            catch
            {
                throw new Exception("Impossible de créer un nouveau pays.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom du pays en fonction de son identifiant
        /// </summary>
        /// <param name="identPays">Récupère l'identifiant du pays</param>
        /// <returns>Retourne le nom du pays correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si le pays n'a pas pu être trouvé</exception>
        public static string TrouvNomPays(int identPays)
        {
            try
            {
                string AppelationPays = "";
                Connection();
                string cmdNomPays = ("select libpays from pays where idpays='" + identPays + "'");
                SqlCommand trouvNomPays = new SqlCommand(cmdNomPays, maConnexion);
                SqlDataReader lecteurNomPays = trouvNomPays.ExecuteReader();

                if (lecteurNomPays.HasRows)
                {
                    while (lecteurNomPays.Read())
                    {
                        AppelationPays = lecteurNomPays[0].ToString();
                    }
                }
                lecteurNomPays.Close();
                return AppelationPays;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom du pays.");
            }
        }
    }
}
