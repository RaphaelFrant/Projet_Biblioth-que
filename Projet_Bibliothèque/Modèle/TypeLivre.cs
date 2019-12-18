using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe TypeLivre
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe TypeLivre 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class TypeLivre
    {
        //--------------------------------Variable--------------------------------
        public int idTypeLivre;
        public string libTypeLivre;

        //--------------------------------Accesseur--------------------------------
        public int AccIdTypeLivre
        {
            get { return this.idTypeLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du type de livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idTypeLivre = value;
                }
            }
        }

        public string AccLibTypeLivre
        {
            get { return this.libTypeLivre; }
            set
            {
                if(value.Length == 0)
                {
                    throw new Exception("Le libellé du type de livre ne peut pas être vide.");
                }
                else
                {
                    this.libTypeLivre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe TypeLivre</summary>
        public TypeLivre () { }

        /// <summary>Constructeur pour la modification d'un objet de la classe TypeLivre</summary>
        public TypeLivre (int numTypeLivre, string nomTypeLivre)
        {
            AccIdTypeLivre = numTypeLivre;
            AccLibTypeLivre = nomTypeLivre;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe TypeLivre</summary>
        public TypeLivre(string nomTypeLivre)
        {
            AccLibTypeLivre = nomTypeLivre;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
