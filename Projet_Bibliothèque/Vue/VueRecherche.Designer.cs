﻿namespace Projet_Bibliothèque.Vue
{
    partial class VueRecherche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.RichTextBox();
            this.labChoixRubrique = new System.Windows.Forms.Label();
            this.cmboxChoixRubrique = new System.Windows.Forms.ComboBox();
            this.labContRecherche = new System.Windows.Forms.Label();
            this.txtContRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.dtGridRecherche = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifLivre = new System.Windows.Forms.Button();
            this.btnSupprimerLivre = new System.Windows.Forms.Button();
            this.btnAfficherLivre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // labRecherche
            // 
            this.labRecherche.AutoSize = true;
            this.labRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecherche.Location = new System.Drawing.Point(290, 22);
            this.labRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRecherche.Name = "labRecherche";
            this.labRecherche.Size = new System.Drawing.Size(207, 39);
            this.labRecherche.TabIndex = 0;
            this.labRecherche.Text = "Rechercher";
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(52, 89);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(727, 77);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.Text = "Cette partie de l\'application vous permettra de rechercher des informations parmi" +
    " les données présentent dans le catalogue de votre bibliothèque. Plusieurs optio" +
    "ns sont disponibles pour cela.";
            // 
            // labChoixRubrique
            // 
            this.labChoixRubrique.AutoSize = true;
            this.labChoixRubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChoixRubrique.Location = new System.Drawing.Point(49, 191);
            this.labChoixRubrique.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChoixRubrique.Name = "labChoixRubrique";
            this.labChoixRubrique.Size = new System.Drawing.Size(343, 24);
            this.labChoixRubrique.TabIndex = 2;
            this.labChoixRubrique.Text = "Choisissez une rubrique de recherche :";
            // 
            // cmboxChoixRubrique
            // 
            this.cmboxChoixRubrique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxChoixRubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxChoixRubrique.FormattingEnabled = true;
            this.cmboxChoixRubrique.Items.AddRange(new object[] {
            "Auteur",
            "Editeur",
            "Genre_Litteraire",
            "Imprimeur",
            "Intervenant_Divers",
            "Livre",
            "Periode_Temporelle",
            "Serie_de_livre",
            "Type_de_livre"});
            this.cmboxChoixRubrique.Location = new System.Drawing.Point(400, 188);
            this.cmboxChoixRubrique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboxChoixRubrique.Name = "cmboxChoixRubrique";
            this.cmboxChoixRubrique.Size = new System.Drawing.Size(379, 32);
            this.cmboxChoixRubrique.TabIndex = 3;
            // 
            // labContRecherche
            // 
            this.labContRecherche.AutoSize = true;
            this.labContRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContRecherche.Location = new System.Drawing.Point(49, 242);
            this.labContRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labContRecherche.Name = "labContRecherche";
            this.labContRecherche.Size = new System.Drawing.Size(252, 24);
            this.labContRecherche.TabIndex = 4;
            this.labContRecherche.Text = "Contenu de votre recherche:";
            // 
            // txtContRecherche
            // 
            this.txtContRecherche.Location = new System.Drawing.Point(308, 242);
            this.txtContRecherche.Name = "txtContRecherche";
            this.txtContRecherche.Size = new System.Drawing.Size(309, 26);
            this.txtContRecherche.TabIndex = 5;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(654, 242);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(125, 26);
            this.btnRecherche.TabIndex = 6;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // dtGridRecherche
            // 
            this.dtGridRecherche.AllowUserToAddRows = false;
            this.dtGridRecherche.AllowUserToDeleteRows = false;
            this.dtGridRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRecherche.Location = new System.Drawing.Point(12, 286);
            this.dtGridRecherche.Name = "dtGridRecherche";
            this.dtGridRecherche.ReadOnly = true;
            this.dtGridRecherche.Size = new System.Drawing.Size(798, 619);
            this.dtGridRecherche.TabIndex = 7;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(709, 927);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(101, 45);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModifLivre
            // 
            this.btnModifLivre.Location = new System.Drawing.Point(12, 929);
            this.btnModifLivre.Name = "btnModifLivre";
            this.btnModifLivre.Size = new System.Drawing.Size(103, 41);
            this.btnModifLivre.TabIndex = 9;
            this.btnModifLivre.Text = "Modifier";
            this.btnModifLivre.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerLivre
            // 
            this.btnSupprimerLivre.Location = new System.Drawing.Point(246, 928);
            this.btnSupprimerLivre.Name = "btnSupprimerLivre";
            this.btnSupprimerLivre.Size = new System.Drawing.Size(103, 42);
            this.btnSupprimerLivre.TabIndex = 10;
            this.btnSupprimerLivre.Text = "Supprimer";
            this.btnSupprimerLivre.UseVisualStyleBackColor = true;
            this.btnSupprimerLivre.Click += new System.EventHandler(this.btnSupprimerLivre_Click);
            // 
            // btnAfficherLivre
            // 
            this.btnAfficherLivre.Location = new System.Drawing.Point(486, 928);
            this.btnAfficherLivre.Name = "btnAfficherLivre";
            this.btnAfficherLivre.Size = new System.Drawing.Size(103, 42);
            this.btnAfficherLivre.TabIndex = 11;
            this.btnAfficherLivre.Text = "Afficher";
            this.btnAfficherLivre.UseVisualStyleBackColor = true;
            this.btnAfficherLivre.Click += new System.EventHandler(this.btnAfficherLivre_Click);
            // 
            // VueRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 987);
            this.Controls.Add(this.btnAfficherLivre);
            this.Controls.Add(this.btnSupprimerLivre);
            this.Controls.Add(this.btnModifLivre);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dtGridRecherche);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtContRecherche);
            this.Controls.Add(this.labContRecherche);
            this.Controls.Add(this.cmboxChoixRubrique);
            this.Controls.Add(this.labChoixRubrique);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.labRecherche);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VueRecherche";
            this.Text = "VueRecherche";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRecherche;
        private System.Windows.Forms.RichTextBox txtRecherche;
        private System.Windows.Forms.Label labChoixRubrique;
        private System.Windows.Forms.ComboBox cmboxChoixRubrique;
        private System.Windows.Forms.Label labContRecherche;
        private System.Windows.Forms.TextBox txtContRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.DataGridView dtGridRecherche;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModifLivre;
        private System.Windows.Forms.Button btnSupprimerLivre;
        private System.Windows.Forms.Button btnAfficherLivre;
    }
}