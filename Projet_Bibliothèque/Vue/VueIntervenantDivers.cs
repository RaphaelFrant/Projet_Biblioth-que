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
    /// Vue permettant de gérer les intervenants
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 5, le 08/01/2020
    /// Implémentation du bouton de création, modification et de suppression d'un nouvel intervenant</remarks>
    public partial class VueIntervenantDivers : Form
    {
        IntervenantDivers nouvInterv = new IntervenantDivers();
        Pays nouvPays = new Pays();
        Fonction nouvFonct = new Fonction();

        public VueIntervenantDivers()
        {
            InitializeComponent();
            cmboxChoixModifInterv.DataSource = IntervenantDivers.ListeIntervExist();
            ViderChampsInterv(false);
            cmboxChoixModifInterv.SelectedIndex = -1;
            cmboxChoixSupprInterv.DataSource = IntervenantDivers.ListeIntervExist();
            cmboxChoixSupprInterv.SelectedIndex = -1;
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'ajouter un nouvel intervenant à la base de données
        private void btnAjoutCreaInterv_Click(object sender, EventArgs e)
        {
            try
            {
                string nomFonctionMod = txtFoncCreaInterv.Text;
                int numFonction = nouvFonct.TrouvNumFonction(nomFonctionMod);
                int numeroPays = nouvPays.TrouvNumPays(txtNatioCreaInterv.Text);
                ArrayList infNouvInterv = new ArrayList();
                infNouvInterv.Add(numeroPays);
                infNouvInterv.Add(numFonction);
                infNouvInterv.Add(txtNomCreaInterv.Text);
                infNouvInterv.Add(txtPrenomCreaInterv.Text);
                infNouvInterv.Add(txtSurnomCreaInterv.Text);
                infNouvInterv.Add(DateTime.Parse(txtDateNaiCreaInterv.Text));
                infNouvInterv.Add(txtDateMortCreaInterv.Text);
                ControlIntervDivers.CreerIntervenant(infNouvInterv);
                MessageBox.Show(txtNomCreaInterv.Text + " " + txtPrenomCreaInterv.Text + " a bien été créé");
                this.Hide();
                VueIntervenantDivers refreshVueInterv = new VueIntervenantDivers();
                refreshVueInterv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Evénement qui a lieu lorsque l'utilisateur sélectionne un intervenant a modifié
        private void cmboxChoixModifInterv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxChoixModifInterv.SelectedIndex != -1)
            {
                string intervChoisi = cmboxChoixModifInterv.SelectedItem.ToString();
                IntervenantDivers intervRecup = IntervenantDivers.RecupInfoInterv(intervChoisi);
                txtIdModifInterv.Text = intervRecup.idInterv.ToString();
                txtNomModifInterv.Text = intervRecup.nomInterv;
                txtPrenomModifInterv.Text = intervRecup.prenomInterv;
                txtSurnModifInterv.Text = intervRecup.surnomInterv;
                txtDateNaiModifInterv.Text = intervRecup.dateNaiInterv.ToString().Substring(0, 10);
                txtDateMortModifInterv.Text = intervRecup.dateMortInterv;
                txtNatioModifInterv.Text = Pays.TrouvNomPays(intervRecup.idPaysInterv);
                txtFoncModifInterv.Text = Fonction.TrouvNomFonction(intervRecup.idFonct);
            }
        }

        //Bouton permettant de modifier les données d'un intervenant présent dans la base de données
        private void btnModifInterv_Click(object sender, EventArgs e)
        {
            try
            {
                string nomFonctionMod = txtFoncCreaInterv.Text;
                int numFonctModif = nouvFonct.TrouvNumFonction(nomFonctionMod);
                int numeroPays = nouvPays.TrouvNumPays(txtNatioModifInterv.Text);
                ArrayList infModifInterv = new ArrayList();
                infModifInterv.Add(int.Parse(txtIdModifInterv.Text));
                infModifInterv.Add(numeroPays);
                infModifInterv.Add(numFonctModif);
                infModifInterv.Add(txtNomModifInterv.Text);
                infModifInterv.Add(txtPrenomModifInterv.Text);
                infModifInterv.Add(txtSurnModifInterv.Text);
                infModifInterv.Add(DateTime.Parse(txtDateNaiModifInterv.Text));
                infModifInterv.Add(txtDateMortModifInterv.Text);
                ControlIntervDivers.ModifIntervenant(infModifInterv);
                MessageBox.Show(cmboxChoixModifInterv.SelectedItem.ToString() + " a bien été modifié");
                this.Hide();
                VueIntervenantDivers refreshVueInterv = new VueIntervenantDivers();
                refreshVueInterv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Bouton permettant de supprimer un intervenant présent dans la base de données
        private void btnSupprInterv_Click(object sender, EventArgs e)
        {
            try
            {
                string intervSelect = cmboxChoixSupprInterv.SelectedItem.ToString();
                ControlIntervDivers.SupprInterveneur(intervSelect);
                MessageBox.Show("L'intervenant '" + intervSelect + "' a bien été supprimé.");
                this.Hide();
                VueIntervenantDivers refreshVueInterv = new VueIntervenantDivers();
                refreshVueInterv.Show();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant de vider les champs du formulaire de création après avoir enregistrer un nouvel intervenant
        /// </summary>
        private void ViderChampsInterv(bool creaFini)
        {
            try
            {
                if (creaFini is true)
                {
                    txtNomCreaInterv.Text = "";
                    txtPrenomCreaInterv.Text = "";
                    txtSurnomCreaInterv.Text = "";
                    txtDateNaiCreaInterv.Text = "";
                    txtDateMortCreaInterv.Text = "";
                    txtNatioCreaInterv.Text = "";
                    txtFoncCreaInterv.Text = "";
                }
                else
                {
                    txtIdModifInterv.Text = "";
                    txtNomModifInterv.Text = "";
                    txtPrenomModifInterv.Text = "";
                    txtSurnModifInterv.Text = "";
                    txtDateNaiModifInterv.Text = "";
                    txtDateMortModifInterv.Text = "";
                    txtNatioModifInterv.Text = "";
                    txtFoncModifInterv.Text = "";
                }
            }
            catch
            {
                throw new Exception("Impossible de vider les champs du formulaire de création.");
            }
        }
    }
}
