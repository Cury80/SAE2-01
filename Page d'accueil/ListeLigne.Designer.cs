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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNom_panel = new System.Windows.Forms.Label();
            this.LblType_transport_panel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAjouter.Location = new System.Drawing.Point(720, 20);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(462, 86);
            this.cmdAjouter.TabIndex = 1;
            this.cmdAjouter.Text = "Ajouter une ligne";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdSupprimer.Location = new System.Drawing.Point(720, 578);
            this.cmdSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(462, 86);
            this.cmdSupprimer.TabIndex = 2;
            this.cmdSupprimer.Text = "Supprimer une ligne";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdModifier.Location = new System.Drawing.Point(720, 468);
            this.cmdModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(462, 86);
            this.cmdModifier.TabIndex = 3;
            this.cmdModifier.Text = "Modifier une ligne";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(715, 138);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 25);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrequence.Location = new System.Drawing.Point(715, 194);
            this.lblFrequence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(117, 25);
            this.lblFrequence.TabIndex = 5;
            this.lblFrequence.Text = "Fréquence :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDepart.Location = new System.Drawing.Point(715, 249);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(81, 25);
            this.lblDepart.TabIndex = 6;
            this.lblDepart.Text = "Départ :";
            // 
            // lblDernier
            // 
            this.lblDernier.AutoSize = true;
            this.lblDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDernier.Location = new System.Drawing.Point(715, 308);
            this.lblDernier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDernier.Name = "lblDernier";
            this.lblDernier.Size = new System.Drawing.Size(168, 25);
            this.lblDernier.TabIndex = 7;
            this.lblDernier.Text = "Dernier Passage :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(715, 372);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(149, 25);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type transport :";
            // 
            // CmdRetour
            // 
            this.CmdRetour.FlatAppearance.BorderSize = 0;
            this.CmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRetour.Image = global::Page_d_accueil.Properties.Resources.fleche_bouton;
            this.CmdRetour.Location = new System.Drawing.Point(12, 12);
            this.CmdRetour.Name = "CmdRetour";
            this.CmdRetour.Size = new System.Drawing.Size(65, 49);
            this.CmdRetour.TabIndex = 9;
            this.CmdRetour.UseVisualStyleBackColor = true;
            this.CmdRetour.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tableLayoutPanel1.Controls.Add(this.LblNom_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblType_transport_panel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.70548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.29452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 584);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // LblNom_panel
            // 
            this.LblNom_panel.AutoSize = true;
            this.LblNom_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblNom_panel.Location = new System.Drawing.Point(3, 0);
            this.LblNom_panel.Name = "LblNom_panel";
            this.LblNom_panel.Size = new System.Drawing.Size(146, 25);
            this.LblNom_panel.TabIndex = 11;
            this.LblNom_panel.Text = "Nom de la ligne";
            this.LblNom_panel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblType_transport_panel
            // 
            this.LblType_transport_panel.AutoSize = true;
            this.LblType_transport_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblType_transport_panel.Location = new System.Drawing.Point(238, 0);
            this.LblType_transport_panel.Name = "LblType_transport_panel";
            this.LblType_transport_panel.Size = new System.Drawing.Size(165, 25);
            this.LblType_transport_panel.TabIndex = 12;
            this.LblType_transport_panel.Text = "Type de transport";
            this.LblType_transport_panel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmListeLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CmdRetour);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDernier);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListeLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metram Lille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeLigne_FormClosed);
            this.Load += new System.EventHandler(this.FrmListeLigne_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblFrequence;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblDernier;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button CmdRetour;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblNom_panel;
        private System.Windows.Forms.Label LblType_transport_panel;
    }
}