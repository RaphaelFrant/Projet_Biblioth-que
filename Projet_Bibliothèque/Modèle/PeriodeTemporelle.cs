using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe PeriodeTemporelle
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe PeriodeTemporelle 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class PeriodeTemporelle
    {
        //--------------------------------Variable--------------------------------
        public int idPeriodTempo;
        public string libPeriodTempo;

        //--------------------------------Accesseur--------------------------------
        public int AccIdPeriodTempo
        {
            get { return this.idPeriodTempo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la période temporelle ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPeriodTempo = value;
                }
            }
        }

        public string AccLibPeriodTempo
        {
            get { return this.libPeriodTempo; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé de la période temporelle ne peut pas être vide.");
                }
                else if (value.Length > 30)
                {
                    throw new Exception("Le libellé de la période temporelle ne peut pas excédé 30 caractères.");
                }
                else
                {
                    this.libPeriodTempo = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe PeriodeTemporelle</summary>
        public PeriodeTemporelle() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe PeriodeTemporelle</summary>
        public PeriodeTemporelle(int numPeriodTempo, string nomPeriodTempo)
        {
            AccIdPeriodTempo = numPeriodTempo;
            AccLibPeriodTempo = nomPeriodTempo;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe PeriodeTemporelle</summary>
        public PeriodeTemporelle(string nomPeriodTempo)
        {
            AccLibPeriodTempo = nomPeriodTempo;
        }

        //--------------------------------Méthodes--------------------------------
    }
}
