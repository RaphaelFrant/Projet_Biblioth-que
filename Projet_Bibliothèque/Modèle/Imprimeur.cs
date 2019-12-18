using System;
using System.Collections.Generic;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class Imprimeur
    {
        //--------------------------------Variable--------------------------------
        public int idImprim;
        public string nomImprim;
        public DateTime dateDebImprim;
        public DateTime dateFinImprim;

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

        public DateTime AccDateFinImprim
        {
            get { return this.dateFinImprim; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date de fermeture de l'imprimeur ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateFinImprim = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Imprimeur</summary>
        public Imprimeur() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Imprimeur</summary>
        public Imprimeur (int numImprimeur, string libImprimeur, DateTime dateOuvert, DateTime dateFerme)
        {
            AccIdImprim = numImprimeur;
            AccLibImprim = libImprimeur;
            AccDateDebImprim = dateOuvert;
            AccDateFinImprim = dateFerme;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Imprimeur</summary>
        public Imprimeur(string libImprimeur, DateTime dateOuvert, DateTime dateFerme)
        {
            AccLibImprim = libImprimeur;
            AccDateDebImprim = dateOuvert;
            AccDateFinImprim = dateFerme;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
