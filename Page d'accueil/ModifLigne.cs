using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page_d_accueil
{
    public partial class FrmModifLigne : Form
    {
        string ancienNom;
        public FrmModifLigne(string nomText, string frequence, string depart, string dernier, string type)
        {
            InitializeComponent();
            txtNom.Text = nomText;
            txtFrequence.Text = frequence;
            txtDépart.Text = depart;
            txtDernier.Text = dernier;
            ancienNom = nomText;
            if (type == "Metro")
            {
                cmbType.Text = "Métro";
            }
            else
            {
                cmbType.Text = type;
            }
        }


     

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            int numeroType = 0;

            if (sender == cmdQuitter)
            {
                DialogResult message_sortie = MessageBox.Show("Voulez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (message_sortie == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (sender == cmdEnregistrer)
            {

                if (cmbType.Text == "Métro")
                {
                    numeroType = 2;
                }
                else if (cmbType.Text == "Tramway")
                {
                    numeroType = 1;
                }

                try
                {
                    bool cmd = Bibliothèque_accès.BDD.Modifier_Ligne(txtNom.Text, TimeSpan.Parse(txtFrequence.Text), TimeSpan.Parse(txtDépart.Text), TimeSpan.Parse(txtDernier.Text), numeroType, ancienNom);
                    if (cmd == true)
                    {
                        MessageBox.Show("Modification réussi", "Message");
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la modification de la ligne", "Message");
                    }
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Erreur dans l'entrée des valeurs, Pour la fréquence, heure de départ et heure de dernier passage veuillez mettre en format hh:mm:ss", "Message");
                }
            }    

        }
    }
}
