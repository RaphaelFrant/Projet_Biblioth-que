using Projet_Bibliothèque.Modèle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe Serie de livre
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 9, le 13/01/2020
    /// Implémentation des contrôles pour la classe SérieLivre</remarks>
    class ControlSerie
    {
        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nouvSerieCree">Récupère le nom de la série de livre indiquéee dans le champs correspondant</param>
        /// <returns>Retourne l'identifiant de la série de livre créée ou trouvée</returns>
        /// <exception cref="">Renvoie une exception si la série de livre n'a pas été trouvé ou s'il n'a pas pu être créé</exception>
        public static int TrouvSerie(string nouvSerieCree)
        {
            try
            {
                SerieLivre nouvSerie = new SerieLivre();
                nouvSerie.AccLibSerieLivre = nouvSerieCree.ToString();
                int numSerie = SerieLivre.TrouvNumSerie(nouvSerie);
                return numSerie;
            }
            catch
            {
                throw new Exception("Impossible de créer un objet SerieLivre avec les informations entrées par l'utilisateur");
            }
        }
    }
}
