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
    public partial class FrmListeLigne : Form
    {
        
        public FrmListeLigne()
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
            }
            else if (sender == cmdAjouter)
            {
                Form ajout_ligne = new Page_d_accueil.FrmAjoutLigne();
                ajout_ligne.ShowDialog();
            }
            else if (sender == cmdModifier)
            {
                Form modif_ligne = new Page_d_accueil.FrmModifLigne(Bibliothèque_accès.BDD.Lecture_NomLigne(lstLigne.SelectedItem.ToString()), Bibliothèque_accès.BDD.Lecture_frequence(lstLigne.SelectedItem.ToString()),
                    Bibliothèque_accès.BDD.Lecture_depart(lstLigne.SelectedItem.ToString()), Bibliothèque_accès.BDD.Lecture_heureDernierDepart(lstLigne.SelectedItem.ToString()), Bibliothèque_accès.BDD.Lecture_TypeTransport(lstLigne.SelectedItem.ToString()));
                modif_ligne.Owner = this;
                modif_ligne.ShowDialog();
            }
            else if (sender == cmdSupprimer)
            {
                bool reponse;
                string nomLigne;
                nomLigne = lstLigne.SelectedItem.ToString();
                reponse = Bibliothèque_accès.BDD.Supp_ligne(nomLigne);

                if (reponse == true)
                {
                    lstLigne.Items.Clear();
                    lecteurListe.Clear();
                    MessageBox.Show("Supression réussi", "Message");
                    lecteurListe = Bibliothèque_accès.BDD.Lecture_Ligne();
                }
                else 
                {
                    MessageBox.Show("erreur", "Message d'erreur");
                }
            }
        }


        private void FrmListeLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == true)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void lstLigne_SelectedValueChanged(object sender, EventArgs e)
        { 

            if (lstLigne.SelectedItem != null)
            {
                lblNom.Text = $"Nom : {Bibliothèque_accès.BDD.Lecture_NomLigne(lstLigne.SelectedItem.ToString())}";
                lblFrequence.Text = $"Fréquence : {Bibliothèque_accès.BDD.Lecture_frequence(lstLigne.SelectedItem.ToString())}";
                lblDepart.Text = $"Départ : {Bibliothèque_accès.BDD.Lecture_depart(lstLigne.SelectedItem.ToString())}";
                lblDernier.Text = $"Dernier Passage : {Bibliothèque_accès.BDD.Lecture_heureDernierDepart(lstLigne.SelectedItem.ToString())}";
                lblType.Text = $"Type Transport : {Bibliothèque_accès.BDD.Lecture_TypeTransport(lstLigne.SelectedItem.ToString())}";
                cmdSupprimer.Enabled = true;
                cmdModifier.Enabled = true;
            }
           
        }

        List<string> lecteurListe;

        private void FrmListeLigne_Activated(object sender, EventArgs e)
        {
            cmdModifier.Enabled = false;
            cmdSupprimer.Enabled = false;

            fermeture = true;
            if (lecteurListe != null)
            {
                lecteurListe.Clear();
            }
            

            lecteurListe = Bibliothèque_accès.BDD.Lecture_Ligne();
            lstLigne.Items.Clear();
            

            foreach (string ligne in lecteurListe)
            {
                lstLigne.Items.Add(ligne);
            }
        }
    }
}
