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

        private void FrmAjoutLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }




        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            
            int numero_type = 0;


            if (sender == cmdQuitter)   //si l'utilisateur veut quitter le form actif et revenir en arrière
            {
                DialogResult message_sortie = MessageBox.Show("Voullez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (message_sortie == DialogResult.Yes)
                {
                    fermeture++;
                    this.Close();
                }
            }
            else if (sender == cmdEnregistrer)  //l'utilisateur veut enregistrer l'ajout d'une ligne
            {
                
                if (cmbMetroTramway.Text == "Métro")
                {
                    numero_type = 2;
                }else if (cmbMetroTramway.Text == "Tramway")
                {
                    numero_type = 1;
                }
                

                fermeture++;
                try
                {
                bool cmd = BDD.Ajout_ligne(txtNom.Text, TimeSpan.Parse(txtFrequence.Text), TimeSpan.Parse(txtDépart.Text), TimeSpan.Parse(txtDernier.Text), numero_type);
                   if (cmd == true)
                   {
                   MessageBox.Show("Ajout réussi", "Ajout ligne");
                   }
                   else
                   {
                       MessageBox.Show("Erreur dans l'ajout de la ligne", "Erreur");
                   }
                        this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur dans l'entrée des valeurs, Pour la fréquence, heure de départ et heure de dernier passage veuillez mettre en format hh:mm:ss", "Message");
                }
                
            }
        }
    }
}
