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
    /// Classe SérieLivre
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe SérieLivre 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 17, le 29/01/2020
    /// Implémentation de la méthode permettant de récupérer la série de livre associé à un livre précis</remarks>
    class SerieLivre : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public int idSerieLivre;
        public string libSerieLivre;

        //--------------------------------Accesseur--------------------------------
        public int AccIdSerieLivre
        {
            get { return this.idSerieLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la série de livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idSerieLivre = value;
                }
            }
        }

        public string AccLibSerieLivre
        {
            get { return this.libSerieLivre; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Le libellé de la série de livre ne peut pas être vide.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Le libellé de la série de livre ne peut pas excédé 50 caractères.");
                }
                else
                {
                    this.libSerieLivre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe SerieLivre</summary>
        public SerieLivre() { }

        /// <summary>Constructeur pour la modification d'un objet de la classe SerieLivre</summary>
        public SerieLivre(int numSerieLivre, string nomSerieLivre)
        {
            AccIdSerieLivre = numSerieLivre;
            AccLibSerieLivre = nomSerieLivre;
        }

        /// <summary>Constructeur pour l'insertion d'un objet de la classe SerieLivre</summary>
        public SerieLivre(string nomSerieLivre)
        {
            AccLibSerieLivre = nomSerieLivre;
        }
        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'une série de livre
        /// </summary>
        /// <param name="serieChoisi">Récupère le nom de la série de livre indiquée par l'utilisateur</param>
        /// <returns>Retourne l'identifiant de la série de livre</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant de la série de livre n'a pas pu être trouvé</exception>
        public static int TrouvNumSerie(SerieLivre serieChoisi)
        {
            try
            {
                int numSerie = 0;
                Connection();
                string cmdNumSerie = ("select idserieliv from serie_de_livre where libserieliv='" + serieChoisi.AccLibSerieLivre + "'");
                SqlCommand trouvNumSerie = new SqlCommand(cmdNumSerie, maConnexion);
                SqlDataReader lecteurSerie = trouvNumSerie.ExecuteReader();

                if (lecteurSerie.HasRows)
                {
                    while (lecteurSerie.Read())
                    {
                        numSerie = int.Parse(lecteurSerie[0].ToString());
                    }
                    lecteurSerie.Close();
                }
                else
                {
                    lecteurSerie.Close();
                    //Appel la méthode de création d'une période temporelle si la période mentionnée n'existe pas en base de données
                    InsertSerie(serieChoisi.AccLibSerieLivre);

                    SqlCommand trouvNumSerieCree = new SqlCommand(cmdNumSerie, maConnexion);
                    SqlDataReader lecteurSerieCree = trouvNumSerieCree.ExecuteReader();

                    if (lecteurSerieCree.HasRows)
                    {
                        while (lecteurSerieCree.Read())
                        {
                            numSerie = int.Parse(lecteurSerieCree[0].ToString());
                        }
                    }
                    lecteurSerieCree.Close();
                }
                return numSerie;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de créer une nouvelle série de livre lorsque l'utilisateur entre une série inconnue dans l'un des formulaires
        /// </summary>
        /// <param name="appelSerie">Récupère le nom de la série de livre entrée par l'utilisateur</param>
        /// <returns>Renvoie à son tour le nom de la série de livre qui a été créée</returns>
        /// <exception cref="">Renvoie une erreur si le nom de la série de livre entrée est invalide</exception>
        private static string InsertSerie(string appelSerie)
        {
            try
            {
                string libCreaSerie;
                Connection();
                libCreaSerie = "Insert into serie_de_livre (libserieliv) values (";
                libCreaSerie += "'" + appelSerie + "')";
                SqlCommand creaSerieBdd = new SqlCommand(libCreaSerie, maConnexion);
                creaSerieBdd.ExecuteScalar();
                return appelSerie;
            }
            catch
            {
                throw new Exception("Impossible de créer une nouvelle série de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer le nom de la série de livre en fonction de son identifiant
        /// </summary>
        /// <param name="identifiantSerie">Récupère l'identifiant de la série de livre</param>
        /// <returns>Retourne le nom de la série de livre correspondant à l'identifiant</returns>
        /// <exception cref="">Renvoie une erreur si la série de livre n'a pas pu être trouvée</exception>
        public static string TrouvNomSerie(int identifiantSerie)
        {
            try
            {
                string AppelationSerie = "";
                Connection();
                string cmdNomSerie = ("select libserieliv from serie_de_livre where idserieliv='" + identifiantSerie + "'");
                SqlCommand trouvNomSerie = new SqlCommand(cmdNomSerie, maConnexion);
                SqlDataReader lecteurNomSerie = trouvNomSerie.ExecuteReader();

                if (lecteurNomSerie.HasRows)
                {
                    while (lecteurNomSerie.Read())
                    {
                        AppelationSerie = lecteurNomSerie[0].ToString();
                    }
                }
                lecteurNomSerie.Close();
                return AppelationSerie;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le nom de la série de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'une série de livre
        /// </summary>
        /// <param name="titreSerie">Récupère le nom de la série de livre dont on veut récupérer l'identifiant</param>
        /// <returns>Retourne l'identifiant de la série de livre correspondant au nom entré</returns>
        /// <exception cref="">Renvoie une exception si l'identifiant n'a pas pu être récupéré</exception>
        public static int RecupIdSerie(string titreSerie)
        {
            try
            {
                Connection();
                int idTrouve = 0;
                string cmdTrouvIdSerie = ("select idserieliv from serie_de_livre where libserieliv='" + titreSerie + "'");
                SqlCommand trouvIdSerie = new SqlCommand(cmdTrouvIdSerie, maConnexion);
                SqlDataReader lecteurTrouvIdSerie = trouvIdSerie.ExecuteReader();
                if (lecteurTrouvIdSerie.HasRows)
                {
                    while (lecteurTrouvIdSerie.Read())
                    {
                        idTrouve = int.Parse(lecteurTrouvIdSerie[0].ToString());
                    }
                }
                lecteurTrouvIdSerie.Close();
                return idTrouve;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de la série de livre sélectionnée.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont associés à la série de livre indiquée par l'utilisateur
        /// </summary>
        /// <param name="numSerieSelect">Récupère le numéro de la série de livre sélectionné par l'utilisateur</param>
        /// <returns>Retourne une ArrayList contenant toutes les oeuvres associées à cette série de livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupérée</exception>
        public static ArrayList RecupOeuvreAssocSerie(int numSerieSelect)
        {
            try
            {
                Connection();
                ArrayList listeOeuvreAssocSerie = new ArrayList();
                string cmdOeuvreAssocSerie = ("select L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L  " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where L.idserieliv ='" + numSerieSelect + "'order by L.libliv asc");
                SqlCommand trouvOeuvreAssocSerie = new SqlCommand(cmdOeuvreAssocSerie, maConnexion);
                SqlDataReader lecteurOeuvreAssocSerie = trouvOeuvreAssocSerie.ExecuteReader();
                if (lecteurOeuvreAssocSerie.HasRows)
                {
                    while (lecteurOeuvreAssocSerie.Read())
                    {
                        listeOeuvreAssocSerie.Add(lecteurOeuvreAssocSerie.GetString(0));
                        listeOeuvreAssocSerie.Add(lecteurOeuvreAssocSerie.GetString(1));
                        listeOeuvreAssocSerie.Add(lecteurOeuvreAssocSerie.GetString(2));
                        listeOeuvreAssocSerie.Add(lecteurOeuvreAssocSerie.GetDateTime(3));
                        listeOeuvreAssocSerie.Add(lecteurOeuvreAssocSerie.GetString(4));
                        listeOeuvreAssocSerie.Add(lecteurOeuvreAssocSerie.GetString(5));
                    }
                }
                lecteurOeuvreAssocSerie.Close();
                return listeOeuvreAssocSerie;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à cette série de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des auteurs pour un livre précis
        /// </summary>
        /// <param name="codeIsbn">Récupère le numéro ISBN du livre</param>
        /// <returns>Retourne le nom de la série auquel appartient le livre</returns>
        /// <exception cref="">Renvoie une exception si lenom de la série n'a pas pu être récupéré</exception>
        public static string RecupSerieLivre(string codeIsbn)
        {
            try
            {
                Connection();
                string serieAssoc = "";
                string cmdSerieAssoc = "select Serie.LIBSERIELIV from SERIE_DE_LIVRE as Serie " +
                    "inner join Livre as L on L.IDSERIELIV = Serie.IDSERIELIV " +
                    "where L.NUMISBN = '" + codeIsbn + "'";
                SqlCommand trouvSerieAssoc = new SqlCommand(cmdSerieAssoc, maConnexion);
                SqlDataReader lecteurSerieAssoc = trouvSerieAssoc.ExecuteReader();
                if (lecteurSerieAssoc.HasRows)
                {
                    while (lecteurSerieAssoc.Read())
                    {
                        serieAssoc = lecteurSerieAssoc.GetString(0);
                    }
                }
                lecteurSerieAssoc.Close();
                return serieAssoc;
            }
            catch
            {
                throw new Exception("Impossible de récupérer le nom de la série pour un livre donné");
            }
        }
    }
}
