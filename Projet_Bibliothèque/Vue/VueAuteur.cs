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
    /// Vue permettant de gérer les auteurs
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 2, le 07/01/2020
    /// Implémentation du bouton de création, modification et de suppression d'un nouvel auteur</remarks>
    public partial class VueAuteur : Form
    {
        Auteur nouvAut = new Auteur();
        Pays nouvPays = new Pays();

        public VueAuteur()
        {
            InitializeComponent();
            cmboxChoixModifAut.DataSource = Auteur.ListeAuteurExist();
            ViderChamps(false);
            cmboxChoixModifAut.SelectedIndex = -1;
            cmboxChoixSupprAut.DataSource = Auteur.ListeAuteurExist();
            cmboxChoixSupprAut.SelectedIndex = -1;
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'ajouter un auteur dans la base de données par le biais d'une ArrayList
        private void btnCreaAut_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioCreaAut.Text);
                ArrayList infNouvAut = new ArrayList();
                infNouvAut.Add(numeroPays);
                infNouvAut.Add(txtNomCreaAut.Text);
                infNouvAut.Add(txtPrenomCreaAut.Text);
                infNouvAut.Add(txtSurnomCreaAut.Text);
                infNouvAut.Add(DateTime.Parse(txtDateNaiCreaAut.Text));
                infNouvAut.Add(txtDateMortCreaAut.Text);
                ControlAuteur.CreerAuteur(infNouvAut);
                MessageBox.Show(txtNomCreaAut.Text + " " + txtPrenomCreaAut.Text + " a bien été créé");
                this.Hide();
                VueAuteur refreshVueAut = new VueAuteur();
                refreshVueAut.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Evénement qui a lieu lorsque l'utilisateur sélectionne un auteur a modifié
        private void cmboxChoixModifAut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboxChoixModifAut.SelectedIndex != -1)
            {
                string auteurChoisi = cmboxChoixModifAut.SelectedItem.ToString();
                Auteur autRecup = Auteur.RecupInfoAuteur(auteurChoisi);
                txtIdAutModif.Text = autRecup.idAut.ToString();
                txtNomModifAut.Text = autRecup.nomAut;
                txtPrenomModifAut.Text = autRecup.prenomAut;
                txtSurnomModifAut.Text = autRecup.surnomAut;
                txtDateNaiModifAut.Text = autRecup.dateNaiAut.ToString().Substring(0, 10);
                txtDateMortModifAut.Text = autRecup.dateMortAut;
                txtNatioModifAut.Text = Pays.TrouvNomPays(autRecup.idPaysAut);
            }
        }

        //BOuton permettant d'enregistrer les modifications apporté à un auteur
        private void btnModifAut_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioModifAut.Text);
                ArrayList infModifAut = new ArrayList();
                infModifAut.Add(int.Parse(txtIdAutModif.Text));
                infModifAut.Add(numeroPays);
                infModifAut.Add(txtNomModifAut.Text);
                infModifAut.Add(txtPrenomModifAut.Text);
                infModifAut.Add(txtSurnomModifAut.Text);
                infModifAut.Add(DateTime.Parse(txtDateNaiModifAut.Text));
                infModifAut.Add(txtDateMortModifAut.Text);
                ControlAuteur.ModifAuteur(infModifAut);
                MessageBox.Show(cmboxChoixModifAut.SelectedItem.ToString() + " a bien été modifié");
                this.Hide();
                VueAuteur refreshVueAut = new VueAuteur();
                refreshVueAut.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Bouton permettant de supprimer un auteur
        private void btnSupprAut_Click(object sender, EventArgs e)
        {
            try
            {
                string auteurSelect = cmboxChoixSupprAut.SelectedItem.ToString();
                ControlAuteur.SupprAuteur(auteurSelect);
                MessageBox.Show("L'auteur '" + auteurSelect + "' a bien été supprimé.");
                this.Hide();
                VueAuteur refreshVueAut = new VueAuteur();
                refreshVueAut.Show();
            }
            catch
            {
                throw new Exception("Impossible de supprimer un auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant de vider les champs du formulaire de création après avoir enregistrer un nouvel auteur
        /// </summary>
        private void ViderChamps(bool creaFini)
        {
            try
            {
                if(creaFini is true)
                {
                    txtNomCreaAut.Text = "";
                    txtPrenomCreaAut.Text = "";
                    txtSurnomCreaAut.Text = "";
                    txtDateNaiCreaAut.Text = "";
                    txtDateMortCreaAut.Text = "";
                    txtNatioCreaAut.Text = "";
                }
                else
                {
                    txtIdAutModif.Text = "";
                    txtNomModifAut.Text = "";
                    txtPrenomModifAut.Text = "";
                    txtSurnomModifAut.Text = "";
                    txtDateNaiModifAut.Text = "";
                    txtDateMortModifAut.Text = "";
                    txtNatioModifAut.Text = "";
                }
            }
            catch
            {
                throw new Exception("Impossible de vider les champs du formulaire de création.");
            }
        }
    }
}
