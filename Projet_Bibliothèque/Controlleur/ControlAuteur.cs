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
    /// Controlleur pour les objets en lien avec la classe Auteur
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 12, le 14/01/2020
    /// Implémentation du contrôle pour récupérer l'identifiant d'un auteur</remarks>
    class ControlAuteur
    {
        /// <summary>
        /// Méthode permettant de transformer une arraylist avec les informations du nouvel auteur en un objet Auteur
        /// </summary>
        /// <param name="nouvInfoAut">Récupère une ArrayList avec les informations de l'auteur entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Auteur ne peut pas être créé</exception>
        public static void CreerAuteur(ArrayList nouvInfoAut)
        {
            try
            {
                Auteur nouvAut = new Auteur();
                nouvAut.AccIdPaysAut = int.Parse(nouvInfoAut[0].ToString());
                nouvAut.AccNomAut = nouvInfoAut[1].ToString();
                nouvAut.AccPrenomAut = nouvInfoAut[2].ToString();
                nouvAut.AccSurnomAut = nouvInfoAut[3].ToString();
                nouvAut.AccDateNaiAut = DateTime.Parse(nouvInfoAut[4].ToString());
                nouvAut.AccDateMortAut = nouvInfoAut[5].ToString();
                Auteur.InsertAuteur(nouvAut);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Auteur avec les informations entrées par l'utilisateur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que les informations modifiées sont valides avant d'être envoyé au Modèle
        /// </summary>
        /// <param name="modifInfoAut">Récupère la liste des nouvelles informations de l'auteur entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Auteur ne peut pas être créé pour modification</exception>
        public static void ModifAuteur(ArrayList modifInfoAut)
        {
            try
            {
                Auteur modifAut = new Auteur();
                modifAut.AccIdAut = int.Parse(modifInfoAut[0].ToString());
                modifAut.AccIdPaysAut = int.Parse(modifInfoAut[1].ToString());
                modifAut.AccNomAut = modifInfoAut[2].ToString();
                modifAut.AccPrenomAut = modifInfoAut[3].ToString();
                modifAut.AccSurnomAut = modifInfoAut[4].ToString();
                modifAut.AccDateNaiAut = DateTime.Parse(modifInfoAut[5].ToString());
                modifAut.AccDateMortAut = modifInfoAut[6].ToString();
                Auteur.UpdateAuteur(modifAut);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Auteur avec les informations entrées par l'utilisateur pour modifier un auteur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomAuteur">Récupère la chaine entrée par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static void SupprAuteur(string nomAuteur)
        {
            try
            {
                Auteur.DeleteAuteur(nomAuteur);
            }
            catch
            {
                throw new Exception("Impossible d'envoyer la chaine au Modèle pour supprimer l'auteur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomAuteurSelect">Récupère la chaine entrée par l'utilisateur comportant le nom de l'auteur dont il faut récupérer l'identifiant</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static int RecupIdAuteur(string nomAuteurSelect)
        {
            try
            {
                int idRecupereAut = Auteur.RecupIdAuteur(nomAuteurSelect);
                return idRecupereAut;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'auteur");
            }
        }
    }
}
