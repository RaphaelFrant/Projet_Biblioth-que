using System;
using System.Collections.Generic;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class IntervenantDivers
    {
        //--------------------------------Variable--------------------------------
        public int idInterv;
        public string nomInterv;
        public string prenomInterv;
        public string surnomInterv;
        public DateTime dateNaiInterv;
        public DateTime dateMortInterv;

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
                if (value.Length == 0)
                {
                    throw new Exception("Le surnom de l'intervenant ne peut pas être vide.");
                }
                else
                {
                    this.surnomInterv = value;
                }
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

        public DateTime AccDateMortInterv
        {
            get { return this.dateMortInterv; }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("La date de décès de l'intervenant ne peut pas être supérieur à la date du jour.");
                }
                else
                {
                    this.dateMortInterv = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe IntervenantDivers</summary>
        public IntervenantDivers() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe IntervenantDivers</summary>
        public IntervenantDivers(int numIntervenant, string nomIntervenant, string prenomIntervenant, string pseudoIntervenant, DateTime dateNaiIntervenant, DateTime dateDecesIntervenant)
        {
            AccIdInterv = numIntervenant;
            AccNomInterv = nomIntervenant;
            AccPrenomInterv = prenomIntervenant;
            AccSurnomInterv = pseudoIntervenant;
            AccDateNaiInterv = dateNaiIntervenant;
            AccDateMortInterv = dateDecesIntervenant;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe IntervenantDivers</summary>
        public IntervenantDivers(string nomIntervenant, string prenomIntervenant, string pseudoIntervenant, DateTime dateNaiIntervenant, DateTime dateDecesIntervenant)
        {
            AccNomInterv = nomIntervenant;
            AccPrenomInterv = prenomIntervenant;
            AccSurnomInterv = pseudoIntervenant;
            AccDateNaiInterv = dateNaiIntervenant;
            AccDateMortInterv = dateDecesIntervenant;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
