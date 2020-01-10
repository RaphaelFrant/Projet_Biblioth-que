using Projet_Bibliothèque.Modèle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe PériodeTemporelle
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 7, le 09/01/2020
    /// Implémentation des contrôles pour la classe PériodeTemporelle</remarks>
    class ControlPeriodeTempo
    {
        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nouvPeriodCree">Récupère le nom de la période temporelle indiquée dans le champs correspondant</param>
        /// <returns>Retourne l'identifiant de la période temporelle créée ou trouvée</returns>
        /// <exception cref="">Renvoie une exception si la période temporelle n'a pas été trouvé ou s'il n'a pas pu être créé</exception>
        public static int TrouvGenre(string nouvPeriodeCree)
        {
            try
            {
                PeriodeTemporelle nouvPeriode = new PeriodeTemporelle();
                nouvPeriode.AccLibPeriodTempo = nouvPeriodeCree.ToString();
                int numPeriode = PeriodeTemporelle.TrouvNumPeriode(nouvPeriode);
                return numPeriode;
            }
            catch
            {
                throw new Exception("Impossible de créer un objet PeriodeTemporelle avec les informations entrées par l'utilisateur");
            }
        }
    }
}