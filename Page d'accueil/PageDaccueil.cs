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

        private void cmdItinéraire_Click(object sender, EventArgs e)
        {
            if (sender == cmdItinéraire)
            {
                Form Itineraire = new Calculateur_d_itinéraire.Calculitineraire();
                this.Hide();
                Itineraire.Show();
            }
            else if (sender == cmdCarte)
            {
                Form carte = new Map();
                this.Hide();
                carte.Show();
            }
            else if (sender == cmdGerer)
            {
                Form gestion_appli = new Gerer_le_reseau.GererReseau();
                this.Hide();
                gestion_appli.Show();
            }

        }
    }
}
