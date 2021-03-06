﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe Imprimeur
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Imprimeur 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction de l'imprimeur</remarks>
    class Imprimeur : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idImprim;
        public int idPaysImprim;
        public string nomImprim;
        public DateTime dateDebImprim;
        public string dateFinImprim;

        //--------------------------------Accesseur--------------------------------
        public int AccIdImprim
        {
            get { return this.idImprim; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de l'imprimeur ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idImprim = value;
                }
            }
        }

        public int AccIdPaysImprim
        {
            get { return this.idPaysImprim; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du pays de l'imprimeur ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPaysImprim = value;
                }
            }
        }

        public string AccLibImprim
        {
            get { return this.nomImprim; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le nom de l'imprimeur ne peut pas être vide.");
                }
                else
                {
                    this.nomImprim = value;
                }
            }
        }

        public DateTime AccDateDebImprim
        {
            get { return this.dateDebImprim; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date d'ouverture de l'imprimeur ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateDebImprim = value;
                }
            }
        }

        public string AccDateFinImprim
        {
            get { return this.dateFinImprim; }
            set
            {
                if (value == "")
                {
                    this.dateFinImprim = null;
                }
                else
                {
                    if (DateTime.Parse(value) >= DateTime.Today)
                    {
                        throw new ArgumentOutOfRangeException("La date de fermeture de l'imprimeur ne peut pas être supérieur à la date du jour.");
                    }
                    else
                    {
                        this.dateFinImprim = value;
                    }
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Imprimeur</summary>
        public Imprimeur() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Imprimeur</summary>
        public Imprimeur (int numImprimeur, int numPaysImprimeur, string libImprimeur, DateTime dateOuvert, string dateFerme)
        {
            AccIdImprim = numImprimeur;
            AccIdPaysImprim = numPaysImprimeur;
            AccLibImprim = libImprimeur;
            AccDateDebImprim = dateOuvert;
            AccDateFinImprim = dateFerme;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Imprimeur</summary>
        public Imprimeur(int numPaysImprimeur, string libImprimeur, DateTime dateOuvert, string dateFerme)
        {
            AccIdPaysImprim = numPaysImprimeur;
            AccLibImprim = libImprimeur;
            AccDateDebImprim = dateOuvert;
            AccDateFinImprim = dateFerme;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de créer un nouvel imprimeur en base de données
        /// </summary>
        /// <param name="nouvImpr">Récupère un objet avec les informations du nouvel imprimeur</param>
        /// <exception cref="">Renvoie une exception si </exception>
        public static void InsertImprimeur(Imprimeur nouvImpr)
        {
            string libCreaImpr;
            try
            {
                Connection();
                libCreaImpr = "Insert into Imprimeur(idPays, nomimprim, datedebimprim, datefinimprim) values (";
                libCreaImpr += "'" + nouvImpr.AccIdPaysImprim + "', ";
                libCreaImpr += "'" + nouvImpr.AccLibImprim + "', ";
                libCreaImpr += "'" + nouvImpr.AccDateDebImprim + "', ";
                libCreaImpr += "'" + nouvImpr.AccDateFinImprim + "')";
                SqlCommand creaImprBdd = new SqlCommand(libCreaImpr, maConnexion);
                creaImprBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel imprimeur.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des imprimeurs présents en base de données
        /// </summary>
        /// <returns>Retourne une arraylist comportant la liste des imprimeurs</returns>
        /// <exception cref="">Renvoie une exception si la liste des imprimeurs n'a pas pu être créée</exception>
        public static ArrayList ListeImprimeurExist()
        {
            ArrayList listeChoixImpr = new ArrayList();
            try
            {
                Connection();
                string cmdListeImpr = ("select nomimprim from imprimeur order by nomimprim");
                SqlCommand trouvChoixImpr = new SqlCommand(cmdListeImpr, maConnexion);
                SqlDataReader lecteurListeImpr = trouvChoixImpr.ExecuteReader();

                if (lecteurListeImpr.HasRows)
                {
                    while (lecteurListeImpr.Read())
                    {
                        listeChoixImpr.Add(lecteurListeImpr[0].ToString());
                    }
                }
                lecteurListeImpr.Close();
                return listeChoixImpr;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des imprimeurs existants.");
            }
        }

        /// <summary>
        /// Méthode permettant de supprimer un imprimeur présent en base de données
        /// </summary>
        /// <param name="libImpr">Récupère le nom de l'imprimeur sélectionné par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'imprimeur n'a pas pu être supprimé</exception>
        public static void DeleteImprimeur(string libImpr)
        {
            try
            {
                string libSupprImpr;
                Connection();
                libSupprImpr = "Delete from imprimeur where nomimprim='" + libImpr + "'";
                SqlCommand supprImprBdd = new SqlCommand(libSupprImpr, maConnexion);
                supprImprBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un imprimeur existant.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer les informations de l'imprimeur sélectionné par l'utilisateur
        /// </summary>
        /// <param name="appelationImpr">Récupère le nom de l'imprimeur à modifier</param>
        /// <returns>Renvoie un objet contenant les informations de l'imprimeur à modifier</returns>
        /// <exception cref="">Renvoie une erreur si les informations liées à l'imprimeur sélectionné n'ont pas pu être récupérées</exception>
        public static Imprimeur RecupInfoImprimeur(string appelationImpr)
        {
            try
            {
                Connection();
                Imprimeur imprAModif = new Imprimeur();
                string cmdInfoImpr = ("select idimprim, idpays, nomimprim, datedebimprim, datefinimprim from imprimeur where nomimprim='" + appelationImpr + "'");
                SqlCommand trouvInfoImpr = new SqlCommand(cmdInfoImpr, maConnexion);
                SqlDataReader lecteurInfoImpr = trouvInfoImpr.ExecuteReader();
                if (lecteurInfoImpr.HasRows)
                {
                    while (lecteurInfoImpr.Read())
                    {
                        imprAModif.AccIdImprim = int.Parse(lecteurInfoImpr[0].ToString());
                        imprAModif.AccIdPaysImprim = int.Parse(lecteurInfoImpr[1].ToString());
                        imprAModif.AccLibImprim = lecteurInfoImpr[2].ToString();
                        imprAModif.AccDateDebImprim = DateTime.Parse(lecteurInfoImpr[3].ToString());
                        if (lecteurInfoImpr[4].ToString().Substring(0, 10) == "01/01/1900")
                        {
                            imprAModif.AccDateFinImprim = "";
                        }
                        else
                        {
                            imprAModif.AccDateFinImprim = lecteurInfoImpr[4].ToString().Substring(0, 10);
                        }
                    }
                }
                lecteurInfoImpr.Close();
                return imprAModif;
            }
            catch
            {
                throw new Exception("Impossible de récupérer les informations de l'imprimeur sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant supprimer les informations d'un imprimeur en base de données
        /// </summary>
        /// <param name="imprAModif">Récupère un objet avec les informations modifiées de l'imprimeur</param>
        /// <exception cref="">Renvoie une erreur si les informations d'un imprimeurs ne peuvent pas être modifiées</exception>
        public static void UpdateImprimeur(Imprimeur imprAModif)
        {
            string libModifImpr;
            try
            {
                Connection();
                libModifImpr = "Update Imprimeur Set ";
                libModifImpr += "idpays='" + imprAModif.AccIdPaysImprim + "', ";
                libModifImpr += "nomimprim='" + imprAModif.AccLibImprim + "', ";
                libModifImpr += "datedebimprim='" + imprAModif.AccDateDebImprim + "', ";
                libModifImpr += "datefinimprim='" + imprAModif.AccDateFinImprim + "'";
                libModifImpr += "where idimprim =" + imprAModif.AccIdImprim;
                SqlCommand modifEditBdd = new SqlCommand(libModifImpr, maConnexion);
                modifEditBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de modifier les informations de l'imprimeur sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'un imprimeur
        /// </summary>
        /// <param name="titreImpr">Récupère le nom de l'imprimeur dont on veut récupérer l'identifiant</param>
        /// <returns>Retourne l'identifiant de l'imprimeur correspondant au nom entré</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant n'a pas pu être récupéré</exception>
        public static int RecupIdImprimeur(string titreImpr)
        {
            try
            {
                Connection();
                int idImprTrouve = 0;
                string cmdTrouvIdImpr = ("select idimprim from imprimeur where nomimprim='" + titreImpr + "'");
                SqlCommand trouvIdImpr = new SqlCommand(cmdTrouvIdImpr, maConnexion);
                SqlDataReader lecteurTrouvIdImpr = trouvIdImpr.ExecuteReader();
                if (lecteurTrouvIdImpr.HasRows)
                {
                    while (lecteurTrouvIdImpr.Read())
                    {
                        idImprTrouve = int.Parse(lecteurTrouvIdImpr[0].ToString());
                    }
                }
                lecteurTrouvIdImpr.Close();
                return idImprTrouve;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'imprimeur sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont associés à l'imprimeur indiqué par l'utilisateur
        /// </summary>
        /// <param name="nomImprSelect">Récupère la chaine indiquée par l'utilisateur lié à un imprimeur</param>
        /// <returns>Retourne une ArrayList contenant toutes les oeuvres associées à cet imprimeur</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupérée</exception>
        public static ArrayList RecupOeuvreAssocImprimeur(string nomImprSelect)
        {
            try
            {
                Connection();
                ArrayList listeOeuvreAssocImpr = new ArrayList();
                string cmdOeuvreAssocImpr = ("select L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L  " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where Impr.nomimprim like '%" + nomImprSelect + "%'order by L.libliv asc");
                SqlCommand trouvOeuvreAssocImpr = new SqlCommand(cmdOeuvreAssocImpr, maConnexion);
                SqlDataReader lecteurOeuvreAssocImpr = trouvOeuvreAssocImpr.ExecuteReader();
                if (lecteurOeuvreAssocImpr.HasRows)
                {
                    while (lecteurOeuvreAssocImpr.Read())
                    {
                        listeOeuvreAssocImpr.Add(lecteurOeuvreAssocImpr.GetString(0));
                        listeOeuvreAssocImpr.Add(lecteurOeuvreAssocImpr.GetString(1));
                        listeOeuvreAssocImpr.Add(lecteurOeuvreAssocImpr.GetString(2));
                        listeOeuvreAssocImpr.Add(lecteurOeuvreAssocImpr.GetDateTime(3));
                        listeOeuvreAssocImpr.Add(lecteurOeuvreAssocImpr.GetString(4));
                        listeOeuvreAssocImpr.Add(lecteurOeuvreAssocImpr.GetString(5));
                    }
                }
                lecteurOeuvreAssocImpr.Close();
                return listeOeuvreAssocImpr;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à cet imprimeur.");
            }
        }
    }
}