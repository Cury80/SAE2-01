﻿namespace Page_d_accueil
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
            this.lstStation = new System.Windows.Forms.ListBox();
            this.CmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(424, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 17;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(463, 99);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom :";
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdModifier.Location = new System.Drawing.Point(466, 145);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(322, 56);
            this.cmdModifier.TabIndex = 12;
            this.cmdModifier.Text = "Modifier une station";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdSupprimer.Location = new System.Drawing.Point(466, 225);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(322, 56);
            this.cmdSupprimer.TabIndex = 11;
            this.cmdSupprimer.Text = "Supprimer une station";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAjouter.Location = new System.Drawing.Point(466, 16);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(322, 56);
            this.cmdAjouter.TabIndex = 10;
            this.cmdAjouter.Text = "Ajouter une station";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // lstStation
            // 
            this.lstStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstStation.FormattingEnabled = true;
            this.lstStation.ItemHeight = 16;
            this.lstStation.Location = new System.Drawing.Point(8, 49);
            this.lstStation.Name = "lstStation";
            this.lstStation.Size = new System.Drawing.Size(441, 372);
            this.lstStation.TabIndex = 9;
            // 
            // CmdRetour
            // 
            this.CmdRetour.FlatAppearance.BorderSize = 0;
            this.CmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRetour.Image = global::Page_d_accueil.Properties.Resources.fleche_bouton;
            this.CmdRetour.Location = new System.Drawing.Point(8, 8);
            this.CmdRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdRetour.Name = "CmdRetour";
            this.CmdRetour.Size = new System.Drawing.Size(43, 32);
            this.CmdRetour.TabIndex = 18;
            this.CmdRetour.UseVisualStyleBackColor = true;
            this.CmdRetour.Click += new System.EventHandler(this.CmdRetour_Click);
            // 
            // FrmListeStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdRetour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstStation);
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
        private System.Windows.Forms.ListBox lstStation;
        private System.Windows.Forms.Button CmdRetour;
    }
}