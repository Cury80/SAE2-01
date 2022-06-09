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
        string ancien_nom_station;
        public FrmModifStation(string nom_station)
        {
            InitializeComponent();
            txtNom.Text = nom_station;
            ancien_nom_station = nom_station;
        }
        private void ModifStation_Load(object sender, EventArgs e)
        {
            string ancien_nom_station = txtNom.Text;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {

            if (sender == cmdQuitter)
            {
                DialogResult message_sortie = MessageBox.Show("Voullez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (message_sortie == DialogResult.Yes)
                {
                    this.Close();
                }
            }else if (sender == cmdEnregistrer)
            {
                try
                {
                    bool reponse = Bibliothèque_accès.BDD.Modif_Station(txtNom.Text, ancien_nom_station);
                    if (reponse == true)
                    {
                        MessageBox.Show("Modification réussi", "Message");

                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la modification de la station", "Message");
                    }
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur dans la modification de la station");
                }
            }

        }
    }
}
