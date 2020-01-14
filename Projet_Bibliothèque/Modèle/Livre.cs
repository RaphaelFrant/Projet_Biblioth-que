using System;
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
    /// <remarks>Auteur Raphaël Frantzen, Version 12, le 14/01/2020
    /// Implémentation de la méthode pour créer un nouveau livre dans la base de données</remarks>
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
    }
}
