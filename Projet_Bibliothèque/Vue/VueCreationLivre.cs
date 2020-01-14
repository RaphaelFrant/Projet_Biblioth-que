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
    /// Vue permettant de créer des livres et de modifier des livres existants
    /// </summary>
    /// <remarks>Auteur Raphaël Frantzen, Version 11, le 14/01/2020
    /// Création des méthodes permettant de gérer les auteurs, editeurs, imprimeurs et intervenant pour la création de livre</remarks>
    public partial class VueCreationLivre : Form
    {
        Pays nouvPays = new Pays();
        Fonction nouvFonct = new Fonction();

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

        //Bouton permettant d'enregistrer un nouveau livre entré par l'utilisateur
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                string genreIndiq = cmbboxGenreLitt.Text;
                int identGenre = ControlGenreLitteraire.TrouvGenre(genreIndiq);
                string periodeIndiq = cmboxPeriodTempo.Text;
                int identPeriod = ControlPeriodeTempo.TrouvGenre(periodeIndiq);
                string serieIndiq = txtSerieLivre.Text;
                int identSerie = 0;
                if(serieIndiq.Length != 0)
                {
                    identSerie = ControlSerie.TrouvSerie(serieIndiq);
                }
                string typeLivIndiq = txtTypeOuvr.Text;
                int identTypeLiv = ControlTypeLivre.TrouvTypeLiv(typeLivIndiq);
                int identEditeur = DesigneEditeur();
                int identImprimeur = DesigneImprimeur();

                //Création du livre
                ArrayList infoLivre = new ArrayList();
                infoLivre.Add(txtIsbnLivre.Text);
                infoLivre.Add(identTypeLiv);
                if(identSerie == 0)
                {
                    infoLivre.Add("");
                }
                else
                {
                    infoLivre.Add(identSerie);
                }
                infoLivre.Add(identPeriod);
                infoLivre.Add(identEditeur);
                infoLivre.Add(identImprimeur);
                infoLivre.Add(identGenre);
                infoLivre.Add(txtTitreLivre.Text);
                infoLivre.Add(txtTitreOrigLivre.Text);
                infoLivre.Add(int.Parse(txtPrixLivre.Text));
                infoLivre.Add(DateTime.Parse(txtDateAcquiLivre.Text));
                infoLivre.Add(txtLangLivre.Text);
                infoLivre.Add(DateTime.Parse(txtDepotLegLivre.Text));
                infoLivre.Add(int.Parse(txtNbrePageLivre.Text));
                infoLivre.Add(txtEtatLivre.Text);
                infoLivre.Add(txtResume.Text);
                ControlLivre.CreerLivre(infoLivre);

                /*ajout d'une méthode qui relie  un livre à un intervenant dans la table ModeleIntervenir*/

                //Association des auteurs à un livre
                int identAutPrincip = 0;
                if (cmboxChoixAutPrincip.Text.Length != 0 & txtNomAutPrincip.Text.Length != 0)
                {
                    identAutPrincip = DesigneAuteurExist(cmboxChoixAutPrincip.Text);
                    ModeleEcrire nouvAssocLivAut = new ModeleEcrire(identAutPrincip, txtIsbnLivre.Text);
                    ModeleEcrire.InsertEcrire(nouvAssocLivAut);
                }
                else if (cmboxChoixAutPrincip.Text.Length != 0 & txtNomAutPrincip.Text.Length != 0)
                {
                    throw new Exception("Vous n'avez pas indiqué d'auteur principal.");
                }
                else
                {
                    identAutPrincip = DesigneNouvelAuteur("principal");
                    ModeleEcrire nouvAssocLivAut = new ModeleEcrire(identAutPrincip, txtIsbnLivre.Text);
                    ModeleEcrire.InsertEcrire(nouvAssocLivAut);
                }

                int identAutSecond = 0;
                if (cmboxChoixAutSecond.Text.Length != 0 & txtNomAutSecond.Text.Length != 0)
                {
                    identAutSecond = DesigneAuteurExist(cmboxChoixAutSecond.Text);
                    ModeleEcrire nouvAssocLivAut = new ModeleEcrire(identAutSecond, txtIsbnLivre.Text);
                    ModeleEcrire.InsertEcrire(nouvAssocLivAut);
                }
                else if (cmboxChoixAutSecond.Text.Length == 0 & txtNomAutSecond.Text.Length != 0)
                {
                    identAutSecond = DesigneNouvelAuteur("second");
                    ModeleEcrire nouvAssocLivAut = new ModeleEcrire(identAutSecond, txtIsbnLivre.Text);
                    ModeleEcrire.InsertEcrire(nouvAssocLivAut);
                }

                int identAutTiers = 0;
                if (cmboxChoixAutTiers.Text.Length != 0 & txtNomAutTiers.Text.Length != 0)
                {
                    identAutTiers = DesigneAuteurExist(cmboxChoixAutTiers.Text);
                    ModeleEcrire nouvAssocLivAut = new ModeleEcrire(identAutTiers, txtIsbnLivre.Text);
                    ModeleEcrire.InsertEcrire(nouvAssocLivAut);
                }
                else if (cmboxChoixAutTiers.Text.Length == 0 & txtNomAutTiers.Text.Length != 0)
                {
                    identAutTiers = DesigneNouvelAuteur("tiers");
                    ModeleEcrire nouvAssocLivAut = new ModeleEcrire(identAutTiers, txtIsbnLivre.Text);
                    ModeleEcrire.InsertEcrire(nouvAssocLivAut);
                }

                //Association des intervenants à un livre
                int identIntervPrincip = 0;
                if (cmboxChoixIntervPrincip.Text.Length != 0 & txtNomIntervPrincip.Text.Length != 0)
                {
                    identIntervPrincip = DesigneIntervExist(cmboxChoixIntervPrincip.Text);
                    ModeleIntervenir nouvAssocIntervLiv = new ModeleIntervenir(identIntervPrincip, txtIsbnLivre.Text);
                    ModeleIntervenir.InsertIntervention(nouvAssocIntervLiv);
                }
                else if (cmboxChoixIntervPrincip.Text.Length == 0 & txtNomIntervPrincip.Text.Length != 0)
                {
                    identIntervPrincip = DesigneNouvelIntervenant("principal");
                    ModeleIntervenir nouvAssocIntervLiv = new ModeleIntervenir(identIntervPrincip, txtIsbnLivre.Text);
                    ModeleIntervenir.InsertIntervention(nouvAssocIntervLiv);
                }
                int identIntervSecond = 0;
                if (cmboxChoixIntervSecond.Text.Length != 0 & txtNomIntervSecond.Text.Length != 0)
                {
                    identIntervSecond = DesigneIntervExist(cmboxChoixIntervSecond.Text);
                    ModeleIntervenir nouvAssocIntervLiv = new ModeleIntervenir(identIntervSecond, txtIsbnLivre.Text);
                    ModeleIntervenir.InsertIntervention(nouvAssocIntervLiv);
                }
                else if (cmboxChoixIntervSecond.Text.Length == 0 & txtNomIntervSecond.Text.Length != 0)
                {
                    identIntervSecond = DesigneNouvelIntervenant("second");
                    ModeleIntervenir nouvAssocIntervLiv = new ModeleIntervenir(identIntervSecond, txtIsbnLivre.Text);
                    ModeleIntervenir.InsertIntervention(nouvAssocIntervLiv);
                }
                int identIntervTiers = 0;
                if (cmboxChoixIntervTiers.Text.Length != 0 & txtNomIntervTiers.Text.Length != 0)
                {
                    identIntervTiers = DesigneIntervExist(cmboxChoixIntervTiers.Text);
                    ModeleIntervenir nouvAssocIntervLiv = new ModeleIntervenir(identIntervTiers, txtIsbnLivre.Text);
                    ModeleIntervenir.InsertIntervention(nouvAssocIntervLiv);
                }
                else if (cmboxChoixIntervTiers.Text.Length == 0 & txtNomIntervTiers.Text.Length != 0)
                {
                    identIntervTiers = DesigneNouvelIntervenant("tiers");
                    ModeleIntervenir nouvAssocIntervLiv = new ModeleIntervenir(identIntervTiers, txtIsbnLivre.Text);
                    ModeleIntervenir.InsertIntervention(nouvAssocIntervLiv);
                }

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
                    txtDateCreaEdit.Text = editChoisi.dateDebEditeur.ToString().Substring(0, 10);
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
                    txtDateCreaImpr.Text = imprChoisi.dateDebImprim.ToString().Substring(0, 10);
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
                    txtDateNaitAutPrincip.Text = autPrincipChoisi.dateNaiAut.ToString().Substring(0, 10);
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
                    txtDateNaiAutSecond.Text = autSecondChoisi.dateNaiAut.ToString().Substring(0, 10);
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
                    txtDateNaiAutTiers.Text = autTiersChoisi.dateNaiAut.ToString().Substring(0, 10);
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
                    txtDateNaiIntervPrincip.Text = intervPrincipChoisi.dateNaiInterv.ToString().Substring(0, 10);
                    txtDateMortIntervPrincip.Text = intervPrincipChoisi.dateMortInterv;
                    txtFonctIntervPrincip.Text = Fonction.TrouvNomFonction(intervPrincipChoisi.idFonct);
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
                    txtDateNaiIntervSecond.Text = intervSecondChoisi.dateNaiInterv.ToString().Substring(0, 10);
                    txtDateMortIntervSecond.Text = intervSecondChoisi.dateMortInterv;
                    txtFonctIntervSecond.Text = Fonction.TrouvNomFonction(intervSecondChoisi.idFonct);
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
                    txtDateNaiIntervTiers.Text = intervTiersChoisi.dateNaiInterv.ToString().Substring(0, 10);
                    txtDateMortIntervTiers.Text = intervTiersChoisi.dateMortInterv;
                    txtFonctIntervTiers.Text = Fonction.TrouvNomFonction(intervTiersChoisi.idFonct);
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer les données du troisième intervenant sélectionné");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant de l'éditeur et, si nécessaire, de créer un nouvel éditeur
        /// </summary>
        /// <returns>Retourne l'identifiant de l'éditeur entré par l'utilisateur</returns>
        /// <exception cref="">Renvoie une erreur si l'identifiant de l'éditeur n'a pas pu être récupéré ou créé</exception>
        private int DesigneEditeur()
        {
            try
            {
                int idRecupEdit = 0;
                if (cmboxChoixEdit.Text.Length != 0)
                {
                    idRecupEdit = ControlEditeur.RecupIdEditeur(txtNomEdit.Text);
                    return idRecupEdit;
                }
                else
                {
                    ArrayList infoNouvEditeur = new ArrayList();
                    infoNouvEditeur.Add(nouvPays.TrouvNumPays(txtNatioEdit.Text));
                    infoNouvEditeur.Add(txtNomEdit.Text);
                    infoNouvEditeur.Add(DateTime.Parse(txtDateCreaEdit.Text));
                    infoNouvEditeur.Add(txtDateFinEdit.Text);
                    infoNouvEditeur.Add(txtAdressEdit.Text);
                    ControlEditeur.CreerEditeur(infoNouvEditeur);
                    idRecupEdit = ControlEditeur.RecupIdEditeur(txtNomEdit.Text);
                    return idRecupEdit;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'éditeur.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant de l'imprimeur et, si nécessaire, de créer un nouvel imprimeur
        /// </summary>
        /// <returns>Retourne l'identifiant de l'imprimeur entré par l'utilisateur</returns>
        /// <exception cref="">Renvoie une erreur si l'identifiant de l'imprimeur n'a pas pu être récupéré ou créé</exception>
        private int DesigneImprimeur()
        {
            try
            {
                int idRecupImpr = 0;
                if (cmboxChoixImpr.Text.Length != 0)
                {
                    idRecupImpr = ControlImprimeur.RecupIdImprimeur(txtNomImpr.Text);
                    return idRecupImpr;
                }
                else
                {
                    ArrayList infoNouvImprimeur = new ArrayList();
                    infoNouvImprimeur.Add(nouvPays.TrouvNumPays(txtNatioImpr.Text));
                    infoNouvImprimeur.Add(txtNomImpr.Text);
                    infoNouvImprimeur.Add(DateTime.Parse(txtDateCreaImpr.Text));
                    infoNouvImprimeur.Add(txtDateFinImpr.Text);
                    ControlImprimeur.CreerImprimeur(infoNouvImprimeur);
                    idRecupImpr = ControlImprimeur.RecupIdImprimeur(txtNomImpr.Text);
                    return idRecupImpr;
                }
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'imprimeur.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'un auteur et, si nécessaire, de créer un nouvel auteur
        /// </summary>
        /// <returns>Retourne l'identifiant de l'auteur entré par l'utilisateur</returns>
        /// <exception cref="">Renvoie une erreur si l'identifiant de l'auteur n'a pas pu être récupéré ou créé</exception>
        private int DesigneAuteurExist(string nomPrenomAut)
        {
            try
            {
                int idRecupAut = 0;
                idRecupAut = ControlAuteur.RecupIdAuteur(nomPrenomAut);
                return idRecupAut;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant de créer un auteur qui n'existe pas en base de données et de récupéré son identifiant
        /// </summary>
        /// <param name="placeAut">Recupère le rang de l'auteur et le crée en fonction des champs désigné</param>
        /// <returns>Retourne l'identifiant de l'auteur créé</returns>
        /// <exception cref="">Renvoie une erreur si l'auteur n'a pas pu être créé ou si l'identifiant n'a pas pu être récupéré</exception>
        private int DesigneNouvelAuteur(string placeAut)
        {
            try
            {
                int idRecupAutCree = 0;
                if (placeAut == "principal")
                {
                    ArrayList infoNouvAutPrincip = new ArrayList();
                    infoNouvAutPrincip.Add(nouvPays.TrouvNumPays(txtNatioAutPrincip.Text));
                    infoNouvAutPrincip.Add(txtNomAutPrincip.Text);
                    infoNouvAutPrincip.Add(txtPrenomAutPrincip.Text);
                    infoNouvAutPrincip.Add(txtSurnAutPrincip.Text);
                    infoNouvAutPrincip.Add(DateTime.Parse(txtDateNaitAutPrincip.Text));
                    infoNouvAutPrincip.Add(txtDateMortAutPrincip.Text);
                    ControlAuteur.CreerAuteur(infoNouvAutPrincip);
                    idRecupAutCree = ControlAuteur.RecupIdAuteur(txtNomAutPrincip.Text + " " + txtPrenomAutPrincip.Text);
                    return idRecupAutCree;
                }
                else if (placeAut == "second")
                {
                    ArrayList infoNouvAutSecond = new ArrayList();
                    infoNouvAutSecond.Add(nouvPays.TrouvNumPays(txtNatioAutSecond.Text));
                    infoNouvAutSecond.Add(txtNomAutSecond.Text);
                    infoNouvAutSecond.Add(txtPrenomAutSecond.Text);
                    infoNouvAutSecond.Add(txtSurnAutSecond.Text);
                    infoNouvAutSecond.Add(DateTime.Parse(txtDateNaiAutSecond.Text));
                    infoNouvAutSecond.Add(txtDateMortAutSecond.Text);
                    ControlAuteur.CreerAuteur(infoNouvAutSecond);
                    idRecupAutCree = ControlAuteur.RecupIdAuteur(txtNomAutSecond.Text + " " + txtPrenomAutSecond.Text);
                    return idRecupAutCree;
                }
                else
                {
                    ArrayList infoNouvAutTiers = new ArrayList();
                    infoNouvAutTiers.Add(nouvPays.TrouvNumPays(txtNatioAutTiers.Text));
                    infoNouvAutTiers.Add(txtNomAutTiers.Text);
                    infoNouvAutTiers.Add(txtPrenomAutTiers.Text);
                    infoNouvAutTiers.Add(txtSurnAutTiers.Text);
                    infoNouvAutTiers.Add(DateTime.Parse(txtDateNaiAutTiers.Text));
                    infoNouvAutTiers.Add(txtDateMortAutTiers.Text);
                    ControlAuteur.CreerAuteur(infoNouvAutTiers);
                    idRecupAutCree = ControlAuteur.RecupIdAuteur(txtNomAutTiers.Text + " " + txtPrenomAutTiers.Text);
                    return idRecupAutCree;
                }
            }
            catch
            {
                throw new Exception("Impossible créer et de récupérer l'identifiant de l'auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant de récupérer l'identifiant d'un intervenant et, si nécessaire, de créer un nouvel intervenant
        /// </summary>
        /// <returns>Retourne l'identifiant de l'intervenant entré par l'utilisateur</returns>
        /// <exception cref="">Renvoie une erreur si l'identifiant de l'intervenant n'a pas pu être récupéré ou créé</exception>
        private int DesigneIntervExist(string nomPrenomInterv)
        {
            try
            {
                int idRecupInterv = 0;
                idRecupInterv = ControlIntervDivers.RetrouvIdIntervenant(nomPrenomInterv);
                return idRecupInterv;
            }
            catch
            {
                throw new Exception("Impossible de récupérer l'identifiant de l'intervenant.");
            }
        }

        /// <summary>
        /// Méthode permettant de créer un intervenant qui n'existe pas en base de données et de récupérer son identifiant
        /// </summary>
        /// <param name="placeInterv">Recupère le rang de l'intervenant et le crée en fonction des champs désigné</param>
        /// <returns>Retourne l'identifiant de l'intervenant créé</returns>
        /// <exception cref="">Renvoie une erreur si l'intervenant n'a pas pu être créé ou si l'identifiant n'a pas pu être récupéré</exception>
        private int DesigneNouvelIntervenant(string placeInterv)
        {
            try
            {
                int idRecupIntervCree = 0;
                if (placeInterv == "principal")
                {
                    ArrayList infoNouvIntervPrincip = new ArrayList();
                    infoNouvIntervPrincip.Add(nouvPays.TrouvNumPays(txtNatioIntervPrincip.Text));
                    infoNouvIntervPrincip.Add(nouvFonct.TrouvNumFonction(txtFonctIntervPrincip.Text));
                    infoNouvIntervPrincip.Add(txtNomIntervPrincip.Text);
                    infoNouvIntervPrincip.Add(txtPrenomIntervPrincip.Text);
                    infoNouvIntervPrincip.Add(txtSurnIntervPrincip.Text);
                    infoNouvIntervPrincip.Add(DateTime.Parse(txtDateNaiIntervPrincip.Text));
                    infoNouvIntervPrincip.Add(txtDateMortIntervPrincip.Text);
                    ControlIntervDivers.CreerIntervenant(infoNouvIntervPrincip);
                    idRecupIntervCree = ControlIntervDivers.RetrouvIdIntervenant(txtNomIntervPrincip.Text + " " + txtPrenomIntervPrincip.Text);
                    return idRecupIntervCree;
                }
                else if (placeInterv == "second")
                {
                    ArrayList infoNouvIntervSecond = new ArrayList();
                    infoNouvIntervSecond.Add(nouvPays.TrouvNumPays(txtNatioIntervSecond.Text));
                    infoNouvIntervSecond.Add(nouvFonct.TrouvNumFonction(txtFonctIntervSecond.Text));
                    infoNouvIntervSecond.Add(txtNomIntervSecond.Text);
                    infoNouvIntervSecond.Add(txtPrenomIntervSecond.Text);
                    infoNouvIntervSecond.Add(txtSurnIntervSecond.Text);
                    infoNouvIntervSecond.Add(DateTime.Parse(txtDateNaiIntervSecond.Text));
                    infoNouvIntervSecond.Add(txtDateMortIntervSecond.Text);
                    ControlIntervDivers.CreerIntervenant(infoNouvIntervSecond);
                    idRecupIntervCree = ControlIntervDivers.RetrouvIdIntervenant(txtNomIntervSecond.Text + " " + txtPrenomIntervSecond.Text);
                    return idRecupIntervCree;
                }
                else
                {
                    ArrayList infoNouvIntervTiers = new ArrayList();
                    infoNouvIntervTiers.Add(nouvPays.TrouvNumPays(txtNatioIntervTiers.Text));
                    infoNouvIntervTiers.Add(nouvFonct.TrouvNumFonction(txtFonctIntervTiers.Text));
                    infoNouvIntervTiers.Add(txtNomIntervTiers.Text);
                    infoNouvIntervTiers.Add(txtPrenomIntervTiers.Text);
                    infoNouvIntervTiers.Add(txtSurnIntervTiers.Text);
                    infoNouvIntervTiers.Add(DateTime.Parse(txtDateNaiIntervTiers.Text));
                    infoNouvIntervTiers.Add(txtDateMortIntervTiers.Text);
                    ControlIntervDivers.CreerIntervenant(infoNouvIntervTiers);
                    idRecupIntervCree = ControlIntervDivers.RetrouvIdIntervenant(txtNomIntervTiers.Text + " " + txtPrenomIntervTiers.Text);
                    return idRecupIntervCree;
                }
            }
            catch
            {
                throw new Exception("Impossible créer et de récupérer l'identifiant de l'auteur.");
            }
        }

        /// <summary>
        /// Méthode permettant de vider l'ensemble des champs du formulaire
        /// </summary>
        /// <exception cref="">Renvoie une erreur si les champs des formulaires n'ont pas pu être vidé</exception>
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
                txtFonctIntervPrincip.Text = "";
                txtNomIntervSecond.Text = "";
                txtPrenomIntervSecond.Text = "";
                txtSurnIntervSecond.Text = "";
                txtNatioIntervSecond.Text = "";
                txtDateNaiIntervSecond.Text = "";
                txtDateMortIntervSecond.Text = "";
                txtFonctIntervSecond.Text = "";
                txtNomIntervTiers.Text = "";
                txtPrenomIntervTiers.Text = "";
                txtSurnIntervTiers.Text = "";
                txtNatioIntervTiers.Text = "";
                txtDateNaiIntervTiers.Text = "";
                txtDateMortIntervTiers.Text = "";
                txtFonctIntervTiers.Text = "";
            }
            catch
            {
                throw new Exception("Impossible de vider les champs des formulaires.");
            }
        }
    }
}
