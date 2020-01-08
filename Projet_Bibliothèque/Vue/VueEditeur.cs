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
    /// Vue permettant de gérer les éditeurs
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 4, le 08/01/2020
    /// Implémentation du bouton de création, modification et de suppression d'un nouvel éditeur</remarks>
    public partial class VueEditeur : Form
    {
        Editeur nouvEdit = new Editeur();
        Pays nouvPays = new Pays();

        public VueEditeur()
        {
            InitializeComponent();
            cmboxChoixModifEdit.DataSource = Editeur.ListeEditeurExist();
            ViderChampsEdit(false);
            cmboxChoixModifEdit.SelectedIndex = -1;
            cmboxChoixSupprEdit.DataSource = Editeur.ListeEditeurExist();
            cmboxChoixSupprEdit.SelectedIndex = -1;
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'ajouter un éditeur à la base de données
        private void btnAjoutCreaEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioCreaEdit.Text);
                ArrayList infNouvEdit = new ArrayList();
                infNouvEdit.Add(numeroPays);
                infNouvEdit.Add(txtNomCreaEdit.Text);
                infNouvEdit.Add(DateTime.Parse(txtDateDebCreaEdit.Text));
                infNouvEdit.Add(txtDateFinCreaEdit.Text);
                infNouvEdit.Add(txtAdressCreaEdit.Text);
                ControlEditeur.CreerEditeur(infNouvEdit);
                MessageBox.Show(txtNomCreaEdit.Text + " a bien été créé");
                this.Hide();
                VueEditeur refreshVueEdit = new VueEditeur();
                refreshVueEdit.Show();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouvel éditeur.");
            }
        }

        //Evénement qui se déclenche lorsque l'utilisateur choisi un éditeur à modifier dans la combobox correspondante
        private void cmboxChoixModifEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxChoixModifEdit.SelectedIndex != -1)
            {
                string editeurChoisi = cmboxChoixModifEdit.SelectedItem.ToString();
                Editeur editRecup = Editeur.RecupInfoEditeur(editeurChoisi);
                txtIdModifEdit.Text = editRecup.idEditeur.ToString();
                txtNomModifEdit.Text = editRecup.nomEditeur;
                txtDateDebModifEdit.Text = editRecup.dateDebEditeur.ToString().Substring(0, 10);
                txtDateFinModifEdit.Text = editRecup.dateFinEditeur;
                txtAdModifEdit.Text = editRecup.adEditeur;
                txtNatioModifEdit.Text = Pays.TrouvNomPays(editRecup.idPaysEdit);
            }
        }

        //Bouton permettant d'éditer les informations d'un éditeur présent dans la base de données
        private void btnModifEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioModifEdit.Text);
                ArrayList infModifEditeur = new ArrayList();
                infModifEditeur.Add(int.Parse(txtIdModifEdit.Text));
                infModifEditeur.Add(numeroPays);
                infModifEditeur.Add(txtNomModifEdit.Text);
                infModifEditeur.Add(DateTime.Parse(txtDateDebModifEdit.Text));
                infModifEditeur.Add(txtDateFinModifEdit.Text);
                infModifEditeur.Add(txtAdModifEdit.Text);
                ControlEditeur.ModifEditeur(infModifEditeur);
                MessageBox.Show(cmboxChoixModifEdit.SelectedItem.ToString() + " a bien été modifié");
                this.Hide();
                VueEditeur refreshVueEdit = new VueEditeur();
                refreshVueEdit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Bouton permettant de supprimer un éditeur présent en base de données
        private void btnSupprEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string editeurrSelect = cmboxChoixSupprEdit.SelectedItem.ToString();
                ControlEditeur.SupprEditeur(editeurrSelect);
                MessageBox.Show("L'éditeur '" + editeurrSelect + "' a bien été supprimé.");
                this.Hide();
                VueEditeur refreshVueEdit = new VueEditeur();
                refreshVueEdit.Show();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un éditeur.");
            }
        }

        /// <summary>
        /// Méthode permettant de vider les champs du formulaire de création après avoir enregistrer un nouvel éditeur
        /// </summary>
        private void ViderChampsEdit(bool creaFini)
        {
            try
            {
                if (creaFini is true)
                {
                    txtNomCreaEdit.Text = "";
                    txtDateDebCreaEdit.Text = "";
                    txtDateFinCreaEdit.Text = "";
                    txtNatioCreaEdit.Text = "";
                    txtAdressCreaEdit.Text = "";
                }
                else
                {
                    txtIdModifEdit.Text = "";
                    txtNomModifEdit.Text = "";
                    txtDateDebModifEdit.Text = "";
                    txtDateFinModifEdit.Text = "";
                    txtNatioModifEdit.Text = "";
                    txtAdModifEdit.Text = "";
                }
            }
            catch
            {
                throw new Exception("Impossible de vider les champs du formulaire de création.");
            }
        }
    }
}
