using Projet_Bibliothèque.Modèle;
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
    /// Vue Nouveauté
    /// 
    /// cette vue permet d'afficher les livres les plus récemment achetés
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 18, le 30/01/2020
    /// Implémentation de la méthode de recherche des livres les plus récemment acquis</remarks>
    public partial class VueNouveaute : Form
    {
        public VueNouveaute()
        {
            InitializeComponent();
            ArrayList listeNouv = Livre.RecupererNouveaute();
            dtGridViewNouveaute.ColumnCount = 7;
            dtGridViewNouveaute.Columns[0].Name = "ISBN";
            dtGridViewNouveaute.Columns[1].Name = "Titre du livre";
            dtGridViewNouveaute.Columns[2].Name = "Auteur";
            dtGridViewNouveaute.Columns[3].Name = "Date de création";
            dtGridViewNouveaute.Columns[4].Name = "Editeur";
            dtGridViewNouveaute.Columns[5].Name = "Imprimeur";
            dtGridViewNouveaute.Columns[6].Name = "Date Achat";
            for (int cursNouv = 0; cursNouv < listeNouv.Count; cursNouv++)
            {
                dtGridViewNouveaute.Rows.Add(listeNouv[cursNouv], listeNouv[cursNouv + 1], listeNouv[cursNouv + 2], listeNouv[cursNouv + 3],
                    listeNouv[cursNouv + 4], listeNouv[cursNouv + 5], listeNouv[cursNouv + 6]);
                cursNouv += 6;
            }
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }
    }
}
