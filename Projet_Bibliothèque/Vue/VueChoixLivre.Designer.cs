namespace Projet_Bibliothèque.Vue
{
    partial class VueChoixLivre
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
            this.labChoixLivre = new System.Windows.Forms.Label();
            this.txtChoixLivre = new System.Windows.Forms.RichTextBox();
            this.dtGridViewChoixLivre = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewChoixLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // labChoixLivre
            // 
            this.labChoixLivre.AutoSize = true;
            this.labChoixLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChoixLivre.Location = new System.Drawing.Point(462, 19);
            this.labChoixLivre.Name = "labChoixLivre";
            this.labChoixLivre.Size = new System.Drawing.Size(320, 39);
            this.labChoixLivre.TabIndex = 0;
            this.labChoixLivre.Text = "Choix de l\'ouvrage";
            // 
            // txtChoixLivre
            // 
            this.txtChoixLivre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChoixLivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChoixLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoixLivre.Location = new System.Drawing.Point(25, 84);
            this.txtChoixLivre.Name = "txtChoixLivre";
            this.txtChoixLivre.ReadOnly = true;
            this.txtChoixLivre.Size = new System.Drawing.Size(969, 32);
            this.txtChoixLivre.TabIndex = 1;
            this.txtChoixLivre.Text = "Veuillez choisir l\'ouvrage à modifier, supprimer ou afficher (selon l\'opération q" +
    "ue vous avez choisi précédemment).";
            // 
            // dtGridViewChoixLivre
            // 
            this.dtGridViewChoixLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewChoixLivre.Location = new System.Drawing.Point(25, 133);
            this.dtGridViewChoixLivre.Name = "dtGridViewChoixLivre";
            this.dtGridViewChoixLivre.Size = new System.Drawing.Size(1152, 598);
            this.dtGridViewChoixLivre.TabIndex = 2;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(545, 751);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 46);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // VueChoixLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 829);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dtGridViewChoixLivre);
            this.Controls.Add(this.txtChoixLivre);
            this.Controls.Add(this.labChoixLivre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VueChoixLivre";
            this.Text = "VueChoixLivre";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewChoixLivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labChoixLivre;
        private System.Windows.Forms.RichTextBox txtChoixLivre;
        private System.Windows.Forms.DataGridView dtGridViewChoixLivre;
        private System.Windows.Forms.Button btnRetour;
    }
}