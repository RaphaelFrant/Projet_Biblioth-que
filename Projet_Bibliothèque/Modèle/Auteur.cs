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
    /// Classe Auteur
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Auteur 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 2, le 07/01/2020
    /// Implémentation de la méthode de création, la modification et la suppression d'un nouvel auteur</remarks>
    class Auteur : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idAut;
        public int idPaysAut;
        public string nomAut;
        public string prenomAut;
        public string surnomAut;
        public DateTime dateNaiAut;
        public string dateMortAut;

        //--------------------------------Accesseur--------------------------------
        public int AccIdAut
        {
            get { return this.idAut; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de l'auteur ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idAut = value;
                }
            }
        }

        public int AccIdPaysAut
        {
            get { return this.idPaysAut; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du pays de l'auteur ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPaysAut = value;
                }
            }
        }

        public string AccNomAut
        {
            get { return this.nomAut; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le nom de l'auteur ne peut pas être vide.");
                }
                else
                {
                    this.nomAut = value;
                }
            }
        }

        public string AccPrenomAut
        {
            get { return this.prenomAut; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le prénom de l'auteur ne peut pas être vide.");
                }
                else
                {
                    this.prenomAut = value;
                }
            }
        }

        public string AccSurnomAut
        {
            get { return this.surnomAut; }
            set
            {
                this.surnomAut = value;
            }
        }

        public DateTime AccDateNaiAut
        {
            get { return this.dateNaiAut; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date de naissance de l'auteur ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateNaiAut = value;
                }
            }
        }

        public string AccDateMortAut
        {
            get { return this.dateMortAut; }
            set
            {
                if(value == "")
                {
                    this.dateMortAut = null;
                }
                else
                {
                    if (DateTime.Parse(value) >= DateTime.Today)
                    {
                        throw new ArgumentOutOfRangeException("La date de décès de l'auteur ne peut pas être supérieur à la date du jour.");
                    }
                    else
                    {
                        this.dateMortAut = value;
                    }
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Auteur</summary>
        public Auteur() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Auteur</summary>
        public Auteur(int numAuteur, int numPaysAuteur, string nomAuteur, string prenomAuteur, string pseudoAuteur, DateTime dateNaiAuteur, string dateDecesAuteur)
        {
            AccIdAut = numAuteur;
            AccIdPaysAut = numPaysAuteur;
            AccNomAut = nomAuteur;
            AccPrenomAut = prenomAuteur;
            AccSurnomAut = pseudoAuteur;
            AccDateNaiAut = dateNaiAuteur;
            AccDateMortAut = dateDecesAuteur;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Auteur</summary>
        public Auteur(int numPaysAuteur, string nomAuteur, string prenomAuteur, string pseudoAuteur, DateTime dateNaiAuteur, string dateDecesAuteur)
        {
            AccIdPaysAut = numPaysAuteur;
            AccNomAut = nomAuteur;
            AccPrenomAut = prenomAuteur;
            AccSurnomAut = pseudoAuteur;
            AccDateNaiAut = dateNaiAuteur;
            AccDateMortAut = dateDecesAuteur;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de créer un auteur dans la base de données
        /// </summary>
        /// <param name="nouvAut">Récupère un objet Auteur créé à partir de la vue</param>
        /// <exception cref="">Renvoie une exception si l'auteur n'a pas pu être créé</exception>
        public static void InsertAuteur(Auteur nouvAut)
        {
            string libAut;
            try
            {
                Connection();
                libAut = "Insert into Auteur(idPays, nomAut, prenomAut, surnomAut, dateNaiAut, dateMortAut)values (";
                libAut += "'" + nouvAut.AccIdPaysAut + "', ";
                libAut += "'" + nouvAut.AccNomAut + "', ";
                libAut += "'" + nouvAut.AccPrenomAut + "', ";
                libAut += "'" + nouvAut.AccSurnomAut + "', ";
                libAut += "'" + nouvAut.AccDateNaiAut + "', ";
                libAut += "'" + nouvAut.AccDateMortAut + "')";
                SqlCommand creaBdd = new SqlCommand(libAut, maConnexion);
                creaBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant d'établir la liste des auteurs présents en base de données
        /// </summary>
        /// <returns>Retourne une arraylist comportant les noms et prénoms des auteurs existants</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut être récupéré</exception>
        public static ArrayList ListeAuteurExist()
        {
            ArrayList listeChoixAut = new ArrayList();
            try
            {
                Connection();
                string cmdListeAut = ("select concat(nomaut, ' ', prenomaut) from auteur order by nomaut");
                SqlCommand trouvChoixAut = new SqlCommand(cmdListeAut, maConnexion);
                SqlDataReader lecteurListeAut = trouvChoixAut.ExecuteReader();

                if (lecteurListeAut.HasRows)
                {
                    while (lecteurListeAut.Read())
                    {
                        listeChoixAut.Add(lecteurListeAut[0].ToString());
                    }
                }
                lecteurListeAut.Close();
                return listeChoixAut;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des auteurs existants.");
            }
        }

        /// <summary>
        /// Méthode permettant de supprimer un auteur existant dans la base de données
        /// </summary>
        /// <param name="libAuteur">Récupère le nom de l'auteur sélectionné par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si le nom de l'auteur sélectionné est invalide</exception>
        public static void DeleteAuteur(string libAuteur)
        {
            try
            {
                string libSupprAut;
                Connection();
                libSupprAut = "Delete from auteur where concat(nomaut, ' ', prenomaut) like '" + libAuteur + "'";
                SqlCommand supprAutBdd = new SqlCommand(libSupprAut, maConnexion);
                supprAutBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un auteur existant.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupére rles informations d'un auteur
        /// </summary>
        /// <param name="appelationAut">Récupère le nom composé d'un auteur</param>
        /// <returns>Retourne un objet Auteur comportant les informations de l'auteur sélectionné</returns>
        /// <exception cref="">Renvoie une erreur si les informations de l'auteur ne peuvent pas être récupérées</exception>
        public static Auteur RecupInfoAuteur(string appelationAut)
        {
            try
            {
                Connection();
                Auteur autAModif = new Auteur();
                string cmdInfoAut = ("select idaut, idpays, nomaut, prenomaut, surnomaut, datenaiaut, datemortaut from auteur where concat(nomaut, ' ', prenomaut) like '" + appelationAut + "'");
                SqlCommand trouvInfoAut = new SqlCommand(cmdInfoAut, maConnexion);
                SqlDataReader lecteurInfoAut = trouvInfoAut.ExecuteReader();
                if (lecteurInfoAut.HasRows)
                {
                    while (lecteurInfoAut.Read())
                    {
                        autAModif.AccIdAut = int.Parse(lecteurInfoAut[0].ToString());
                        autAModif.AccIdPaysAut = int.Parse(lecteurInfoAut[1].ToString());
                        autAModif.AccNomAut = lecteurInfoAut[2].ToString();
                        autAModif.AccPrenomAut = lecteurInfoAut[3].ToString();
                        autAModif.AccSurnomAut = lecteurInfoAut[4].ToString();
                        autAModif.AccDateNaiAut = DateTime.Parse(lecteurInfoAut[5].ToString());
                        if(lecteurInfoAut[6].ToString().Substring(0, 10) == "01/01/1900")
                        {
                            autAModif.AccDateMortAut = "";
                        }
                        else
                        {
                            autAModif.AccDateMortAut = lecteurInfoAut[6].ToString().Substring(0,10);
                        }
                    }
                }
                lecteurInfoAut.Close();
                return autAModif;
            }
            catch
            {
                throw new Exception("Impossible de récupérer les informations du client sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de modifier les informations d'un auteur dans la base de données
        /// </summary>
        /// <param name="autAModif">Récupère un objet Auteur qui a été modifié</param>
        /// <exception cref="">Renvoie une erreur si les informations de l'auteur n'ont pas pu être modifié</exception>
        public static void UpdateAuteur(Auteur autAModif)
        {
            string libModifAut;
            try
            {
                Connection();
                libModifAut = "Update Auteur Set ";
                libModifAut += "idPays='" + autAModif.AccIdPaysAut + "', ";
                libModifAut += "nomAut='" + autAModif.AccNomAut + "', ";
                libModifAut += "prenomAut='" + autAModif.AccPrenomAut + "', ";
                libModifAut += "surnomAut='" + autAModif.AccSurnomAut + "', ";
                libModifAut += "dateNaiAut='" + autAModif.AccDateNaiAut + "', ";
                libModifAut += "dateMortAut='" + autAModif.AccDateMortAut + "'";
                libModifAut += "where idaut =" + autAModif.AccIdAut;
                SqlCommand modifAutBdd = new SqlCommand(libModifAut, maConnexion);
                modifAutBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de modifier les informations de l'auteur sélectionné.");
            }
        }
    }
}
