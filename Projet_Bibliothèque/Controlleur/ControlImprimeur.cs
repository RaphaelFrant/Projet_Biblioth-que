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
    /// <remarks>Auteur Raphaël Frantzen, Version 4, le 08/01/2020
    /// Implémentation des contrôles pour la classe Imprimeur</remarks>
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
    }
}
