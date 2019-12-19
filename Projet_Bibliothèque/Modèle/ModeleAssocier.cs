using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe ModeleAssocier
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe ModeleAssocier 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class ModeleAssocier
    {
        //--------------------------------Variable--------------------------------
        public int idGenreLittLivre;
        public int numIsbnGenre;

        //--------------------------------Accesseur--------------------------------
        public int AccIdGenreLittLivre
        {
            get { return this.idGenreLittLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du genre littéraire d'un livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idGenreLittLivre = value;
                }
            }
        }

        public int AccNumIsbnGenre
        {
            get { return this.numIsbnGenre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'ISBN d'un livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.numIsbnGenre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe ModeleAssocier</summary>
        public ModeleAssocier() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe ModeleAssocier</summary>
        public ModeleAssocier(int identifiantGenreLitt, int isbnGenre)
        {
            AccIdGenreLittLivre = identifiantGenreLitt;
            AccNumIsbnGenre = isbnGenre;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
