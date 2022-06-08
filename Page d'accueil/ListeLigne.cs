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
    public partial class FrmListeLigne : Form
    {
        
        public FrmListeLigne()
        {
            InitializeComponent();
        }

        int fermeture = 0;

        private void CmdRetour_Click(object sender, EventArgs e)
        {
            fermeture = 1;
            if (sender == CmdRetour)
            {
                Form ligne_station = new Page_d_accueil.FrmLigneOuStation();
                ligne_station.Show();
                this.Dispose();
            }
            else if (sender == cmdAjouter)
            {
                Form ajout_ligne = new Page_d_accueil.FrmAjoutLigne();
                ajout_ligne.Show();
                this.Dispose();
            }
            else if (sender == cmdModifier)
            {
                Form modif_ligne = new Page_d_accueil.FrmModifLigne();
                modif_ligne.Owner = this;
                modif_ligne.Show();
                //string ligne_focus = lstLigne.SelectedValue.ToString();
                this.Hide();
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

                    foreach (string ligne in lecteurListe)
                    {
                        lstLigne.Items.Add(ligne);
                    }
                }
                else 
                {
                    MessageBox.Show("erreur", "Message d'erreur");
                }
            }
        }

        private void FrmListeLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }

        List<string> lecteurListe;

        private void FrmListeLigne_Load(object sender, EventArgs e)
        {
            lecteurListe = Bibliothèque_accès.BDD.Lecture_Ligne();
            
            foreach(string ligne in lecteurListe)
            {
                lstLigne.Items.Add(ligne);
            }
        }

        
        private void lstLigne_SelectedValueChanged(object sender, EventArgs e)
        {
            lblNom.Text = Bibliothèque_accès.BDD.Lecture_NomLigne(lstLigne.SelectedItems.ToString());
            
            
            //lblDepart;
            //lblFrequence;
            //lblDernier;
            //lblType
        }
    }
}
