using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe Pays
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Pays 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class Pays
    {
        //--------------------------------Variable--------------------------------
        public int idPays;
        public string libPays;

        //--------------------------------Accesseur--------------------------------
        public int AccIdPays
        {
            get { return this.idPays; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du Pays ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPays = value;
                }
            }
        }

        public string AccLibPays
        {
            get { return this.libPays; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé du Pays ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le nom du pays ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libPays = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Pays</summary>
        public Pays() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Pays</summary>
        public Pays(int numPays, string nomPays)
        {
            AccIdPays = numPays;
            AccLibPays = nomPays;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Pays</summary>
        public Pays(string nomPays)
        {
            AccLibPays = nomPays;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
