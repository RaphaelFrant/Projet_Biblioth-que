using Projet_Bibliothèque.Modèle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe Livre
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 16, le 28/01/2020
    /// mplémentation de la méthode de recherche d'un livre en fonction d'un titre</remarks>
    class ControlLivre
    {
        /// <summary>
        /// Méthode permettant de vérifier les données entrées par l'utilisateur pour créer un nouveau livre
        /// </summary>
        /// <param name="nouvInfoLiv">Récupère une ArrayList avec les informations du nouveau livre</param>
        /// <exception cref="">Renvoie une exception si le livre n'a pas pu être créé</exception>
        public static void CreerLivre(ArrayList nouvInfoLiv)
        {
            try
            {
                Livre nouvLivre = new Livre();
                nouvLivre.AccNumIsbn = nouvInfoLiv[0].ToString();
                nouvLivre.AccIdTypeLivre = int.Parse(nouvInfoLiv[1].ToString());
                nouvLivre.AccIdSerieLivre = nouvInfoLiv[2].ToString();
                nouvLivre.AccIdPeriodTempo = int.Parse(nouvInfoLiv[3].ToString());
                nouvLivre.AccIdEditeur = int.Parse(nouvInfoLiv[4].ToString());
                nouvLivre.AccIdImprim = int.Parse(nouvInfoLiv[5].ToString());
                nouvLivre.AccIdGenre = int.Parse(nouvInfoLiv[6].ToString());
                nouvLivre.AccLibLivre = nouvInfoLiv[7].ToString();
                nouvLivre.AccLibOrigLivre = nouvInfoLiv[8].ToString();
                nouvLivre.AccPrixLivre = int.Parse(nouvInfoLiv[9].ToString());
                nouvLivre.AccDateAchatLivre = DateTime.Parse(nouvInfoLiv[10].ToString());
                nouvLivre.AccLangLivre = nouvInfoLiv[11].ToString();
                nouvLivre.AccDepLegLivre = DateTime.Parse(nouvInfoLiv[12].ToString());
                nouvLivre.AccNbrePageLivre = int.Parse(nouvInfoLiv[13].ToString());
                nouvLivre.AccEtatLivre = nouvInfoLiv[14].ToString();
                nouvLivre.AccResumLivre = nouvInfoLiv[15].ToString();
                Livre.InsertLivre(nouvLivre);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Livre avec les informations entrées par l'utilisateur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier la chaine entré
        /// </summary>
        /// <param name="numIsbn">Récupère le numéro d'ISBN du livre choisi par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si la chaine est incorrect ou si le livre n'a pas pu être supprimé</exception>
        public static void SupprLivre(string numIsbn)
        {
            try
            {
                Livre.DeleteLivre(numIsbn);
            }
            catch
            {
                throw new Exception("Impossible d'envoyer la chaine au Modèle pour supprimer le livre sélectionné");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés à un titre de livre sélectionné
        /// </summary>
        /// <param name="chaineTitreChoisi">Récupère l'identifiant du livre indiqué</param>
        /// <returns>Retourne une ArrayList avec les informations des oeuvres récupérées</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssocLivre(string chaineTitreChoisi)
        {
            try
            {
                return Livre.RecupOeuvreAssocLivre(chaineTitreChoisi);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à un titre de livre");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des informations d'un livre sélectionné pour affichage
        /// </summary>
        /// <param name="chaineIsbn">Récupère le numéro d'ISBn du livre</param>
        /// <returns>Retourne une ArrayListe avec les informations du livre</returns>
        /// <exception cref="">Renvoie une exception si la chaine est incorrecte ou si la liste des informations n'a pas pu être récupéré</exception>
        public static ArrayList RecupInfoLivre(string chaineIsbn)
        {
            try
            {
                return Livre.AfficherLivre(chaineIsbn);
            }
            catch
            {
                throw new Exception("Impossible de récupérer les informations du livre sélectionné.");
            }
        }
    }
}
