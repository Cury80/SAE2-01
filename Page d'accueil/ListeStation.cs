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

        /// <summary>
        /// on initialise fermeture a vrai
        /// 
        /// cette variable permet de détecter lorsque l'utilisateur ferme le
        /// formulaire avec la croix en haut a droite
        /// </summary>
        bool fermeture = true;


        /// <summary>
        /// 
        /// Lorsque l'on appuie sur cmdRetour on place fermeture en faux
        /// on montre le formulaire ouvert (mais caché) indexé en 0 dans
        /// le tableau OpenForms et ensuite on ferme le formulaire LigneOuStation
        /// 
        /// Losque l'on appuie sur CmdAjouter, on instancie un formulaire 
        /// FrmAjoutStation que l'on affiche à l'écran tout en gardant le formulaire
        /// précédent ouvert
        /// 
        /// Losque l'on appuie sur CmdModifer, on instancie un formulaire 
        /// FrmModifStation que l'on affiche à l'écran tout en gardant le formulaire
        /// précédent ouvert
        /// 
        /// Lorsque l'on appuie sur CmdSupprimer, on crée 2 variables, une en bool
        /// et une autre en chaine de caractères
        /// 
        /// Dans la chaine de caractère, on place la valeur de l'élément sélectionné
        /// par l'utilisateur dans la listbox (convertie en string)
        /// 
        /// Dans la variable bool, on place le résultat que retourne la fonction 
        /// SuppStation qui se situe dans Bibliothèque_accès
        /// 
        /// Si ce que retourne la fonction est égale a vrai alors on efface toutes 
        /// données contenue dans la listbox et dans la liste lecteurListe
        /// on affiche un message de confirmation puis avec la fonction
        /// Lecture_Station on rempli lecteurListe de la liste des stations
        /// dans la base de données puis on parcourt la liste et on ajoute
        /// dans la listbox une ligne pour chaque nom de station trouvé
        /// dans la liste 
        /// 
        /// </summary>
        /// <param name="sender">boutons CmdRetour, CmdAjouter, CmdModifier et CmdSupprimer</param>
        /// <param name="e">au clique sur l'un des boutons</param>
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
                Form ajout_station = new Page_d_accueil.FrmAjoutStation();
                ajout_station.ShowDialog();

            }
            else if (sender == cmdModifier)
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
