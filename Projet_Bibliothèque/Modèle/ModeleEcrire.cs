using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 12, le 14/01/2020
    /// Implémentation de la méthode de création d'un lien entre auteur et livre</remarks>
    class ModeleEcrire : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idAut;
        public string numIsbn;

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

        public string AccNumIsbnEcrire
        {
            get { return this.numIsbn; }
            set
            {
                if (value.Length <= 0)
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
        public ModeleEcrire(int numAuteur, string isbn)
        {
            AccIdAutEcrire = numAuteur;
            AccNumIsbnEcrire = isbn;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant d'associer un auteur à un livre après la création des deux objets
        /// </summary>
        /// <param name="nouvEcrit">Récupère un objet contenant l'identifiant du livre et celui de l'auteur</param>
        /// <exception cref="">Renvoie une erreur si la requête est erronée ou que l'association n'a pas pu être faite.</exception>
        public static void InsertEcrire(ModeleEcrire nouvEcrit)
        {
            string libCreaEcrire;
            try
            {
                Connection();
                libCreaEcrire = "Insert into Ecrire(idaut, numisbn)values (";
                libCreaEcrire += "'" + nouvEcrit.AccIdAutEcrire + "', ";
                libCreaEcrire += "'" + nouvEcrit.AccNumIsbnEcrire + "')";
                SqlCommand creaEcrireBdd = new SqlCommand(libCreaEcrire, maConnexion);
                creaEcrireBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible d'associer un livre avec un auteur");
            }
        }
    }
}
