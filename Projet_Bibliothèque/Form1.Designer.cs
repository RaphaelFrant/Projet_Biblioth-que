namespace Projet_Bibliothèque
{
    partial class Intro
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.labTitrePrincip = new System.Windows.Forms.Label();
            this.txtIntroAppli = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDebut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitrePrincip
            // 
            this.labTitrePrincip.AutoSize = true;
            this.labTitrePrincip.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitrePrincip.Location = new System.Drawing.Point(140, 28);
            this.labTitrePrincip.Name = "labTitrePrincip";
            this.labTitrePrincip.Size = new System.Drawing.Size(537, 42);
            this.labTitrePrincip.TabIndex = 0;
            this.labTitrePrincip.Text = "Gestionnaire de Bibliothèque ";
            // 
            // txtIntroAppli
            // 
            this.txtIntroAppli.AutoSize = true;
            this.txtIntroAppli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntroAppli.Location = new System.Drawing.Point(12, 86);
            this.txtIntroAppli.Name = "txtIntroAppli";
            this.txtIntroAppli.Size = new System.Drawing.Size(0, 24);
            this.txtIntroAppli.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(772, 82);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnDebut
            // 
            this.btnDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebut.Location = new System.Drawing.Point(316, 233);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(157, 51);
            this.btnDebut.TabIndex = 3;
            this.btnDebut.Text = "Commencer";
            this.btnDebut.UseVisualStyleBackColor = true;
            this.btnDebut.Click += new System.EventHandler(this.btnDebut_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.btnDebut);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtIntroAppli);
            this.Controls.Add(this.labTitrePrincip);
            this.Name = "Intro";
            this.Text = "Introduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitrePrincip;
        private System.Windows.Forms.Label txtIntroAppli;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDebut;
    }
}

