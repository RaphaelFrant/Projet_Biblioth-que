using Projet_Bibliothèque.Vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bibliothèque
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btnDebut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil nouvPageAcc = new Accueil();
            nouvPageAcc.Show();
        }
    }
}
