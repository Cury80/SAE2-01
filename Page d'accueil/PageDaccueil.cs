using Carte_du_reseau;
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
    public partial class FrmPageDaccueil : Form
    {
        public FrmPageDaccueil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// procédure qui regarde sur quel boutton l'utilisateur appuie,
        /// 
        /// s'il appuie sur Rechercher un itinéraire (cmdItinéraire) on crée
        /// une instance du formulaire Calculitineraire, on cache ensuite le formulaire
        /// de départ (s'il est fermé il arrête totalement l'application) et on ouvre 
        /// l'instance créée précédement.
        /// 
        /// Appuyer sur le bouton cmdCarte crée une instance du formulaire Map
        /// on cache ensuite le formulaire d'origine et on affiche l'instance du formulaire
        /// Map.
        /// 
        /// Appuyer sur le bouton cmdGerer crée une instance du formulaire GererReseau
        /// on cache le formulaire d'origine et on affiche l'instance du formulaire GererReseau
        /// </summary>
        /// <param name="sender">récupère l'objet d'où vient l'interaction</param>
        /// <param name="e">récupère l'evenement</param>
        private void cmdItinéraire_Click(object sender, EventArgs e)
        {
            if (sender == cmdItinéraire)
            {
                Form Itineraire = new Calculateur_d_itinéraire.FrmCalculitineraire();
                this.Hide();
                Itineraire.Show();
            }
            else if (sender == cmdCarte)
            {
                Form carte = new FrmMap();
                this.Hide();
                carte.Show();
            }
            else if (sender == cmdGerer)
            {
                Form gestion_appli = new Gerer_le_reseau.FrmGererReseau();
                this.Hide();
                gestion_appli.Show();
            }
        }


        /// <summary>
        /// Suite d'instructions que l'on effectue au chargement du formulaire 
        /// 
        /// On appelle la fonction initConnection qui se trouve dans la 
        /// bibliothèque_accès
        /// 
        /// On stock la valeur de sortie dans un bool et on vérifie la valeur pour afficher 
        /// un message je confirmation
        ///
        /// </summary>
        /// <param name="sender">le formulaire</param>
        /// <param name="e">le chargement du formulaire</param>
        private void FrmPageDaccueil_Load(object sender, EventArgs e)
        {
            bool connexion = Bibliothèque_accès.BDD.initConnexion();
            if (connexion == true)
            {
                LblConnexion.Text = "Connexion au serveur réussie";

            }
            else
            {
                LblConnexion.Text = "Echec de la connexion à la base";
            }
        }

        /// <summary>
        /// On appelle la fonction FermerConnexion et on stock la valeur de retour dans 
        /// un bool, si la valeur est vraie alors on affiche un message de 
        /// réussite sinon un message d'erreur
        /// 
        /// </summary>
        /// <param name="sender">le formulaire</param>
        /// <param name="e">la fermeture du formulaire</param>
        private void FrmPageDaccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool fermeture = Bibliothèque_accès.BDD.FermerConnexion();
            if (fermeture == true)
            {
                MessageBox.Show("Déconnexion réussi à la base", "Fermeture");
            }
            else
            {
                MessageBox.Show("Echech de la deconnexion");
            }
        }
    }
}
