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
    /// Classe IntervenantDivers
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe IntervenantDivers 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 5, le 08/01/2020
    /// Implémentation méthodes de création, modification et suppression d'un intervenant</remarks>
    class IntervenantDivers : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idInterv;
        public int idPaysInterv;
        public int idFonct;
        public string nomInterv;
        public string prenomInterv;
        public string surnomInterv;
        public DateTime dateNaiInterv;
        public string dateMortInterv;

        //--------------------------------Accesseur--------------------------------
        public int AccIdInterv
        {
            get { return this.idInterv; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de l'intervenant ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idInterv = value;
                }
            }
        }

        public int AccIdPaysInterv
        {
            get { return this.idPaysInterv; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du pays de l'intervenant ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPaysInterv = value;
                }
            }
        }

        public int AccIdFonctInterv
        {
            get { return this.idFonct; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la fonction de l'intervenant ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idFonct = value;
                }
            }
        }

        public string AccNomInterv
        {
            get { return this.nomInterv; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le nom de l'intervenant ne peut pas être vide.");
                }
                else
                {
                    this.nomInterv = value;
                }
            }
        }

        public string AccPrenomInterv
        {
            get { return this.prenomInterv; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le prénom de l'intervenant ne peut pas être vide.");
                }
                else
                {
                    this.prenomInterv = value;
                }
            }
        }

        public string AccSurnomInterv
        {
            get { return this.surnomInterv; }
            set
            {
                this.surnomInterv = value;
            }
        }

        public DateTime AccDateNaiInterv
        {
            get { return this.dateNaiInterv; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date de naissance de l'intervenant ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateNaiInterv = value;
                }
            }
        }

        public string AccDateMortInterv
        {
            get { return this.dateMortInterv; }
            set
            {
                if (value == "")
                {
                    this.dateMortInterv = null;
                }
                else
                {
                    if (DateTime.Parse(value) >= DateTime.Today)
                    {
                        throw new ArgumentOutOfRangeException("La date de mort de l'intervenant ne peut pas être supérieur à la date du jour.");
                    }
                    else
                    {
                        this.dateMortInterv = value;
                    }
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe IntervenantDivers</summary>
        public IntervenantDivers() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe IntervenantDivers</summary>
        public IntervenantDivers(int numIntervenant, int numPaysIntervenant, int numFonct, string nomIntervenant, string prenomIntervenant, string pseudoIntervenant, DateTime dateNaiIntervenant, string dateDecesIntervenant)
        {
            AccIdInterv = numIntervenant;
            AccIdPaysInterv = numPaysIntervenant;
            AccIdFonctInterv = numFonct;
            AccNomInterv = nomIntervenant;
            AccPrenomInterv = prenomIntervenant;
            AccSurnomInterv = pseudoIntervenant;
            AccDateNaiInterv = dateNaiIntervenant;
            AccDateMortInterv = dateDecesIntervenant;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe IntervenantDivers</summary>
        public IntervenantDivers(int numPaysIntervenant, int numFonct, string nomIntervenant, string prenomIntervenant, string pseudoIntervenant, DateTime dateNaiIntervenant, string dateDecesIntervenant)
        {
            AccIdPaysInterv = numPaysIntervenant;
            AccIdFonctInterv = numFonct;
            AccNomInterv = nomIntervenant;
            AccPrenomInterv = prenomIntervenant;
            AccSurnomInterv = pseudoIntervenant;
            AccDateNaiInterv = dateNaiIntervenant;
            AccDateMortInterv = dateDecesIntervenant;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de créer un intervenant à partir des informations entrées par l'utilisateur
        /// </summary>
        /// <param name="nouvInterv">Récupère un objet contenant les informations du nouvel intervenant</param>
        /// <exception cref="">Renvoie une exception si l'intervenant n'a pas pu être créé</exception>
        public static void InsertIntervenant(IntervenantDivers nouvInterv)
        {
            string libCreaInterv;
            try
            {
                Connection();
                libCreaInterv = "Insert into Intervenant_Divers(idPays, idfonction, nominterv, prenominterv, surnominterv, datenaiinterv, datemortinterv) values (";
                libCreaInterv += "'" + nouvInterv.AccIdPaysInterv + "', ";
                libCreaInterv += "'" + nouvInterv.AccIdFonctInterv + "', ";
                libCreaInterv += "'" + nouvInterv.AccNomInterv + "', ";
                libCreaInterv += "'" + nouvInterv.AccPrenomInterv + "', ";
                libCreaInterv += "'" + nouvInterv.AccSurnomInterv + "', ";
                libCreaInterv += "'" + nouvInterv.AccDateNaiInterv + "', ";
                libCreaInterv += "'" + nouvInterv.AccDateMortInterv + "')";
                SqlCommand creaIntervBdd = new SqlCommand(libCreaInterv, maConnexion);
                creaIntervBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel intervenant.");
            }
        }

        /// <summary>
        /// éthode permettant de récupérer la liste des intervenants existants en base de données
        /// </summary>
        /// <returns>Retourne une arraylist contenant les noms de tous les intervenants</returns>
        /// <exception cref="">Renvoie une exception si la requête est erroné ou si la liste en peut pas être créée</exception>
        public static ArrayList ListeIntervExist()
        {
            ArrayList listeChoixInterv = new ArrayList();
            try
            {
                Connection();
                string cmdListeInterv = ("select concat(nominterv, ' ', prenominterv) from intervenant_divers order by nominterv");
                SqlCommand trouvChoixInterv = new SqlCommand(cmdListeInterv, maConnexion);
                SqlDataReader lecteurListeInterv = trouvChoixInterv.ExecuteReader();

                if (lecteurListeInterv.HasRows)
                {
                    while (lecteurListeInterv.Read())
                    {
                        listeChoixInterv.Add(lecteurListeInterv[0].ToString());
                    }
                }
                lecteurListeInterv.Close();
                return listeChoixInterv;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des intervenants existants.");
            }
        }

        /// <summary>
        /// Méthode permettant de supprimer un intervenant existant dans la base de données
        /// </summary>
        /// <param name="libInterv">Récupère le nom de l'intervenant sélectionné par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si le nom de l'intervenant sélectionné est invalide</exception>
        public static void DeleteInterv(string libInterv)
        {
            try
            {
                string libSupprInterv;
                Connection();
                libSupprInterv = "Delete from intervenant_divers where concat(nominterv, ' ', prenominterv) like '" + libInterv + "'";
                SqlCommand supprIntervBdd = new SqlCommand(libSupprInterv, maConnexion);
                supprIntervBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un intervenant existant.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer les informations de l'intervenant sélectionné par l'utilisateur
        /// </summary>
        /// <param name="appelationInterv">Récupère le nom de l'intervenant</param>
        /// <returns>Retourne un objet contenant les informations de l'intervenant</returns>
        /// <exception cref="">Renvoie une exception si les informations de l'intervenant n'ont pas pu être récupérées</exception>
        public static IntervenantDivers RecupInfoInterv(string appelationInterv)
        {
            try
            {
                Connection();
                IntervenantDivers intervAModif = new IntervenantDivers();
                string cmdInfoInterv = ("select idinterv, idpays, idfonction, nominterv, prenominterv, surnominterv, datenaiinterv, datemortinterv from intervenant_divers " +
                    "where concat(nominterv, ' ', prenominterv) like '" + appelationInterv + "'");
                SqlCommand trouvInfoInterv = new SqlCommand(cmdInfoInterv, maConnexion);
                SqlDataReader lecteurInfoInterv = trouvInfoInterv.ExecuteReader();
                if (lecteurInfoInterv.HasRows)
                {
                    while (lecteurInfoInterv.Read())
                    {
                        intervAModif.AccIdInterv = int.Parse(lecteurInfoInterv[0].ToString());
                        intervAModif.AccIdPaysInterv = int.Parse(lecteurInfoInterv[1].ToString());
                        intervAModif.AccIdFonctInterv = int.Parse(lecteurInfoInterv[2].ToString());
                        intervAModif.AccNomInterv = lecteurInfoInterv[3].ToString();
                        intervAModif.AccPrenomInterv = lecteurInfoInterv[4].ToString();
                        intervAModif.AccSurnomInterv = lecteurInfoInterv[5].ToString();
                        intervAModif.AccDateNaiInterv = DateTime.Parse(lecteurInfoInterv[6].ToString());
                        if (lecteurInfoInterv[7].ToString().Substring(0, 10) == "01/01/1900")
                        {
                            intervAModif.AccDateMortInterv = "";
                        }
                        else
                        {
                            intervAModif.AccDateMortInterv = lecteurInfoInterv[7].ToString().Substring(0, 10);
                        }
                    }
                }
                lecteurInfoInterv.Close();
                return intervAModif;
            }
            catch
            {
                throw new Exception("Impossible de récupérer les informations de l'intervenant sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de mettre à jour un intervenant existant dans la base de données
        /// </summary>
        /// <param name="intervAModif">Récupère un objet Auteur qui a été modifié</param>
        /// <exception cref="">Renvoie une erreur si les informations ne peuvent pas être modifiées</exception>
        public static void UpdateInterv(IntervenantDivers intervAModif)
        {
            string libModifInterv;
            try
            {
                Connection();
                libModifInterv = "Update intervenant_divers Set ";
                libModifInterv += "idPays='" + intervAModif.AccIdPaysInterv + "', ";
                libModifInterv += "idfonction='" + intervAModif.AccIdFonctInterv + "', "; 
                libModifInterv += "nominterv='" + intervAModif.AccNomInterv + "', ";
                libModifInterv += "prenominterv='" + intervAModif.AccPrenomInterv + "', ";
                libModifInterv += "surnominterv='" + intervAModif.AccSurnomInterv + "', ";
                libModifInterv += "dateNaiinterv='" + intervAModif.AccDateNaiInterv + "', ";
                libModifInterv += "dateMortinterv='" + intervAModif.AccDateMortInterv + "'";
                libModifInterv += "where idinterv =" + intervAModif.AccIdInterv;
                SqlCommand modifIntervBdd = new SqlCommand(libModifInterv, maConnexion);
                modifIntervBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de modifier les informations de l'intervenant sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré l'identifiant de l'intervenant entré par l'utilisateur
        /// </summary>
        /// <param name="intervChoix">Récupère le nom de l'intervenant</param>
        /// <returns>Retourne l'identifiant de l'intervenant</returns>
        /// <exception cref="">Renvoie une erreur si l'identifiant n'a pas pu être trouvé</exception>
        public static int RecupLastIdInterv(string intervChoix)
        {
            try
            {
                Connection();
                int identInterv = 0;
                string cmdIdInterv = ("select idinterv from intervenant_divers where concat(nominterv, ' ', prenominterv) like '" + intervChoix + "'");
                SqlCommand trouvIdInterv = new SqlCommand(cmdIdInterv, maConnexion);
                SqlDataReader lecteurIdInterv = trouvIdInterv.ExecuteReader();
                if (lecteurIdInterv.HasRows)
                {
                    while (lecteurIdInterv.Read())
                    {
                        identInterv = int.Parse(lecteurIdInterv[0].ToString());
                    }
                }
                lecteurIdInterv.Close();
                return identInterv;
            }
            catch
            {
                throw new Exception("Impossible de trouver l'identifiant correspondant au nom de l'intervenant.");
            }
        }
    }
}