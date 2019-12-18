namespace Projet_Bibliothèque.Vue
{
    partial class VueImprimeur
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
            this.labImprim = new System.Windows.Forms.Label();
            this.txtIntroImpr = new System.Windows.Forms.RichTextBox();
            this.grpBoxNouvImprim = new System.Windows.Forms.GroupBox();
            this.txtNatioCreaImpr = new System.Windows.Forms.TextBox();
            this.labNatioCreaImpr = new System.Windows.Forms.Label();
            this.btnAjoutImpr = new System.Windows.Forms.Button();
            this.txtDateFinNouvImpr = new System.Windows.Forms.TextBox();
            this.labDateFermImprim = new System.Windows.Forms.Label();
            this.txtDateDebNouvImpr = new System.Windows.Forms.TextBox();
            this.labDateDebNouvImpr = new System.Windows.Forms.Label();
            this.txtNomNouvImpr = new System.Windows.Forms.TextBox();
            this.labNomNouvImpr = new System.Windows.Forms.Label();
            this.grBoxModifImpr = new System.Windows.Forms.GroupBox();
            this.txtNatioModifImpr = new System.Windows.Forms.TextBox();
            this.labNatioModifImpr = new System.Windows.Forms.Label();
            this.btnModifImpr = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labDateFinModifImpr = new System.Windows.Forms.Label();
            this.labDateDebModifImpr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labNomModifImpr = new System.Windows.Forms.Label();
            this.cmbBoxChoixModifImpr = new System.Windows.Forms.ComboBox();
            this.labChoixModifImpr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSupprImpr = new System.Windows.Forms.Button();
            this.cmbBoxChoixSupprImpr = new System.Windows.Forms.ComboBox();
            this.labChoixSupprImpr = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpBoxNouvImprim.SuspendLayout();
            this.grBoxModifImpr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labImprim
            // 
            this.labImprim.AutoSize = true;
            this.labImprim.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labImprim.Location = new System.Drawing.Point(197, 21);
            this.labImprim.Name = "labImprim";
            this.labImprim.Size = new System.Drawing.Size(432, 42);
            this.labImprim.TabIndex = 0;
            this.labImprim.Text = "Gestion des imprimeurs";
            // 
            // txtIntroImpr
            // 
            this.txtIntroImpr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtIntroImpr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntroImpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntroImpr.Location = new System.Drawing.Point(30, 97);
            this.txtIntroImpr.Name = "txtIntroImpr";
            this.txtIntroImpr.Size = new System.Drawing.Size(724, 54);
            this.txtIntroImpr.TabIndex = 1;
            this.txtIntroImpr.Text = "Cette page vous servira à créer, modifier ou supprimer un imprimeur existant. Les" +
    " champs marqués d\'une étoile sont obligatoires. Les autres sont facultatifs.";
            // 
            // grpBoxNouvImprim
            // 
            this.grpBoxNouvImprim.Controls.Add(this.txtNatioCreaImpr);
            this.grpBoxNouvImprim.Controls.Add(this.labNatioCreaImpr);
            this.grpBoxNouvImprim.Controls.Add(this.btnAjoutImpr);
            this.grpBoxNouvImprim.Controls.Add(this.txtDateFinNouvImpr);
            this.grpBoxNouvImprim.Controls.Add(this.labDateFermImprim);
            this.grpBoxNouvImprim.Controls.Add(this.txtDateDebNouvImpr);
            this.grpBoxNouvImprim.Controls.Add(this.labDateDebNouvImpr);
            this.grpBoxNouvImprim.Controls.Add(this.txtNomNouvImpr);
            this.grpBoxNouvImprim.Controls.Add(this.labNomNouvImpr);
            this.grpBoxNouvImprim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNouvImprim.Location = new System.Drawing.Point(30, 168);
            this.grpBoxNouvImprim.Name = "grpBoxNouvImprim";
            this.grpBoxNouvImprim.Size = new System.Drawing.Size(724, 236);
            this.grpBoxNouvImprim.TabIndex = 2;
            this.grpBoxNouvImprim.TabStop = false;
            this.grpBoxNouvImprim.Text = "Création d\'imprimeur";
            // 
            // txtNatioCreaImpr
            // 
            this.txtNatioCreaImpr.Location = new System.Drawing.Point(127, 184);
            this.txtNatioCreaImpr.Name = "txtNatioCreaImpr";
            this.txtNatioCreaImpr.Size = new System.Drawing.Size(223, 26);
            this.txtNatioCreaImpr.TabIndex = 12;
            // 
            // labNatioCreaImpr
            // 
            this.labNatioCreaImpr.AutoSize = true;
            this.labNatioCreaImpr.Location = new System.Drawing.Point(23, 187);
            this.labNatioCreaImpr.Name = "labNatioCreaImpr";
            this.labNatioCreaImpr.Size = new System.Drawing.Size(98, 20);
            this.labNatioCreaImpr.TabIndex = 11;
            this.labNatioCreaImpr.Text = "Nationalité* :";
            // 
            // btnAjoutImpr
            // 
            this.btnAjoutImpr.Location = new System.Drawing.Point(460, 178);
            this.btnAjoutImpr.Name = "btnAjoutImpr";
            this.btnAjoutImpr.Size = new System.Drawing.Size(123, 38);
            this.btnAjoutImpr.TabIndex = 10;
            this.btnAjoutImpr.Text = "Ajouter";
            this.btnAjoutImpr.UseVisualStyleBackColor = true;
            // 
            // txtDateFinNouvImpr
            // 
            this.txtDateFinNouvImpr.Location = new System.Drawing.Point(458, 126);
            this.txtDateFinNouvImpr.Name = "txtDateFinNouvImpr";
            this.txtDateFinNouvImpr.Size = new System.Drawing.Size(150, 26);
            this.txtDateFinNouvImpr.TabIndex = 9;
            // 
            // labDateFermImprim
            // 
            this.labDateFermImprim.AutoSize = true;
            this.labDateFermImprim.Location = new System.Drawing.Point(411, 103);
            this.labDateFermImprim.Name = "labDateFermImprim";
            this.labDateFermImprim.Size = new System.Drawing.Size(248, 20);
            this.labDateFermImprim.TabIndex = 8;
            this.labDateFermImprim.Text = "Date de fermeture de l\'imprimeur :";
            // 
            // txtDateDebNouvImpr
            // 
            this.txtDateDebNouvImpr.Location = new System.Drawing.Point(90, 126);
            this.txtDateDebNouvImpr.Name = "txtDateDebNouvImpr";
            this.txtDateDebNouvImpr.Size = new System.Drawing.Size(150, 26);
            this.txtDateDebNouvImpr.TabIndex = 7;
            // 
            // labDateDebNouvImpr
            // 
            this.labDateDebNouvImpr.AutoSize = true;
            this.labDateDebNouvImpr.Location = new System.Drawing.Point(62, 103);
            this.labDateDebNouvImpr.Name = "labDateDebNouvImpr";
            this.labDateDebNouvImpr.Size = new System.Drawing.Size(216, 20);
            this.labDateDebNouvImpr.TabIndex = 6;
            this.labDateDebNouvImpr.Text = "Date d\'ouverture d\'imprimeur:";
            // 
            // txtNomNouvImpr
            // 
            this.txtNomNouvImpr.Location = new System.Drawing.Point(90, 46);
            this.txtNomNouvImpr.Name = "txtNomNouvImpr";
            this.txtNomNouvImpr.Size = new System.Drawing.Size(610, 26);
            this.txtNomNouvImpr.TabIndex = 4;
            // 
            // labNomNouvImpr
            // 
            this.labNomNouvImpr.AutoSize = true;
            this.labNomNouvImpr.Location = new System.Drawing.Point(23, 46);
            this.labNomNouvImpr.Name = "labNomNouvImpr";
            this.labNomNouvImpr.Size = new System.Drawing.Size(56, 20);
            this.labNomNouvImpr.TabIndex = 3;
            this.labNomNouvImpr.Text = "Nom* :";
            // 
            // grBoxModifImpr
            // 
            this.grBoxModifImpr.Controls.Add(this.txtNatioModifImpr);
            this.grBoxModifImpr.Controls.Add(this.labNatioModifImpr);
            this.grBoxModifImpr.Controls.Add(this.btnModifImpr);
            this.grBoxModifImpr.Controls.Add(this.textBox3);
            this.grBoxModifImpr.Controls.Add(this.textBox2);
            this.grBoxModifImpr.Controls.Add(this.labDateFinModifImpr);
            this.grBoxModifImpr.Controls.Add(this.labDateDebModifImpr);
            this.grBoxModifImpr.Controls.Add(this.textBox1);
            this.grBoxModifImpr.Controls.Add(this.labNomModifImpr);
            this.grBoxModifImpr.Controls.Add(this.cmbBoxChoixModifImpr);
            this.grBoxModifImpr.Controls.Add(this.labChoixModifImpr);
            this.grBoxModifImpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxModifImpr.Location = new System.Drawing.Point(30, 421);
            this.grBoxModifImpr.Name = "grBoxModifImpr";
            this.grBoxModifImpr.Size = new System.Drawing.Size(724, 271);
            this.grBoxModifImpr.TabIndex = 3;
            this.grBoxModifImpr.TabStop = false;
            this.grBoxModifImpr.Text = "Modification d\'imprimeur";
            // 
            // txtNatioModifImpr
            // 
            this.txtNatioModifImpr.Location = new System.Drawing.Point(127, 216);
            this.txtNatioModifImpr.Name = "txtNatioModifImpr";
            this.txtNatioModifImpr.Size = new System.Drawing.Size(223, 26);
            this.txtNatioModifImpr.TabIndex = 10;
            // 
            // labNatioModifImpr
            // 
            this.labNatioModifImpr.AutoSize = true;
            this.labNatioModifImpr.Location = new System.Drawing.Point(23, 219);
            this.labNatioModifImpr.Name = "labNatioModifImpr";
            this.labNatioModifImpr.Size = new System.Drawing.Size(98, 20);
            this.labNatioModifImpr.TabIndex = 9;
            this.labNatioModifImpr.Text = "Nationalité* :";
            // 
            // btnModifImpr
            // 
            this.btnModifImpr.Location = new System.Drawing.Point(460, 209);
            this.btnModifImpr.Name = "btnModifImpr";
            this.btnModifImpr.Size = new System.Drawing.Size(123, 41);
            this.btnModifImpr.TabIndex = 8;
            this.btnModifImpr.Text = "Enregistrer";
            this.btnModifImpr.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(458, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 6;
            // 
            // labDateFinModifImpr
            // 
            this.labDateFinModifImpr.AutoSize = true;
            this.labDateFinModifImpr.Location = new System.Drawing.Point(411, 143);
            this.labDateFinModifImpr.Name = "labDateFinModifImpr";
            this.labDateFinModifImpr.Size = new System.Drawing.Size(248, 20);
            this.labDateFinModifImpr.TabIndex = 5;
            this.labDateFinModifImpr.Text = "Date de fermeture de l\'imprimeur :";
            // 
            // labDateDebModifImpr
            // 
            this.labDateDebModifImpr.AutoSize = true;
            this.labDateDebModifImpr.Location = new System.Drawing.Point(54, 143);
            this.labDateDebModifImpr.Name = "labDateDebModifImpr";
            this.labDateDebModifImpr.Size = new System.Drawing.Size(224, 20);
            this.labDateDebModifImpr.TabIndex = 4;
            this.labDateDebModifImpr.Text = "Date d\'ouverture d\'imprimeur : ";
            this.labDateDebModifImpr.Click += new System.EventHandler(this.labDateDebModifImpr_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 26);
            this.textBox1.TabIndex = 3;
            // 
            // labNomModifImpr
            // 
            this.labNomModifImpr.AutoSize = true;
            this.labNomModifImpr.Location = new System.Drawing.Point(23, 96);
            this.labNomModifImpr.Name = "labNomModifImpr";
            this.labNomModifImpr.Size = new System.Drawing.Size(56, 20);
            this.labNomModifImpr.TabIndex = 2;
            this.labNomModifImpr.Text = "Nom* :";
            // 
            // cmbBoxChoixModifImpr
            // 
            this.cmbBoxChoixModifImpr.FormattingEnabled = true;
            this.cmbBoxChoixModifImpr.Location = new System.Drawing.Point(290, 40);
            this.cmbBoxChoixModifImpr.Name = "cmbBoxChoixModifImpr";
            this.cmbBoxChoixModifImpr.Size = new System.Drawing.Size(410, 28);
            this.cmbBoxChoixModifImpr.TabIndex = 1;
            // 
            // labChoixModifImpr
            // 
            this.labChoixModifImpr.AutoSize = true;
            this.labChoixModifImpr.Location = new System.Drawing.Point(23, 43);
            this.labChoixModifImpr.Name = "labChoixModifImpr";
            this.labChoixModifImpr.Size = new System.Drawing.Size(261, 20);
            this.labChoixModifImpr.TabIndex = 0;
            this.labChoixModifImpr.Text = "Choisissez un imprimeur à modifier :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupprImpr);
            this.groupBox1.Controls.Add(this.cmbBoxChoixSupprImpr);
            this.groupBox1.Controls.Add(this.labChoixSupprImpr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 713);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppression d\'imprimeur";
            // 
            // btnSupprImpr
            // 
            this.btnSupprImpr.Location = new System.Drawing.Point(290, 99);
            this.btnSupprImpr.Name = "btnSupprImpr";
            this.btnSupprImpr.Size = new System.Drawing.Size(123, 43);
            this.btnSupprImpr.TabIndex = 2;
            this.btnSupprImpr.Text = "Supprimer";
            this.btnSupprImpr.UseVisualStyleBackColor = true;
            // 
            // cmbBoxChoixSupprImpr
            // 
            this.cmbBoxChoixSupprImpr.FormattingEnabled = true;
            this.cmbBoxChoixSupprImpr.Location = new System.Drawing.Point(290, 41);
            this.cmbBoxChoixSupprImpr.Name = "cmbBoxChoixSupprImpr";
            this.cmbBoxChoixSupprImpr.Size = new System.Drawing.Size(410, 28);
            this.cmbBoxChoixSupprImpr.TabIndex = 1;
            // 
            // labChoixSupprImpr
            // 
            this.labChoixSupprImpr.AutoSize = true;
            this.labChoixSupprImpr.Location = new System.Drawing.Point(23, 44);
            this.labChoixSupprImpr.Name = "labChoixSupprImpr";
            this.labChoixSupprImpr.Size = new System.Drawing.Size(265, 20);
            this.labChoixSupprImpr.TabIndex = 0;
            this.labChoixSupprImpr.Text = "Choisissez un imprimeur à modifier : ";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(313, 891);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(136, 47);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // VueImprimeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 950);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grBoxModifImpr);
            this.Controls.Add(this.grpBoxNouvImprim);
            this.Controls.Add(this.txtIntroImpr);
            this.Controls.Add(this.labImprim);
            this.Name = "VueImprimeur";
            this.Text = "VueImprimeur";
            this.grpBoxNouvImprim.ResumeLayout(false);
            this.grpBoxNouvImprim.PerformLayout();
            this.grBoxModifImpr.ResumeLayout(false);
            this.grBoxModifImpr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labImprim;
        private System.Windows.Forms.RichTextBox txtIntroImpr;
        private System.Windows.Forms.GroupBox grpBoxNouvImprim;
        private System.Windows.Forms.TextBox txtDateFinNouvImpr;
        private System.Windows.Forms.Label labDateFermImprim;
        private System.Windows.Forms.TextBox txtDateDebNouvImpr;
        private System.Windows.Forms.Label labDateDebNouvImpr;
        private System.Windows.Forms.TextBox txtNomNouvImpr;
        private System.Windows.Forms.Label labNomNouvImpr;
        private System.Windows.Forms.Button btnAjoutImpr;
        private System.Windows.Forms.GroupBox grBoxModifImpr;
        private System.Windows.Forms.Label labDateFinModifImpr;
        private System.Windows.Forms.Label labDateDebModifImpr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labNomModifImpr;
        private System.Windows.Forms.ComboBox cmbBoxChoixModifImpr;
        private System.Windows.Forms.Label labChoixModifImpr;
        private System.Windows.Forms.Button btnModifImpr;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSupprImpr;
        private System.Windows.Forms.ComboBox cmbBoxChoixSupprImpr;
        private System.Windows.Forms.Label labChoixSupprImpr;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtNatioCreaImpr;
        private System.Windows.Forms.Label labNatioCreaImpr;
        private System.Windows.Forms.TextBox txtNatioModifImpr;
        private System.Windows.Forms.Label labNatioModifImpr;
    }
}