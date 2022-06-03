using Carte_du_reseau;
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
    public partial class PageDaccueil : Form
    {
        public PageDaccueil()
        {
            InitializeComponent();
        }

        private void PageDaccueil_Load(object sender, EventArgs e)
        {

        }

        private void cmdCarte_Click(object sender, EventArgs e)
        {
            Form carte = new Map();
            carte.ShowDialog();
        }
    }
}
