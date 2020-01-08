using Projet_Bibliothèque.Controlleur;
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
    /// Vue permettant de gérer les imprimeurs
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 4, le 08/01/2020
    /// Implémentation du bouton de création, modification et de suppression d'un nouvel imprimeur</remarks>
    public partial class VueImprimeur : Form
    {
        Imprimeur nouvImpr = new Imprimeur();
        Pays nouvPays = new Pays();

        public VueImprimeur()
        {
            InitializeComponent();
            cmbBoxChoixModifImpr.DataSource = Imprimeur.ListeImprimeurExist();
            ViderChampsImpr(false);
            cmbBoxChoixModifImpr.SelectedIndex = -1;
            cmbBoxChoixSupprImpr.DataSource = Imprimeur.ListeImprimeurExist();
            cmbBoxChoixSupprImpr.SelectedIndex = -1;
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'ajouter un nouvel imprimeur à la base de données
        private void btnAjoutImpr_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioCreaImpr.Text);
                ArrayList infNouvImpr = new ArrayList();
                infNouvImpr.Add(numeroPays);
                infNouvImpr.Add(txtNomNouvImpr.Text);
                infNouvImpr.Add(DateTime.Parse(txtDateDebNouvImpr.Text));
                infNouvImpr.Add(txtDateFinNouvImpr.Text);
                ControlImprimeur.CreerImprimeur(infNouvImpr);
                MessageBox.Show(txtNomNouvImpr.Text + " a bien été créé");
                this.Hide();
                VueImprimeur refreshVueImpr = new VueImprimeur();
                refreshVueImpr.Show();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel imprimeur.");
            }
        }

        //Evénement qui se déclenche lorsque l'utilisateur choisi un imprimeur à modifier dans la combobox correspondante
        private void cmbBoxChoixModifImpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxChoixModifImpr.SelectedIndex != -1)
            {
                string imprimeurChoisi = cmbBoxChoixModifImpr.SelectedItem.ToString();
                Imprimeur imprRecup = Imprimeur.RecupInfoImprimeur(imprimeurChoisi);
                txtIdModifImpr.Text = imprRecup.idImprim.ToString();
                txtNomModifImpr.Text = imprRecup.nomImprim;
                txtDateDebModifImpr.Text = imprRecup.dateDebImprim.ToString().Substring(0, 10);
                txtDateFinModifImpr.Text = imprRecup.dateFinImprim;
                txtNatioModifImpr.Text = Pays.TrouvNomPays(imprRecup.idPaysImprim);
            }
        }

        //Bouton permettant de modifier les informations d'un nouvel imprimeur à la base de données
        private void btnModifImpr_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioModifImpr.Text);
                ArrayList infoModifImprimeur = new ArrayList();
                infoModifImprimeur.Add(int.Parse(txtIdModifImpr.Text));
                infoModifImprimeur.Add(numeroPays);
                infoModifImprimeur.Add(txtNomModifImpr.Text);
                infoModifImprimeur.Add(DateTime.Parse(txtDateDebModifImpr.Text));
                infoModifImprimeur.Add(txtDateFinModifImpr.Text);
                ControlImprimeur.ModifImprimeur(infoModifImprimeur);
                MessageBox.Show(cmbBoxChoixModifImpr.SelectedItem.ToString() + " a bien été modifié");
                this.Hide();
                VueImprimeur refreshVueImpr = new VueImprimeur();
                refreshVueImpr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Bouton permettant de supprimer un imprimeur à la base de données
        private void btnSupprImpr_Click(object sender, EventArgs e)
        {
            try
            {
                string imprimeurSelect = cmbBoxChoixSupprImpr.SelectedItem.ToString();
                ControlImprimeur.SupprImprimeur(imprimeurSelect);
                MessageBox.Show("L'imprimeur '" + imprimeurSelect + "' a bien été supprimé.");
                this.Hide();
                VueImprimeur refreshVueImpr = new VueImprimeur();
                refreshVueImpr.Show();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un imprimeur.");
            }
        }

        /// <summary>
        /// Méthode permettant de vider les champs du formulaire de création après avoir enregistrer un nouvel imprimeur
        /// </summary>
        private void ViderChampsImpr(bool creaFini)
        {
            try
            {
                if (creaFini is true)
                {
                    txtNomNouvImpr.Text = "";
                    txtDateDebNouvImpr.Text = "";
                    txtDateFinNouvImpr.Text = "";
                    txtNatioCreaImpr.Text = "";
                }
                else
                {
                    txtIdModifImpr.Text = "";
                    txtNomModifImpr.Text = "";
                    txtDateDebModifImpr.Text = "";
                    txtDateFinModifImpr.Text = "";
                    txtNatioModifImpr.Text = "";
                }
            }
            catch
            {
                throw new Exception("Impossible de vider les champs du formulaire.");
            }
        }
    }
}
