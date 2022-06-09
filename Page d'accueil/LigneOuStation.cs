using System;
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
    public partial class FrmLigneOuStation : Form
    {
        public FrmLigneOuStation()
        {
            InitializeComponent();
        }



        int fermeture = 0;
        private void LigneOuStation_Load(object sender, EventArgs e)
        {

        }

        private void CmdRetour_Click(object sender, EventArgs e)
        {
            try
            {
                fermeture++;
                Form gestion = new Gerer_le_reseau.FrmGererReseau();
                gestion.Show();
                this.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Form lignestation = new Page_d_accueil.FrmLigneOuStation();
                lignestation.Show();
            }
        }

        private void cmdLignes_Click(object sender, EventArgs e)
        {
            if (sender == cmdLignes)
            {
                fermeture++;
                Form lignes = new Page_d_accueil.FrmListeLigne();
                lignes.Show();
                this.Dispose();
            }else if (sender == cmdStations)
            {
                fermeture++;
                Form station = new Page_d_accueil.FrmListeStation();
                station.Show();
                this.Dispose();
            }
        }

        private void FrmLigneOuStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
