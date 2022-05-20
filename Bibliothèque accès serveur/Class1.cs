using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Bibliothèque_accès_serveur
{
    public class BDD
    {
        private static MySqlConnection maCnx;

        public static bool initConnexion()
        {
            string serveur = "10.1.139.235";
            string login = "f5";
            string passwd = "mdp";
            string BD = "basef5";
            string chaineDeConnexion = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            maCnx = new MySqlConnection(chaineDeConnexion);
            try
            {
                maCnx.Open();
                Console.WriteLine("ça passe mon gars");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool FermerConnexion()
        {
            try
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                {
                    maCnx.Close();
                    maCnx.Dispose();
                }
                return true;
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
                return false;
            }
        }
    }
}
