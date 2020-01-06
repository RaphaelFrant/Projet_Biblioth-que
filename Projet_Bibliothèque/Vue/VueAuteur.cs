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
    public partial class VueAuteur : Form
    {
        Auteur nouvAut = new Auteur();
        Pays nouvPays = new Pays();

        public VueAuteur()
        {
            InitializeComponent();
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'ajouter un auteur dans la base de données
        private void btnCreaAut_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioCreaAut.Text);
                Auteur nouvAuteur = new Auteur(numeroPays, txtNomCreaAut.Text, txtPrenomCreaAut.Text, txtSurnomCreaAut.Text, DateTime.Parse(txtDateNaiCreaAut.Text),
                    txtDateMortCreaAut.Text);
                Auteur.InsertAuteur(nouvAuteur);
                MessageBox.Show("Le nouvelle auteur a bien été créé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
