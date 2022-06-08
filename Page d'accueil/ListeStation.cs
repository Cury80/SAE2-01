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

        int fermeture = 0;

        List<string> lecteurListe;
        private void ListeStation_Load(object sender, EventArgs e)
        {
            lecteurListe = Bibliothèque_accès.BDD.Lecture_Station();

            foreach (string station in lecteurListe)
            {
                lstStation.Items.Add(station);
            }
        }

        private void CmdRetour_Click(object sender, EventArgs e)
        {
            fermeture++;
            if (sender == CmdRetour)
            {
                
                Form ligne_station = new Page_d_accueil.FrmLigneOuStation();
                ligne_station.Show();
                this.Dispose();
            }else if (sender == cmdAjouter)
            {
                Form ajout_station = new Page_d_accueil.FrmAjoutStation();
                ajout_station.Show();
                this.Close();
            }else if (sender == cmdModifier)
            {
                Form modif_station = new Page_d_accueil.FrmModifStation();
                modif_station.Show();
                this.Hide();
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
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
