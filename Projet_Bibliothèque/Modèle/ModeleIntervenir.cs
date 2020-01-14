using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 12, le 14/01/2020
    /// Implémentation de la méthode de création d'un lien entre intervenant et livre</remarks>
    class ModeleIntervenir : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idInterv;
        public string numIsbn;

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

        public string AccNumIsbnInterv
        {
            get { return this.numIsbn; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'ISBN ne peut pas être vide");
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
        public ModeleIntervenir(int numInterv, string isbnInterv)
        {
            AccIdIntervLivre = numInterv;
            AccNumIsbnInterv = isbnInterv;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant d'associer un intervenant à un livre après la création des deux objets
        /// </summary>
        /// <param name="nouvInterv">Récupère un objet contenant l'identifiant du livre et celui de l'intervenant</param>
        /// <exception cref="">Renvoie une erreur si la requête est erronée ou que l'association n'a pas pu être faite.</exception>
        public static void InsertIntervention(ModeleIntervenir nouvIntervention)
        {
            string libCreaIntervention;
            try
            {
                Connection();
                libCreaIntervention = "Insert into intervenir(idinterv, numisbn)values (";
                libCreaIntervention += "'" + nouvIntervention.AccIdIntervLivre + "', ";
                libCreaIntervention += "'" + nouvIntervention.AccNumIsbnInterv + "')";
                SqlCommand creaInterventionBdd = new SqlCommand(libCreaIntervention, maConnexion);
                creaInterventionBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible d'associer un intervenant avec un auteur");
            }
        }
    }
}
