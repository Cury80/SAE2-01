namespace Page_d_accueil
{
    partial class LigneOuStation
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
            this.SuspendLayout();
            // 
            // cmdLignes
            // 
            this.cmdLignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmdLignes.Location = new System.Drawing.Point(259, 99);
            this.cmdLignes.Name = "cmdLignes";
            this.cmdLignes.Size = new System.Drawing.Size(282, 105);
            this.cmdLignes.TabIndex = 0;
            this.cmdLignes.Text = "Liste des lignes";
            this.cmdLignes.UseVisualStyleBackColor = true;
            // 
            // cmdStations
            // 
            this.cmdStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmdStations.Location = new System.Drawing.Point(259, 246);
            this.cmdStations.Name = "cmdStations";
            this.cmdStations.Size = new System.Drawing.Size(282, 105);
            this.cmdStations.TabIndex = 1;
            this.cmdStations.Text = "Liste des stations";
            this.cmdStations.UseVisualStyleBackColor = true;
            this.cmdStations.Click += new System.EventHandler(this.button2_Click);
            // 
            // LigneOuStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdStations);
            this.Controls.Add(this.cmdLignes);
            this.Name = "LigneOuStation";
            this.Text = "Metram Lille";
            this.Load += new System.EventHandler(this.LigneOuStation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLignes;
        private System.Windows.Forms.Button cmdStations;
    }
}