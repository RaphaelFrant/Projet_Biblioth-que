using System;
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
    /// Vue Accueil
    /// 
    /// Cette vue est la première que l'utilisateur voit et celle qui lui permet de s'orienter dans l'application
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 18, le 30/01/2020
    /// Implémentation de la méthode de recherche des livres les plus récemment acquis à travers le bouton "Nouveauté"</remarks>
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        //Bouton permettant d'appeler la vue pour créer un livre
        private void btnCreaLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueCreationLivre creaLivre = new VueCreationLivre();
            creaLivre.Show();
        }

        //Bouton permettant d'appeler la vue pour une recherche d'information
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueRecherche pageRecherche = new VueRecherche();
            pageRecherche.Show();
        }

        //Bouton permettant d'appeler la vue pour gérer la liste des auteurs
        private void btnAuteur_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueAuteur pageGestAut = new VueAuteur();
            pageGestAut.Show();
        }

        //Bouton permettant d'appeler la vue pour gérer la liste des éditeurs
        private void btnEditeur_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueEditeur pageGestEdit = new VueEditeur();
            pageGestEdit.Show();
        }

        //Bouton permettant d'appeler la vue pour gérer la liste des imprimeurs
        private void btnImpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueImprimeur pageGestImpr = new VueImprimeur();
            pageGestImpr.Show();
        }

        //Bouton permettant d'appeler la vue pour gérer la liste des intervenants
        private void btnInterv_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueIntervenantDivers pageGestInterv = new VueIntervenantDivers();
            pageGestInterv.Show();
        }

        //Bouton permettant d'appeler la vue pour modifier un livre
        private void btnModifLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueChoixLivre pageChoixModifLivre = new VueChoixLivre();
            pageChoixModifLivre.Show();
        }

        //Bouton pour fermer l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Bouton permettant d'accéder à la vue "Nouveauté" de l'application
        private void btnNouveaute_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueNouveaute pageNouveau = new VueNouveaute();
            pageNouveau.Show();
        }
    }
}
