using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerer_le_reseau
{
    
    public partial class GererReseau : Form
    {
        public GererReseau()
        {
            InitializeComponent();
            Owner = Application.OpenForms["PageDaccueil"];
            
            
        }

        private void GererReseau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["PageDaccueil"].Show();
        }

        private void GererReseau_Load(object sender, EventArgs e)
        {

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
                Form gestion = new GererReseau();
                gestion.Show();
            }
        }
    }
}
