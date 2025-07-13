using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuizSoftware
{

    public class Datenbank
    {
        private MySqlConnection conn;
        private string connstr = "SERVER=localhost; UID='root';PASSWORD='';DATABASE=quizsoftware";


        public Datenbank() {
            conn = new MySqlConnection(connstr);
        }

        public Spieler benutzerUberpruefen(string benutzer, string passwort)
        {
          
            Spieler bn = null;
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT *FROM spieler WHERE spielername='"
                    + benutzer + "'" + " AND passwort='" + passwort + "';";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bn = new Spieler(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //finally ist optional

            }
            conn.Close();
            return bn;
        }

        public List<Spieler> benutzerEinlesen()
        {
            List<Spieler> liBenutzer = new List<Spieler>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM spieler order by spielerID desc;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liBenutzer.Add(new Spieler(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liBenutzer;
        }
        public void benutzerInsert(Spieler nB)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "INSERT INTO spieler VALUES(NULL, '{0}', '{1}');",
                    nB.SpielerName, nB.Passwort
                    );
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        public List<Landinfo> landinfoEinlesen()
        {
            List<Landinfo> liLandinfo = new List<Landinfo>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM landinfo order by RAND();";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liLandinfo.Add(new Landinfo(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3), 
                        reader.GetString(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liLandinfo;

        }
        public List<Landinfo> landinfoBeschraenktEinlesen(string kontinent)
        {
            string beschraenkung = kontinent;
            List<Landinfo> liLandinfo = new List<Landinfo>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                      "SELECT * FROM landinfo where kontinent = '{0}' order by RAND();",
                        beschraenkung
                    );
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liLandinfo.Add(new Landinfo(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liLandinfo;


        }
        public List<Landinfo> getOptionen(Landinfo richtig)
        {
            List<Landinfo> liDreiOptionen = new List<Landinfo>();
            int landinfoID = richtig.LandID;
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                     "SELECT * FROM landinfo where landID != {0} order by RAND() limit 3;",
                     landinfoID
                    );
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liDreiOptionen.Add(new Landinfo(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liDreiOptionen;
        }

        public List<Landinfo> getOptionenBeschraenkt(Landinfo richtig, string kontinent)
        {
            string beschraenkung = kontinent;
            List<Landinfo> liDreiOptionen = new List<Landinfo>();
            int landinfoID = richtig.LandID;
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                     "SELECT * FROM landinfo where landID != {0} and kontinent = '{1}' order by RAND() limit 3;",
                     landinfoID, beschraenkung
                    );
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liDreiOptionen.Add(new Landinfo(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liDreiOptionen;
        }
        public int guizInsert(Quiz q)
        {
            int l = -1;
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "INSERT INTO quiz VALUES(NULL, {0}, '{1}', {2});",
                    q.SpielerID, q.QuizTyp, q.GesamtPunkte
                );
                cmd.ExecuteNonQuery();
                l = (int)cmd.LastInsertedId; // Explicitly cast 'long' to 'int' to fix CS0266
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return l;
        }

        public List<Quiz> quizEinlesen()
        {
            List<Quiz> liQuiz = new List<Quiz>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM quiz order by quizID desc;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liQuiz.Add(new Quiz(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetInt32(3)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liQuiz;
        }

        public void punkteInsert(Punkte punkte)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "INSERT INTO punkte VALUES(NULL, {0}, {1}, {2});",
                    punkte.SpielerID, punkte.QuizID, punkte.GesamtPunkte
                    );
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Punkte> punkteEinlesen()
        {
            List<Punkte> liPunkte = new List<Punkte>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM punkte order by punkteID desc;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liPunkte.Add(new Punkte(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liPunkte;
        }

        public List<Punkte> punkteEinlesenVonSpieler(Spieler s)
        {
            List<Punkte> liPunkte = new List<Punkte>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "SELECT * FROM punkte WHERE spielerID={0} order by quizID desc;",
                    s.SpielerId
                    );
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liPunkte.Add(new Punkte(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liPunkte;
        }
   
        public List<HoechstePunktzahl> hoechstPunkteEinlesen()
        {
            List<HoechstePunktzahl> liHoechstePunkte = new List<HoechstePunktzahl>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM  v_hoechste_punktzahl order by hoechste_punktzahl desc;";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liHoechstePunkte.Add(new HoechstePunktzahl(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return liHoechstePunkte;
        }


    }
}
