using Microsoft.VisualBasic;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Mysqlx.Notice;

namespace GeoQuiz
{
    public partial class FragenDisplayForm : Form
    {
        public List<Frage> FragenQuiz { get; set; }
        private int zaehler = 0;
        private int currentScore = 0;
        private string currentRichtigAnt;
        private bool ff;
        private bool fa;
        public bool Ff { get => ff; set => ff = value; }
        public bool Fa { get => fa; set => fa = value; }

        // Konstruktor der Klasse FragenDisplayForm
        public FragenDisplayForm(List<Frage> frageList, bool ff, bool fa)
        {
            InitializeComponent();
            FragenQuiz = frageList;
            Ff = ff;
            Fa = fa;
        }

        // Eventhandler für den Submit-Button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Variable zur Speicherung der Ausgabemeldung
            string ausgabe = "Richtig!";
            try
            {
                // Überprüfung der Antwort und Aktualisierung des Punktestands
                if (rbOption1.Checked && rbOption1.Text == currentRichtigAnt)
                {
                    currentScore++;
                }
                else if (rbOption2.Checked && rbOption2.Text == currentRichtigAnt)
                {
                    currentScore++;
                }
                else if (rbOption3.Checked && rbOption3.Text == currentRichtigAnt)
                {
                    currentScore++;
                }
                else if (rbOption4.Checked && rbOption4.Text == currentRichtigAnt)
                {
                    currentScore++;
                }
                else
                {
                    ausgabe = "Falsch:(";
                }

                if (zaehler > 0) MessageBox.Show(ausgabe);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Punkteberechnung: {ex.Message}", "Error calculating score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                // Überprüfung, ob noch Fragen offen sind
                if (zaehler < FragenQuiz.Count)
                {
                    rbOption1.Checked = false;
                    rbOption2.Checked = false;
                    rbOption3.Checked = false;
                    rbOption4.Checked = false;

                    Frage f = FragenQuiz[zaehler];

                    // Mischen der Antwortoptionen
                    string[] options = { f.FOption1, f.FOption2, f.FOption3, f.FOption4 };
                    Random rand = new Random();
                    for (int i = options.Length - 1; i > 0; i--)
                    {
                        int j = rand.Next(i + 1);
                        string temp = options[i];
                        options[i] = options[j];
                        options[j] = temp;
                    }

                    // Zuweisung der gemischten Optionen und der Frage an die UI-Elemente
                    rbOption1.Text = options[0];
                    rbOption2.Text = options[1];
                    rbOption3.Text = options[2];
                    rbOption4.Text = options[3];

                    lblFrage.Text = f.FFrage;

                    // Anzeige von Bildern basierend auf den Auswahlkriterien
                    if (ff)
                    {
                        // Suche nach einem Bild für die Frage
                        string pathF = "Images\\" + f.FFrage + ".png";

                        if (File.Exists(pathF))
                        {
                            pbFrage.Image = Image.FromFile(pathF);
                        }
                        else
                        {
                            pbFrage.Image = null;
                        }
                        lblFrage.Text = "";
                    } else if (fa)
                    {
                        // Suche nach Bildern für die Antworten
                        string path1 = "Images\\" + options[0] + ".png";
                        string path2 = "Images\\" + options[1] + ".png";
                        string path3 = "Images\\" + options[2] + ".png";
                        string path4 = "Images\\" + options[3] + ".png";

                        if (File.Exists(path1) && File.Exists(path2) && File.Exists(path3) && File.Exists(path4))
                        {
                            pb1.Image = Image.FromFile(path1);
                            pb2.Image = Image.FromFile(path2);
                            pb3.Image = Image.FromFile(path3);
                            pb4.Image = Image.FromFile(path4);
                        }
                        else
                        {
                            pb1.Image = null;
                            pb2.Image = null;
                            pb3.Image = null;
                            pb4.Image = null;
                        }
                    }

                    // Aktualisierung der richtigen Antwort und Inkrementierung des Zählers
                    currentRichtigAnt = f.FRichtingAnt;
                    zaehler++;
                }
                else
                {
                    // Deaktivierung des Submit-Buttons und Anzeige des Abschlussfensters
                    btnSubmit.Enabled = false;
                    DialogResult result = MessageBox.Show($"Quiz abgeschlossen! Ihr Endergebnis ist {currentScore}. Möchten Sie Ihren Namen und Ihr Ergebnis speichern?", "Completion Message", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Übertragen des Ergebnisses in ein neues Formular zum Speichern
                        var saveScoreWindow = new SaveScore(currentScore);
                        saveScoreWindow.Show();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(($"Bilddatei nicht gefunden: {ex.FileName}"), "Image file not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unerwarteter Fehler: {ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}