using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Bibliothèque_accès
{
    public class BDD
    {
        private static MySqlConnection maCnx;

        public static bool initConnexion()
        {
            string serveur = "10.1.139.236";
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

        public static bool Ajout_ligne(string nom, string frequence, string heure_depart, string heure_dernier_passage, int type)
        {
            bool reponse = true;
            try
            {
                string sql = $"INSERT INTO ligne VALUES ('{nom}', '{frequence}', '{heure_depart}', '{heure_dernier_passage}', '{type}')";
                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            }
            catch (Exception erreur)
            {
                Debug.Print(erreur.Message);
                reponse = false;
            }
            return reponse;
        }

        public static bool Ajout_station(string nom_station)
        {
            string sql = $"insert into station (nomstation) values ('{nom_station}')";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            return true;
        }

        public static bool Supp_ligne(string nom_ligne)
        {
            string sql = $"delete from ligne where nomligne = '{nom_ligne}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            return true;
        }

        public static bool Supp_station(string nom_station)
        {
            string sql = $"delete from station where nomstation = '{nom_station}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            return true;
        }

        public static List<Lignes> Lecture_Ligne(){
            
            List<Lignes> liste_lignes = new List<Lignes> ();

            string sql = "select * from ligne";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string nom = (string)rdr[1];
                    string frequence = (string)rdr[2];
                    string heure_depart = (string)rdr[3];
                    string heure_dernier_passage = (string)rdr[4];
                    int type = (int)rdr[5];


                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
                
            }
            return liste_lignes;
        }

        public static List<Station> Lecture_Station()
        {
            List<Station> liste_stations = new List<Station>();

            string sql = "select * from station";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int num_station = (int)rdr[0];
                    string nom_station = (string)rdr[1];
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }
            return liste_stations;
        }
    }
}
