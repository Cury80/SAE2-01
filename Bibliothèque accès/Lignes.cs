using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothèque_accès
{
    public class Lignes
    {

        public string nom_ligne
        {
            get
            {
                return nom_ligne;
            }
        }

        public string frequence
        {
            get { return frequence; }
        }

        public string heure_depart
        {
            get { return heure_depart; }
        }

        public string heure_dernier_passage
        {
            get { return heure_dernier_passage; }
        }

        public int type
        {
            get { return type; }
        }
    }
}
