namespace Page_d_accueil
{
    partial class FrmListeStation
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.lstLigne = new System.Windows.Forms.ListBox();
            this.CmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(636, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 17;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(694, 152);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 25);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom :";
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdModifier.Location = new System.Drawing.Point(699, 223);
            this.cmdModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(483, 86);
            this.cmdModifier.TabIndex = 12;
            this.cmdModifier.Text = "Modifier une station";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdSupprimer.Location = new System.Drawing.Point(699, 346);
            this.cmdSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(483, 86);
            this.cmdSupprimer.TabIndex = 11;
            this.cmdSupprimer.Text = "Supprimer une station";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAjouter.Location = new System.Drawing.Point(699, 25);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(483, 86);
            this.cmdAjouter.TabIndex = 10;
            this.cmdAjouter.Text = "Ajouter une station";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // lstLigne
            // 
            this.lstLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstLigne.FormattingEnabled = true;
            this.lstLigne.ItemHeight = 25;
            this.lstLigne.Items.AddRange(new object[] {
            "Station 1"});
            this.lstLigne.Location = new System.Drawing.Point(12, 75);
            this.lstLigne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLigne.Name = "lstLigne";
            this.lstLigne.Size = new System.Drawing.Size(659, 579);
            this.lstLigne.TabIndex = 9;
            // 
            // CmdRetour
            // 
            this.CmdRetour.FlatAppearance.BorderSize = 0;
            this.CmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRetour.Image = global::Page_d_accueil.Properties.Resources.fleche_bouton;
            this.CmdRetour.Location = new System.Drawing.Point(12, 12);
            this.CmdRetour.Name = "CmdRetour";
            this.CmdRetour.Size = new System.Drawing.Size(65, 49);
            this.CmdRetour.TabIndex = 18;
            this.CmdRetour.UseVisualStyleBackColor = true;
            this.CmdRetour.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // FrmListeStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.CmdRetour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstLigne);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListeStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metram Lille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeStation_FormClosed);
            this.Load += new System.EventHandler(this.ListeStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.ListBox lstLigne;
        private System.Windows.Forms.Button CmdRetour;
    }
}