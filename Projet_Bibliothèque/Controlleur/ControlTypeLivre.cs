using Projet_Bibliothèque.Modèle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe TypeLivre
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 9, le 13/01/2020
    /// Implémentation des contrôles pour la classe TypeLivre</remarks>
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
    }
}
