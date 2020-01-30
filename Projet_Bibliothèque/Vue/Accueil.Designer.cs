namespace Projet_Bibliothèque.Vue
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.labGestBiblio = new System.Windows.Forms.Label();
            this.txtPresentGestBiblio = new System.Windows.Forms.RichTextBox();
            this.btnCreaLivre = new System.Windows.Forms.Button();
            this.btnModifLivre = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnAuteur = new System.Windows.Forms.Button();
            this.btnEditeur = new System.Windows.Forms.Button();
            this.btnImpr = new System.Windows.Forms.Button();
            this.btnInterv = new System.Windows.Forms.Button();
            this.labCreaLivre = new System.Windows.Forms.RichTextBox();
            this.labModifLivre = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.txtAuteur = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtNouveau = new System.Windows.Forms.RichTextBox();
            this.btnNouveaute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labGestBiblio
            // 
            this.labGestBiblio.AutoSize = true;
            this.labGestBiblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestBiblio.Location = new System.Drawing.Point(149, 19);
            this.labGestBiblio.Name = "labGestBiblio";
            this.labGestBiblio.Size = new System.Drawing.Size(484, 39);
            this.labGestBiblio.TabIndex = 0;
            this.labGestBiblio.Text = "Gestionnaire de bibliothèque";
            // 
            // txtPresentGestBiblio
            // 
            this.txtPresentGestBiblio.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPresentGestBiblio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPresentGestBiblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentGestBiblio.Location = new System.Drawing.Point(28, 100);
            this.txtPresentGestBiblio.Name = "txtPresentGestBiblio";
            this.txtPresentGestBiblio.Size = new System.Drawing.Size(729, 81);
            this.txtPresentGestBiblio.TabIndex = 1;
            this.txtPresentGestBiblio.Text = resources.GetString("txtPresentGestBiblio.Text");
            // 
            // btnCreaLivre
            // 
            this.btnCreaLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaLivre.Location = new System.Drawing.Point(546, 232);
            this.btnCreaLivre.Name = "btnCreaLivre";
            this.btnCreaLivre.Size = new System.Drawing.Size(158, 46);
            this.btnCreaLivre.TabIndex = 2;
            this.btnCreaLivre.Text = "Créer un livre";
            this.btnCreaLivre.UseVisualStyleBackColor = true;
            this.btnCreaLivre.Click += new System.EventHandler(this.btnCreaLivre_Click);
            // 
            // btnModifLivre
            // 
            this.btnModifLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifLivre.Location = new System.Drawing.Point(546, 308);
            this.btnModifLivre.Name = "btnModifLivre";
            this.btnModifLivre.Size = new System.Drawing.Size(158, 46);
            this.btnModifLivre.TabIndex = 3;
            this.btnModifLivre.Text = "Modifier un livre";
            this.btnModifLivre.UseVisualStyleBackColor = true;
            this.btnModifLivre.Click += new System.EventHandler(this.btnModifLivre_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(546, 457);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(158, 46);
            this.btnRecherche.TabIndex = 6;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnAuteur
            // 
            this.btnAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuteur.Location = new System.Drawing.Point(546, 526);
            this.btnAuteur.Name = "btnAuteur";
            this.btnAuteur.Size = new System.Drawing.Size(158, 46);
            this.btnAuteur.TabIndex = 7;
            this.btnAuteur.Text = "Auteurs";
            this.btnAuteur.UseVisualStyleBackColor = true;
            this.btnAuteur.Click += new System.EventHandler(this.btnAuteur_Click);
            // 
            // btnEditeur
            // 
            this.btnEditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditeur.Location = new System.Drawing.Point(546, 597);
            this.btnEditeur.Name = "btnEditeur";
            this.btnEditeur.Size = new System.Drawing.Size(158, 46);
            this.btnEditeur.TabIndex = 8;
            this.btnEditeur.Text = "Editeur";
            this.btnEditeur.UseVisualStyleBackColor = true;
            this.btnEditeur.Click += new System.EventHandler(this.btnEditeur_Click);
            // 
            // btnImpr
            // 
            this.btnImpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpr.Location = new System.Drawing.Point(546, 666);
            this.btnImpr.Name = "btnImpr";
            this.btnImpr.Size = new System.Drawing.Size(158, 46);
            this.btnImpr.TabIndex = 9;
            this.btnImpr.Text = "Imprimeur";
            this.btnImpr.UseVisualStyleBackColor = true;
            this.btnImpr.Click += new System.EventHandler(this.btnImpr_Click);
            // 
            // btnInterv
            // 
            this.btnInterv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterv.Location = new System.Drawing.Point(546, 735);
            this.btnInterv.Name = "btnInterv";
            this.btnInterv.Size = new System.Drawing.Size(158, 46);
            this.btnInterv.TabIndex = 10;
            this.btnInterv.Text = "Intervenants divers";
            this.btnInterv.UseVisualStyleBackColor = true;
            this.btnInterv.Click += new System.EventHandler(this.btnInterv_Click);
            // 
            // labCreaLivre
            // 
            this.labCreaLivre.BackColor = System.Drawing.SystemColors.Menu;
            this.labCreaLivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labCreaLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCreaLivre.Location = new System.Drawing.Point(28, 232);
            this.labCreaLivre.Name = "labCreaLivre";
            this.labCreaLivre.Size = new System.Drawing.Size(501, 46);
            this.labCreaLivre.TabIndex = 12;
            this.labCreaLivre.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet d\'ajouter un l" +
    "ivre à votre catalogue";
            // 
            // labModifLivre
            // 
            this.labModifLivre.BackColor = System.Drawing.SystemColors.Menu;
            this.labModifLivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labModifLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labModifLivre.Location = new System.Drawing.Point(28, 308);
            this.labModifLivre.Name = "labModifLivre";
            this.labModifLivre.Size = new System.Drawing.Size(501, 46);
            this.labModifLivre.TabIndex = 13;
            this.labModifLivre.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet de modifier un" +
    " livre présent dans votre catalogue";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(28, 457);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(501, 46);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet d\'ajouter un l" +
    "ivre à votre catalogue";
            // 
            // txtAuteur
            // 
            this.txtAuteur.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAuteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuteur.Location = new System.Drawing.Point(28, 526);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(501, 46);
            this.txtAuteur.TabIndex = 17;
            this.txtAuteur.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet de gérer la li" +
    "ste des auteurs et leurs informations";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(28, 597);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 46);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet de gérer la li" +
    "ste des éditeurs et leurs informations";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(28, 666);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(501, 46);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet de gérer la li" +
    "ste des imprimeurs et leurs informations";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(28, 735);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(501, 46);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = "Ce bouton vous permettra d\'accéder à un formulaire qui vous permet de gérer les i" +
    "ntervenants et leurs informations";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(351, 824);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(114, 44);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtNouveau
            // 
            this.txtNouveau.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNouveau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouveau.Location = new System.Drawing.Point(29, 386);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(500, 42);
            this.txtNouveau.TabIndex = 22;
            this.txtNouveau.Text = "Ce bouton vous permettra de visualiser les derniers livres que vous avez ajouter " +
    "au logiciel";
            // 
            // btnNouveaute
            // 
            this.btnNouveaute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveaute.Location = new System.Drawing.Point(546, 382);
            this.btnNouveaute.Name = "btnNouveaute";
            this.btnNouveaute.Size = new System.Drawing.Size(158, 46);
            this.btnNouveaute.TabIndex = 23;
            this.btnNouveaute.Text = "Nouveautés";
            this.btnNouveaute.UseVisualStyleBackColor = true;
            this.btnNouveaute.Click += new System.EventHandler(this.btnNouveaute_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 911);
            this.Controls.Add(this.btnNouveaute);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.labModifLivre);
            this.Controls.Add(this.labCreaLivre);
            this.Controls.Add(this.btnInterv);
            this.Controls.Add(this.btnImpr);
            this.Controls.Add(this.btnEditeur);
            this.Controls.Add(this.btnAuteur);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnModifLivre);
            this.Controls.Add(this.btnCreaLivre);
            this.Controls.Add(this.txtPresentGestBiblio);
            this.Controls.Add(this.labGestBiblio);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGestBiblio;
        private System.Windows.Forms.RichTextBox txtPresentGestBiblio;
        private System.Windows.Forms.Button btnCreaLivre;
        private System.Windows.Forms.Button btnModifLivre;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnAuteur;
        private System.Windows.Forms.Button btnEditeur;
        private System.Windows.Forms.Button btnImpr;
        private System.Windows.Forms.Button btnInterv;
        private System.Windows.Forms.RichTextBox labCreaLivre;
        private System.Windows.Forms.RichTextBox labModifLivre;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox txtAuteur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.RichTextBox txtNouveau;
        private System.Windows.Forms.Button btnNouveaute;
    }
}