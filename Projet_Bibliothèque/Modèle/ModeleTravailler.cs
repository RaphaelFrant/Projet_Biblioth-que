using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe ModeleTravailler
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe ModeleTravailler 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class ModeleTravailler
    {
        //--------------------------------Variable--------------------------------
        public int idInterv;
        public int idFonct;

        //--------------------------------Accesseur--------------------------------
        public int AccIdIntervFonct
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

        public int AccIdFonctInterv
        {
            get { return this.idFonct; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la fonction de l'intervenant ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idFonct = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe ModeleTravailler</summary>
        public ModeleTravailler() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe ModeleTravailler</summary>
        public ModeleTravailler(int numInterv, int numFonct)
        {
            AccIdIntervFonct = numInterv;
            AccIdFonctInterv = numFonct;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
