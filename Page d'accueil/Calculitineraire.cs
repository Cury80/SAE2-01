using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculateur_d_itinéraire
{
    public partial class Calculitineraire : Form
    {
        ///<summary>
        ///Déclaration des différentes variables de la classe Calculateur_itineraire
        ///</summary>

        class Calculateur_itineraire
        {
            protected:
                int distance = 0;
                int distance_temp = 0;
                int[] PointParcouru = new int[31];
                int remplissage_point_parcouru = 2;
                int temp_remplissage_Point_Parcouru = 2;
                int[] successeur_depart = new int[31];
                int[] successeur_depart_temp = new int[31];
                int[] itineraire = new int[31];
                int[] itineraire_temp = new int[31];
                
            public:
                int Calculateur_itineraire(int, int, int[][]);         
        }
    }

        public Calculitineraire()
        {
            InitializeComponent();
        }


    }
}
