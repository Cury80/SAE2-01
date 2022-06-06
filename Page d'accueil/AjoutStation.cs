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
    public partial class FrmAjoutStation : Form
    {
        public FrmAjoutStation()
        {
            InitializeComponent();
        }

        private void FrmAjoutStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
