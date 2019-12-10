namespace Projet_Bibliothèque.Vue
{
    partial class VueEditeur
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
            this.labGestEdit = new System.Windows.Forms.Label();
            this.txtGestEdit = new System.Windows.Forms.RichTextBox();
            this.grpboxCreaEdit = new System.Windows.Forms.GroupBox();
            this.labNomCreaEdit = new System.Windows.Forms.Label();
            this.txtNomCreaEdit = new System.Windows.Forms.TextBox();
            this.labDateDebCreaEdit = new System.Windows.Forms.Label();
            this.labDateFinCreaEdit = new System.Windows.Forms.Label();
            this.txtDateDebCreaEdit = new System.Windows.Forms.TextBox();
            this.txtDateFinCreaEdit = new System.Windows.Forms.TextBox();
            this.labAdressCreaEdit = new System.Windows.Forms.Label();
            this.txtAdressCreaEdit = new System.Windows.Forms.TextBox();
            this.btnAjoutCreaEdit = new System.Windows.Forms.Button();
            this.grpboxModifEdit = new System.Windows.Forms.GroupBox();
            this.labChoixModifEdit = new System.Windows.Forms.Label();
            this.cmboxChoixModifEdit = new System.Windows.Forms.ComboBox();
            this.labNomModifEdit = new System.Windows.Forms.Label();
            this.txtNomModifEdit = new System.Windows.Forms.TextBox();
            this.labDateDebModifEdit = new System.Windows.Forms.Label();
            this.labDateFinModifEdit = new System.Windows.Forms.Label();
            this.txtDateDebModifEdit = new System.Windows.Forms.TextBox();
            this.txtDateFinModifEdit = new System.Windows.Forms.TextBox();
            this.labAdModifEdit = new System.Windows.Forms.Label();
            this.txtAdModifEdit = new System.Windows.Forms.TextBox();
            this.btnModifEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labChoixSupprEdit = new System.Windows.Forms.Label();
            this.cmboxChoixSupprEdit = new System.Windows.Forms.ComboBox();
            this.btnSupprEdit = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpboxCreaEdit.SuspendLayout();
            this.grpboxModifEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labGestEdit
            // 
            this.labGestEdit.AutoSize = true;
            this.labGestEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestEdit.Location = new System.Drawing.Point(184, 24);
            this.labGestEdit.Name = "labGestEdit";
            this.labGestEdit.Size = new System.Drawing.Size(404, 42);
            this.labGestEdit.TabIndex = 0;
            this.labGestEdit.Text = "Gestionnaire d\'éditeur";
            // 
            // txtGestEdit
            // 
            this.txtGestEdit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtGestEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGestEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestEdit.Location = new System.Drawing.Point(25, 88);
            this.txtGestEdit.Name = "txtGestEdit";
            this.txtGestEdit.Size = new System.Drawing.Size(742, 56);
            this.txtGestEdit.TabIndex = 1;
            this.txtGestEdit.Text = "Ce formulaire vous permet de gérer les éditeurs (création, modification et suppre" +
    "ssion). Les champs munis d\'une étoile sont obligatoires.";
            // 
            // grpboxCreaEdit
            // 
            this.grpboxCreaEdit.Controls.Add(this.btnAjoutCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.txtAdressCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.labAdressCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.txtDateFinCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.txtDateDebCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.labDateFinCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.labDateDebCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.txtNomCreaEdit);
            this.grpboxCreaEdit.Controls.Add(this.labNomCreaEdit);
            this.grpboxCreaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxCreaEdit.Location = new System.Drawing.Point(25, 163);
            this.grpboxCreaEdit.Name = "grpboxCreaEdit";
            this.grpboxCreaEdit.Size = new System.Drawing.Size(751, 256);
            this.grpboxCreaEdit.TabIndex = 2;
            this.grpboxCreaEdit.TabStop = false;
            this.grpboxCreaEdit.Text = "Création d\'éditeur";
            // 
            // labNomCreaEdit
            // 
            this.labNomCreaEdit.AutoSize = true;
            this.labNomCreaEdit.Location = new System.Drawing.Point(24, 39);
            this.labNomCreaEdit.Name = "labNomCreaEdit";
            this.labNomCreaEdit.Size = new System.Drawing.Size(56, 20);
            this.labNomCreaEdit.TabIndex = 0;
            this.labNomCreaEdit.Text = "Nom* :";
            // 
            // txtNomCreaEdit
            // 
            this.txtNomCreaEdit.Location = new System.Drawing.Point(86, 36);
            this.txtNomCreaEdit.Name = "txtNomCreaEdit";
            this.txtNomCreaEdit.Size = new System.Drawing.Size(636, 26);
            this.txtNomCreaEdit.TabIndex = 1;
            // 
            // labDateDebCreaEdit
            // 
            this.labDateDebCreaEdit.AutoSize = true;
            this.labDateDebCreaEdit.Location = new System.Drawing.Point(82, 83);
            this.labDateDebCreaEdit.Name = "labDateDebCreaEdit";
            this.labDateDebCreaEdit.Size = new System.Drawing.Size(135, 20);
            this.labDateDebCreaEdit.TabIndex = 2;
            this.labDateDebCreaEdit.Text = "Date de création :";
            // 
            // labDateFinCreaEdit
            // 
            this.labDateFinCreaEdit.AutoSize = true;
            this.labDateFinCreaEdit.Location = new System.Drawing.Point(490, 83);
            this.labDateFinCreaEdit.Name = "labDateFinCreaEdit";
            this.labDateFinCreaEdit.Size = new System.Drawing.Size(147, 20);
            this.labDateFinCreaEdit.TabIndex = 3;
            this.labDateFinCreaEdit.Text = "Date de fermeture :";
            // 
            // txtDateDebCreaEdit
            // 
            this.txtDateDebCreaEdit.Location = new System.Drawing.Point(67, 106);
            this.txtDateDebCreaEdit.Name = "txtDateDebCreaEdit";
            this.txtDateDebCreaEdit.Size = new System.Drawing.Size(167, 26);
            this.txtDateDebCreaEdit.TabIndex = 4;
            // 
            // txtDateFinCreaEdit
            // 
            this.txtDateFinCreaEdit.Location = new System.Drawing.Point(480, 106);
            this.txtDateFinCreaEdit.Name = "txtDateFinCreaEdit";
            this.txtDateFinCreaEdit.Size = new System.Drawing.Size(167, 26);
            this.txtDateFinCreaEdit.TabIndex = 5;
            // 
            // labAdressCreaEdit
            // 
            this.labAdressCreaEdit.AutoSize = true;
            this.labAdressCreaEdit.Location = new System.Drawing.Point(24, 156);
            this.labAdressCreaEdit.Name = "labAdressCreaEdit";
            this.labAdressCreaEdit.Size = new System.Drawing.Size(82, 20);
            this.labAdressCreaEdit.TabIndex = 6;
            this.labAdressCreaEdit.Text = "Adresse* :";
            // 
            // txtAdressCreaEdit
            // 
            this.txtAdressCreaEdit.Location = new System.Drawing.Point(112, 153);
            this.txtAdressCreaEdit.Name = "txtAdressCreaEdit";
            this.txtAdressCreaEdit.Size = new System.Drawing.Size(610, 26);
            this.txtAdressCreaEdit.TabIndex = 7;
            // 
            // btnAjoutCreaEdit
            // 
            this.btnAjoutCreaEdit.Location = new System.Drawing.Point(316, 197);
            this.btnAjoutCreaEdit.Name = "btnAjoutCreaEdit";
            this.btnAjoutCreaEdit.Size = new System.Drawing.Size(104, 43);
            this.btnAjoutCreaEdit.TabIndex = 8;
            this.btnAjoutCreaEdit.Text = "Ajouter";
            this.btnAjoutCreaEdit.UseVisualStyleBackColor = true;
            // 
            // grpboxModifEdit
            // 
            this.grpboxModifEdit.Controls.Add(this.btnModifEdit);
            this.grpboxModifEdit.Controls.Add(this.txtAdModifEdit);
            this.grpboxModifEdit.Controls.Add(this.labAdModifEdit);
            this.grpboxModifEdit.Controls.Add(this.txtDateFinModifEdit);
            this.grpboxModifEdit.Controls.Add(this.txtDateDebModifEdit);
            this.grpboxModifEdit.Controls.Add(this.labDateFinModifEdit);
            this.grpboxModifEdit.Controls.Add(this.labDateDebModifEdit);
            this.grpboxModifEdit.Controls.Add(this.txtNomModifEdit);
            this.grpboxModifEdit.Controls.Add(this.labNomModifEdit);
            this.grpboxModifEdit.Controls.Add(this.cmboxChoixModifEdit);
            this.grpboxModifEdit.Controls.Add(this.labChoixModifEdit);
            this.grpboxModifEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxModifEdit.Location = new System.Drawing.Point(25, 440);
            this.grpboxModifEdit.Name = "grpboxModifEdit";
            this.grpboxModifEdit.Size = new System.Drawing.Size(751, 278);
            this.grpboxModifEdit.TabIndex = 3;
            this.grpboxModifEdit.TabStop = false;
            this.grpboxModifEdit.Text = "Modification d\'éditeur";
            // 
            // labChoixModifEdit
            // 
            this.labChoixModifEdit.AutoSize = true;
            this.labChoixModifEdit.Location = new System.Drawing.Point(15, 32);
            this.labChoixModifEdit.Name = "labChoixModifEdit";
            this.labChoixModifEdit.Size = new System.Drawing.Size(241, 20);
            this.labChoixModifEdit.TabIndex = 0;
            this.labChoixModifEdit.Text = "Choisissez un éditeur à modifier :";
            // 
            // cmboxChoixModifEdit
            // 
            this.cmboxChoixModifEdit.FormattingEnabled = true;
            this.cmboxChoixModifEdit.Location = new System.Drawing.Point(262, 29);
            this.cmboxChoixModifEdit.Name = "cmboxChoixModifEdit";
            this.cmboxChoixModifEdit.Size = new System.Drawing.Size(460, 28);
            this.cmboxChoixModifEdit.TabIndex = 1;
            // 
            // labNomModifEdit
            // 
            this.labNomModifEdit.AutoSize = true;
            this.labNomModifEdit.Location = new System.Drawing.Point(15, 76);
            this.labNomModifEdit.Name = "labNomModifEdit";
            this.labNomModifEdit.Size = new System.Drawing.Size(56, 20);
            this.labNomModifEdit.TabIndex = 2;
            this.labNomModifEdit.Text = "Nom* :";
            // 
            // txtNomModifEdit
            // 
            this.txtNomModifEdit.Location = new System.Drawing.Point(77, 73);
            this.txtNomModifEdit.Name = "txtNomModifEdit";
            this.txtNomModifEdit.Size = new System.Drawing.Size(645, 26);
            this.txtNomModifEdit.TabIndex = 3;
            // 
            // labDateDebModifEdit
            // 
            this.labDateDebModifEdit.AutoSize = true;
            this.labDateDebModifEdit.Location = new System.Drawing.Point(84, 116);
            this.labDateDebModifEdit.Name = "labDateDebModifEdit";
            this.labDateDebModifEdit.Size = new System.Drawing.Size(135, 20);
            this.labDateDebModifEdit.TabIndex = 4;
            this.labDateDebModifEdit.Text = "Date de création :";
            // 
            // labDateFinModifEdit
            // 
            this.labDateFinModifEdit.AutoSize = true;
            this.labDateFinModifEdit.Location = new System.Drawing.Point(490, 116);
            this.labDateFinModifEdit.Name = "labDateFinModifEdit";
            this.labDateFinModifEdit.Size = new System.Drawing.Size(147, 20);
            this.labDateFinModifEdit.TabIndex = 5;
            this.labDateFinModifEdit.Text = "Date de fermeture :";
            // 
            // txtDateDebModifEdit
            // 
            this.txtDateDebModifEdit.Location = new System.Drawing.Point(67, 139);
            this.txtDateDebModifEdit.Name = "txtDateDebModifEdit";
            this.txtDateDebModifEdit.Size = new System.Drawing.Size(167, 26);
            this.txtDateDebModifEdit.TabIndex = 6;
            // 
            // txtDateFinModifEdit
            // 
            this.txtDateFinModifEdit.Location = new System.Drawing.Point(480, 139);
            this.txtDateFinModifEdit.Name = "txtDateFinModifEdit";
            this.txtDateFinModifEdit.Size = new System.Drawing.Size(167, 26);
            this.txtDateFinModifEdit.TabIndex = 7;
            // 
            // labAdModifEdit
            // 
            this.labAdModifEdit.AutoSize = true;
            this.labAdModifEdit.Location = new System.Drawing.Point(15, 184);
            this.labAdModifEdit.Name = "labAdModifEdit";
            this.labAdModifEdit.Size = new System.Drawing.Size(82, 20);
            this.labAdModifEdit.TabIndex = 8;
            this.labAdModifEdit.Text = "Adresse* :";
            // 
            // txtAdModifEdit
            // 
            this.txtAdModifEdit.Location = new System.Drawing.Point(103, 181);
            this.txtAdModifEdit.Name = "txtAdModifEdit";
            this.txtAdModifEdit.Size = new System.Drawing.Size(619, 26);
            this.txtAdModifEdit.TabIndex = 9;
            // 
            // btnModifEdit
            // 
            this.btnModifEdit.Location = new System.Drawing.Point(316, 223);
            this.btnModifEdit.Name = "btnModifEdit";
            this.btnModifEdit.Size = new System.Drawing.Size(104, 40);
            this.btnModifEdit.TabIndex = 10;
            this.btnModifEdit.Text = "Enregistrer";
            this.btnModifEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupprEdit);
            this.groupBox1.Controls.Add(this.cmboxChoixSupprEdit);
            this.groupBox1.Controls.Add(this.labChoixSupprEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 737);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppression d\'éditeur";
            // 
            // labChoixSupprEdit
            // 
            this.labChoixSupprEdit.AutoSize = true;
            this.labChoixSupprEdit.Location = new System.Drawing.Point(15, 36);
            this.labChoixSupprEdit.Name = "labChoixSupprEdit";
            this.labChoixSupprEdit.Size = new System.Drawing.Size(255, 20);
            this.labChoixSupprEdit.TabIndex = 0;
            this.labChoixSupprEdit.Text = "Choisissez un éditeur à supprimer :";
            // 
            // cmboxChoixSupprEdit
            // 
            this.cmboxChoixSupprEdit.FormattingEnabled = true;
            this.cmboxChoixSupprEdit.Location = new System.Drawing.Point(276, 33);
            this.cmboxChoixSupprEdit.Name = "cmboxChoixSupprEdit";
            this.cmboxChoixSupprEdit.Size = new System.Drawing.Size(446, 28);
            this.cmboxChoixSupprEdit.TabIndex = 1;
            // 
            // btnSupprEdit
            // 
            this.btnSupprEdit.Location = new System.Drawing.Point(316, 76);
            this.btnSupprEdit.Name = "btnSupprEdit";
            this.btnSupprEdit.Size = new System.Drawing.Size(104, 40);
            this.btnSupprEdit.TabIndex = 2;
            this.btnSupprEdit.Text = "Supprimer";
            this.btnSupprEdit.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(328, 900);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(127, 52);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // VueEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 960);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpboxModifEdit);
            this.Controls.Add(this.grpboxCreaEdit);
            this.Controls.Add(this.txtGestEdit);
            this.Controls.Add(this.labGestEdit);
            this.Name = "VueEditeur";
            this.Text = "VueEditeur";
            this.grpboxCreaEdit.ResumeLayout(false);
            this.grpboxCreaEdit.PerformLayout();
            this.grpboxModifEdit.ResumeLayout(false);
            this.grpboxModifEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGestEdit;
        private System.Windows.Forms.RichTextBox txtGestEdit;
        private System.Windows.Forms.GroupBox grpboxCreaEdit;
        private System.Windows.Forms.Button btnAjoutCreaEdit;
        private System.Windows.Forms.TextBox txtAdressCreaEdit;
        private System.Windows.Forms.Label labAdressCreaEdit;
        private System.Windows.Forms.TextBox txtDateFinCreaEdit;
        private System.Windows.Forms.TextBox txtDateDebCreaEdit;
        private System.Windows.Forms.Label labDateFinCreaEdit;
        private System.Windows.Forms.Label labDateDebCreaEdit;
        private System.Windows.Forms.TextBox txtNomCreaEdit;
        private System.Windows.Forms.Label labNomCreaEdit;
        private System.Windows.Forms.GroupBox grpboxModifEdit;
        private System.Windows.Forms.Button btnModifEdit;
        private System.Windows.Forms.TextBox txtAdModifEdit;
        private System.Windows.Forms.Label labAdModifEdit;
        private System.Windows.Forms.TextBox txtDateFinModifEdit;
        private System.Windows.Forms.TextBox txtDateDebModifEdit;
        private System.Windows.Forms.Label labDateFinModifEdit;
        private System.Windows.Forms.Label labDateDebModifEdit;
        private System.Windows.Forms.TextBox txtNomModifEdit;
        private System.Windows.Forms.Label labNomModifEdit;
        private System.Windows.Forms.ComboBox cmboxChoixModifEdit;
        private System.Windows.Forms.Label labChoixModifEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSupprEdit;
        private System.Windows.Forms.ComboBox cmboxChoixSupprEdit;
        private System.Windows.Forms.Label labChoixSupprEdit;
        private System.Windows.Forms.Button btnRetour;
    }
}