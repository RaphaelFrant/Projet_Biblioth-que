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
    /// Controlleur pour les objets en lien avec la classe Serie de livre
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 16, le 28/01/2020
    /// mplémentation de la méthode de recherche de livre en fonction de la série de livre</remarks>
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

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomSerieSelect">Récupère la chaine entrée par l'utilisateur comportant le nom de la série de livre dont il faut récupérer l'identifiant</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static int RecupIdSerieLiv(string nomSerieSelect)
        {
            try
            {
                int idRecupereSerie = SerieLivre.RecupIdSerie(nomSerieSelect);
                return idRecupereSerie;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de la série de livre");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés à la série de livre sélectionnée
        /// </summary>
        /// <param name="numSerieChoisie">Récupère l'identifiant de la série de livre sélectionnée</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssocSerieLiv(int numSerieChoisie)
        {
            try
            {
                return SerieLivre.RecupOeuvreAssocSerie(numSerieChoisie);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à une série de livre.");
            }
        }
    }
}
