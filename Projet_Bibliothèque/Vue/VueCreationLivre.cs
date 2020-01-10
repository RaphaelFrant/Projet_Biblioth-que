using Projet_Bibliothèque.Controlleur;
using Projet_Bibliothèque.Modèle;
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
    public partial class VueCreationLivre : Form
    {
        public VueCreationLivre()
        {
            InitializeComponent();
            cmbboxGenreLitt.DataSource = GenreLitteraire.RecupListeGenre();
            cmbboxGenreLitt.SelectedIndex = -1;
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'enregistrer le nouveau livre amené par l'auteur
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                string genreIndiq = cmbboxGenreLitt.Text;
                int identGenre = ControlGenreLitteraire.TrouvGenre(genreIndiq);
            }
            catch
            {
                throw new Exception("Impossible de créer un nouveau livre.");
            }
        }
    }
}
