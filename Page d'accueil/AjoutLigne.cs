using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Bibliothèque_accès;

namespace Page_d_accueil
{
    public partial class FrmAjoutLigne : Form
    {
        public FrmAjoutLigne()
        {
            InitializeComponent();
        }

        int fermeture = 0;

        private void AjoutLigne_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAjoutLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
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
                DialogResult message_sortie = MessageBox.Show("Voullez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (message_sortie == DialogResult.Yes)
                {
                    fermeture++;
                    Form liste_lignes = new Page_d_accueil.FrmListeLigne();
                    liste_lignes.Show();
                    this.Close();
                }
            }
            else if (sender == cmdEnregistrer)
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
                    fermeture++;
                    //MySqlCommand commande = new MySqlCommand(commande_sql, Aujout_ligne();
                    
                    bool cmd = BDD.Ajout_ligne(txtNom.Text, txtFrequence.Text, txtDépart.Text, txtDernier.Text, numero_type);
                    if (cmd == true)
                    {
                        MessageBox.Show("Ajout réussi", "Ajout ligne");
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans l'ajout de la ligne", "Erreur");
                    }
                    Form liste_ligne = new Page_d_accueil.FrmListeLigne();
                    liste_ligne.Show();
                    this.Close();
                }
            }
        }
    }
}
