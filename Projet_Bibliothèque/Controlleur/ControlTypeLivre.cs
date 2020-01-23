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
    /// Controlleur pour les objets en lien avec la classe TypeLivre
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction du type de livre</remarks>
    class ControlTypeLivre
    {
        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nouvTypeLivCree">Récupère le nom du type de livre indiquéee dans le champs correspondant</param>
        /// <returns>Retourne l'identifiant du type de livre créée ou trouvée</returns>
        /// <exception cref="">Renvoie une exception si le type de livre n'a pas été trouvé ou s'il n'a pas pu être créé</exception>
        public static int TrouvTypeLiv(string nouvTypeLivCree)
        {
            try
            {
                TypeLivre nouvTypeLiv = new TypeLivre();
                nouvTypeLiv.AccLibTypeLivre = nouvTypeLivCree.ToString();
                int numTypeLiv = TypeLivre.TrouvNumTypeLivre(nouvTypeLiv);
                return numTypeLiv;
            }
            catch
            {
                throw new Exception("Impossible de créer un objet SerieLivre avec les informations entrées par l'utilisateur");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomTypeLivSelect">Récupère la chaine entrée par l'utilisateur comportant le libellé du type de livre dont il faut récupérer l'identifiant</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static int RecupIdTypeLivre(string nomTypeLivSelect)
        {
            try
            {
                int idRecupereTypeLiv = TypeLivre.RecupIdTypeLivre(nomTypeLivSelect);
                return idRecupereTypeLiv;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant du type de livre.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés au type de livre sélectionné
        /// </summary>
        /// <param name="numTypeLivChoisi">Récupère l'identifiant du type de livre sélectionné</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssocTypeLivre(int numTypeLivChoisi)
        {
            try
            {
                return TypeLivre.RecupOeuvreAssocTypeLivre(numTypeLivChoisi);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés au type de livre indiqué");
            }
        }
    }
}
