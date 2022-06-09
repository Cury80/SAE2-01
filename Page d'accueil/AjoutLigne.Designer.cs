namespace Page_d_accueil
{
    partial class FrmAjoutLigne
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdEnregistrer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblDernier = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblFrequence = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFrequence = new System.Windows.Forms.TextBox();
            this.txtDernier = new System.Windows.Forms.TextBox();
            this.txtDépart = new System.Windows.Forms.TextBox();
            this.cmbMetroTramway = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(260, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajouter une ligne";
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdEnregistrer.Location = new System.Drawing.Point(482, 358);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(108, 49);
            this.cmdEnregistrer.TabIndex = 6;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            this.cmdEnregistrer.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdQuitter.Location = new System.Drawing.Point(623, 358);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(108, 49);
            this.cmdQuitter.TabIndex = 5;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTransport.Location = new System.Drawing.Point(12, 298);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(134, 17);
            this.lblTransport.TabIndex = 35;
            this.lblTransport.Text = "Type de Transport :";
            // 
            // lblDernier
            // 
            this.lblDernier.AutoSize = true;
            this.lblDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDernier.Location = new System.Drawing.Point(24, 247);
            this.lblDernier.Name = "lblDernier";
            this.lblDernier.Size = new System.Drawing.Size(122, 17);
            this.lblDernier.TabIndex = 34;
            this.lblDernier.Text = "Dernier Passage :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDepart.Location = new System.Drawing.Point(87, 197);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(59, 17);
            this.lblDepart.TabIndex = 33;
            this.lblDepart.Text = "Départ :";
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrequence.Location = new System.Drawing.Point(62, 147);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(84, 17);
            this.lblFrequence.TabIndex = 32;
            this.lblFrequence.Text = "Fréquence :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(101, 97);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 31;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(152, 97);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(612, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.Validated += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // txtFrequence
            // 
            this.txtFrequence.Location = new System.Drawing.Point(152, 147);
            this.txtFrequence.MaxLength = 8;
            this.txtFrequence.Name = "txtFrequence";
            this.txtFrequence.Size = new System.Drawing.Size(612, 20);
            this.txtFrequence.TabIndex = 1;
            this.txtFrequence.Validated += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // txtDernier
            // 
            this.txtDernier.Location = new System.Drawing.Point(152, 247);
            this.txtDernier.MaxLength = 8;
            this.txtDernier.Name = "txtDernier";
            this.txtDernier.Size = new System.Drawing.Size(612, 20);
            this.txtDernier.TabIndex = 3;
            this.txtDernier.Validated += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // txtDépart
            // 
            this.txtDépart.Location = new System.Drawing.Point(152, 197);
            this.txtDépart.MaxLength = 8;
            this.txtDépart.Name = "txtDépart";
            this.txtDépart.Size = new System.Drawing.Size(612, 20);
            this.txtDépart.TabIndex = 2;
            this.txtDépart.Validated += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmbMetroTramway
            // 
            this.cmbMetroTramway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetroTramway.FormattingEnabled = true;
            this.cmbMetroTramway.Items.AddRange(new object[] {
            "Métro",
            "Tramway"});
            this.cmbMetroTramway.Location = new System.Drawing.Point(152, 297);
            this.cmbMetroTramway.Name = "cmbMetroTramway";
            this.cmbMetroTramway.Size = new System.Drawing.Size(612, 21);
            this.cmbMetroTramway.TabIndex = 4;
            // 
            // FrmAjoutLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMetroTramway);
            this.Controls.Add(this.cmdEnregistrer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblDernier);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtFrequence);
            this.Controls.Add(this.txtDernier);
            this.Controls.Add(this.txtDépart);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metram Lille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAjoutLigne_FormClosed);
            this.Load += new System.EventHandler(this.AjoutLigne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdEnregistrer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblDernier;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblFrequence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFrequence;
        private System.Windows.Forms.TextBox txtDernier;
        private System.Windows.Forms.TextBox txtDépart;
        private System.Windows.Forms.ComboBox cmbMetroTramway;
    }
}