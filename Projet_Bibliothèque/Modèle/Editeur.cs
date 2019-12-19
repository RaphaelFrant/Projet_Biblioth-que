using System;
using System.Collections.Generic;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class Editeur
    {
        //--------------------------------Variable--------------------------------
        public int idEditeur;
        public int idPaysEdit;
        public string nomEditeur;
        public DateTime dateDebEditeur;
        public DateTime dateFinEditeur;
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

        public DateTime AccDateFinEditeur
        {
            get { return this.dateFinEditeur; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date de fermeture de l'éditeur ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateFinEditeur = value;
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
        public Editeur(int numEditeur, int numIdPaysEditeur, string libEditeur, DateTime dateOuvertEditeur, DateTime dateFermeEditeur, string adresseEditeur)
        {
            AccIdEditeur = numEditeur;
            AccIdPaysEditeur = numIdPaysEditeur;
            AccLibEditeur = libEditeur;
            AccDateDebEditeur = dateOuvertEditeur;
            AccDateFinEditeur = dateFermeEditeur;
            AccAdEditeur = adresseEditeur;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Editeur</summary>
        public Editeur(int numIdPaysEditeur, string libEditeur, DateTime dateOuvertEditeur, DateTime dateFermeEditeur, string adresseEditeur)
        {
            AccIdPaysEditeur = numIdPaysEditeur;
            AccLibEditeur = libEditeur;
            AccDateDebEditeur = dateOuvertEditeur;
            AccDateFinEditeur = dateFermeEditeur;
            AccAdEditeur = adresseEditeur;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
