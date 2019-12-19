using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe SérieLivre
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe SérieLivre 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class SerieLivre
    {
        //--------------------------------Variable--------------------------------
        public int idSerieLivre;
        public string libSerieLivre;

        //--------------------------------Accesseur--------------------------------
        public int AccIdSerieLivre
        {
            get { return this.idSerieLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la série de livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idSerieLivre = value;
                }
            }
        }

        public string AccLibSerieLivre
        {
            get { return this.libSerieLivre; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé de la série de livre ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le libellé de la série de livre ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libSerieLivre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe SerieLivre</summary>
        public SerieLivre() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe SerieLivre</summary>
        public SerieLivre(int numSerieLivre, string nomSerieLivre)
        {
            AccIdSerieLivre = numSerieLivre;
            AccLibSerieLivre = nomSerieLivre;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe SerieLivre</summary>
        public SerieLivre(string nomSerieLivre)
        {
            AccLibSerieLivre = nomSerieLivre;
        }
        //--------------------------------Méthodes--------------------------------
    }
}
