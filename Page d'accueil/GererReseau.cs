using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerer_le_reseau
{
    
    public partial class FrmGererReseau : Form
    {
        public FrmGererReseau()
        {
            InitializeComponent();
        }

        int fermeture = 0;
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            try
            {
                fermeture = 1;
                Application.OpenForms[0].Show();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Form gestion = new FrmGererReseau();
                gestion.Show();
            }
        }

        private void CmdConnexion_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int nb_erreurs = 0;

            if (string.IsNullOrEmpty(TxtPseudo.Text) == true)
            {
                nb_erreurs++;
                errorProvider1.SetError(TxtPseudo, "Veuillez rentrer votre identifiant");
            }else if (TxtPseudo.Text != "Admin")
            {
                nb_erreurs++;
                errorProvider1.SetError(TxtPseudo, "Nom d'utilisateur invalide (Admin)");
            }

            if (string.IsNullOrEmpty(TxtMdp.Text) == true)
            {
                nb_erreurs++;
                errorProvider1.SetError(TxtMdp, "Veuillez rentrer votre mot de passe");
            }else if (TxtMdp.Text != "Admin")
            {
                nb_erreurs++;
                errorProvider1.SetError(TxtMdp, "Mot de passe incorrect (Admin)");
            }

            if (nb_erreurs == 0)
            {
                fermeture++; ;
                Form LigneStation = new Page_d_accueil.FrmLigneOuStation();
                LigneStation.Show();
                this.Close();
            }
        }


        private void FrmGererReseau_Load(object sender, EventArgs e)
        {

        }

        private void FrmGererReseau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
