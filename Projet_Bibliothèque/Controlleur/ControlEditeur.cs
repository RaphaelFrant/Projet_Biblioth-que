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
    /// Controlleur pour les objets en lien avec la classe Editeur
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 4, le 08/01/2020
    /// Implémentation des contrôles pour la classe Editeur</remarks>
    class ControlEditeur
    {
        /// <summary>
        /// Méthode permettant de transformer une arraylist avec les informations du nouvel éditeur en un objet Editeur
        /// </summary>
        /// <param name="nouvInfoEdit">Récupère une ArrayList avec les informations de l'éditeur entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Editeur ne peut pas être créé</exception>
        public static void CreerEditeur(ArrayList nouvInfoEdit)
        {
            try
            {
                Editeur nouvEdit = new Editeur();
                nouvEdit.AccIdPaysEditeur = int.Parse(nouvInfoEdit[0].ToString());
                nouvEdit.AccLibEditeur = nouvInfoEdit[1].ToString();
                nouvEdit.AccDateDebEditeur = DateTime.Parse(nouvInfoEdit[2].ToString());
                nouvEdit.AccDateFinEditeur = nouvInfoEdit[3].ToString();
                nouvEdit.AccAdEditeur = nouvInfoEdit[4].ToString();
                Editeur.InsertEditeur(nouvEdit);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Editeur avec les informations entrées par l'utilisateur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que les informations modifiées sont valides avant d'être envoyé au Modèle
        /// </summary>
        /// <param name="modifInfoEdit">Récupère la liste des nouvelles informations de l'éditeur entrées par l'utilisateur</param>
        /// <exception cref="">Renvoie une erreur si l'objet Editeur ne peut pas être créé pour modification</exception>
        public static void ModifEditeur(ArrayList modifInfoEdit)
        {
            try
            {
                Editeur modifEdit = new Editeur();
                modifEdit.AccIdEditeur = int.Parse(modifInfoEdit[0].ToString());
                modifEdit.AccIdPaysEditeur = int.Parse(modifInfoEdit[1].ToString());
                modifEdit.AccLibEditeur = modifInfoEdit[2].ToString();
                modifEdit.AccDateDebEditeur = DateTime.Parse(modifInfoEdit[3].ToString());
                modifEdit.AccDateFinEditeur = modifInfoEdit[4].ToString();
                modifEdit.AccAdEditeur = modifInfoEdit[5].ToString();
                Editeur.UpdateEditeur(modifEdit);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Editeur avec les informations entrées par l'utilisateur pour modifier un éditeur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomEditeur">Récupère la chaine entrée par l'utilisateur comportant le nom de l'éditeur à supprimer</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static void SupprEditeur(string nomEditeur)
        {
            try
            {
                Editeur.DeleteEditeur(nomEditeur);
            }
            catch
            {
                throw new Exception("Impossible d'envoyer la chaine au Modèle pour supprimer l'éditeur");
            }
        }
    }
}
