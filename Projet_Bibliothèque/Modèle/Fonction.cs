using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe Fonction
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Fonction 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 5, le 08/01/2020
    /// Implémentation des méthodes de récupération de l'Identifiant d'une fonction et de création d'une nouvelle fonction</remarks>
    class Fonction : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idFonct;
        public string libFonct;

        //--------------------------------Accesseur--------------------------------
        public int AccIdFonct
        {
            get { return this.idFonct; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la fonction d'un intervenant ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idFonct = value;
                }
            }
        }

        public string AccLibFonct
        {
            get { return this.libFonct; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé d'une fonction d'un intervenant ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le libellé de la fonction de l'intervenant ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libFonct = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Fonction</summary>
        public Fonction() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Fonction</summary>
        public Fonction(int numFonct, string nomFonct)
        {
            AccIdFonct = numFonct;
            AccLibFonct = nomFonct;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Fonction</summary>
        public Fonction(string nomFonct)
        {
            AccLibFonct = nomFonct;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de renvoyer le numéro de la fonction d'un intervenant
        /// </summary>
        /// <param name="nomFonction">Nom de la fonction soumis à la méthode</param>
        /// <returns>Retourne le numéro de la fonction correspondant</returns>
        /// <exception cref="">Renvoie une erreur si le nom de la fonction ne correspond à rien dans la base de données</exception>
        public int TrouvNumFonction(string nomFonction)
        {
            try
            {
                int numFonct = 0;
                Connection();
                string comdNumFonct = ("select idfonction from fonction where libfonction='" + nomFonction + "'");
                SqlCommand trouvNumFonct = new SqlCommand(comdNumFonct, maConnexion);
                SqlDataReader lecteurFonct = trouvNumFonct.ExecuteReader();

                if (lecteurFonct.HasRows)
                {
                    while (lecteurFonct.Read())
                    {
                        numFonct = int.Parse(lecteurFonct[0].ToString());
                    }
                    lecteurFonct.Close();
                }
                else
                {
                    lecteurFonct.Close();
                    //Appel la méthode de création d'un pays si le pays mentionné n'existe pas en base de données
                    InsertFonction(nomFonction);

                    SqlCommand trouvNumPaysCree = new SqlCommand(comdNumFonct, maConnexion);
                    SqlDataReader lecteurFonctCree = trouvNumPaysCree.ExecuteReader();

                    if (lecteurFonctCree.HasRows)
                    {
                        while (lecteurFonctCree.Read())
                        {
                            numFonct = int.Parse(lecteurFonctCree[0].ToString());
                        }
                    }
                    lecteurFonctCree.Close();
                }
                return numFonct;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer une nouvelle fonction lorsque l'utilisateur entre une fonction inconnue dans l'un des formulaires
        /// </summary>
        /// <param name="libFonct">Récupère le nom de la fonction entrée par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom de la fonction qui a été créé</returns>
        /// <exception cref="">Renvoie une erreur si le nom de la fonction entré est invalide</exception>
        private string InsertFonction(string libFonct)
        {
            try
            {
                string libCreaFonct;
                Connection();
                libCreaFonct = "Insert into Fonction (libfonction) values (";
                libCreaFonct += "'" + libFonct + "')";
                SqlCommand creaFonctBdd = new SqlCommand(libCreaFonct, maConnexion);
                creaFonctBdd.ExecuteScalar();
                return libCreaFonct;
            }
            catch
            {
                throw new Exception("Impossible de créer une nouvelle fonction.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom de la fonction en fonction de son identifiant
        /// </summary>
        /// <param name="identFonct">Récupère l'identifiant de la fonction</param>
        /// <returns>Retourne le nom de la fonction correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si la fonction n'a pas pu être trouvé</exception>
        public static string TrouvNomFonction(int identFonct)
        {
            try
            {
                string AppelationFonct = "";
                Connection();
                string cmdNomFonct = ("select libfonction from fonction where idfonction='" + identFonct + "'");
                SqlCommand trouvNomFonct = new SqlCommand(cmdNomFonct, maConnexion);
                SqlDataReader lecteurNomFonct = trouvNomFonct.ExecuteReader();

                if (lecteurNomFonct.HasRows)
                {
                    while (lecteurNomFonct.Read())
                    {
                        AppelationFonct = lecteurNomFonct[0].ToString();
                    }
                }
                lecteurNomFonct.Close();
                return AppelationFonct;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom de la fonction.");
            }
        }
    }
}
