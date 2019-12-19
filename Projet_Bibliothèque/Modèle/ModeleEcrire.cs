using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe ModeleEcrire
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe ModeleEcrire 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class ModeleEcrire
    {
        //--------------------------------Variable--------------------------------
        public int idAut;
        public int numIsbn;

        //--------------------------------Accesseur--------------------------------
        public int AccIdAutEcrire
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

        public int AccNumIsbnEcrire
        {
            get { return this.numIsbn; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'ISBN ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.numIsbn = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe ModeleEcrire</summary>
        public ModeleEcrire() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe ModeleEcrire</summary>
        public ModeleEcrire(int numAuteur, int isbn)
        {
            AccIdAutEcrire = numAuteur;
            AccNumIsbnEcrire = isbn;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
