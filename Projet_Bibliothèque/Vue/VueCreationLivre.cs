using Projet_Bibliothèque.Controlleur;
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
    /// Vue permettant de créer des livres et de modifier des livres existants
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 7, le 10/01/2020
    /// Mise en place des combox de genre littéraire, période temporelle, auteurs, éditeur, imprimeur et intervenants</remarks>
    public partial class VueCreationLivre : Form
    {
        public VueCreationLivre()
        {
            InitializeComponent();
            cmbboxGenreLitt.DataSource = GenreLitteraire.RecupListeGenre();
            cmbboxGenreLitt.SelectedIndex = -1;
            cmboxPeriodTempo.DataSource = PeriodeTemporelle.RecupListePeriode();
            cmboxPeriodTempo.SelectedIndex = -1;
            cmboxChoixEdit.DataSource = Editeur.ListeEditeurExist();
            cmboxChoixEdit.SelectedIndex = -1;
            cmboxChoixImpr.DataSource = Imprimeur.ListeImprimeurExist();
            cmboxChoixImpr.SelectedIndex = -1;
            cmboxChoixAutPrincip.DataSource = Auteur.ListeAuteurExist();
            cmboxChoixAutPrincip.SelectedIndex = -1;
            cmboxChoixAutSecond.DataSource = Auteur.ListeAuteurExist();
            cmboxChoixAutSecond.SelectedIndex = -1;
            cmboxChoixAutTiers.DataSource = Auteur.ListeAuteurExist();
            cmboxChoixAutTiers.SelectedIndex = -1;
            cmboxChoixIntervPrincip.DataSource = IntervenantDivers.ListeIntervExist();
            cmboxChoixIntervPrincip.SelectedIndex = -1;
            cmboxChoixIntervSecond.DataSource = IntervenantDivers.ListeIntervExist();
            cmboxChoixIntervSecond.SelectedIndex = -1;
            cmboxChoixIntervTiers.DataSource = IntervenantDivers.ListeIntervExist();
            cmboxChoixIntervTiers.SelectedIndex = -1;
            ViderFormulaire();
        }

        //Bouton permettant de revenir à la page d'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAcc = new Accueil();
            pageAcc.Show();
        }

        //Bouton permettant d'enregistrer le nouveau livre amené par l'auteur
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                /*string genreIndiq = cmbboxGenreLitt.Text;
                int identGenre = ControlGenreLitteraire.TrouvGenre(genreIndiq);*/
                string periodeIndiq = cmboxPeriodTempo.Text;
                int identPeriod = ControlPeriodeTempo.TrouvGenre(periodeIndiq);

                this.Hide();
                VueCreationLivre nouvPageCreaLiv = new VueCreationLivre();
                nouvPageCreaLiv.Show();
            }
            catch
            {
                throw new Exception("Impossible de créer un nouveau livre.");
            }
        }

        //Evénement qui charge les informations de l'éditeur sélectionné par l'utilisateur
        private void cmboxChoixEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmboxChoixEdit.SelectedIndex != -1)
                {
                    string nomEditChoisi = cmboxChoixEdit.SelectedItem.ToString();
                    Editeur editChoisi = Editeur.RecupInfoEditeur(nomEditChoisi);
                    txtNomEdit.Text = editChoisi.nomEditeur;
                    txtNatioEdit.Text = Pays.TrouvNomPays(editChoisi.idPaysEdit);
                    txtDateCreaEdit.Text = editChoisi.dateDebEditeur.ToString();
                    txtDateFinEdit.Text = editChoisi.dateFinEditeur;
                    txtAdressEdit.Text = editChoisi.adEditeur;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données de l'éditeur sélectionné");
            }
        }

        //Evénement qui charge les informations de l'imprimeur sélectionné par l'utilisateur
        private void cmboxChoixImpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixImpr.SelectedIndex != -1)
                {
                    string nomImprChoisi = cmboxChoixImpr.SelectedItem.ToString();
                    Imprimeur imprChoisi = Imprimeur.RecupInfoImprimeur(nomImprChoisi);
                    txtNomImpr.Text = imprChoisi.nomImprim;
                    txtNatioImpr.Text = Pays.TrouvNomPays(imprChoisi.idPaysImprim);
                    txtDateCreaImpr.Text = imprChoisi.dateDebImprim.ToString();
                    txtDateFinImpr.Text = imprChoisi.dateFinImprim;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données de l'imprimeur sélectionné");
            }
        }

        //Evénement qui charge les informations du premier auteur sélectionné par l'utilisateur
        private void cmboxChoixAutPrincip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixAutPrincip.SelectedIndex != -1)
                {
                    string nomAutPrincipChoisi = cmboxChoixAutPrincip.SelectedItem.ToString();
                    Auteur autPrincipChoisi = Auteur.RecupInfoAuteur(nomAutPrincipChoisi);
                    txtNomAutPrincip.Text = autPrincipChoisi.nomAut;
                    txtPrenomAutPrincip.Text = autPrincipChoisi.prenomAut;
                    txtSurnAutPrincip.Text = autPrincipChoisi.surnomAut;
                    txtNatioAutPrincip.Text = Pays.TrouvNomPays(autPrincipChoisi.idPaysAut);
                    txtDateNaitAutPrincip.Text = autPrincipChoisi.dateNaiAut.ToString();
                    txtDateMortAutPrincip.Text = autPrincipChoisi.dateMortAut;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du premier auteur sélectionné");
            }
        }

        //Evénement qui charge les informations du deuxième auteur sélectionné par l'utilisateur
        private void cmboxChoixAutSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixAutSecond.SelectedIndex != -1)
                {
                    string nomAutSecondChoisi = cmboxChoixAutSecond.SelectedItem.ToString();
                    Auteur autSecondChoisi = Auteur.RecupInfoAuteur(nomAutSecondChoisi);
                    txtNomAutSecond.Text = autSecondChoisi.nomAut;
                    txtPrenomAutSecond.Text = autSecondChoisi.prenomAut;
                    txtSurnAutSecond.Text = autSecondChoisi.surnomAut;
                    txtNatioAutSecond.Text = Pays.TrouvNomPays(autSecondChoisi.idPaysAut);
                    txtDateNaiAutSecond.Text = autSecondChoisi.dateNaiAut.ToString();
                    txtDateMortAutSecond.Text = autSecondChoisi.dateMortAut;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du second auteur sélectionné");
            }
        }

        //Evénement qui charge les informations du troisième auteur sélectionné par l'utilisateur
        private void cmboxChoixAutTiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixAutTiers.SelectedIndex != -1)
                {
                    string nomAutTiersChoisi = cmboxChoixAutTiers.SelectedItem.ToString();
                    Auteur autTiersChoisi = Auteur.RecupInfoAuteur(nomAutTiersChoisi);
                    txtNomAutTiers.Text = autTiersChoisi.nomAut;
                    txtPrenomAutTiers.Text = autTiersChoisi.prenomAut;
                    txtSurnAutTiers.Text = autTiersChoisi.surnomAut;
                    txtNatioAutTiers.Text = Pays.TrouvNomPays(autTiersChoisi.idPaysAut);
                    txtDateNaiAutTiers.Text = autTiersChoisi.dateNaiAut.ToString();
                    txtDateMortAutTiers.Text = autTiersChoisi.dateMortAut;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du troisième auteur sélectionné");
            }
        }

        //Evénement qui charge les informations du premier intervenant sélectionné par l'utilisateur
        private void cmboxChoixIntervPrincip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixIntervPrincip.SelectedIndex != -1)
                {
                    string nomIntervPrincipChoisi = cmboxChoixIntervPrincip.SelectedItem.ToString();
                    IntervenantDivers intervPrincipChoisi = IntervenantDivers.RecupInfoInterv(nomIntervPrincipChoisi);
                    txtNomIntervPrincip.Text = intervPrincipChoisi.nomInterv;
                    txtPrenomIntervPrincip.Text = intervPrincipChoisi.prenomInterv;
                    txtSurnIntervPrincip.Text = intervPrincipChoisi.surnomInterv;
                    txtNatioIntervPrincip.Text = Pays.TrouvNomPays(intervPrincipChoisi.idPaysInterv);
                    txtDateNaiIntervPrincip.Text = intervPrincipChoisi.dateNaiInterv.ToString();
                    txtDateMortIntervPrincip.Text = intervPrincipChoisi.dateMortInterv;
                }

            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du premier intervenant sélectionné");
            }
        }

        //Evénement qui charge les informations du deuxième intervenant sélectionné par l'utilisateur
        private void cmboxChoixIntervSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixIntervSecond.SelectedIndex != -1)
                {
                    string nomIntervSecondChoisi = cmboxChoixIntervSecond.SelectedItem.ToString();
                    IntervenantDivers intervSecondChoisi = IntervenantDivers.RecupInfoInterv(nomIntervSecondChoisi);
                    txtNomIntervSecond.Text = intervSecondChoisi.nomInterv;
                    txtPrenomIntervSecond.Text = intervSecondChoisi.prenomInterv;
                    txtSurnIntervSecond.Text = intervSecondChoisi.surnomInterv;
                    txtNatioIntervSecond.Text = Pays.TrouvNomPays(intervSecondChoisi.idPaysInterv);
                    txtDateNaiIntervSecond.Text = intervSecondChoisi.dateNaiInterv.ToString();
                    txtDateMortIntervSecond.Text = intervSecondChoisi.dateMortInterv;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du deuxième intervenant sélectionné");
            }
        }

        //Evénement qui charge les informations du troisième intervenant sélectionné par l'utilisateur
        private void cmboxChoixIntervTiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboxChoixIntervTiers.SelectedIndex != -1)
                {
                    string nomIntervTiersChoisi = cmboxChoixIntervTiers.SelectedItem.ToString();
                    IntervenantDivers intervTiersChoisi = IntervenantDivers.RecupInfoInterv(nomIntervTiersChoisi);
                    txtNomIntervTiers.Text = intervTiersChoisi.nomInterv;
                    txtPrenomIntervTiers.Text = intervTiersChoisi.prenomInterv;
                    txtSurnIntervTiers.Text = intervTiersChoisi.surnomInterv;
                    txtNatioIntervTiers.Text = Pays.TrouvNomPays(intervTiersChoisi.idPaysInterv);
                    txtDateNaiIntervTiers.Text = intervTiersChoisi.dateNaiInterv.ToString();
                    txtDateMortIntervTiers.Text = intervTiersChoisi.dateMortInterv;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du troisième intervenant sélectionné");
            }
        }

        /// <summary>
        /// Méthode permettant de vider l'ensemble des champs du formulaire
        /// </summary>
        private void ViderFormulaire()
        {
            try
            {
                txtNomEdit.Text = "";
                txtNatioEdit.Text = "";
                txtDateCreaEdit.Text = "";
                txtDateFinEdit.Text = "";
                txtAdressEdit.Text = "";
                txtNomImpr.Text = "";
                txtNatioImpr.Text = "";
                txtDateCreaImpr.Text = "";
                txtDateFinImpr.Text = "";
                txtNomAutPrincip.Text = "";
                txtPrenomAutPrincip.Text = "";
                txtSurnAutPrincip.Text = "";
                txtNatioAutPrincip.Text = "";
                txtDateNaitAutPrincip.Text = "";
                txtDateMortAutPrincip.Text = "";
                txtNomAutSecond.Text = "";
                txtPrenomAutSecond.Text = "";
                txtSurnAutSecond.Text = "";
                txtNatioAutSecond.Text = "";
                txtDateNaiAutSecond.Text = "";
                txtDateMortAutSecond.Text = "";
                txtNomAutTiers.Text = "";
                txtPrenomAutTiers.Text = "";
                txtSurnAutTiers.Text = "";
                txtNatioAutTiers.Text = "";
                txtDateNaiAutTiers.Text = "";
                txtDateMortAutTiers.Text = "";
                txtNomIntervPrincip.Text = "";
                txtPrenomIntervPrincip.Text = "";
                txtSurnIntervPrincip.Text = "";
                txtNatioIntervPrincip.Text = "";
                txtDateNaiIntervPrincip.Text = "";
                txtDateMortIntervPrincip.Text = "";
                txtNomIntervSecond.Text = "";
                txtPrenomIntervSecond.Text = "";
                txtSurnIntervSecond.Text = "";
                txtNatioIntervSecond.Text = "";
                txtDateNaiIntervSecond.Text = "";
                txtDateMortIntervSecond.Text = "";
                txtNomIntervTiers.Text = "";
                txtPrenomIntervTiers.Text = "";
                txtSurnIntervTiers.Text = "";
                txtNatioIntervTiers.Text = "";
                txtDateNaiIntervTiers.Text = "";
                txtDateMortIntervTiers.Text = "";
            }
            catch
            {
                throw new Exception("Impossible de vider les champs des formulaires.");
            }
        }
    }
}
