﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page_d_accueil
{
    public partial class FrmAjoutStation : Form
    {
        public FrmAjoutStation()
        {
            InitializeComponent();
        }

        int fermeture = 0;

        private void FrmAjoutStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (sender == cmdQuitter)
            {
                DialogResult message_sortie = MessageBox.Show("Voullez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (message_sortie == DialogResult.Yes)
                {
                    fermeture++;
                    this.Close();
                }
                
            }else if (sender == cmdEnregistrer)
            {
                bool reponse = Bibliothèque_accès.BDD.Ajout_station(txtNom.Text);
                fermeture++;

                if (reponse)
                {
                    MessageBox.Show("Ajout de la station réussi", "Message système");
                    
                }
                else
                {
                    MessageBox.Show("Echec de l'ajout de la station ", "Message système");
                }
                this.Close();
            }
        }

        private void FrmAjoutStation_Load(object sender, EventArgs e)
        {

        }
    }
}
