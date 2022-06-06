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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["PageDaccueil"].Show();
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Form gestion = new Map();
                gestion.Show();
            }
        }
    }
}
