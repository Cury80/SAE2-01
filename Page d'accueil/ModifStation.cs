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
    public partial class FrmModifStation : Form
    {
        public FrmModifStation()
        {
            InitializeComponent();
        }

        private void ModifStation_Load(object sender, EventArgs e)
        {

        }

        private void FrmModifStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
