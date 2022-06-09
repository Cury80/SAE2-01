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
        /// le tableau OpenForms et ensuite on ferme le formulaire GererReseau
        /// </summary>
        /// <param name="sender">le bouton cmdRetour</param>
        /// <param name="e">évenement click sur le bouton cmdRetour</param>
        private void cmdRetour_Click(object sender, EventArgs e)
        { 
            fermeture = false;
            Application.OpenForms[0].Show();
            this.Close();
        }


        /// <summary>
        /// On efface d'abords l'errorProvider1, on initialise nb_erreur a 0
        /// 
        /// On vérifie si le texte dans TxtPseudo n'est pas vide :
        /// 
        /// Si la valeur est null ou vide alors on place un errorProvider et
        /// on incrémente de 1 la valeur de nb_erreurs sinon on test si la valeur
        /// est bien la valeur demander pour se connecter à l'application
        /// 
        /// Si ce n'est pas le cas on incrémente nb_erreurs de 1 et on place
        /// un errorProvider sur la textBox pour indiquer le problème
        /// 
        /// On fait de même pour le texte dans txtMdp
        /// 
        /// Ensuite s'il n'y a pass d'erreurs c'est à dire nb_erreurs est égale
        /// a 0 alors on autorise la connexion : on passe fermeture en faux
        /// on crée une instance du formulaire FrmLigneOuStation que l'on montre
        /// et on ferme ce formulaire
        /// </summary>
        /// <param name="sender">le bouton CmdConnexion</param>
        /// <param name="e">l'évenement clique</param>
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
                fermeture = false; 
                Form LigneStation = new Page_d_accueil.FrmLigneOuStation();
                LigneStation.Show();
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
        private void FrmGererReseau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fermeture == true)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
