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
    public partial class FrmLigneOuStation : Form
    {
        public FrmLigneOuStation()
        {
            InitializeComponent();
        }


        /// <summary>
        /// on initialise fermeture a vrai
        /// 
        /// cette variable permet de détecter lorsque l'utilisateur ferme le
        /// formulaire avec la croix en haut a droite
        /// </summary>
        bool fermeture = true;


        /// <summary>
        /// Lorsque l'on appuie sur cmdRetour on place fermeture en faux
        /// on montre le formulaire ouvert (mais caché) indexé en 0 dans
        /// le tableau OpenForms et ensuite on ferme le formulaire LigneOuStation
        /// </summary>
        /// <param name="sender">le bouton cmdRetour</param>
        /// <param name="e">évenement click sur le bouton cmdRetour</param>
        private void CmdRetour_Click(object sender, EventArgs e)
        {
            try
            {
                fermeture = false;
                Form gestion = new Gerer_le_reseau.FrmGererReseau();
                gestion.Show();
                this.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Form lignestation = new Page_d_accueil.FrmLigneOuStation();
                lignestation.Show();
            }
        }


        /// <summary>
        /// Lorsque l'on appuie sur le bouton cmdLignes, on passe fermeture en faux
        /// on instancie un formulaire FrmListeLigne que l'on fait apparaitre puis on 
        /// ferme le formulaire actuel
        /// 
        /// Lorsque l'on appuie sur le bouton cmdStation, on passe fermeture en faux
        /// on instancie un formulaire FrmListeStation que l'on fait apparaitre puis on 
        /// ferme le formulaire actuel
        /// </summary>
        /// <param name="sender">soit le bouton cmdLignes soit le bouton cmdStations</param>
        /// <param name="e">l'évènement est le click sur un des bouton</param>
        private void cmdLignes_Click(object sender, EventArgs e)
        {
            if (sender == cmdLignes)
            {
                fermeture = false;
                Form lignes = new Page_d_accueil.FrmListeLigne();
                lignes.Show();
                this.Close();
            }else if (sender == cmdStations)
            {
                fermeture = false;
                Form station = new Page_d_accueil.FrmListeStation();
                station.Show();
                this.Close();
            }
        }


        /// <summary>
        /// 
        /// On détecte si l'utilisateur veut fermer l'application en appuyant 
        /// sur la croix en haut a droite avec fermeture :
        /// 
        /// Si fermeture est égale a vrai alors on ferme le formulaire d'origine
        /// de l'application, ce qui provoque la fermeture de l'application
        /// 
        /// </summary>
        /// <param name="sender">le formulaire actuelle</param>
        /// <param name="e">événement de fermeture du formulaire</param>
        private void FrmLigneOuStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == true)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
