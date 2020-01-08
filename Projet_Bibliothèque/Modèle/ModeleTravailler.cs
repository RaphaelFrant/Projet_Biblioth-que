using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 5, le 08/01/2020
    /// Implémentation de la méthode d'insertion d'u couple Intervenant/Fonction dans la base de données</remarks>
    class ModeleTravailler : ConnexionBase
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
        public static void InsertTravail(ModeleTravailler coupleIdent)
        {
            string libTrav;
            try
            {
                Connection();
                libTrav = "Insert into Travailler_comme(idinterv, idfonction)values (";
                libTrav += "'" + coupleIdent.AccIdIntervFonct + "', ";
                libTrav += "'" + coupleIdent.AccIdFonctInterv + "')";
                SqlCommand creaTravBdd = new SqlCommand(libTrav, maConnexion);
                creaTravBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de remplir la base de données avec les données entrées");
            }
        }
    }
}
