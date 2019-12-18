namespace Projet_Bibliothèque.Vue
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cmboxChoixRubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxChoixRubrique.FormattingEnabled = true;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 688);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(362, 995);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(101, 45);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // VueRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 1061);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetour;
    }
}