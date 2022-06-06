namespace Page_d_accueil
{
    partial class ListeLigne
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
            this.lstLigne = new System.Windows.Forms.ListBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblFrequence = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblDernier = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLigne
            // 
            this.lstLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstLigne.FormattingEnabled = true;
            this.lstLigne.ItemHeight = 16;
            this.lstLigne.Items.AddRange(new object[] {
            "Metro Ligne 1"});
            this.lstLigne.Location = new System.Drawing.Point(12, 12);
            this.lstLigne.Name = "lstLigne";
            this.lstLigne.Size = new System.Drawing.Size(390, 420);
            this.lstLigne.TabIndex = 0;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAjouter.Location = new System.Drawing.Point(427, 13);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(361, 56);
            this.cmdAjouter.TabIndex = 1;
            this.cmdAjouter.Text = "Ajouter une ligne";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdSupprimer.Location = new System.Drawing.Point(427, 376);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(361, 56);
            this.cmdSupprimer.TabIndex = 2;
            this.cmdSupprimer.Text = "Supprimer une ligne";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdModifier.Location = new System.Drawing.Point(427, 304);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(361, 56);
            this.cmdModifier.TabIndex = 3;
            this.cmdModifier.Text = "Modifier une ligne";
            this.cmdModifier.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(424, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrequence.Location = new System.Drawing.Point(424, 126);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(84, 17);
            this.lblFrequence.TabIndex = 5;
            this.lblFrequence.Text = "Fréquence :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDepart.Location = new System.Drawing.Point(424, 162);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(59, 17);
            this.lblDepart.TabIndex = 6;
            this.lblDepart.Text = "Départ :";
            // 
            // lblDernier
            // 
            this.lblDernier.AutoSize = true;
            this.lblDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDernier.Location = new System.Drawing.Point(424, 200);
            this.lblDernier.Name = "lblDernier";
            this.lblDernier.Size = new System.Drawing.Size(122, 17);
            this.lblDernier.TabIndex = 7;
            this.lblDernier.Text = "Dernier Passage :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(424, 242);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type transport :";
            // 
            // ListeLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDernier);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstLigne);
            this.Name = "ListeLigne";
            this.Text = "Metram Lille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLigne;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblFrequence;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblDernier;
        private System.Windows.Forms.Label lblType;
    }
}