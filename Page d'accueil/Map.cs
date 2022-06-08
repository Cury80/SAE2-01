using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carte_du_reseau
{
    public partial class FrmMap : Form
    {
        public FrmMap()
        {
            InitializeComponent();
            
        }
        int fermeture = 0;

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fermeture % 2 == 0)
            {
                Application.OpenForms[0].Close();
            }
            

        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            try
            {
                fermeture++;
                this.Close();
                Application.OpenForms[0].Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Form gestion = new FrmMap();
                gestion.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
