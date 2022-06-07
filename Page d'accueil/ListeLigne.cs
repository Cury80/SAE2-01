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
        List<Bibliothèque_accès.Lignes> liste_lignes;
        
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
            }else if (sender == cmdAjouter)
            {
                Form ajout_ligne = new Page_d_accueil.FrmAjoutLigne();
                ajout_ligne.Show();
                this.Dispose();
            }else if (sender == cmdModifier)
            {
                Form modif_ligne = new Page_d_accueil.FrmModifLigne();
                modif_ligne.Show();
                //string ligne_focus = lstLigne.SelectedValue.ToString();
                this.Close();
            }
        }

        private void FrmListeLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void FrmListeLigne_Load(object sender, EventArgs e)
        {
            int ligne_panel = 0;
            liste_lignes = Bibliothèque_accès.BDD.Lecture_Ligne();
            foreach (Bibliothèque_accès.Lignes lignes in liste_lignes)
            {
                ligne_panel++;
                Ajout_label(lignes.Nom_ligne, 0, ligne_panel);
                Ajout_label(lignes.Type.ToString(), 0, ligne_panel);
            }
        }

        private void Ajout_label(string nom_ligne, int nb_ligne, int colonne)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = LblType_transport_panel.Size;
            lbl.Font = new Font(LblType_transport_panel.Font, FontStyle.Regular);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            if ( nom_ligne.ToString() == "1")
            {
                lbl.Text = "Tramway";
            }else if ( nom_ligne.ToString() == "2")
            {
                lbl.Text = "Métro";
            }
            else
            {
                lbl.Text = nom_ligne;
            }
           

            tableLayoutPanel1.Controls.Add(lbl, nb_ligne, colonne);
        }
    }
}
