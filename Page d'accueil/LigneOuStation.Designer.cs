namespace Page_d_accueil
{
    partial class FrmLigneOuStation
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
            this.cmdLignes = new System.Windows.Forms.Button();
            this.cmdStations = new System.Windows.Forms.Button();
            this.CmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLignes
            // 
            this.cmdLignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmdLignes.Location = new System.Drawing.Point(388, 152);
            this.cmdLignes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLignes.Name = "cmdLignes";
            this.cmdLignes.Size = new System.Drawing.Size(423, 162);
            this.cmdLignes.TabIndex = 0;
            this.cmdLignes.Text = "Liste des lignes";
            this.cmdLignes.UseVisualStyleBackColor = true;
            this.cmdLignes.Click += new System.EventHandler(this.cmdLignes_Click);
            // 
            // cmdStations
            // 
            this.cmdStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmdStations.Location = new System.Drawing.Point(388, 378);
            this.cmdStations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdStations.Name = "cmdStations";
            this.cmdStations.Size = new System.Drawing.Size(423, 162);
            this.cmdStations.TabIndex = 1;
            this.cmdStations.Text = "Liste des stations";
            this.cmdStations.UseVisualStyleBackColor = true;
            this.cmdStations.Click += new System.EventHandler(this.cmdLignes_Click);
            // 
            // CmdRetour
            // 
            this.CmdRetour.FlatAppearance.BorderSize = 0;
            this.CmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRetour.Image = global::Page_d_accueil.Properties.Resources.fleche_bouton;
            this.CmdRetour.Location = new System.Drawing.Point(12, 12);
            this.CmdRetour.Name = "CmdRetour";
            this.CmdRetour.Size = new System.Drawing.Size(65, 49);
            this.CmdRetour.TabIndex = 2;
            this.CmdRetour.UseVisualStyleBackColor = true;
            this.CmdRetour.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // FrmLigneOuStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.CmdRetour);
            this.Controls.Add(this.cmdStations);
            this.Controls.Add(this.cmdLignes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLigneOuStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metram Lille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLigneOuStation_FormClosed);
            this.Load += new System.EventHandler(this.LigneOuStation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLignes;
        private System.Windows.Forms.Button cmdStations;
        private System.Windows.Forms.Button CmdRetour;
    }
}