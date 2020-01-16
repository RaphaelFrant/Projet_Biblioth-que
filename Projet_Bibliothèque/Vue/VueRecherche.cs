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
    /// Vue de Recherche
    /// 
    /// Cette vue permet à l'utilisateur d'effectuer une recherche dans sa base de données en fonction des informations qu'il a entré 
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 13, le 16/01/2020
    /// Implémentation de la méthode de recherche des livres correspondant à un genre littéraire</remarks>
    public partial class VueRecherche : Form
    {
        public VueRecherche()
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

        //Bouton permettant de lancer la recherche des éléments en lien avec la recherche
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string sujetChoisi = cmboxChoixRubrique.Text;
            if(sujetChoisi == "Genre_Litteraire")
            {
                int numGenreRecherche = ControlGenreLitteraire.TrouvGenre(txtContRecherche.Text);
                dtGridRecherche.ColumnCount = 2;
                dtGridRecherche.Columns[0].Name = "ISBN";
                dtGridRecherche.Columns[1].Name = "Titre du livre";
                ArrayList listeOeuvreGenre = new ArrayList();
                listeOeuvreGenre = ControlGenreLitteraire.TrouvOeuvreAssoc(numGenreRecherche);
                for (int cursGenre = 0; cursGenre < listeOeuvreGenre.Count; cursGenre++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvreGenre[cursGenre], listeOeuvreGenre[cursGenre + 1]);
                    cursGenre += 1;
                }
            }
        }
    }
}
