﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime;
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

        public static bool Ajout_ligne(string nom, TimeSpan frequence, TimeSpan heure_depart, TimeSpan heure_dernier_passage, int type)
        {
            bool reponse = true; //N_Ligne, NomLigne, Fréquence, HeureDeDépart, HeureDeDernierPassage, N_Type)

            string sql = $"INSERT INTO Ligne VALUES (NULL,'{nom}','{frequence}','{heure_depart}','{heure_dernier_passage}',{type})";
            MySqlCommand cmd1 = new MySqlCommand(sql, maCnx);

            try
            {
                cmd1.ExecuteNonQuery();
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
            bool reponse = true;
            string sql = $"insert into Station (nomstation) values ('{nom_station}')";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception erreur)
            {
                Debug.Print(erreur.Message);
                reponse = false;
            }
            return reponse;
        }

        public static bool Modifier_Ligne(string nom, TimeSpan frequence, TimeSpan heure_depart, TimeSpan heure_dernier_passage, int type, string ancienNom)
        {
            //N_Ligne, NomLigne, Fréquence, HeureDeDépart, HeureDeDernierPassage, N_Type)

            string sql = $"UPDATE Ligne SET NomLigne ='{nom}', Fréquence ='{frequence}', HeureDeDépart ='{heure_depart}', HeureDeDernierPassage = '{heure_dernier_passage}', N_type = {type}) WHERE NomLigne = '{ancienNom}'";
            MySqlCommand cmd1 = new MySqlCommand(sql, maCnx);

            try
            {
                cmd1.ExecuteNonQuery();
                return true;
            }
            catch (Exception erreur)
            {
                Debug.Print(erreur.Message);
                return false;
            }
        }

    

        public static bool Supp_ligne(string nom_ligne) { 
            string sql = $"delete from Ligne where nomligne = '{nom_ligne}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception erreur)
            {
                Debug.Print(erreur.Message);
                return false;
            }
        }

        public static bool Supp_station(string nom_station)
        {
            string sql = $"delete from Station where nomstation = '{nom_station}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception erreur)
            {
                Debug.Print(erreur.Message);
                return false;
            }
        }

        public static List<string> Lecture_Ligne(){
            
            List<string> liste_lignes = new List<string>();

            string sql = "select NomLigne from Ligne";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string nomLigne = (string)rdr[0];

                    liste_lignes.Add(nomLigne);
                    
                }
                rdr.Close();
                cmd.Dispose();
                Debug.Print("On est entré dans la boucle");
            }
            catch (Exception er)
            {
                Debug.Print("On rentre pas dedans : ");
                Debug.Print(er.Message);
                
            }
            return liste_lignes;
        }

        public static List<string> Lecture_Station()
        {
            List<string> liste_stations = new List<string>();

            string sql = "select NomStation from Station";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string nomStation = (string)rdr[0];

                    liste_stations.Add(nomStation);

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

        public static string Lecture_NomLigne(string nom)
        {
            List<string> listeNomLigne = new List<string>();
            string nomLigne;
            string sql = $"select NomLigne FROM Ligne WHERE NomLigne = '{nom}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    nomLigne = (string)rdr[0];

                    listeNomLigne.Add(nomLigne);
                }
                
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }

            nomLigne = listeNomLigne[0];

            return nomLigne;

        }

        public static string Lecture_frequence(string nom_ligne)
        {
            List<string> listeFrequence = new List<string>();
            string frequence;
            string sql = $"select Fréquence FROM Ligne WHERE NomLigne = '{nom_ligne}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    frequence = Convert.ToString((TimeSpan)rdr[0]);

                    listeFrequence.Add(frequence);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }

            frequence = listeFrequence[0];

            return frequence;
        }

        public static string Lecture_depart(string nom_ligne)
        {
            List<string> listeDepart = new List<string>();
            string depart;
            string sql = $"select HeureDeDépart FROM Ligne WHERE NomLigne = '{nom_ligne}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    depart = Convert.ToString((TimeSpan)rdr[0]);

                    listeDepart.Add(depart);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }

            depart = listeDepart[0];

            return depart;
        }

        public static string Lecture_heureDernierDepart(string nom_ligne)
        {
            List<string> listeHeureDernierDepart = new List<string>();
            string HeureDernierDepart;
            string sql = $"select HeureDeDernierPassage FROM Ligne WHERE NomLigne = '{nom_ligne}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    HeureDernierDepart = Convert.ToString((TimeSpan)rdr[0]);

                    listeHeureDernierDepart.Add(HeureDernierDepart);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }

            HeureDernierDepart = listeHeureDernierDepart[0];

            return HeureDernierDepart;
        }

        public static string Lecture_TypeTransport(string nom)
        {
            List<string> listeTypeTransport = new List<string>();
            string TypeTransport;
            string sql = $"select NomType FROM Type, Ligne WHERE Type.N_Type = Ligne.N_Type and NomLigne = '{nom}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    TypeTransport = (string)rdr[0];

                    listeTypeTransport.Add(TypeTransport);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }

            TypeTransport = listeTypeTransport[0];

            return TypeTransport;

        }


        public static string Lecture_NomStation(string nom)
        {
            List<string> listeNomStation = new List<string>();
            string NomStation;
            string sql = $"select NomStation FROM Station where NomStation = '{nom}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    NomStation = (string)rdr[0];

                    listeNomStation.Add(NomStation);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception er)
            {
                Debug.Print(er.Message);
            }

            NomStation = listeNomStation[0];

            return NomStation;

        }

    }
}
