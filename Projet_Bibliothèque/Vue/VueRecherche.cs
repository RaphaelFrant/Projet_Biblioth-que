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
    /// <remarks>Auteur Raphaël Frantzen, Version 14, le 22/01/2020
    /// Implémentation de la méthode de suppression d'un livre</remarks>
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
            //Définition de la taille de la datagrid
            dtGridRecherche.ColumnCount = 6;
            dtGridRecherche.Columns[0].Name = "ISBN";
            dtGridRecherche.Columns[1].Name = "Titre du livre";
            dtGridRecherche.Columns[2].Name = "Auteur";
            dtGridRecherche.Columns[3].Name = "Date de création";
            dtGridRecherche.Columns[4].Name = "Editeur";
            dtGridRecherche.Columns[5].Name = "Imprimeur";

            //Modification de la recherche en fonction du thème
            string sujetChoisi = cmboxChoixRubrique.Text;
            if(sujetChoisi == "Genre_Litteraire")
            {
                int numGenreRecherche = ControlGenreLitteraire.TrouvGenre(txtContRecherche.Text);
                ArrayList listeOeuvreGenre = new ArrayList();
                listeOeuvreGenre = ControlGenreLitteraire.TrouvOeuvreAssoc(numGenreRecherche);
                for (int cursGenre = 0; cursGenre < listeOeuvreGenre.Count; cursGenre++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvreGenre[cursGenre], listeOeuvreGenre[cursGenre + 1], listeOeuvreGenre[cursGenre + 2], listeOeuvreGenre[cursGenre + 3],
                        listeOeuvreGenre[cursGenre + 4], listeOeuvreGenre[cursGenre + 5]);
                    cursGenre += 5;
                }
            }
            dtGridRecherche.AutoResizeColumns();
        }

        //Bouton permettant de supprimer un livre en fonction de la ligne sélectionné
        private void btnSupprimerLivre_Click(object sender, EventArgs e)
        {
            int LigneSelectionnee = dtGridRecherche.CurrentCell.RowIndex;
            string isbnRecup = dtGridRecherche.Rows[LigneSelectionnee].Cells[0].Value.ToString();
            ControlLivre.SupprLivre(isbnRecup);
            MessageBox.Show("Le livre intitulé '" + dtGridRecherche.Rows[LigneSelectionnee].Cells[1].Value.ToString() + "' a bien été supprimé.");
        }
    }
}
