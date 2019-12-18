using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe Fonction
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Fonction 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class Fonction
    {
        //--------------------------------Variable--------------------------------
        public int idFonct;
        public string libFonct;

        //--------------------------------Accesseur--------------------------------
        public int AccIdFonct
        {
            get { return this.idFonct; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la fonction d'un intervenant ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idFonct = value;
                }
            }
        }

        public string AccLibFonct
        {
            get { return this.libFonct; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé d'une fonction d'un intervenant ne peut pas être vide.");
                }
                else
                {
                    this.libFonct = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Fonction</summary>
        public Fonction() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Fonction</summary>
        public Fonction(int numFonct, string nomFonct)
        {
            AccIdFonct = numFonct;
            AccLibFonct = nomFonct;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Fonction</summary>
        public Fonction(string nomFonct)
        {
            AccLibFonct = nomFonct;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
