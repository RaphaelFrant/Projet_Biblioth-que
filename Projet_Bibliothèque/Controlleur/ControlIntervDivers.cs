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
    /// Controlleur pour les objets en lien avec la classe Intervenant_Divers
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 17, le 29/01/2020
    /// Implémentation de la méthode pour récupérer la liste des intervenants pour un livre précis</remarks>
    class ControlIntervDivers
    {
        /// <summary>
        /// Méthode permettant de transformer une arraylist avec les informations du nouvel intervenant en un objet Intervenant_Divers
        /// </summary>
        /// <param name="nouvInfoInterv">Récupère une ArrayList avec les informations de l'intervenant entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Intervenant_Divers ne peut pas être créé</exception>
        public static void CreerIntervenant(ArrayList nouvInfoInterv)
        {
            try
            {
                IntervenantDivers nouvInterv = new IntervenantDivers();
                nouvInterv.AccIdPaysInterv = int.Parse(nouvInfoInterv[0].ToString());
                nouvInterv.AccIdFonctInterv = int.Parse(nouvInfoInterv[1].ToString());
                nouvInterv.AccNomInterv = nouvInfoInterv[2].ToString();
                nouvInterv.AccPrenomInterv = nouvInfoInterv[3].ToString();
                nouvInterv.AccSurnomInterv = nouvInfoInterv[4].ToString();
                nouvInterv.AccDateNaiInterv = DateTime.Parse(nouvInfoInterv[5].ToString());
                nouvInterv.AccDateMortInterv = nouvInfoInterv[6].ToString();
                IntervenantDivers.InsertIntervenant(nouvInterv);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Intervenant_Divers avec les informations entrées par l'utilisateur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que les informations modifiées sont valides avant d'être envoyé au Modèle
        /// </summary>
        /// <param name="modifInfoInterv">Récupère la liste des nouvelles informations de l'intervenant entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Intervenant_Divers ne peut pas être créé pour modification</exception>
        public static void ModifIntervenant(ArrayList modifInfoInterv)
        {
            try
            {
                IntervenantDivers modifInterv = new IntervenantDivers();
                modifInterv.AccIdInterv = int.Parse(modifInfoInterv[0].ToString());
                modifInterv.AccIdPaysInterv = int.Parse(modifInfoInterv[1].ToString());
                modifInterv.AccIdFonctInterv = int.Parse(modifInfoInterv[2].ToString());
                modifInterv.AccNomInterv = modifInfoInterv[3].ToString();
                modifInterv.AccPrenomInterv = modifInfoInterv[4].ToString();
                modifInterv.AccSurnomInterv = modifInfoInterv[5].ToString();
                modifInterv.AccDateNaiInterv = DateTime.Parse(modifInfoInterv[6].ToString());
                modifInterv.AccDateMortInterv = modifInfoInterv[7].ToString();
                IntervenantDivers.UpdateInterv(modifInterv);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Intervenant_Divers avec les informations entrées par l'utilisateur pour modifier un intervenant");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomInterv">Récupère la chaine entrée par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static void SupprInterveneur(string nomInterv)
        {
            try
            {
                IntervenantDivers.DeleteInterv(nomInterv);
            }
            catch
            {
                throw new Exception("Impossible d'envoyer la chaine au Modèle pour supprimer l'intervenant");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomIntervSelect">Récupère la chaine entrée par l'utilisateur comportant le nom de l'intervenant dont il faut récupérer l'identifiant</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static int RetrouvIdIntervenant(string nomIntervSelect)
        {
            try
            {
                int idRecupereInterv = IntervenantDivers.RecupIdIntervenant(nomIntervSelect);
                return idRecupereInterv;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'intervenant");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés à l'intervenant sélectionné
        /// </summary>
        /// <param name="chaineIntervEntr">Récupère la chaine entrée par l'utilisateur en lien avec un intervenant</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssocInterv(string chaineIntervEntr)
        {
            try
            {
                return IntervenantDivers.RecupOeuvreAssocInterv(chaineIntervEntr);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à un intervenant");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des intervenants ayant participés à la sortie du livre
        /// </summary>
        /// <param name="chaineIsbn">Récupère le numéro d'ISBN du livre</param>
        /// <returns>Retourne une ArrayList avec les noms de tous les intervenants</returns>
        /// <exception cref="">Renvoie une erreur si la liste n'a pas pu être récupérée</exception>
        public static ArrayList RecupIntervLivre(string chaineIsbn)
        {
            try
            {
                return IntervenantDivers.RecupIntervenantLivre(chaineIsbn);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des intervenants associés au livre.");
            }
        }
    }
}
