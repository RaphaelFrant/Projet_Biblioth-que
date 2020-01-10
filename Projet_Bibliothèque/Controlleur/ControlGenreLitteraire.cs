using Projet_Bibliothèque.Modèle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe GenreLittéraire
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 6, le 10/01/2020
    /// Implémentation des contrôles pour la classe Genre littéraire</remarks>
    class ControlGenreLitteraire
    {
        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nouvGenreCree">Récupère le nom du genre littéraire indiqué dans le champs correspondant</param>
        /// <returns>Retourne l'identifiant du genre créer ou trouver</returns>
        /// <exception cref="">Renvoie une exception si le genre n'a pas été trouvé ou s'il n'a pas pu être créé</exception>
        public static int TrouvGenre(string nouvGenreCree)
        {
            try
            {
                GenreLitteraire nouvGenre = new GenreLitteraire();
                nouvGenre.AccLibGenreLitt = nouvGenreCree.ToString();
                int numGenre = GenreLitteraire.TrouvNumGenre(nouvGenre);
                return numGenre;
            }
            catch
            {
                throw new Exception("Impossible de créer un objet GenreLittéraire avec les informations entrées par l'utilisateur");
            }
        }
    }
}
