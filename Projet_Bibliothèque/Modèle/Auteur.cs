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
    /// <remarks>Auteur Raphaël Frantzen, Version 17, le 29/01/2020
    /// Implémentation de la méthode permettant de récupérer la liste des auteurs pour un livre</remarks>
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

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant de l'auteur
        /// </summary>
        /// <param name="titreAut">Récupère le nom de l'auteur dont on veut récupérer l'identifiant</param>
        /// <returns>Retourne l'identifiant de l'auteur correspondant au nom entré</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant n'a pas pu être récupéré</exception>
        public static int RecupIdAuteur(string titreAut)
        {
            try
            {
                Connection();
                int idTrouve = 0;
                string cmdTrouvIdAut = ("select idaut from auteur where concat(nomaut, ' ', prenomaut)='" + titreAut + "'");
                SqlCommand trouvIdAut = new SqlCommand(cmdTrouvIdAut, maConnexion);
                SqlDataReader lecteurTrouvIdAut = trouvIdAut.ExecuteReader();
                if (lecteurTrouvIdAut.HasRows)
                {
                    while (lecteurTrouvIdAut.Read())
                    {
                        idTrouve = int.Parse(lecteurTrouvIdAut[0].ToString());
                    }
                }
                lecteurTrouvIdAut.Close();
                return idTrouve;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'auteur sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont associés à l'auteur indiqué par l'utilisateur
        /// </summary>
        /// <param name="chaineAutSelect">Récupère la chaine de caractère indiqué par l'utilisateur et lié à un auteur</param>
        /// <returns>Retourne une ArrayList contenant toutes les oeuvres associées à cet auteur</returns>
        /// <exception cref="">Renvoie ue erreur si la liste n'a pas pu être récupérée</exception>
        public static ArrayList RecupOeuvreAssocAut(string chaineAutSelect)
        {
            try
            {
                Connection();
                ArrayList listeOeuvreAssocAut = new ArrayList();
                string cmdOeuvreAssocAut = ("select L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L  " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where Aut.nomaut like '%" + chaineAutSelect + "%' or Aut.prenomaut like '%" + chaineAutSelect + "%' or concat(nomaut, ' ', prenomaut) like '%" + chaineAutSelect + "%'" +
                    "order by L.libliv asc");
                SqlCommand trouvOeuvreAssocAut = new SqlCommand(cmdOeuvreAssocAut, maConnexion);
                SqlDataReader lecteurOeuvreAssocAut = trouvOeuvreAssocAut.ExecuteReader();
                if (lecteurOeuvreAssocAut.HasRows)
                {
                    while (lecteurOeuvreAssocAut.Read())
                    {
                        listeOeuvreAssocAut.Add(lecteurOeuvreAssocAut.GetString(0));
                        listeOeuvreAssocAut.Add(lecteurOeuvreAssocAut.GetString(1));
                        listeOeuvreAssocAut.Add(lecteurOeuvreAssocAut.GetString(2));
                        listeOeuvreAssocAut.Add(lecteurOeuvreAssocAut.GetDateTime(3));
                        listeOeuvreAssocAut.Add(lecteurOeuvreAssocAut.GetString(4));
                        listeOeuvreAssocAut.Add(lecteurOeuvreAssocAut.GetString(5));
                    }
                }
                lecteurOeuvreAssocAut.Close();
                return listeOeuvreAssocAut;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à cet auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des auteurs pour un livre précis
        /// </summary>
        /// <param name="codeIsbn">Récupère le numéro ISBN du livre</param>
        /// <returns>Retourne la liste des auteurs ayant participé à l'écriture du livre</returns>
        /// <exception cref="">Renvoie une exception si la liste n'a pas pu être créée</exception>
        public static ArrayList RecupAuteurLivre(string codeIsbn)
        {
            try
            {
                Connection();
                ArrayList listeAut = new ArrayList();
                string cmdAutLivre = "select (Aut.NOMAUT + ' ' + Aut.PRENOMAUT) from auteur as Aut " +
                    "inner join Ecrire as Ecr on Ecr.IDAUT = Aut.IDAUT " +
                    "inner join Livre as L on L.NUMISBN = Ecr.NUMISBN " +
                    "where L.NUMISBN = '" + codeIsbn + "'";
                SqlCommand trouvAutLivre = new SqlCommand(cmdAutLivre, maConnexion);
                SqlDataReader lecteurAutLivre = trouvAutLivre.ExecuteReader();
                if (lecteurAutLivre.HasRows)
                {
                    while (lecteurAutLivre.Read())
                    {
                        listeAut.Add(lecteurAutLivre.GetString(0));
                    }
                }
                lecteurAutLivre.Close();
                return listeAut;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des auteurs pour un livre donné");
            }
        }
    }
}
