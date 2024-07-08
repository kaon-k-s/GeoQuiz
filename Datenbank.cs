
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Datenbank
    {
        // Deklaration der MySQL-Verbindung
        private MySqlConnection con;

        // Konstruktor der Klasse Datenbank, der die Verbindungsinformationen initialisiert
        public Datenbank()
        {
            string conStr = "SERVER=localhost;DATABASE=GeoQuiz; UID=root;PASSWORD=''";
            con = new MySqlConnection(conStr);
        }

        // Methode zum Öffnen der Verbindung zur Datenbank
        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verbindung konnte nicht geöffnet werden: " + ex.Message);
            }
        }

        // Methode zum Schließen der Verbindung zur Datenbank
        private void schliessen()
        {
            if (con != null)
            {
                try
                {
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Verbindung konnte nicht geschlossen werden: " + ex.Message);
                }
            }
        }

        // Methode zum Abrufen einer Liste von Ländern basierend auf einem Kontinent
        public List<Land> getLand(int selectedKont)
        {
            List<Land> liLa = new List<Land>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                if (selectedKont == 100)
                {
                    cmd.CommandText = "SELECT * FROM land order by rand() limit 4;";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM land WHERE LKontinentFK='" + selectedKont + "' order by rand() limit 4;";
                }
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liLa.Add(
                        new Land(
                            dr.IsDBNull(0) ? -1 : dr.GetInt32(0),   //LId
                            dr.IsDBNull(1) ? "" : dr.GetString(1),  //LName
                            dr.IsDBNull(2) ? "" : dr.GetString(2),  //LHauptstadt
                            dr.IsDBNull(3) ? -1 : dr.GetInt32(3),   //FFlagge
                            dr.IsDBNull(4) ? -1 : dr.GetInt32(4)    //LKontinentFK
                            )
                        );
                }

                dr.Close();
                schliessen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Landdaten konnten nicht abgerufen werden: {ex.Message}", "Failed to fetch land data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return liLa;
        }


        // Methode zum Speichern der Punktzahl eines Spielers in der Datenbank
        public void SavePlayerScore(Scores score)
        {
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();
                string s;
                string dat = score.ScDatum.ToString("yyyy-MM-dd");

                s = string.Format("INSERT INTO scores " +
                    "VALUES(NULL, '{0}', '{1}','{2}');",
                        score.ScName, score.ScScore, dat);

                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                schliessen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Speichern des Spielerpunktestands fehlgeschlagen: {ex.Message}", "Failed to save player score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Methode zum Abrufen aller gespeicherten Punktzahlen aus der Datenbank
        public List<Scores> getAllScores()
        {
            List<Scores> lisc = new List<Scores>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM scores ORDER BY ScScore DESC;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string dat = dr.IsDBNull(3) ? "" : dr.GetDateTime(3).Day +
                                                     "." + dr.GetDateTime(3).Month +
                                                     "." + dr.GetDateTime(3).Year;

                    lisc.Add(
                        new Scores(
                            dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //ScId
                            dr.IsDBNull(1) ? "" : dr.GetString(1),   //ScName
                            dr.IsDBNull(2) ? -1 : dr.GetInt32(2),    //ScScore
                            Convert.ToDateTime(dat)                  //ScDatum
                            )
                        );
                }
                dr.Close();
                schliessen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es konnten nicht alle Scores abgerufen werden: {ex.Message}", "Failed to fetch all scores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lisc;
        }

        // Methode zum Abrufen der persönlichen Punktzahlen eines Spielers aus der Datenbank
        public List<Scores> getPersonScores(string spName)
        {
            List<Scores> liscp = new List<Scores>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM scores WHERE ScName='" + spName + "' ORDER BY ScScore DESC;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string dat = dr.IsDBNull(3) ? "" : dr.GetDateTime(3).Day +
                                                   "." + dr.GetDateTime(3).Month +
                                                   "." + dr.GetDateTime(3).Year;
                    liscp.Add(
                        new Scores(
                            dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //ScId
                            dr.IsDBNull(1) ? "" : dr.GetString(1),   //ScName
                            dr.IsDBNull(2) ? -1 : dr.GetInt32(2),    //ScScore
                            Convert.ToDateTime(dat)                  //ScDatum
                            )
                        );
                }
                dr.Close();
                schliessen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Persoenliche Scores konnten nicht abgerufen werden: {ex.Message}", "Failed to fetch personal scores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return liscp;
        }
    }
}
