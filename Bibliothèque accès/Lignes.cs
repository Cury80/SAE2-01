using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothèque_accès
{
    public class Lignes
    {
        public string Nom_ligne
        {
            get
            {
                return Nom_ligne;
            }
        }

        public string Frequence
        {
            get { return Frequence; }
        }

        public string Heure_depart
        {
            get { return Heure_depart; }
        }

        public string Heure_dernier_passage
        {
            get { return Heure_dernier_passage; }
        }

        public int Type
        {
            get { return Type; }
        }
    }
}
