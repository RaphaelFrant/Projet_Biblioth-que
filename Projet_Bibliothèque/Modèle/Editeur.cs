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
    /// Classe Editeur
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Editeur 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction de l'éditeur</remarks>
    class Editeur : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idEditeur;
        public int idPaysEdit;
        public string nomEditeur;
        public DateTime dateDebEditeur;
        public string dateFinEditeur;
        public string adEditeur;

        //--------------------------------Accesseur--------------------------------
        public int AccIdEditeur
        {
            get { return this.idEditeur; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de l'éditeur ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idEditeur = value;
                }
            }
        }

        public int AccIdPaysEditeur
        {
            get { return this.idPaysEdit; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du pays de l'éditeur ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPaysEdit = value;
                }
            }
        }

        public string AccLibEditeur
        {
            get { return this.nomEditeur; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le nom de l'éditeur ne peut pas être vide.");
                }
                else
                {
                    this.nomEditeur = value;
                }
            }
        }

        public DateTime AccDateDebEditeur
        {
            get { return this.dateDebEditeur; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date d'ouverture de l'éditeur ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateDebEditeur = value;
                }
            }
        }

        public string AccDateFinEditeur
        {
            get { return this.dateFinEditeur; }
            set
            {
                if (value == "")
                {
                    this.dateFinEditeur = null;
                }
                else
                {
                    if (DateTime.Parse(value) >= DateTime.Today)
                    {
                        throw new ArgumentOutOfRangeException("La date de fermeture de l'éditeur ne peut pas être supérieur à la date du jour.");
                    }
                    else
                    {
                        this.dateFinEditeur = value;
                    }
                }
            }
        }

        public string AccAdEditeur
        {
            get { return this.adEditeur; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("L'adresse de l'éditeur ne peut pas être vide.");
                }
                else
                {
                    this.adEditeur = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Editeur</summary>
        public Editeur() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Editeur</summary>
        public Editeur(int numEditeur, int numIdPaysEditeur, string libEditeur, DateTime dateOuvertEditeur, string dateFermeEditeur, string adresseEditeur)
        {
            AccIdEditeur = numEditeur;
            AccIdPaysEditeur = numIdPaysEditeur;
            AccLibEditeur = libEditeur;
            AccDateDebEditeur = dateOuvertEditeur;
            AccDateFinEditeur = dateFermeEditeur;
            AccAdEditeur = adresseEditeur;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Editeur</summary>
        public Editeur(int numIdPaysEditeur, string libEditeur, DateTime dateOuvertEditeur, string dateFermeEditeur, string adresseEditeur)
        {
            AccIdPaysEditeur = numIdPaysEditeur;
            AccLibEditeur = libEditeur;
            AccDateDebEditeur = dateOuvertEditeur;
            AccDateFinEditeur = dateFermeEditeur;
            AccAdEditeur = adresseEditeur;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de créer un nouvel éditeur dans la base de données
        /// </summary>
        /// <param name="nouvEdit">Récupère un objet Editeur comportant les informations du nouvel éditeur</param>
        /// <exception cref="">Retourne une erreur si les données entrées ou la requête SQL sont invalides</exception>
        public static void InsertEditeur(Editeur nouvEdit)
        {
            string libCreaEdit;
            try
            {
                Connection();
                libCreaEdit = "Insert into Editeur(idPays, nomedit, datedebedit, datefinedit, adedit) values (";
                libCreaEdit += "'" + nouvEdit.AccIdPaysEditeur + "', ";
                libCreaEdit += "'" + nouvEdit.AccLibEditeur + "', ";
                libCreaEdit += "'" + nouvEdit.AccDateDebEditeur + "', ";
                libCreaEdit += "'" + nouvEdit.AccDateFinEditeur + "', ";
                libCreaEdit += "'" + nouvEdit.AccAdEditeur + "')";
                SqlCommand creaEditBdd = new SqlCommand(libCreaEdit, maConnexion);
                creaEditBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel éditeur.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des éditeurs présents dans la base de données pour remplir des combobox du formulaire
        /// </summary>
        /// <returns>Retourne une ArrayList comportant l'ensemble des éditeurs existants dans la base de donnnées</returns>
        /// <exception cref="">Renvoie une exception si la liste n'a pas pu être mise en place.</exception>
        public static ArrayList ListeEditeurExist()
        {
            ArrayList listeChoixEdit = new ArrayList();
            try
            {
                Connection();
                string cmdListeEdit = ("select nomedit from editeur order by nomedit");
                SqlCommand trouvChoixEdit = new SqlCommand(cmdListeEdit, maConnexion);
                SqlDataReader lecteurListeEdit = trouvChoixEdit.ExecuteReader();

                if (lecteurListeEdit.HasRows)
                {
                    while (lecteurListeEdit.Read())
                    {
                        listeChoixEdit.Add(lecteurListeEdit[0].ToString());
                    }
                }
                lecteurListeEdit.Close();
                return listeChoixEdit;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des éditeurs existants.");
            }
        }

        /// <summary>
        /// Méthode permettant de supprimer l'éditeur sélectionné par l'utilisateur
        /// </summary>
        /// <param name="libEdit">Récupère le nom de l'éditeur à supprimer</param>
        /// <exception cref="">Renvoie une exception si l'éditeur ne peut pas être supprimé de la base de données ou si le nom de l'éditeur n'existe pas</exception>
        public static void DeleteEditeur(string libEdit)
        {
            try
            {
                string libSupprEdit;
                Connection();
                libSupprEdit = "Delete from editeur where nomedit='" + libEdit + "'";
                SqlCommand supprEditBdd = new SqlCommand(libSupprEdit, maConnexion);
                supprEditBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un éditeur existant.");
            }
        }

        /// <summary>
        /// Méthode permettant de modifier les informations de l'éditeur sélectionné par l'utilisateur
        /// </summary>
        /// <param name="appelationEdit">Récupère le nom de l'éditeur sélectionné</param>
        /// <returns>Retourne un objet Editeur avec les informations dudit éditeur pour le modifier</returns>
        /// <exception cref="">Renvoie une exception si les informations n'ont pas pu être récupérées</exception>
        public static Editeur RecupInfoEditeur(string appelationEdit)
        {
            try
            {
                Connection();
                Editeur editAModif = new Editeur();
                string cmdInfoEdit = ("select idedit, idpays, nomedit, datedebedit, datefinedit, adedit from editeur where nomedit='" + appelationEdit + "'");
                SqlCommand trouvInfoEdit = new SqlCommand(cmdInfoEdit, maConnexion);
                SqlDataReader lecteurInfoEdit = trouvInfoEdit.ExecuteReader();
                if (lecteurInfoEdit.HasRows)
                {
                    while (lecteurInfoEdit.Read())
                    {
                        editAModif.AccIdEditeur = int.Parse(lecteurInfoEdit[0].ToString());
                        editAModif.AccIdPaysEditeur = int.Parse(lecteurInfoEdit[1].ToString());
                        editAModif.AccLibEditeur = lecteurInfoEdit[2].ToString();
                        editAModif.AccDateDebEditeur = DateTime.Parse(lecteurInfoEdit[3].ToString());
                        if (lecteurInfoEdit[4].ToString().Substring(0, 10) == "01/01/1900")
                        {
                            editAModif.AccDateFinEditeur = "";
                        }
                        else
                        {
                            editAModif.AccDateFinEditeur = lecteurInfoEdit[4].ToString().Substring(0, 10);
                        }
                        editAModif.AccAdEditeur = lecteurInfoEdit[5].ToString();
                    }
                }
                lecteurInfoEdit.Close();
                return editAModif;
            }
            catch
            {
                throw new Exception("Impossible de récupérer les informations de l'éditeur sélectionné.");
            }
        }

        /// <summary>
        /// Méthide permettant de modifier les informations d'un éditeur présent en base de données
        /// </summary>
        /// <param name="editeurAModif">Récupère un objet Editeur avec les nouvelles informations de l'éditeur</param>
        /// <exception cref="">Renoie une exception si les données de l'éditeur n'ont pas pu être modifiées</exception>
        public static void UpdateEditeur(Editeur editeurAModif)
        {
            string libModifEditeur;
            try
            {
                Connection();
                libModifEditeur = "Update Editeur Set ";
                libModifEditeur += "idpays='" + editeurAModif.AccIdPaysEditeur + "', ";
                libModifEditeur += "nomedit='" + editeurAModif.AccLibEditeur + "', ";
                libModifEditeur += "datedebedit='" + editeurAModif.AccDateDebEditeur + "', ";
                libModifEditeur += "datefinedit='" + editeurAModif.AccDateFinEditeur + "', ";
                libModifEditeur += "adedit='" + editeurAModif.AccAdEditeur + "'";
                libModifEditeur += "where idedit =" + editeurAModif.AccIdEditeur;
                SqlCommand modifEditBdd = new SqlCommand(libModifEditeur, maConnexion);
                modifEditBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de modifier les informations de l'éditeur sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant de l'éditeur
        /// </summary>
        /// <param name="titreEdit">Récupère le nom de l'éditeur dont on veut récupérer l'identifiant</param>
        /// <returns>Retourne l'identifiant de l'éditeur correspondant au nom entré</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant n'a pas pu être récupéré</exception>
        public static int RecupIdEditeur(string titreEdit)
        {
            try
            {
                Connection();
                int idTrouve = 0;
                string cmdTrouvIdEdit = ("select idedit from editeur where nomedit='" + titreEdit + "'");
                SqlCommand trouvIdEdit = new SqlCommand(cmdTrouvIdEdit, maConnexion);
                SqlDataReader lecteurTrouvIdEdit = trouvIdEdit.ExecuteReader();
                if (lecteurTrouvIdEdit.HasRows)
                {
                    while (lecteurTrouvIdEdit.Read())
                    {
                        idTrouve = int.Parse(lecteurTrouvIdEdit[0].ToString());
                    }
                }
                lecteurTrouvIdEdit.Close();
                return idTrouve;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'éditeur sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont associés à l'éditeur indiquée par l'utilisateur
        /// </summary>
        /// <param name="nomEditeurSelect">Récupère une chaine de caractère entrée par l'utilisateur</param>
        /// <returns>Retourne une ArrayList contenant toutes les oeuvres associées à cet éditeur</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupérée</exception>
        public static ArrayList RecupOeuvreAssocEdit(string nomEditeurSelect)
        {
            try
            {
                Connection();
                ArrayList listeOeuvreAssocEdit = new ArrayList();
                string cmdOeuvreAssocEdit = ("select L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L  " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where Edit.nomedit like '%" + nomEditeurSelect + "%'order by L.libliv asc");
                SqlCommand trouvOeuvreAssocEdit = new SqlCommand(cmdOeuvreAssocEdit, maConnexion);
                SqlDataReader lecteurOeuvreAssocEdit = trouvOeuvreAssocEdit.ExecuteReader();
                if (lecteurOeuvreAssocEdit.HasRows)
                {
                    while (lecteurOeuvreAssocEdit.Read())
                    {
                        listeOeuvreAssocEdit.Add(lecteurOeuvreAssocEdit.GetString(0));
                        listeOeuvreAssocEdit.Add(lecteurOeuvreAssocEdit.GetString(1));
                        listeOeuvreAssocEdit.Add(lecteurOeuvreAssocEdit.GetString(2));
                        listeOeuvreAssocEdit.Add(lecteurOeuvreAssocEdit.GetDateTime(3));
                        listeOeuvreAssocEdit.Add(lecteurOeuvreAssocEdit.GetString(4));
                        listeOeuvreAssocEdit.Add(lecteurOeuvreAssocEdit.GetString(5));
                    }
                }
                lecteurOeuvreAssocEdit.Close();
                return listeOeuvreAssocEdit;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à cet éditeur.");
            }
        }
    }
}
