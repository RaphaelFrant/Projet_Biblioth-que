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
    /// Controlleur pour les objets en lien avec la classe GenreLittéraire
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 13, le 16/01/2020
    /// Implémentation de la méthode de récupération des oeuvres en lien avec le genre choiis par l'utilisateur</remarks>
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

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés au genre littéraire sélectionné
        /// </summary>
        /// <param name="numGenreChoisi">Récupère l'identifiant du genre sélectionné</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssoc(int numGenreChoisi)
        {
            try
            {
                return GenreLitteraire.RecupOeuvreAssoc(numGenreChoisi);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés ");
            }
        }
    }
}
