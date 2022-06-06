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
    public partial class FrmModifStation : Form
    {
        public FrmModifStation()
        {
            InitializeComponent();
        }

        int fermeture = 0;

        private void ModifStation_Load(object sender, EventArgs e)
        {

        }

        private void FrmModifStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            DialogResult message_sortie = MessageBox.Show("Voullez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
            if (message_sortie == DialogResult.Yes)
            {
                fermeture++;
                Form liste_station = new Page_d_accueil.FrmListeStation();
                liste_station.Show();
                this.Close();
            }
        }
    }
}
