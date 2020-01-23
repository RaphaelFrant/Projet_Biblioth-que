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
    /// <remarks>Auteur Raphaël Frantzen, Version 15, le 23/01/2020
    /// Implémentation de la méthode de recherche de livre en fonction de l'auteur, de l'éditeur, de l'imprimeur, de la période temporelle, du type de livre</remarks>
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
            ArrayList listeOeuvre = new ArrayList();
            if (sujetChoisi == "Genre_Litteraire")
            {
                int numGenreRecherche = ControlGenreLitteraire.TrouvGenre(txtContRecherche.Text);
                listeOeuvre = ControlGenreLitteraire.TrouvOeuvreAssoc(numGenreRecherche);
                for (int cursGenre = 0; cursGenre < listeOeuvre.Count; cursGenre++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursGenre], listeOeuvre[cursGenre + 1], listeOeuvre[cursGenre + 2], listeOeuvre[cursGenre + 3],
                        listeOeuvre[cursGenre + 4], listeOeuvre[cursGenre + 5]);
                    cursGenre += 5;
                }
            }
            else if (sujetChoisi == "Auteur")
            {
                int numAutRecherche = ControlAuteur.RecupIdAuteur(txtContRecherche.Text);
                listeOeuvre = ControlAuteur.TrouvOeuvreAssocAut(numAutRecherche);
                for (int cursAuteur = 0; cursAuteur < listeOeuvre.Count; cursAuteur++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursAuteur], listeOeuvre[cursAuteur + 1], listeOeuvre[cursAuteur + 2], listeOeuvre[cursAuteur + 3],
                        listeOeuvre[cursAuteur + 4], listeOeuvre[cursAuteur + 5]);
                    cursAuteur += 5;
                }
            }
            else if(sujetChoisi == "Editeur")
            {
                int numEditRecherche = ControlEditeur.RecupIdEditeur(txtContRecherche.Text);
                listeOeuvre = ControlEditeur.TrouvOeuvreAssocEdit(numEditRecherche);
                for (int cursEditeur = 0; cursEditeur < listeOeuvre.Count; cursEditeur++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursEditeur], listeOeuvre[cursEditeur + 1], listeOeuvre[cursEditeur + 2], listeOeuvre[cursEditeur + 3],
                        listeOeuvre[cursEditeur + 4], listeOeuvre[cursEditeur + 5]);
                    cursEditeur += 5;
                }
            }
            else if(sujetChoisi == "Imprimeur")
            {
                int numImprRecherche = ControlImprimeur.RecupIdImprimeur(txtContRecherche.Text);
                listeOeuvre = ControlImprimeur.TrouvOeuvreAssocImpr(numImprRecherche);
                for (int cursImpr = 0; cursImpr < listeOeuvre.Count; cursImpr++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursImpr], listeOeuvre[cursImpr + 1], listeOeuvre[cursImpr + 2], listeOeuvre[cursImpr + 3],
                        listeOeuvre[cursImpr + 4], listeOeuvre[cursImpr + 5]);
                    cursImpr += 5;
                }
            }
            else if(sujetChoisi == "Intervenant_Divers")
            {
                int numIntervRecherche = ControlIntervDivers.RetrouvIdIntervenant(txtContRecherche.Text);
                listeOeuvre = ControlIntervDivers.TrouvOeuvreAssocInterv(numIntervRecherche);
                for (int cursInterv = 0; cursInterv < listeOeuvre.Count; cursInterv++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursInterv], listeOeuvre[cursInterv + 1], listeOeuvre[cursInterv + 2], listeOeuvre[cursInterv + 3],
                        listeOeuvre[cursInterv + 4], listeOeuvre[cursInterv + 5]);
                    cursInterv += 5;
                }
            }
            else if(sujetChoisi == "Periode_Temporelle")
            {
                int numPeriodRecherche = ControlPeriodeTempo.RecupIdPeriodTemp(txtContRecherche.Text);
                listeOeuvre = ControlPeriodeTempo.TrouvOeuvreAssocPerioTemp(numPeriodRecherche);
                for (int cursPeriod = 0; cursPeriod < listeOeuvre.Count; cursPeriod++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursPeriod], listeOeuvre[cursPeriod + 1], listeOeuvre[cursPeriod + 2], listeOeuvre[cursPeriod + 3],
                        listeOeuvre[cursPeriod + 4], listeOeuvre[cursPeriod + 5]);
                    cursPeriod += 5;
                }
            }
            else if(sujetChoisi == "Type_de_livre")
            {
                int numTypeLivRecherche = ControlTypeLivre.RecupIdTypeLivre(txtContRecherche.Text);
                listeOeuvre = ControlTypeLivre.TrouvOeuvreAssocTypeLivre(numTypeLivRecherche);
                for (int cursTypeLiv = 0; cursTypeLiv < listeOeuvre.Count; cursTypeLiv++)
                {
                    dtGridRecherche.Rows.Add(listeOeuvre[cursTypeLiv], listeOeuvre[cursTypeLiv + 1], listeOeuvre[cursTypeLiv + 2], listeOeuvre[cursTypeLiv + 3],
                        listeOeuvre[cursTypeLiv + 4], listeOeuvre[cursTypeLiv + 5]);
                    cursTypeLiv += 5;
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
