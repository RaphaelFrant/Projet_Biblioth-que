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
    /// Controlleur pour les objets en lien avec la classe Imprimeur
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction de l'imprimeur</remarks>
    class ControlImprimeur
    {
        /// <summary>
        /// Méthode permettant de transformer une arraylist avec les informations du nouvel imprimeur en un objet Imprimeur
        /// </summary>
        /// <param name="nouvInfoImpr">Récupère une ArrayList avec les informations de l'imprimeur entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Imprimeur ne peut pas être créé</exception>
        public static void CreerImprimeur(ArrayList nouvInfoImpr)
        {
            try
            {
                Imprimeur nouvImpr = new Imprimeur();
                nouvImpr.AccIdPaysImprim = int.Parse(nouvInfoImpr[0].ToString());
                nouvImpr.AccLibImprim = nouvInfoImpr[1].ToString();
                nouvImpr.AccDateDebImprim = DateTime.Parse(nouvInfoImpr[2].ToString());
                nouvImpr.AccDateFinImprim = nouvInfoImpr[3].ToString();
                Imprimeur.InsertImprimeur(nouvImpr);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Imprimeur avec les informations entrées par l'utilisateur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que les informations modifiées sont valides avant d'être envoyé au Modèle Imprimeur
        /// </summary>
        /// <param name="modifInfoImpr">Récupère la liste des nouvelles informations de l'imprimeur entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Imprimeur ne peut pas être créé pour modification</exception>
        public static void ModifImprimeur(ArrayList modifInfoImpr)
        {
            try
            {
                Imprimeur modifImpr = new Imprimeur();
                modifImpr.AccIdImprim = int.Parse(modifInfoImpr[0].ToString());
                modifImpr.AccIdPaysImprim = int.Parse(modifInfoImpr[1].ToString());
                modifImpr.AccLibImprim = modifInfoImpr[2].ToString();
                modifImpr.AccDateDebImprim = DateTime.Parse(modifInfoImpr[3].ToString());
                modifImpr.AccDateFinImprim = modifInfoImpr[4].ToString();
                Imprimeur.UpdateImprimeur(modifImpr);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Imprimeur avec les informations entrées par l'utilisateur pour modifier un imprimeur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomImpr">Récupère la chaine entrée par l'utilisateur comportant le nom de l'imprimeur à supprimer</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static void SupprImprimeur(string nomImpr)
        {
            try
            {
                Imprimeur.DeleteImprimeur(nomImpr);
            }
            catch
            {
                throw new Exception("Impossible d'envoyer la chaine au Modèle pour supprimer l'imprimeur");
            }
        }
        
        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomImprSelect">Récupère la chaine entrée par l'utilisateur comportant le nom de l'imprimeur dont il faut récupérer l'identifiant</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static int RecupIdImprimeur(string nomImprSelect)
        {
            try
            {
                int idRecupereImpr = Imprimeur.RecupIdImprimeur(nomImprSelect);
                return idRecupereImpr;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'imprimeur");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés à l'imprimeur sélectionné
        /// </summary>
        /// <param name="nomImprimEntr">Récupère une chaine de caractère entrée par l'utilisateur pour la recherche d'un imprimeur</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssocImpr(string nomImprimEntr)
        {
            try
            {
                return Imprimeur.RecupOeuvreAssocImprimeur(nomImprimEntr);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à l'imprimeur");
            }
        }
    }
}
