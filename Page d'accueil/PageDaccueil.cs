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
    public partial class FrmPageDaccueil : Form
    {
        public FrmPageDaccueil()
        {
            InitializeComponent();
        }

        private void cmdItinéraire_Click(object sender, EventArgs e)
        {
            if (sender == cmdItinéraire)
            {
                Form Itineraire = new Calculateur_d_itinéraire.FrmCalculitineraire();
                this.Hide();
                Itineraire.Show();
            }
            else if (sender == cmdCarte)
            {
                Form carte = new FrmMap();
                this.Hide();
                carte.Show();
            }
            else if (sender == cmdGerer)
            {
                Form gestion_appli = new Gerer_le_reseau.FrmGererReseau();
                this.Hide();
                gestion_appli.Show();
            }
        }

        private void FrmPageDaccueil_Load(object sender, EventArgs e)
        {
            bool connexion = Bibliothèque_accès.BDD.initConnexion();
            if (connexion == true)
            {
                LblConnexion.Text = "Connexion au serveur réussie";

            }
            else
            {
                LblConnexion.Text = "Echec de la connexion à la base";
            }
        }

        private void FrmPageDaccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool fermeture = Bibliothèque_accès.BDD.FermerConnexion();
            if (fermeture == true)
            {
                MessageBox.Show("Déconnexion réussi à la base", "Fermeture");
            }
            else
            {
                MessageBox.Show("Echech de la deconnexion");
            }
        }
    }
}
