﻿namespace Page_d_accueil
{
    partial class AjoutLigne
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFrequence = new System.Windows.Forms.TextBox();
            this.txtDernier = new System.Windows.Forms.TextBox();
            this.txtDépart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(260, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajouter une ligne";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdEnregistrer.Location = new System.Drawing.Point(482, 358);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(108, 49);
            this.cmdEnregistrer.TabIndex = 37;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdQuitter.Location = new System.Drawing.Point(623, 358);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(108, 49);
            this.cmdQuitter.TabIndex = 36;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
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
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(152, 297);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(612, 20);
            this.txtType.TabIndex = 30;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(152, 97);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(612, 20);
            this.txtNom.TabIndex = 29;
            // 
            // txtFrequence
            // 
            this.txtFrequence.Location = new System.Drawing.Point(152, 147);
            this.txtFrequence.Name = "txtFrequence";
            this.txtFrequence.Size = new System.Drawing.Size(612, 20);
            this.txtFrequence.TabIndex = 28;
            // 
            // txtDernier
            // 
            this.txtDernier.Location = new System.Drawing.Point(152, 247);
            this.txtDernier.Name = "txtDernier";
            this.txtDernier.Size = new System.Drawing.Size(612, 20);
            this.txtDernier.TabIndex = 27;
            // 
            // txtDépart
            // 
            this.txtDépart.Location = new System.Drawing.Point(152, 197);
            this.txtDépart.Name = "txtDépart";
            this.txtDépart.Size = new System.Drawing.Size(612, 20);
            this.txtDépart.TabIndex = 26;
            // 
            // AjoutLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdEnregistrer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblDernier);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtFrequence);
            this.Controls.Add(this.txtDernier);
            this.Controls.Add(this.txtDépart);
            this.Controls.Add(this.label1);
            this.Name = "AjoutLigne";
            this.Text = "Metram Lille";
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
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFrequence;
        private System.Windows.Forms.TextBox txtDernier;
        private System.Windows.Forms.TextBox txtDépart;
    }
}