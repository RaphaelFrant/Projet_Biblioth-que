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

        private void btnCreaLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueCreationLivre creaLivre = new VueCreationLivre();
            creaLivre.Show();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueRecherche pageRecherche = new VueRecherche();
            pageRecherche.Show();
        }

        private void btnAuteur_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueAuteur pageGestAut = new VueAuteur();
            pageGestAut.Show();
        }

        private void btnEditeur_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueEditeur pageGestEdit = new VueEditeur();
            pageGestEdit.Show();
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueImprimeur pageGestImpr = new VueImprimeur();
            pageGestImpr.Show();
        }

        private void btnInterv_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueIntervenantDivers pageGestInterv = new VueIntervenantDivers();
            pageGestInterv.Show();
        }

        private void btnModifLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueChoixLivre pageChoixModifLivre = new VueChoixLivre();
            pageChoixModifLivre.Show();
        }

        private void btnAffLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueChoixLivre pageChoixAffLivre = new VueChoixLivre();
            pageChoixAffLivre.Show();
        }

        private void btnSupprLivre_Click(object sender, EventArgs e)
        {
            this.Hide();
            VueChoixLivre pageChoixSupprLivre = new VueChoixLivre();
            pageChoixSupprLivre.Show();
        }
    }
}
