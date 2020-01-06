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

        //Bouton permettant d'appeler la vue pour afficher un livre
        private void btnAffLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueChoixLivre pageChoixAffLivre = new VueChoixLivre();
            pageChoixAffLivre.Show();
        }

        //Bouton permettant d'appeler la vue pour supprimer un livre
        private void btnSupprLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueChoixLivre pageChoixSupprLivre = new VueChoixLivre();
            pageChoixSupprLivre.Show();
        }

        //Bouton pour fermer l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
