using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe GenreLitteraire
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe GenreLitteraire 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class GenreLitteraire
    {
        //--------------------------------Variable--------------------------------
        public int idGenreLitt;
        public string libGenreLitt;

        //--------------------------------Accesseur--------------------------------
        public int AccIdGenreLitt
        {
            get { return this.idGenreLitt; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du genre littéraire du livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idGenreLitt = value;
                }
            }
        }

        public string AccLibGenreLitt
        {
            get { return this.libGenreLitt; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé du genre littéraire du livre ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le libellé du genre littéraire ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libGenreLitt = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe GenreLitteraire</summary>
        public GenreLitteraire() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe GenreLitteraire</summary>
        public GenreLitteraire(int numGenreLitt, string nomGenreLitt)
        {
            AccIdGenreLitt = numGenreLitt;
            AccLibGenreLitt = nomGenreLitt;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe GenreLitteraire</summary>
        public GenreLitteraire(string nomGenreLitt)
        {
            AccLibGenreLitt = nomGenreLitt;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
