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
    public partial class FrmListeStation : Form
    {
        public FrmListeStation()
        {
            InitializeComponent();
        }

        int fermeture = 0;
        private void ListeStation_Load(object sender, EventArgs e)
        {

        }

        private void CmdRetour_Click(object sender, EventArgs e)
        {
            fermeture++;
            if (sender == CmdRetour)
            {
                
                Form ligne_station = new Page_d_accueil.FrmLigneOuStation();
                ligne_station.Show();
                this.Dispose();
            }else if (sender == cmdAjouter)
            {
                Form ajout_station = new Page_d_accueil.FrmAjoutStation();
                ajout_station.Show();
                this.Close();
            }else if (sender == cmdModifier)
            {
                Form modif_station = new Page_d_accueil.FrmModifStation();
                modif_station.Show();
                this.Close();
            }
        }

        private void FrmListeStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
