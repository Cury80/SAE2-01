namespace Page_d_accueil
{
    partial class FrmListeLigne
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
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblFrequence = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblDernier = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.CmdRetour = new System.Windows.Forms.Button();
            this.lstLigne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAjouter.Location = new System.Drawing.Point(480, 13);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(308, 56);
            this.cmdAjouter.TabIndex = 1;
            this.cmdAjouter.Text = "Ajouter une ligne";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdSupprimer.Location = new System.Drawing.Point(480, 376);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(308, 56);
            this.cmdSupprimer.TabIndex = 2;
            this.cmdSupprimer.Text = "Supprimer une ligne";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdModifier.Location = new System.Drawing.Point(480, 304);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(308, 56);
            this.cmdModifier.TabIndex = 3;
            this.cmdModifier.Text = "Modifier une ligne";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(477, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrequence.Location = new System.Drawing.Point(477, 126);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(84, 17);
            this.lblFrequence.TabIndex = 5;
            this.lblFrequence.Text = "Fréquence :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDepart.Location = new System.Drawing.Point(477, 162);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(59, 17);
            this.lblDepart.TabIndex = 6;
            this.lblDepart.Text = "Départ :";
            // 
            // lblDernier
            // 
            this.lblDernier.AutoSize = true;
            this.lblDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDernier.Location = new System.Drawing.Point(477, 200);
            this.lblDernier.Name = "lblDernier";
            this.lblDernier.Size = new System.Drawing.Size(122, 17);
            this.lblDernier.TabIndex = 7;
            this.lblDernier.Text = "Dernier Passage :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(477, 242);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type transport :";
            // 
            // CmdRetour
            // 
            this.CmdRetour.FlatAppearance.BorderSize = 0;
            this.CmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRetour.Image = global::Page_d_accueil.Properties.Resources.fleche_bouton;
            this.CmdRetour.Location = new System.Drawing.Point(8, 8);
            this.CmdRetour.Margin = new System.Windows.Forms.Padding(2);
            this.CmdRetour.Name = "CmdRetour";
            this.CmdRetour.Size = new System.Drawing.Size(43, 32);
            this.CmdRetour.TabIndex = 9;
            this.CmdRetour.UseVisualStyleBackColor = true;
            this.CmdRetour.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // lstLigne
            // 
            this.lstLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstLigne.FormattingEnabled = true;
            this.lstLigne.ItemHeight = 16;
            this.lstLigne.Location = new System.Drawing.Point(8, 49);
            this.lstLigne.Name = "lstLigne";
            this.lstLigne.Size = new System.Drawing.Size(441, 372);
            this.lstLigne.TabIndex = 10;
            this.lstLigne.SelectedValueChanged += new System.EventHandler(this.lstLigne_SelectedValueChanged);
            // 
            // FrmListeLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLigne);
            this.Controls.Add(this.CmdRetour);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDernier);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Name = "FrmListeLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metram Lille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeLigne_FormClosed);
            this.Load += new System.EventHandler(this.FrmListeLigne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdModifier;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Label lblFrequence;
        public System.Windows.Forms.Label lblDepart;
        public System.Windows.Forms.Label lblDernier;
        public System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button CmdRetour;
        private System.Windows.Forms.ListBox lstLigne;
    }
}