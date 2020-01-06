using System;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
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
    }
}
