namespace Page_d_accueil
{
    partial class ListeStation
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
            this.lblNom.Location = new System.Drawing.Point(424, 99);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom :";
            // 
            // cmdModifier
            // 
            this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdModifier.Location = new System.Drawing.Point(427, 145);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(361, 56);
            this.cmdModifier.TabIndex = 12;
            this.cmdModifier.Text = "Modifier une station";
            this.cmdModifier.UseVisualStyleBackColor = true;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdSupprimer.Location = new System.Drawing.Point(427, 225);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(361, 56);
            this.cmdSupprimer.TabIndex = 11;
            this.cmdSupprimer.Text = "Supprimer une station";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAjouter.Location = new System.Drawing.Point(427, 16);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(361, 56);
            this.cmdAjouter.TabIndex = 10;
            this.cmdAjouter.Text = "Ajouter une station";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            // 
            // lstLigne
            // 
            this.lstLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstLigne.FormattingEnabled = true;
            this.lstLigne.ItemHeight = 16;
            this.lstLigne.Items.AddRange(new object[] {
            "Station 1"});
            this.lstLigne.Location = new System.Drawing.Point(12, 15);
            this.lstLigne.Name = "lstLigne";
            this.lstLigne.Size = new System.Drawing.Size(390, 420);
            this.lstLigne.TabIndex = 9;
            // 
            // ListeStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstLigne);
            this.Name = "ListeStation";
            this.Text = "Metram Lille";
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
    }
}