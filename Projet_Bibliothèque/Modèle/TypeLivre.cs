using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Modèle
{
    /// <summary>
    /// Classe TypeLivre
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe TypeLivre 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction du type de livre</remarks>
    class TypeLivre : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idTypeLivre;
        public string libTypeLivre;

        //--------------------------------Accesseur--------------------------------
        public int AccIdTypeLivre
        {
            get { return this.idTypeLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du type de livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idTypeLivre = value;
                }
            }
        }

        public string AccLibTypeLivre
        {
            get { return this.libTypeLivre; }
            set
            {
                if(value.Length == 0)
                {
                    throw new Exception("Le libellé du type de livre ne peut pas être vide.");
                }
                else if (value.Length > 20)
                {
                    throw new Exception("Le libellé du type de livre ne peut pas excédé 20 caractères.");
                }
                else
                {
                    this.libTypeLivre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe TypeLivre</summary>
        public TypeLivre () { }

        /// <summary>Constructeur pour la modification d'un objet de la classe TypeLivre</summary>
        public TypeLivre (int numTypeLivre, string nomTypeLivre)
        {
            AccIdTypeLivre = numTypeLivre;
            AccLibTypeLivre = nomTypeLivre;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe TypeLivre</summary>
        public TypeLivre(string nomTypeLivre)
        {
            AccLibTypeLivre = nomTypeLivre;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'un type de livre
        /// </summary>
        /// <param name="serieChoisi">Récupère le nom du type de livre indiquée par l'utilisateur</param>
        /// <returns>Retourne l'identifiant du type de livre</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant du type de livre n'a pas pu être trouvé</exception>
        public static int TrouvNumTypeLivre(TypeLivre typeLivChoisi)
        {
            try
            {
                int numTypeLiv = 0;
                Connection();
                string cmdNumTypeLiv = ("select idtypeliv from type_de_livre where libtypeliv='" + typeLivChoisi.AccLibTypeLivre + "'");
                SqlCommand trouvNumTypeLiv = new SqlCommand(cmdNumTypeLiv, maConnexion);
                SqlDataReader lecteurTypeLiv = trouvNumTypeLiv.ExecuteReader();

                if (lecteurTypeLiv.HasRows)
                {
                    while (lecteurTypeLiv.Read())
                    {
                        numTypeLiv = int.Parse(lecteurTypeLiv[0].ToString());
                    }
                    lecteurTypeLiv.Close();
                }
                else
                {
                    lecteurTypeLiv.Close();
                    //Appel la méthode de création d'une période temporelle si la période mentionnée n'existe pas en base de données
                    InsertTypeLivre(typeLivChoisi.AccLibTypeLivre);

                    SqlCommand trouvNumTypeLivCree = new SqlCommand(cmdNumTypeLiv, maConnexion);
                    SqlDataReader lecteurTypeLivCree = trouvNumTypeLivCree.ExecuteReader();

                    if (lecteurTypeLivCree.HasRows)
                    {
                        while (lecteurTypeLivCree.Read())
                        {
                            numTypeLiv = int.Parse(lecteurTypeLivCree[0].ToString());
                        }
                    }
                    lecteurTypeLivCree.Close();
                }
                return numTypeLiv;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer une nouveau type de livre lorsque l'utilisateur entre un type inconnu dans l'un des formulaires
        /// </summary>
        /// <param name="appelTypeLiv">Récupère le nom du type de livre entrée par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom du type de livre qui a été créée</returns>
        /// <exception cref="">Renvoie une erreur si le nom du type de livre entrée est invalide</exception>
        private static string InsertTypeLivre(string appelTypeLiv)
        {
            try
            {
                string libCreaTypeLiv;
                Connection();
                libCreaTypeLiv = "Insert into type_de_livre (libtypeliv) values (";
                libCreaTypeLiv += "'" + appelTypeLiv + "')";
                SqlCommand creaTypeLivBdd = new SqlCommand(libCreaTypeLiv, maConnexion);
                creaTypeLivBdd.ExecuteScalar();
                return appelTypeLiv;
            }
            catch
            {
                throw new Exception("Impossible de créer un nouveau type de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom du type de livre en fonction de son identifiant
        /// </summary>
        /// <param name="identifiantTypeLiv">Récupère l'identifiant du type de livre</param>
        /// <returns>Retourne le nom du type de livre correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si le type de livre n'a pas pu être trouvée</exception>
        public static string TrouvNomTypeLiv(int identifiantTypeLiv)
        {
            try
            {
                string AppelationTypeLiv = "";
                Connection();
                string cmdNomTypeLiv = ("select libtypeliv from type_de_livre where idtypeliv='" + identifiantTypeLiv + "'");
                SqlCommand trouvNomTypeLiv = new SqlCommand(cmdNomTypeLiv, maConnexion);
                SqlDataReader lecteurNomTypeLiv = trouvNomTypeLiv.ExecuteReader();

                if (lecteurNomTypeLiv.HasRows)
                {
                    while (lecteurNomTypeLiv.Read())
                    {
                        AppelationTypeLiv = lecteurNomTypeLiv[0].ToString();
                    }
                }
                lecteurNomTypeLiv.Close();
                return AppelationTypeLiv;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom du type de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant du type de livre
        /// </summary>
        /// <param name="nomTypeLiv">Récupère le nom du type de livre dont on veut récupérer l'identifiant</param>
        /// <returns>Retourne l'identifiant du type de livre correspondant au nom entré</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant n'a pas pu être récupéré</exception>
        public static int RecupIdTypeLivre(string nomTypeLiv)
        {
            try
            {
                Connection();
                int idTrouve = 0;
                string cmdTrouvIdTypeLiv = ("select idtypeliv from type_de_livre where libtypeliv='" + nomTypeLiv + "'");
                SqlCommand trouvIdTypeLiv = new SqlCommand(cmdTrouvIdTypeLiv, maConnexion);
                SqlDataReader lecteurTrouvIdTypeLiv = trouvIdTypeLiv.ExecuteReader();
                if (lecteurTrouvIdTypeLiv.HasRows)
                {
                    while (lecteurTrouvIdTypeLiv.Read())
                    {
                        idTrouve = int.Parse(lecteurTrouvIdTypeLiv[0].ToString());
                    }
                }
                lecteurTrouvIdTypeLiv.Close();
                return idTrouve;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant du type de livre sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont associés au type de livre indiqué par l'utilisateur
        /// </summary>
        /// <param name="numTypeLivSelect">Récupère le numéro ddu type de livre sélectionné par l'utilisateur</param>
        /// <returns>Retourne une ArrayList contenant toutes les oeuvres associées à ce type de livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupérée</exception>
        public static ArrayList RecupOeuvreAssocTypeLivre(int numTypeLivSelect)
        {
            try
            {
                Connection();
                ArrayList listeOeuvreAssocTypeLiv = new ArrayList();
                string cmdOeuvreAssocTypeLiv = ("select L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L  " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where L.idtypeliv ='" + numTypeLivSelect + "'order by L.libliv asc");
                SqlCommand trouvOeuvreAssocTypeLiv = new SqlCommand(cmdOeuvreAssocTypeLiv, maConnexion);
                SqlDataReader lecteurOeuvreAssocTypeLiv = trouvOeuvreAssocTypeLiv.ExecuteReader();
                if (lecteurOeuvreAssocTypeLiv.HasRows)
                {
                    while (lecteurOeuvreAssocTypeLiv.Read())
                    {
                        listeOeuvreAssocTypeLiv.Add(lecteurOeuvreAssocTypeLiv.GetString(0));
                        listeOeuvreAssocTypeLiv.Add(lecteurOeuvreAssocTypeLiv.GetString(1));
                        listeOeuvreAssocTypeLiv.Add(lecteurOeuvreAssocTypeLiv.GetString(2));
                        listeOeuvreAssocTypeLiv.Add(lecteurOeuvreAssocTypeLiv.GetDateTime(3));
                        listeOeuvreAssocTypeLiv.Add(lecteurOeuvreAssocTypeLiv.GetString(4));
                        listeOeuvreAssocTypeLiv.Add(lecteurOeuvreAssocTypeLiv.GetString(5));
                    }
                }
                lecteurOeuvreAssocTypeLiv.Close();
                return listeOeuvreAssocTypeLiv;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à ce type de livre.");
            }
        }
    }
}
