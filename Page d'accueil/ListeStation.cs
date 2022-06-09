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
    public partial class FrmListeStation : Form
    {
        public FrmListeStation()
        {
            InitializeComponent();
        }

        bool fermeture = true;


        private void CmdRetour_Click(object sender, EventArgs e)
        {
            fermeture = false;
            if (sender == CmdRetour)
            {
                
                Form ligne_station = new Page_d_accueil.FrmLigneOuStation();
                ligne_station.Show();
                this.Close();

            }else if (sender == cmdAjouter)
            {
                Form ajout_station = new Page_d_accueil.FrmAjoutStation();
                ajout_station.ShowDialog();

            }else if (sender == cmdModifier)
            {
                Form modif_station = new Page_d_accueil.FrmModifStation(lstStation.SelectedItem.ToString());
                modif_station.ShowDialog();
            }
            else if (sender == cmdSupprimer)
            {
                bool reponse;
                string nomStation;
                nomStation = lstStation.SelectedItem.ToString();
                reponse = Bibliothèque_accès.BDD.Supp_station(nomStation);

                if (reponse == true)
                {
                    lstStation.Items.Clear();
                    lecteurListe.Clear();
                    MessageBox.Show("Supression réussi", "Message");
                    lecteurListe = Bibliothèque_accès.BDD.Lecture_Station();

                    foreach (string station in lecteurListe)
                    {
                        lstStation.Items.Add(station);
                    }
                }
                else
                {
                    MessageBox.Show("erreur", "Message d'erreur");
                }
            }
        }

        private void FrmListeStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == true)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void lstStation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstStation.SelectedItem != null)
            {
                lblNom.Text = $"Nom : {Bibliothèque_accès.BDD.Lecture_NomStation(lstStation.SelectedItem.ToString())}";
                cmdModifier.Enabled = true;
                cmdSupprimer.Enabled = true;
            }
        }


        List<string> lecteurListe;
        private void FrmListeStation_Activated(object sender, EventArgs e)
        {
            fermeture = true;
            cmdModifier.Enabled = false;
            cmdSupprimer.Enabled = false;
            lblNom.Text = "Nom :";

            lecteurListe = Bibliothèque_accès.BDD.Lecture_Station();
            lstStation.Items.Clear();

            foreach (string station in lecteurListe)
            {
                lstStation.Items.Add(station);
            }
        }
    }
}
