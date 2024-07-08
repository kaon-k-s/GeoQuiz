using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoQuiz
{
    public partial class SaveScore : Form
    {
        private List<Scores> allScoreList;
        private List<Scores> personScoreList;
        private int currentScore = 0;
        private string spNameNeu;
        private DateTime currentDate;
        private Datenbank db = new Datenbank();

        public string SpNameNeu { get => spNameNeu; set => spNameNeu = value; }
        public int CurrentScore { get => currentScore; set => currentScore = value; }

        // Konstruktor der Klasse SaveScore
        public SaveScore(int currentScore)
        {
            InitializeComponent();
            CurrentScore = currentScore;
        }

        // Methode zum Anzeigen aller bisher gespeicherten Punktzahlen
        private void dispAllScores()
        {
            try
            {
                // Abrufen aller Punktzahlen aus der Datenbank
                allScoreList = db.getAllScores();
                libAllHighSc.Items.Clear();

                // Durchlaufen aller gespeicherten Punktzahlen und Hinzufügen zu ListView
                foreach (Scores score in allScoreList)
                {
                    libAllHighSc.Items.Add(score.ScScore + " " + score.ScName + " " + score.ScDatum.ToString("dd.MM.yyyy"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es konnten nicht alle Scores abgerufen werden: {ex.Message}", "Failed to fetch all scores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Methode zum Anzeigen der persönlichen Punktzahlen eines Spielers
        private void dispPersonScores(string spName)
        {
            try
            {
                // Abrufen der persönlichen Punktzahlen eines Spielers aus der Datenbank
                personScoreList = db.getPersonScores(spName);
                libPersonHighSc.Items.Clear();

                // Durchlaufen aller persönlichen Punktzahlen und Hinzufügen zu ListView
                foreach (Scores score in personScoreList)
                {
                    libPersonHighSc.Items.Add(score.ScScore + " " + score.ScName + " " + score.ScDatum.ToString("dd.MM.yyyy"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Persoenliche Scores konnten nicht abgerufen werden: {ex.Message}", "Failed to fetch personal scores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Eventhandler für den Button zum Speichern der aktuellen Punktzahl eines Spielers
        private void btnSaveSpieler_Click(object sender, EventArgs e)
        {
            try
            {
                // Speichern des neuen Spieler-Namens und der aktuellen Zeit
                spNameNeu = tbNeuSpieler.Text;
                currentDate = DateTime.Now;
                Scores score = new Scores(0, spNameNeu, currentScore, currentDate);

                // Speichern der Punktzahl in der Datenbank
                db.SavePlayerScore(score);

                // Aktualisieren der Anzeige aller Punktzahlen und der persönlichen Punktzahlen des Spielers
                dispAllScores();
                dispPersonScores(spNameNeu);

                // Deaktivieren des Buttons zum Speichern, da die Aktion bereits ausgeführt wurde
                btnSaveSpieler.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Speichern des Spielerpunktestands fehlgeschlagen: {ex.Message}", "Failed to save player score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}