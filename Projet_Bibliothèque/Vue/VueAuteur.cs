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
            cmboxChoixSupprAut.DataSource = Auteur.ListeAuteurExist();
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
                int numeroPays = nouvPays.TrouvNumPays(txtNatioCreaAut.Text);
                Auteur nouvAuteur = new Auteur(numeroPays, txtNomCreaAut.Text, txtPrenomCreaAut.Text, txtSurnomCreaAut.Text, DateTime.Parse(txtDateNaiCreaAut.Text),
                    txtDateMortCreaAut.Text);
                Auteur.InsertAuteur(nouvAuteur);
                MessageBox.Show(txtNomCreaAut.Text + " " + txtPrenomCreaAut.Text + " a bien été créé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Evénement qui a lieu lorsque l'utilisateur sélectionne un auteur a modifié
        private void cmboxChoixModifAut_SelectedIndexChanged(object sender, EventArgs e)
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

        //BOuton permettant d'enregistrer les modifications apporté à un auteur
        private void btnModifAut_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPays = nouvPays.TrouvNumPays(txtNatioModifAut.Text);
                Auteur modifAuteur = new Auteur(int.Parse(txtIdAutModif.Text), numeroPays, txtNomModifAut.Text, txtPrenomModifAut.Text, txtSurnomModifAut.Text, 
                    DateTime.Parse(txtDateNaiModifAut.Text), txtDateMortModifAut.Text);
                Auteur.UpdateAuteur(modifAuteur);
                MessageBox.Show(cmboxChoixModifAut.SelectedItem.ToString() + " a bien été modifié");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Bouton permettant de supprimer un auteur
        private void btnSupprAut_Click(object sender, EventArgs e)
        {
            string auteurSelect = cmboxChoixSupprAut.SelectedItem.ToString();
            Auteur.DeleteAuteur(auteurSelect);
            MessageBox.Show("L'auteur '" + auteurSelect + "' a bien été supprimé.");
        }
    }
}
