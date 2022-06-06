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
    public partial class FrmListeLigne : Form
    {
        
        public FrmListeLigne()
        {
            InitializeComponent();
        }

        int fermeture = 0;

        private void ListeLigne_Load(object sender, EventArgs e)
        {

        }

        private void CmdRetour_Click(object sender, EventArgs e)
        {
            fermeture = 1;
            if (sender == CmdRetour)
            {
                Form ligne_station = new Page_d_accueil.FrmLigneOuStation();
                ligne_station.Show();
                this.Dispose();
            }else if (sender == cmdAjouter)
            {
                Form ajout_ligne = new Page_d_accueil.FrmAjoutLigne();
                ajout_ligne.Show();
                this.Dispose();
            }else if (sender == cmdModifier)
            {
                Form modif_ligne = new Page_d_accueil.FrmModifLigne();
                modif_ligne.Show();
                //string ligne_focus = lstLigne.SelectedValue.ToString();
                this.Close();
            }
        }

        private void FrmListeLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
