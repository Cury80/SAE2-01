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
    public partial class FrmModifLigne : Form
    {
        public FrmModifLigne()
        {
            InitializeComponent();
        }

        int fermeture = 0;


        private void FrmModifLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == 0)
            {
                Application.OpenForms[0].Close();
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (sender == cmdQuitter)
            {
                DialogResult message_sortie = MessageBox.Show("Voulez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (message_sortie == DialogResult.Yes)
                {
                    fermeture++;
                    this.Close();
                }
            }
        }

        private void FrmModifLigne_Load(object sender, EventArgs e)
        {
            Form ListeLigne = (Form)this.Owner;
            
        }
    }
}
