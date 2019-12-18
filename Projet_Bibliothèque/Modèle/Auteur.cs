using System;
using System.Collections.Generic;
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
    class Auteur
    {
        //--------------------------------Variable--------------------------------
        public int idAut;
        public string nomAut;
        public string prenomAut;
        public string surnomAut;
        public DateTime dateNaiAut;
        public DateTime dateMortAut;

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
                if (value.Length == 0)
                {
                    throw new Exception("Le surnom de l'auteur ne peut pas être vide.");
                }
                else
                {
                    this.surnomAut = value;
                }
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

        public DateTime AccDateMortAut
        {
            get { return this.dateMortAut; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date de décès de l'auteur ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateMortAut = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Auteur</summary>
        public Auteur() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Auteur</summary>
        public Auteur(int numAuteur, string nomAuteur, string prenomAuteur, string pseudoAuteur, DateTime dateNaiAuteur, DateTime dateDecesAuteur)
        {
            AccIdAut = numAuteur;
            AccNomAut = nomAuteur;
            AccPrenomAut = prenomAuteur;
            AccSurnomAut = pseudoAuteur;
            AccDateNaiAut = dateNaiAuteur;
            AccDateMortAut = dateDecesAuteur;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Auteur</summary>
        public Auteur(string nomAuteur, string prenomAuteur, string pseudoAuteur, DateTime dateNaiAuteur, DateTime dateDecesAuteur)
        {
            AccNomAut = nomAuteur;
            AccPrenomAut = prenomAuteur;
            AccSurnomAut = pseudoAuteur;
            AccDateNaiAut = dateNaiAuteur;
            AccDateMortAut = dateDecesAuteur;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
