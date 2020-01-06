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
                int numeroPays = TrouvNumPays(txtNatioCreaAut.ToString());
                Auteur nouvAuteur = new Auteur(numeroPays, txtNomCreaAut.ToString(), txtPrenomCreaAut.ToString(), txtSurnomCreaAut.ToString(), 
                    DateTime.Parse(txtDateNaiCreaAut.ToString()), DateTime.Parse(txtDateMortCreaAut.ToString()));
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel auteur.");
            }
            
        }
    }
}
