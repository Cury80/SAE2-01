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
    public partial class FrmAjoutLigne : Form
    {
        public FrmAjoutLigne()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutLigne_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAjoutLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            int nb_erreurs = 0;
            int numero_type = 0;
            if (sender == cmdQuitter)
            {
                Form liste_ligne = new Page_d_accueil.FrmListeLigne();
                liste_ligne.Show();
                this.Close();
            }else if (sender == cmdEnregistrer)
            {
                if (txtType.Text.ToLower() == "métro")
                {
                    numero_type = 2;
                }else if (txtType.Text.ToLower() == "tramway" || txtType.Text.ToLower() == "tram")
                {
                    numero_type = 1;
                }
                else
                {
                    nb_erreurs++;
                    errorProvider1.SetError(lblTransport, "Veuillez écrire soit Métro soit Tramway");
                }

                if (nb_erreurs == 0)
                {
                    //string commande_sql = $"insert into ligne (nomligne, frequence, heureDeDepart, HeureDeDernierPassage, n_type) values ('{txtNom.Text}', '{txtFrequence.Text}', '{lblDepart.Text}', '{lblDernier.Text}', '{lblTransport.Text}')";
                }
            }
        }
    }
}
