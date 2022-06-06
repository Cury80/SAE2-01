namespace Page_d_accueil
{
    partial class FrmModifLigne
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
            this.cmdEnregistrer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblDernier = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblFrequence = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblModif = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFrequence = new System.Windows.Forms.TextBox();
            this.txtDernier = new System.Windows.Forms.TextBox();
            this.txtDépart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdEnregistrer.Location = new System.Drawing.Point(722, 548);
            this.cmdEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(162, 75);
            this.cmdEnregistrer.TabIndex = 25;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdQuitter.Location = new System.Drawing.Point(933, 548);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(162, 75);
            this.cmdQuitter.TabIndex = 24;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTransport.Location = new System.Drawing.Point(14, 457);
            this.lblTransport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(184, 25);
            this.lblTransport.TabIndex = 23;
            this.lblTransport.Text = "Type de Transport :";
            // 
            // lblDernier
            // 
            this.lblDernier.AutoSize = true;
            this.lblDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDernier.Location = new System.Drawing.Point(32, 378);
            this.lblDernier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDernier.Name = "lblDernier";
            this.lblDernier.Size = new System.Drawing.Size(168, 25);
            this.lblDernier.TabIndex = 22;
            this.lblDernier.Text = "Dernier Passage :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDepart.Location = new System.Drawing.Point(126, 302);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(81, 25);
            this.lblDepart.TabIndex = 21;
            this.lblDepart.Text = "Départ :";
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrequence.Location = new System.Drawing.Point(88, 225);
            this.lblFrequence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(117, 25);
            this.lblFrequence.TabIndex = 20;
            this.lblFrequence.Text = "Fréquence :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(147, 148);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 25);
            this.lblNom.TabIndex = 19;
            this.lblNom.Text = "Nom :";
            // 
            // lblModif
            // 
            this.lblModif.AutoSize = true;
            this.lblModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblModif.Location = new System.Drawing.Point(376, 35);
            this.lblModif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModif.Name = "lblModif";
            this.lblModif.Size = new System.Drawing.Size(420, 58);
            this.lblModif.TabIndex = 18;
            this.lblModif.Text = "Modifier une ligne";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(224, 455);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(916, 26);
            this.txtType.TabIndex = 35;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(224, 148);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(916, 26);
            this.txtNom.TabIndex = 34;
            // 
            // txtFrequence
            // 
            this.txtFrequence.Location = new System.Drawing.Point(224, 225);
            this.txtFrequence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrequence.Name = "txtFrequence";
            this.txtFrequence.Size = new System.Drawing.Size(916, 26);
            this.txtFrequence.TabIndex = 33;
            // 
            // txtDernier
            // 
            this.txtDernier.Location = new System.Drawing.Point(224, 378);
            this.txtDernier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDernier.Name = "txtDernier";
            this.txtDernier.Size = new System.Drawing.Size(916, 26);
            this.txtDernier.TabIndex = 32;
            // 
            // txtDépart
            // 
            this.txtDépart.Location = new System.Drawing.Point(224, 302);
            this.txtDépart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDépart.Name = "txtDépart";
            this.txtDépart.Size = new System.Drawing.Size(916, 26);
            this.txtDépart.TabIndex = 31;
            // 
            // FrmModifLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtFrequence);
            this.Controls.Add(this.txtDernier);
            this.Controls.Add(this.txtDépart);
            this.Controls.Add(this.cmdEnregistrer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblDernier);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblModif);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModifLigne";
            this.Text = "Metram Lille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModifLigne_FormClosed);
            this.Load += new System.EventHandler(this.FrmModifLigne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEnregistrer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblDernier;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblFrequence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblModif;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFrequence;
        private System.Windows.Forms.TextBox txtDernier;
        private System.Windows.Forms.TextBox txtDépart;
    }
}