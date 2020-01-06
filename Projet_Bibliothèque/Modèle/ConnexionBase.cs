using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Projet_Bibliothèque.Modèle
{
    abstract class ConnexionBase
    {
        //Initialisation de ma SqlConnection
        protected static SqlConnection maConnexion = getConnexion();

        /// <summary>
        /// Méthode permettant de récupérer la chaine de connexion dans le dossier AppConfig
        /// </summary>
        /// <returns>Renvoie la connexion à la base de données</returns>
        /// <exception cref="System.Exception">Lancer une erreur si la chaine de connexion n'a pas pu être récupérée</exception>
        private static SqlConnection getConnexion()
        {
            try
            {
                //Chaine de connexion présent dans le App.config
                ConnectionStringSettings parametreConnexion = ConfigurationManager.ConnectionStrings["sgbd"];
                string laChaineDeConnexion = parametreConnexion.ConnectionString;
                return maConnexion = new SqlConnection(laChaineDeConnexion);
            }
            catch (Exception)
            {
                throw new Exception("Impossible de récupérer la chaine de connexion!");
            }
        }

        /// <summary>
        /// Méthode permettant de se connecter à la base de données quand elle est appelé
        /// </summary>
        /// <exception cref="System.Exception">Lancer une erreur si l'application n'a pas pu se connecter à la base de données</exception>
        protected static void Connection()
        {
            try
            {
                if (maConnexion.State != System.Data.ConnectionState.Open)
                {
                    maConnexion.Open();
                    Console.WriteLine("ConnexOuverte");
                }
            }
            catch (Exception)
            {
                throw new Exception("Impossible de se connecter à la base de donnée. Veuillez contacter l'administrateur!");
            }
        }
    }
}
