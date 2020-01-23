using Projet_Bibliothèque.Modèle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe PériodeTemporelle
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction de la période temporelle</remarks>
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

        /// <summary>
        /// Méthode permettant de vérifier que la chaine entrée par l'utilisateur est valide
        /// </summary>
        /// <param name="nomPeriodSelect">Récupère la chaine entrée par l'utilisateur comportant le nom de la période temporelle dont il faut récupérer l'identifiant</param>
        /// <exception cref="">Renvoie une erreur si la chaine entrée ne correspond pas à ce qui est attendu</exception>
        public static int RecupIdPeriodTemp(string nomPeriodSelect)
        {
            try
            {
                int idRecuperePeriod = PeriodeTemporelle.RecupIdPeriodTemp(nomPeriodSelect);
                return idRecuperePeriod;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de la période temporelle");
            }
        }

        /// <summary>
        /// Méthode permettant de récupéré la liste des oeuvres associés à la période temporelle sélectionnée
        /// </summary>
        /// <param name="numPeriodTempChoisi">Récupère l'identifiant de la période temporelle sélectionnée</param>
        /// <returns>Retourne une ArrayList avec les informations du livre</returns>
        /// <exception cref="">Renvoie une erreur si la liste ne peut pas être récupéré</exception>
        public static ArrayList TrouvOeuvreAssocPerioTemp(int numPeriodTempChoisi)
        {
            try
            {
                return PeriodeTemporelle.RecupOeuvreAssocPeriodTempo(numPeriodTempChoisi);
            }
            catch
            {
                throw new Exception("Impossible de récupérer la liste des oeuvres associés à la période temporelle.");
            }
        }
    }
}