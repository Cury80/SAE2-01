using System;
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

        /// <summary>
        /// On crée une variable MySqlConnection maCnx
        /// </summary>
        private static MySqlConnection maCnx;

        /// <summary>
        /// On crée une variable en chaine de caractères pour chaque information
        /// a enter pour se connecter à la base de données puis dans 
        /// chaineDeConnexion on stock le script pour se connecter à la base
        /// 
        /// on instancie ensuite un MySqlConnection avec en paramètre 
        /// le script Sql
        /// 
        /// On execute le script avec maCnx.Open()
        /// 
        /// s'il n'y a pas d'erreurs, on retourne vrai soinon on retourne faux
        /// </summary>
        /// 
        /// <returns>
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
        public static bool initConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "f5";
            string passwd = "mdp";
            string BD = "basef5";
            string chaineDeConnection = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            maCnx = new MySqlConnection(chaineDeConnection);
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


        /// <summary>
        /// On regarde si l'état de maCnx est bien ouvert (si l'application est
        /// bien connectée à la base de donnée), si oui alors on ferme cette 
        /// connection puis on libère la mémoire allouée a maCnx
        /// 
        /// </summary>
        /// <returns>
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
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


        /// <summary>
        /// 
        /// On crée une variable booléen qu'on initialise a vrai
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant d'ajouter une ligne a la table Ligne
        /// 
        /// On instancie une commande cmd1 dans laquelle on place en paramètre 
        /// la chaine de charactère avec le script Sql et maCnx
        /// 
        /// On execute ensuite la commmande avec cmd1.ExecuteNonQuery()
        /// S'il n'y a pas d erreur la fonction retourne vrai sinon elle 
        /// retourne faux
        /// 
        /// </summary>
        /// <param name="nom">Contient le nom de la ligne a ajouter a la base</param>
        /// <param name="frequence">Contient la fréquence (en format hh:mm:ss)</param>
        /// <param name="heure_depart">Contient l'heure du premier départ (meme format que frequence</param>
        /// <param name="heure_dernier_passage">Contient l'heure du dernier départ (meme format que frequence</param>
        /// <param name="type">Contient le chiffre correspondant au type de transport utilisé</param>
        /// <returns>        
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
        public static bool Ajout_ligne(string nom, TimeSpan frequence, TimeSpan heure_depart, TimeSpan heure_dernier_passage, int type)
        {
            bool reponse = true; 
            
            //N_Ligne, NomLigne, Fréquence, HeureDeDépart, HeureDeDernierPassage, N_Type)

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


        /// <summary>
        /// 
        /// On crée une variable booléen qu'on initialise a vrai
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant d'ajouter une station a la table station
        /// 
        /// On instancie une commande cmd dans laquelle on place en paramètre 
        /// la chaine de charactère avec le script Sql et maCnx
        /// 
        /// On execute ensuite la commmande avec cmd.ExecuteNonQuery()
        /// S'il n'y a pas d erreur la fonction retourne vrai sinon elle 
        /// retourne faux
        /// 
        /// </summary>
        /// <param name="nom_station">Contient le nom de la station à ajouter à la base</param>
        /// <returns>retourne vrai s'il n'y a aps eu d'erreurs sinon retourne faux</returns>
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


        /// <summary>
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de modifier une ligne de la table Ligne
        /// 
        /// On instancie une commande cmd1 dans laquelle on place en paramètre 
        /// la chaine de charactère avec le script Sql et maCnx
        /// 
        /// On execute ensuite la commmande avec cmd1.ExecuteNonQuery()
        /// S'il n'y a pas d erreur la fonction retourne vrai sinon elle 
        /// retourne faux
        /// 
        /// </summary>
        /// <param name="nom">Contient le nouveau nom de la ligne</param>
        /// <param name="frequence">contient la nouvelle fréquence de la ligne</param>
        /// <param name="heure_depart">contient la nouvelle heure de départ de la ligne</param>
        /// <param name="heure_dernier_passage">contient la nouvelle heure de dernier passage de la ligne</param>
        /// <param name="type">contient le nouveau type de la ligne</param>
        /// <param name="ancienNom">contient l'ancien nom de la ligne</param>
        /// <returns>
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
        public static bool Modifier_Ligne(string nom, TimeSpan frequence, TimeSpan heure_depart, TimeSpan heure_dernier_passage, int type, string ancienNom)
        {
            //N_Ligne, NomLigne, Fréquence, HeureDeDépart, HeureDeDernierPassage, N_Type)

            string sql = $"UPDATE Ligne SET NomLigne ='{nom}', Fréquence ='{frequence}', HeureDeDépart ='{heure_depart}', HeureDeDernierPassage = '{heure_dernier_passage}', N_type = '{type}' WHERE NomLigne = '{ancienNom}'";
            MySqlCommand cmd1 = new MySqlCommand(sql, maCnx);

            try
            {
                cmd1.ExecuteNonQuery();
                
            }
            catch (Exception erreur)
            {
                Debug.Print(erreur.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de modifer une station de la table Station
        /// 
        /// On instancie une commande cmd dans laquelle on place en paramètre 
        /// la chaine de charactère avec le script Sql et maCnx
        /// 
        /// On execute ensuite la commmande avec cmd.ExecuteNonQuery()
        /// S'il n'y a pas d erreur la fonction retourne vrai sinon elle 
        /// retourne faux
        /// 
        /// </summary>
        /// <param name="nom_station">Contient le nouveau nom de la station</param>
        /// <param name="ancien_nom_station">Contient l'ancien nom de la station</param>
        /// <returns>
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
        public static bool Modif_Station(string nom_station, string ancien_nom_station)
        {

            string sql = $"update Station set NomStation = '{nom_station}' where NomStation = '{ancien_nom_station}'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception erreur)
            {
                Debug.Print(erreur.Message);
                return false;
            }
            return true;
        }


        /// <summary>
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de supprimer une ligne de la table Ligne
        /// 
        /// On instancie une commande cmd dans laquelle on place en paramètre 
        /// la chaine de charactère avec le script Sql et maCnx
        /// 
        /// On execute ensuite la commmande avec cmd.ExecuteNonQuery()
        /// S'il n'y a pas d erreur la fonction retourne vrai sinon elle 
        /// retourne faux
        /// 
        /// </summary>
        /// <param name="nom_ligne">Contient le nom de la ligne a supprimer</param>
        /// <returns>
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
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


        /// <summary>
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de suppprimer une station de la table Station
        /// 
        /// On instancie une commande cmd dans laquelle on place en paramètre 
        /// la chaine de charactère avec le script Sql et maCnx
        /// 
        /// On execute ensuite la commmande avec cmd.ExecuteNonQuery()
        /// S'il n'y a pas d erreur la fonction retourne vrai sinon elle 
        /// retourne faux
        /// 
        /// </summary>
        /// <param name="nom_station">Contient le nom de la station a supprimer</param>
        /// <returns>
        /// vrai s'il n'y a pas eu d'erreur pendant l'execution
        /// du code et faux s'il y a eu des erreurs
        /// </returns>
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

        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// le nom des Lignes de la base
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les lignes présentes dans la table 
        /// Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une ligne a lire, on ajoute dans la liste
        /// le nom de la ligne lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// </summary>
        /// <returns>
        /// Retourne la liste des lignes présentes dans la base de données
        /// </returns>
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

        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// le nom des Stations de la base
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les Station présentes dans la table 
        /// Station
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une station a lire, on ajoute dans la liste
        /// le nom de la station lu 
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Retourne la liste des Stations présentes dans la base de données
        /// </returns>
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

        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// le nom de la Ligne recherchée de la base
        /// 
        /// On crée une variable en chaine de charactères qui contiendra le nom
        /// de la ligne recherchée
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les lignes présentes dans la table 
        /// Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une ligne a lire, on ajoute dans la liste
        /// le nom de la ligne lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// On place dans nomLigne le nom de la première ligne lue
        /// 
        /// </summary>
        /// <param name="nom">Contient le nom de la ligne à retrouver </param>
        /// <returns>
        /// Retourne le nom de la ligne séléctionnée
        /// </returns>
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


        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// la fréquence de la ligne (convertie en chaine de charactères)
        /// recherchée de la base
        /// 
        /// On crée une variable en chaine de charactères qui contiendra la 
        /// fréquence de la ligne (convertie en chaine de charactères) de la *
        /// ligne recherchée
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les lignes présentes dans la table 
        /// Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une ligne a lire, on ajoute dans la liste
        /// la fréquence de la ligne (convertie en chaine de charactères) lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// On place dans frequence la fréquence (convertie en chaine de 
        /// charactères) de la première ligne lue
        /// 
        /// </summary>
        /// <param name="nom">Contient le nom de la ligne à retrouver </param>
        /// <returns>
        /// Retourne la fréquence de la ligne (convertie en chaine de charactères) séléctionnée
        /// </returns>
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

        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// l'heure de départ recherchée de la base
        /// 
        /// On crée une variable en chaine de charactères qui contiendra 
        /// l'heure de départ (convertie en chaine de charactères) de la ligne 
        /// recherchée
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les heures de départ présentes 
        /// dans la table Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une ligne a lire, on ajoute dans la liste
        /// l'heure de départ (convertie en chaine de charactères) de la ligne lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// On place dans depart l'heure de départ (convertie en chaine de charactères) de la première ligne lue
        /// 
        /// </summary>
        /// <param name="nom">Contient le nom de la ligne à retrouver </param>
        /// <returns>
        /// Retourne l'heure de départ (convertie en chaine de charactères)
        /// séléctionnée
        /// </returns>
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

        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// l'heure du dernier passage (convertie en chaine de charactères) 
        /// de la Ligne recherchée de la base
        /// 
        /// On crée une variable en chaine de charactères qui contiendra l'heure
        /// du dernier passage (convertie en chaine de charactères) de la ligne 
        /// recherchée
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les heures du dernier passage 
        /// (convertie en chaine de charactères) présentes dans la table Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une heure du dernier passage 
        /// (convertie en chaine de charactères) a lire, on ajoute dans la liste
        /// l'heure du dernier passage (convertie en chaine de charactères) 
        /// de la ligne lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// On place dans HeureDernierDepart l'heure du dernier passage 
        /// (convertie en chaine de charactères) de la première ligne lue
        /// 
        /// </summary>
        /// <param name="nom">Contient le nom de la ligne à retrouver </param>
        /// <returns>
        /// Retourne l'heure du dernier passage (convertie en chaine de charactères)
        /// de la ligne séléctionnée
        /// </returns>
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

        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// le type de la Ligne recherchée de la base
        /// 
        /// On crée une variable en chaine de charactères qui contiendra le type
        /// de la ligne recherchée
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les types présentd dans la table 
        /// Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a un type a lire, on ajoute dans 
        /// la liste le type de la ligne lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// On place dans nomType le type de la première ligne lue
        /// 
        /// </summary>
        /// <param name="nom">Contient le type de la ligne à retrouver </param>
        /// <returns>
        /// Retourne le type de la ligne séléctionnée
        /// </returns>
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


        /// <summary>
        /// 
        /// On crée une liste de chaine de charactères qui servira a recueillir
        /// le nom de la Station recherchée de la base
        /// 
        /// On crée une variable en chaine de charactères qui contiendra le nom
        /// de la Station recherchée
        /// 
        /// On crée une variable en chaine de charactères dans laquelle on met
        /// le script Sql permettant de lire les Station présentes dans la table 
        /// Ligne
        /// 
        /// Avec MySqlDataReader rdr = cmd.ExecuteReader() on crée une commande 
        /// dans laquelle on execute le script contenu dans la chaine de charactères
        /// (On utilise ExecuteReader() au lien de ExectuteNoQuerry() car on veut juste 
        /// lire ce qu'il y a dans la table)
        /// 
        /// Ensuite tant que la commande rdr a une Station a lire, on ajoute dans la liste
        /// le nom de la Station lu
        /// 
        /// On libère l'espace alloué aux commandes créées
        /// 
        /// On place dans nomStation le nom de la première Station lue
        /// 
        /// </summary>
        /// <param name="nom">Contient le nom de la ligne à retrouver </param>
        /// <returns>
        /// Retourne le nom de la station séléctionnée
        /// </returns>
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
