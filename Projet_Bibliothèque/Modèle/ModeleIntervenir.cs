using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe ModeleIntervenir
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe ModeleIntervenir 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class ModeleIntervenir
    {
        //--------------------------------Variable--------------------------------
        public int idInterv;
        public int numIsbn;

        //--------------------------------Accesseur--------------------------------
        public int AccIdIntervLivre
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

        public int AccNumIsbnInterv
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
        /// <summary>Constructeur par défaut de la classe ModeleIntervenir</summary>
        public ModeleIntervenir() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe ModeleIntervenir</summary>
        public ModeleIntervenir(int numInterv, int isbnInterv)
        {
            AccIdIntervLivre = numInterv;
            AccNumIsbnInterv = isbnInterv;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
