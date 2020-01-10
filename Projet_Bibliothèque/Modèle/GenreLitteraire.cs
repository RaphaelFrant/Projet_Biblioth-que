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
    /// Classe GenreLitteraire
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe GenreLittéraire 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 6, le 09/01/2020
    /// Implémentation des méthodes de récupération de l'Identifiant d'un genre littéraire et de création d'un nouveau genre littéraire</remarks>
    class GenreLitteraire : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idGenreLitt;
        public string libGenreLitt;

        //--------------------------------Accesseur--------------------------------
        public int AccIdGenreLitt
        {
            get { return this.idGenreLitt; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du genre littéraire du livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idGenreLitt = value;
                }
            }
        }

        public string AccLibGenreLitt
        {
            get { return this.libGenreLitt; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé du genre littéraire du livre ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le libellé du genre littéraire ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libGenreLitt = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe GenreLitteraire</summary>
        public GenreLitteraire() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe GenreLitteraire</summary>
        public GenreLitteraire(int numGenreLitt, string nomGenreLitt)
        {
            AccIdGenreLitt = numGenreLitt;
            AccLibGenreLitt = nomGenreLitt;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe GenreLitteraire</summary>
        public GenreLitteraire(string nomGenreLitt)
        {
            AccLibGenreLitt = nomGenreLitt;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'un genre littéraire
        /// </summary>
        /// <param name="genreChoisi">Récupère un objet Genre littéraire à partir des informations saisies par l'utilisateur</param>
        /// <returns>Retourne l'identifiant du genre littéraire</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant du genre littéraire n'a pas pu être trouvé</exception>
        public static int TrouvNumGenre(GenreLitteraire genreChoisi)
        {
            try
            {
                int numGenre = 0;
                Connection();
                string cmdNumGenre = ("select idgenre from genre_litteraire where libgenre='" + genreChoisi.AccLibGenreLitt + "'");
                SqlCommand trouvNumGenre = new SqlCommand(cmdNumGenre, maConnexion);
                SqlDataReader lecteurGenre = trouvNumGenre.ExecuteReader();

                if (lecteurGenre.HasRows)
                {
                    while (lecteurGenre.Read())
                    {
                        numGenre = int.Parse(lecteurGenre[0].ToString());
                    }
                    lecteurGenre.Close();
                }
                else
                {
                    lecteurGenre.Close();
                    //Appel la méthode de création d'un pays si le pays mentionné n'existe pas en base de données
                    InsertGenre(genreChoisi.AccLibGenreLitt);

                    SqlCommand trouvNumGenreCree = new SqlCommand(cmdNumGenre, maConnexion);
                    SqlDataReader lecteurGenreCree = trouvNumGenreCree.ExecuteReader();

                    if (lecteurGenreCree.HasRows)
                    {
                        while (lecteurGenreCree.Read())
                        {
                            numGenre = int.Parse(lecteurGenreCree[0].ToString());
                        }
                    }
                    lecteurGenreCree.Close();
                }
                return numGenre;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer un nouveau genre littéraire lorsque l'utilisateur entre un genre inconnu dans l'un des formulaires
        /// </summary>
        /// <param name="appelGenre">Récupère le nom du genre littéraire entré par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom du genre littéraire qui a été créé</returns>
        /// <exception cref="">Renvoie une erreur si le nom du genre littéraire entré est invalide</exception>
        private static string InsertGenre(string appelGenre)
        {
            try
            {
                string libCreaGenre;
                Connection();
                libCreaGenre = "Insert into Genre_litteraire (libgenre) values (";
                libCreaGenre += "'" + appelGenre + "')";
                SqlCommand creaGenreBdd = new SqlCommand(libCreaGenre, maConnexion);
                creaGenreBdd.ExecuteScalar();
                return appelGenre;
            }
            catch
            {
                throw new Exception("Impossible de créer un nouveau genre littéraire.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom du genre littéraire en fonction de son identifiant
        /// </summary>
        /// <param name="identifiantGenre">Récupère l'identifiant du genre littéraire</param>
        /// <returns>Retourne le nom du genre littéraire correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si le genre littéraire n'a pas pu être trouvé</exception>
        public static string TrouvNomGenre(int identifiantGenre)
        {
            try
            {
                string AppelationGenre = "";
                Connection();
                string cmdNomGenre = ("select libgenre from genre_littéraire where idgenre='" + identifiantGenre + "'");
                SqlCommand trouvNomGenre = new SqlCommand(cmdNomGenre, maConnexion);
                SqlDataReader lecteurNomGenre = trouvNomGenre.ExecuteReader();

                if (lecteurNomGenre.HasRows)
                {
                    while (lecteurNomGenre.Read())
                    {
                        AppelationGenre = lecteurNomGenre[0].ToString();
                    }
                }
                lecteurNomGenre.Close();
                return AppelationGenre;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom du genre littéraire.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des genres littéraires existants en base de données
        /// </summary>
        /// <returns>Retourne la liste des genres littéraires</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupéré</exception>
        public static ArrayList RecupListeGenre()
        {
            try
            {
                ArrayList listGenre = new ArrayList();
                Connection();
                string cmdLisGenre = ("select libgenre from genre_litteraire");
                SqlCommand trouvListGenre = new SqlCommand(cmdLisGenre, maConnexion);
                SqlDataReader lecteurListGenre = trouvListGenre.ExecuteReader();

                if (lecteurListGenre.HasRows)
                {
                    while (lecteurListGenre.Read())
                    {
                        listGenre.Add(lecteurListGenre[0].ToString());
                    }
                }
                lecteurListGenre.Close();
                return listGenre;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des genres littéraires.");
            }
        }
    }
}
