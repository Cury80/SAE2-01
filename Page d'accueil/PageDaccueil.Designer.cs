﻿
namespace Page_d_accueil
{
    partial class PageDaccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdItinéraire = new System.Windows.Forms.Button();
            this.cmdCarte = new System.Windows.Forms.Button();
            this.cmdGerer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(171, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue sur le réseau Metram Lille";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(277, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Que souhaitez-vous faire ?";
            // 
            // cmdItinéraire
            // 
            this.cmdItinéraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdItinéraire.Location = new System.Drawing.Point(156, 226);
            this.cmdItinéraire.Name = "cmdItinéraire";
            this.cmdItinéraire.Size = new System.Drawing.Size(187, 54);
            this.cmdItinéraire.TabIndex = 2;
            this.cmdItinéraire.Text = "Rechercher un Itinéraire";
            this.cmdItinéraire.UseVisualStyleBackColor = true;
            // 
            // cmdCarte
            // 
            this.cmdCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdCarte.Location = new System.Drawing.Point(458, 226);
            this.cmdCarte.Name = "cmdCarte";
            this.cmdCarte.Size = new System.Drawing.Size(187, 54);
            this.cmdCarte.TabIndex = 3;
            this.cmdCarte.Text = "Afficher la carte";
            this.cmdCarte.UseVisualStyleBackColor = true;
            this.cmdCarte.Click += new System.EventHandler(this.cmdCarte_Click);
            // 
            // cmdGerer
            // 
            this.cmdGerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdGerer.Location = new System.Drawing.Point(307, 327);
            this.cmdGerer.Name = "cmdGerer";
            this.cmdGerer.Size = new System.Drawing.Size(187, 54);
            this.cmdGerer.TabIndex = 4;
            this.cmdGerer.Text = "Gérer le réseau";
            this.cmdGerer.UseVisualStyleBackColor = true;
            // 
            // PageDaccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdGerer);
            this.Controls.Add(this.cmdCarte);
            this.Controls.Add(this.cmdItinéraire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageDaccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metram Lille";
            this.Load += new System.EventHandler(this.PageDaccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdItinéraire;
        private System.Windows.Forms.Button cmdCarte;
        private System.Windows.Forms.Button cmdGerer;
    }
}

