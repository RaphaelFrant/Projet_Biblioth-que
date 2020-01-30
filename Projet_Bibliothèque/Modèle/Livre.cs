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
    /// Classe Livre
    /// 
    /// Ensemble des variables et des méthodes appartenant à la classe Livre 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 18, le 30/01/2020
    /// Implémentation de la méthode de recherche des livres les plus récemment acquis</remarks>
    class Livre : ConnexionBase
    {
        //--------------------------------Variable--------------------------------
        public string numIsbn;
        public int idTypeLivre;
        public string idSerieLivre;
        public int idPeriodTempo;
        public int idEditeur;
        public int idImprim;
        public int idGenre;
        public string libLivre;
        public string libOrigLivre;
        public int prixLivre;
        public DateTime dateAchatLivre;
        public string langLivre;
        public DateTime depLegLivre;
        public int nbrePageLivre;
        public string etatLivre;
        public string resumLivre;


        //--------------------------------Accesseur--------------------------------
        public string AccNumIsbn
        {
            get { return this.numIsbn; }
            set
            {
                if (value.Length == 0 || value.Length != 17)
                {
                    throw new Exception("Le numéro d'ISBN du livre ne peut pas être vide et doit comporter 10 ou 13 caractères.");
                }
                else
                {
                    this.numIsbn = value;
                }
            }
        }

        public int AccIdTypeLivre
        {
            get { return this.idTypeLivre; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du type de livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idTypeLivre = value;
                }
            }
        }

        public string AccIdSerieLivre
        {
            get { return this.idSerieLivre; }
            set { this.idSerieLivre = value;}
        }

        public int AccIdPeriodTempo
        {
            get { return this.idPeriodTempo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de la période temporelle du livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idPeriodTempo = value;
                }
            }
        }

        public int AccIdEditeur
        {
            get { return this.idEditeur; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de l'éditeur du livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idEditeur = value;
                }
            }
        }

        public int AccIdImprim
        {
            get { return this.idImprim; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant de l'imprimeur du livre ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idImprim = value;
                }
            }
        }

        public int AccIdGenre
        {
            get { return this.idGenre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("L'identifiant du genre littéraire ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.idGenre = value;
                }
            }
        }

        public string AccLibLivre
        {
            get { return this.libLivre; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new Exception("Le titre du livre ne peut pas être vide");
                }
                else if(value.Length > 300)
                {
                    throw new Exception("Le titre du livre ne peut pas dépasser 300 caractères");
                }
                else
                {
                    this.libLivre = value;
                }
            }
        }

        public string AccLibOrigLivre
        {
            get { return this.libOrigLivre; }
            set
            {
                if (value.Length > 300)
                {
                    throw new Exception("Le titre du livre ne peut pas dépasser 300 caractères");
                }
                else
                {
                    this.libOrigLivre = value;
                }
            }
        }

        public int AccPrixLivre
        {
            get { return this.prixLivre; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Le prix du livre ne peut pas être négatif.");
                }
                else
                {
                    this.prixLivre = value;
                }
            }
        }

        public DateTime AccDateAchatLivre
        {
            get { return this.dateAchatLivre; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("La date d'acquisition ne peut pas être supérieure à celle du jour.");
                }
                else
                {
                    this.dateAchatLivre = value;
                }
            }
        }

        public string AccLangLivre
        {
            get { return this.langLivre; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("La langue du livre ne peut pas être vide.");
                }
                else if (value.Length > 30)
                {
                    throw new Exception("La langue du livre ne peut pas excédé 30 caractères.");
                }
                else
                {
                    this.langLivre = value;
                }
            }
        }

        public DateTime AccDepLegLivre
        {
            get { return this.depLegLivre; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("La date de dépôt légal de l'ouvrage ne peut être supérieure à la date du jour.");
                }
                else
                {
                    this.depLegLivre = value;
                }
            }
        }

        public int AccNbrePageLivre
        {
            get { return this.nbrePageLivre; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Le nombre de page ne peut pas être inférieur ou égal à zéro.");
                }
                else
                {
                    this.nbrePageLivre = value;
                }
            }
        }

        public string AccEtatLivre
        {
            get { return this.etatLivre; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("L'état du livre ne peut pas être vide.");
                }
                else if (value.Length > 20)
                {
                    throw new Exception("La langue du livre ne peut pas excédé 20 caractères.");
                }
                else
                {
                    this.etatLivre = value;
                }
            }
        }

        public string AccResumLivre
        {
            get { return this.resumLivre; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Lrésumé du livre ne peut pas être vide.");
                }
                else
                {
                    this.resumLivre = value;
                }
            }
        }

        //--------------------------------Constructeur--------------------------------
        /// <summary>Constructeur par défaut de la classe Livre</summary>
        public Livre () { }

        /// <summary>Constructeur pour la création ou la modification de la classe Livre</summary>
        public Livre(string numeroIsbn, int numTypeLivre, string numSerieLivre, int numPeriodeTemporelle, int numEdit, int numImprimeur, int numGenre, string titreLivre, string titreOriginal, 
            int montant, DateTime dateAcquisition, string langue, DateTime depotLegal, int pages, string etatOuvrage, string resume)
        {
            AccNumIsbn = numeroIsbn;
            AccIdTypeLivre = numTypeLivre;
            AccIdSerieLivre = numSerieLivre;
            AccIdPeriodTempo = numPeriodeTemporelle;
            AccIdEditeur = numEdit;
            AccIdImprim = numImprimeur;
            AccIdGenre = numGenre;
            AccLibLivre = titreLivre;
            AccLibOrigLivre = titreOriginal;
            AccPrixLivre = montant;
            AccDateAchatLivre = dateAcquisition;
            AccLangLivre = langue;
            AccDepLegLivre = depotLegal;
            AccNbrePageLivre = pages;
            AccEtatLivre = etatOuvrage;
            AccResumLivre = resume;
        }

        //--------------------------------Méthodes--------------------------------
        /// <summary>
        /// Méthode permettant de créer un nouveau livre dans la base de données
        /// </summary>
        /// <param name="nouvLivre">Récupère un objet Livre comprenant les informations du livre</param>
        /// <exception cref="">Renvoie une exception si le livre n'a pas pu être créé</exception>
        public static void InsertLivre(Livre nouvLivre)
        {
            string libCreaLivre;
            try
            {
                Connection();
                libCreaLivre = "Insert into Livre(numisbn, idtypeliv, idserieliv, idperiotemp, idedit, idimprim, idgenre, libliv, liborigliv, prixliv, dateachat, langueliv, " +
                    "deplegliv, nbpageliv, etatlecture, resumliv)values (";
                libCreaLivre += "'" + nouvLivre.AccNumIsbn + "', ";
                libCreaLivre += "'" + nouvLivre.AccIdTypeLivre + "', ";
                if(nouvLivre.AccIdSerieLivre == "")
                {
                    libCreaLivre += "null, ";
                }
                else
                {
                    libCreaLivre += "'" + nouvLivre.AccIdSerieLivre + "', ";
                }
                libCreaLivre += "'" + nouvLivre.AccIdPeriodTempo + "', ";
                libCreaLivre += "'" + nouvLivre.AccIdEditeur + "', ";
                libCreaLivre += "'" + nouvLivre.AccIdImprim + "', ";
                libCreaLivre += "'" + nouvLivre.AccIdGenre + "', ";
                libCreaLivre += "'" + nouvLivre.AccLibLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccLibOrigLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccPrixLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccDateAchatLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccLangLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccDepLegLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccNbrePageLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccEtatLivre + "', ";
                libCreaLivre += "'" + nouvLivre.AccResumLivre + "')";
                SqlCommand creaLivreBdd = new SqlCommand(libCreaLivre, maConnexion);
                creaLivreBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouveau livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de supprimer un livre en fonction de la donnée sélectionné par l'utilisateur
        /// </summary>
        /// <param name="codeIsbn">Récupère le numéro d'ISBN du livre que l'utilisateur a sélectionné</param>
        /// <exception cref="">Renvoie une erreur si le livre n'a pas pu être supprimé</exception>
        public static void DeleteLivre(string codeIsbn)
        {
            try
            {
                string libSupprLiv;
                Connection();
                libSupprLiv = "Delete from livre where numisbn='" + codeIsbn + "'";
                SqlCommand supprLivBdd = new SqlCommand(libSupprLiv, maConnexion);
                supprLivBdd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Impossible de supprimer le livre sélectionné.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont associés au titre indiqué par l'utilisateur
        /// </summary>
        /// <param name="chaineLivre">Récupère la chaine entré par l'auteur comme titre de livre</param>
        /// <returns>Retourne la liste des oeuvres qui correspondent à la chaine entrée</returns>
        /// <exception cref="">Renvoie une exception si la requête n'a pas pu aboutir et que la liste n'a pas pu être récupéré</exception>
        public static ArrayList RecupOeuvreAssocLivre(string chaineLivre)
        {
            try
            {
                Connection();
                ArrayList listeOeuvreAssocLivre = new ArrayList();
                string cmdOeuvreAssocLivre = ("select L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where L.libliv like '%" + chaineLivre + "%' order by L.libliv asc");
                SqlCommand trouvOeuvreAssocLivre = new SqlCommand(cmdOeuvreAssocLivre, maConnexion);
                SqlDataReader lecteurOeuvreAssocLivre = trouvOeuvreAssocLivre.ExecuteReader();
                if (lecteurOeuvreAssocLivre.HasRows)
                {
                    while (lecteurOeuvreAssocLivre.Read())
                    {
                        listeOeuvreAssocLivre.Add(lecteurOeuvreAssocLivre.GetString(0));
                        listeOeuvreAssocLivre.Add(lecteurOeuvreAssocLivre.GetString(1));
                        listeOeuvreAssocLivre.Add(lecteurOeuvreAssocLivre.GetString(2));
                        listeOeuvreAssocLivre.Add(lecteurOeuvreAssocLivre.GetDateTime(3));
                        listeOeuvreAssocLivre.Add(lecteurOeuvreAssocLivre.GetString(4));
                        listeOeuvreAssocLivre.Add(lecteurOeuvreAssocLivre.GetString(5));
                    }
                }
                lecteurOeuvreAssocLivre.Close();
                return listeOeuvreAssocLivre;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à cet intitulé de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des informations concernant le livre choisi par l'utilisateur
        /// </summary>
        /// <param name="isbn">Récupère le numéro d'ISBN du livre</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste des informations n'a pas pu être récupéré</exception>
        public static ArrayList AfficherLivre(string isbn)
        {
            try
            {
                Connection();
                ArrayList livreAff = new ArrayList();
                string cmdLivreARecup = "select L.NUMISBN, L.libliv, L.LIBORIGLIV, L.PRIXLIV, L.DATEACHAT, L.LANGUELIV, L.DEPLEGLIV, L.NBPAGELIV, L.ETATLECTURE, Genr.LIBGENRE, " +
                    "Perio.LIBPERIOTEMP, typ.LIBTYPELIV, L.RESUMLIV, Edit.NOMEDIT, Impr.NOMIMPRIM " +
                    "from livre as L " +
                    "inner join GENRE_LITTERAIRE as Genr on Genr.IDGENRE = L.IDGENRE " +
                    "inner join PERIODE_TEMPORELLE as Perio on Perio.IDPERIOTEMP = L.IDPERIOTEMP " +
                    "inner join TYPE_DE_LIVRE as typ on typ.IDTYPELIV = L.IDTYPELIV " +
                    "inner join Editeur as Edit on Edit.IDEDIT =  L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "where L.NUMISBN = '" + isbn + "'";
                SqlCommand trouvLivreARecup = new SqlCommand(cmdLivreARecup, maConnexion);
                SqlDataReader lecteurLivreARecup = trouvLivreARecup.ExecuteReader();
                if (lecteurLivreARecup.HasRows)
                {
                    while (lecteurLivreARecup.Read())
                    {
                        livreAff.Add(lecteurLivreARecup.GetString(0));
                        livreAff.Add(lecteurLivreARecup.GetString(1));
                        livreAff.Add(lecteurLivreARecup.GetString(2));
                        livreAff.Add(int.Parse(lecteurLivreARecup[3].ToString()));
                        livreAff.Add(lecteurLivreARecup.GetDateTime(4));
                        livreAff.Add(lecteurLivreARecup.GetString(5));
                        livreAff.Add(lecteurLivreARecup.GetDateTime(6));
                        livreAff.Add(int.Parse(lecteurLivreARecup[7].ToString()));
                        livreAff.Add(lecteurLivreARecup.GetString(8));
                        livreAff.Add(lecteurLivreARecup.GetString(9));
                        livreAff.Add(lecteurLivreARecup.GetString(10));
                        livreAff.Add(lecteurLivreARecup.GetString(11));
                        livreAff.Add(lecteurLivreARecup.GetString(12));
                        livreAff.Add(lecteurLivreARecup.GetString(13));
                        livreAff.Add(lecteurLivreARecup.GetString(14));
                    }
                }
                lecteurLivreARecup.Close();
                return livreAff;
            }
            catch
            {
                throw new Exception("La liste des informations du livre n'a pas pu être récupéré.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des oeuvres qui sont les plus récentes
        /// </summary>
        /// <param name="chaineLivre">Récupère la chaine entré par l'auteur comme titre de livre</param>
        /// <returns>Retourne la liste des oeuvres qui correspondent à la chaine entrée</returns>
        /// <exception cref="">Renvoie une exception si la requête n'a pas pu aboutir et que la liste n'a pas pu être récupéré</exception>
        public static ArrayList RecupererNouveaute()
        {
            try
            {
                Connection();
                ArrayList listeNouveaute = new ArrayList();
                DateTime dateJour = DateTime.Today;
                string cmdNouveaute = ("select Top(5) L.numisbn, L.libliv, (Aut.NOMAUT + ' ' + PRENOMAUT) as 'Nom Auteur', L.DEPLEGLIV, Edit.NOMEDIT, Impr.NOMIMPRIM, L.dateachat " +
                    "from livre as L " +
                    "inner join Ecrire as Ecr on Ecr.NUMISBN = L.NUMISBN " +
                    "inner join Auteur as Aut on  Aut.IDAUT = Ecr.IDAUT " +
                    "inner join Editeur as Edit on Edit.IDEDIT = L.IDEDIT " +
                    "inner join Imprimeur as Impr on Impr.IDIMPRIM = L.IDIMPRIM " +
                    "order by year(L.DATEACHAT) desc");
                SqlCommand trouvNouveaute = new SqlCommand(cmdNouveaute, maConnexion);
                SqlDataReader lecteurNouveaute = trouvNouveaute.ExecuteReader();
                if (lecteurNouveaute.HasRows)
                {
                    while (lecteurNouveaute.Read())
                    {
                        listeNouveaute.Add(lecteurNouveaute.GetString(0));
                        listeNouveaute.Add(lecteurNouveaute.GetString(1));
                        listeNouveaute.Add(lecteurNouveaute.GetString(2));
                        listeNouveaute.Add(lecteurNouveaute.GetDateTime(3));
                        listeNouveaute.Add(lecteurNouveaute.GetString(4));
                        listeNouveaute.Add(lecteurNouveaute.GetString(5));
                        listeNouveaute.Add(lecteurNouveaute.GetDateTime(6));
                    }
                }
                lecteurNouveaute.Close();
                return listeNouveaute;
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres les plus récentes.");
            }
        }
    }
}
