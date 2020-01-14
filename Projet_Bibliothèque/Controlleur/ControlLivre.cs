﻿using Projet_Bibliothèque.Modèle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliothèque.Controlleur
{
    /// <summary>
    /// Controlleur pour les objets en lien avec la classe Livre
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 12, le 14/01/2020
    /// Implémentation du contrôle pour créer un nouveau livre</remarks>
    class ControlLivre
    {
        /// <summary>
        /// Méthode permettant de vérifier les données entrées par l'utilisateur pour créer un nouveau livre
        /// </summary>
        /// <param name="nouvInfoLiv">Récupère une ArrayList avec les informations du nouveau livre</param>
        /// <exception cref="">Renvoie une exception si le livre n'a pas pu être créé</exception>
        public static void CreerLivre(ArrayList nouvInfoLiv)
        {
            try
            {
                Livre nouvLivre = new Livre();
                nouvLivre.AccNumIsbn = nouvInfoLiv[0].ToString();
                nouvLivre.AccIdTypeLivre = int.Parse(nouvInfoLiv[1].ToString());
                nouvLivre.AccIdSerieLivre = nouvInfoLiv[2].ToString();
                nouvLivre.AccIdPeriodTempo = int.Parse(nouvInfoLiv[3].ToString());
                nouvLivre.AccIdEditeur = int.Parse(nouvInfoLiv[4].ToString());
                nouvLivre.AccIdImprim = int.Parse(nouvInfoLiv[5].ToString());
                nouvLivre.AccIdGenre = int.Parse(nouvInfoLiv[6].ToString());
                nouvLivre.AccLibLivre = nouvInfoLiv[7].ToString();
                nouvLivre.AccLibOrigLivre = nouvInfoLiv[8].ToString();
                nouvLivre.AccPrixLivre = int.Parse(nouvInfoLiv[9].ToString());
                nouvLivre.AccDateAchatLivre = DateTime.Parse(nouvInfoLiv[10].ToString());
                nouvLivre.AccLangLivre = nouvInfoLiv[11].ToString();
                nouvLivre.AccDepLegLivre = DateTime.Parse(nouvInfoLiv[12].ToString());
                nouvLivre.AccNbrePageLivre = int.Parse(nouvInfoLiv[13].ToString());
                nouvLivre.AccEtatLivre = nouvInfoLiv[14].ToString();
                nouvLivre.AccResumLivre = nouvInfoLiv[15].ToString();
                Livre.InsertLivre(nouvLivre);
            }
            catch
            {
                throw new Exception("Impossible de créer un objet Livre avec les informations entrées par l'utilisateur");
            }
        }
    }
}
