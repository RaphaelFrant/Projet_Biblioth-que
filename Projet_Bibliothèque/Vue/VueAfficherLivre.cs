using Projet_Bibliothèque.Controlleur;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bibliothèque.Vue
{
    /// <summary>
    /// Vue d'affichage d'un livre
    /// 
    /// Cette vue permet à l'utilisateur de visualiser les informations concernant un livre en particulier
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 17, le 29/01/2020
    /// Implémentation de la méthode pour afficher un livre et ses informations</remarks>
    public partial class VueAfficherLivre : Form
    {
        public VueAfficherLivre(string codeIsbn)
        {
            InitializeComponent();
            ArrayList listeInfoLivre = RecupDonneesLivre(codeIsbn);
            ArrayList listeAut = ControlAuteur.RecupAutLivre(codeIsbn);
            ArrayList listeInterv = ControlIntervDivers.RecupIntervLivre(codeIsbn);
            string nomSerie = ControlSerie.RecupSerieAssocie(codeIsbn);
            RemplirChamp(listeInfoLivre, listeAut, listeInterv, nomSerie);
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueRecherche pageRecherche = new VueRecherche();
            pageRecherche.Show();
        }

        /// <summary>
        /// Méthode permettant de récupérer une liste des informations des données associées au livre
        /// </summary>
        /// <param name="identLivre">Récupère l'identifiant du livre, à savoir son ISBN</param>
        /// <returns>Retourne une arraylist contenant les informations du livre connus en base de données</returns>
        /// <exception cref="">Renvoie une exception si les informations du livre n'ont pas pu être récupéré</exception>
        private ArrayList RecupDonneesLivre(string identLivre)
        {
            try
            {
                ArrayList infoRecup = new ArrayList();
                infoRecup = ControlLivre.RecupInfoLivre(identLivre);
                return infoRecup;
            }
            catch
            {
                throw new Exception("Impossible de récupérer les informations du livre sélectionner");
            }
        }

        /// <summary>
        /// Méthode permettant de remplir les champs du formulaire d'affichage pour un livre sélectionné
        /// </summary>
        /// <param name="donneesLivre">Recupère la liste des informations d'un livre</param>
        /// <exception cref="">Renvoie une exception si les champs n'ont pas pu être rempli</exception>
        private void RemplirChamp(ArrayList donneesLivre, ArrayList listAutLivre, ArrayList listeIntervLivre, string libSerieLivre)
        {
            try
            {
                txtNumIsbn.Text = donneesLivre[0].ToString();
                txtTitreLivre.Text = donneesLivre[1].ToString();
                txtTitreOrigLivre.Text = donneesLivre[2].ToString();
                txtPrix.Text = donneesLivre[3].ToString();
                txtDateAcquis.Text = donneesLivre[4].ToString().Substring(0, 10);
                txtLangue.Text = donneesLivre[5].ToString();
                txtDepotLeg.Text = donneesLivre[6].ToString().Substring(0, 10);
                txtNbrePage.Text = donneesLivre[7].ToString();
                txtEtatLivre.Text = donneesLivre[8].ToString();
                txtSerieLivre.Text = libSerieLivre;
                txtGenreLitt.Text = donneesLivre[9].ToString();
                txtPeriodTempo.Text = donneesLivre[10].ToString();
                txtTypeLivre.Text = donneesLivre[11].ToString();
                txtResume.Text = donneesLivre[12].ToString();
                txtEditeur.Text = donneesLivre[13].ToString();
                txtImpr.Text = donneesLivre[14].ToString();
                for (int cursAut = 0; cursAut < listAutLivre.Count; cursAut++)
                {
                    txtAuteur.Text += listAutLivre[cursAut] + ", ";
                }
                for (int cursInterv = 0; cursInterv < listeIntervLivre.Count; cursInterv++)
                {
                    txtInterv.Text += listeIntervLivre[cursInterv] + ", ";
                }
            }
            catch
            {
                throw new Exception("Impossible de remplir les champs du formulaires.");
            }
        }
    }
}
