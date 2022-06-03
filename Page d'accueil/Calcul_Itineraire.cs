using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
#pragma warning disable CS0234 // Le nom de type ou d'espace de noms 'Linq' n'existe pas dans l'espace de noms 'System' (vous manque-t-il une référence d'assembly ?)
using System.Linq;
#pragma warning restore CS0234 // Le nom de type ou d'espace de noms 'Linq' n'existe pas dans l'espace de noms 'System' (vous manque-t-il une référence d'assembly ?)
using System.Text;
#pragma warning disable CS0234 // Le nom de type ou d'espace de noms 'Tasks' n'existe pas dans l'espace de noms 'System.Threading' (vous manque-t-il une référence d'assembly ?)
using System.Threading.Tasks;
#pragma warning restore CS0234 // Le nom de type ou d'espace de noms 'Tasks' n'existe pas dans l'espace de noms 'System.Threading' (vous manque-t-il une référence d'assembly ?)
using System.Windows.Forms;

namespace Calculateur_d_itinéraire
{
    public partial class Calcul_Itineraire : Form
    {
        public Calcul_Itineraire()
        {
            InitializeComponent();
        }

        // Objet dans lequel on va faire la matrice, Requete à la base , on rempli la matrice des poids matrice carrè m[31][31], La matrice des distances dans le cadre de dijkstra, et la matrice des prédecesseurs
        //class calculateur itineraire, objet matrice des poids, objet matrice des distances, objet matrice des prédecesseurs

        ///<summary>
        ///Déclaration des différentes variables de la classe Calculateur_itineraire
        ///</summary>

        class Calculateur_itineraire
        {
            private int distance;   //nombre de minutes necessaire pour aller du départ à l'arrivée
            private int distance_temp;  // distance temporaire qu'on ajoute si c'est la distance la plus courte 
            private int[] PointParcouru = new int[31];  //regroupe les points qui ont été compté par le calculateur
            private int remplissage_point_parcouru = 2; //indice de remplissage du tableau point parcouru
            private int temp_remplissage_Point_Parcouru = 2;    //indice temporaire avant vérification 
            private int[] successeur_depart = new int[31];  //liste qui regroupe les points parcouru après le point de départ vers le point d'arrivé
            private int[] successeur_depart_temp = new int[31]; //liste temporaire de successeur_depart avant vérification et validation
            private int[] itineraire = new int[31]; // Liste des stations à parcourir pour aller du départ à l'arrivée
            private int[] itineraire_temp = new int[31];    //liste temporaire jusqu'a ce qu'elle soit validée et copié dans itineraire
            private int point_pivot;    //  point suivant le point précédement visité  

            /*public Calculateur_itineraire(int, int, int[][]) //constructeur du calculateur
            {

            }*/
            //public void init_Calculateur(); //initialisateur du constructeur
            //public void Calculateur();  //le sous programme du calculateur
            //public ~Calculateur_itineraire();
        }

        private void Calcul_Itineraire_Load(object sender, EventArgs e)
        {

        }

        ///<summary>
        ///Initialisateur du Calculateur qui prend en paramètres la station de départ, la station d'arrivé et la matrice de graph du réseau
        ///<\summary>
        ///<param name= "depart">Station de départ de l'utilisateur</param>
        ///<param name= "arrivee">Station d'arrivée de l'utilisateur</param>
        ///<param name= "matrice">Matrice dans laquelle se trouve le graph du réseau de tram</param>
        ///<returns></returns>
        /* public Calcul_Itineraire(int depart, int arrivee, int[][] matrice)
         {
             distance = 0;
             distance_temp = 0;

             //on vérifie ici que départ et arrivée sont différents et on place départ au niveau de la première station visitée
             if (depart != arrivee)
             {
                 for (int i = 0; i < 31; i++)
                 {
                     if (matrice[i][depart] == 0)
                     {
                         distance_temp = matrice[i][depart];
                         point_pivot = i;
                         pointParcouru[0] = depart;
                         itineraire[0] = depart;
                         itineraire_temp[0] = depart;
                     }
                 }
             }
         }

         public void init_Calculateur()
         {

         }

         private void Calculitineraire_Load(object sender, EventArgs e)
         {

         }*/
    }
}

/*
Objet Matrice_De_Toute_Distance
protected :
int[31][31] // vecteur

constructeur Matrice_De_Toute_Distance(a){

}

~Matrice_De_Toute_Distance(){}

Objet tableau_Distance : Matrice_DeTouteDistance
protected:
int[31][31] // à transformer en vecteur
constructeur tableau_Distance(int){

}
miseAJour(int){

}
~tableau_Distance(){}

Objet tableau_Prédecesseur : Matrice_DeTouteDistance
protected :
int[31][31] // vecteur

constructeur tableau_Prédecesseur(a){

}
miseAJour(int){

}
~tableau_Prédecesseur(){}

Objet Calculateur : tableau_Prédecesseur, tableau_Distance
protected :
int[31] pointAParcourir // vecteur les deux
int[31] pointParcouru
int temps

constructeur calculateur(int a) : tableau_Prédecesseur(a) : tableau_Distance(a){


}
~calculateur(){}
calcul(int,int){

}
Affichage(){

}

main{
int a,b;
calculateur();
Veuillez entrer la station de départ : get;
Veuillez entrer la station d'arrivée : get;
calcul(a,b);
}
*/
