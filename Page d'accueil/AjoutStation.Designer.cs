namespace Page_d_accueil
{
    partial class FrmAjoutStation
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdEnregistrer.Location = new System.Drawing.Point(741, 557);
            this.cmdEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(162, 75);
            this.cmdEnregistrer.TabIndex = 38;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdQuitter.Location = new System.Drawing.Point(952, 557);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(162, 75);
            this.cmdQuitter.TabIndex = 37;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNom.Location = new System.Drawing.Point(18, 155);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 25);
            this.lblNom.TabIndex = 32;
            this.lblNom.Text = "Nom :";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblStation.Location = new System.Drawing.Point(387, 60);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(450, 58);
            this.lblStation.TabIndex = 31;
            this.lblStation.Text = "Ajouter une Station";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(94, 155);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(1068, 26);
            this.txtNom.TabIndex = 29;
            // 
            // FrmAjoutStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cmdEnregistrer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.txtNom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAjoutStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAjoutStation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEnregistrer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtNom;
    }
}