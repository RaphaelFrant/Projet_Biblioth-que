using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe Pays
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Pays 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 1, le 18/12/2019
    /// Implémentation des attributs des classes</remarks>
    class Pays : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idPays;
        public string libPays;

        //--------------------------------Accesseur--------------------------------
        public int AccIdPays
        {
            get { return this.idPays; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du Pays ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPays = value;
                }
            }
        }

        public string AccLibPays
        {
            get { return this.libPays; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé du Pays ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le nom du pays ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libPays = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Pays</summary>
        public Pays() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe Pays</summary>
        public Pays(int numPays, string nomPays)
        {
            AccIdPays = numPays;
            AccLibPays = nomPays;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe Pays</summary>
        public Pays(string nomPays)
        {
            AccLibPays = nomPays;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de renvoyer le numéro du pays en fonction du nom indiqué. Si le pays n'existe pas encore dans la liste, la méthode l'ajoute avant de renvoyé 
        /// le numéro du pays
        /// </summary>
        /// <param name="nomPays">Nom du pays soumis à la méthode</param>
        /// <returns>Retourne le numéro du pays correspondant</returns>
        /// <exception cref="">Renvoie une erreur si le nom du pays ne correspond à rien dans la base de données</exception>
        public int TrouvNumPays (string nomPays)
        {
            try
            {
                int numPays = 0;
                Connection();
                string comdNumPays = ("select idPays from pays where libpays='" + nomPays + "'");
                SqlCommand trouvNumPays = new SqlCommand(comdNumPays, maConnexion);
                SqlDataReader lecteur = trouvNumPays.ExecuteReader();

                if (lecteur.HasRows)
                {
                    while (lecteur.Read())
                    {
                        numPays = int.Parse(lecteur[0].ToString());
                    }
                    lecteur.Close();
                }
                else
                {
                    lecteur.Close();
                    string libCreaPays;
                    Connection();
                    libCreaPays = "Insert into Pays (libpays) values (";
                    libCreaPays += "'" + nomPays + "')";
                    SqlCommand creaPaysBdd = new SqlCommand(libCreaPays, maConnexion);
                    creaPaysBdd.ExecuteScalar();

                    SqlCommand trouvNumPaysCree = new SqlCommand(comdNumPays, maConnexion);
                    SqlDataReader lecteurPaysCree = trouvNumPays.ExecuteReader();

                    if (lecteurPaysCree.HasRows)
                    {
                        while (lecteurPaysCree.Read())
                        {
                            numPays = int.Parse(lecteurPaysCree[0].ToString());
                        }
                    }
                    lecteurPaysCree.Close();
                }
                return numPays;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
