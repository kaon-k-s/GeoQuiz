using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;

namespace GeoQuiz
{
    public partial class Form1 : Form
    {
        private string selectedFrTyp;
        private string selectedAntTyp;
        private int selectedKont = 100;
        private List<Land> LandList;
        private List<Frage> frageList;
        private bool ff;
        private bool fa;

        private Datenbank db = new Datenbank();

        // Konstruktor der Klasse Form1
        public Form1()
        {
            InitializeComponent();

            // Hinzufügen von EventHandlern zu verschiedenen RadioButtons
            radioButton1.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton10.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton11.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton12.CheckedChanged += new EventHandler(HandleCheckedChanged);
            radioButton13.CheckedChanged += new EventHandler(HandleCheckedChanged);
        }


        // Eventhandler für Änderungen an den RadioButtons
        private void HandleCheckedChanged(object sender, EventArgs e)
        {
            // Typumwandlung des senders in ein RadioButton
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                // Liste mit gültigen Pairs von RadioButtons
                List<(RadioButton, RadioButton)> validPairs = new List<(RadioButton, RadioButton)>
                {
                    (radioButton1, radioButton4),
                    (radioButton2, radioButton5),
                    (radioButton3, radioButton6)
                };

                // Überprüfung, ob eine ungültige Auswahl getroffen wurde
                bool isInvalidSelection = false;
                foreach (var pair in validPairs)
                {
                    if ((pair.Item1 == radioButton && pair.Item2.Checked) || (pair.Item2 == radioButton && pair.Item1.Checked))
                    {
                        isInvalidSelection = true;
                        break;
                    }
                }

                // Handhabung einer ungültigen Auswahl
                if (isInvalidSelection)
                {
                    DeselectAllRadioButtons();

                    MessageBox.Show("Diese Paare koennen nicht gleichzeitig ausgewaehlt werden.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Setzen der entsprechenden Werte basierend auf der Auswahl
                    if (radioButton.Parent.Name == "gbFrageTyp")
                    {
                        switch (radioButton.Name)
                        {
                            case "radioButton1":
                                selectedFrTyp = "lf";
                                break;
                            case "radioButton2":
                                selectedFrTyp = "hf";
                                break;
                            case "radioButton3":
                                selectedFrTyp = "ff";
                                break;
                        }
                    }
                    
                    if (radioButton.Parent.Name == "gbAntTyp")
                    {
                        switch (radioButton.Name)
                        {
                            case "radioButton4":
                                selectedAntTyp = "la";
                                break;
                            case "radioButton5":
                                selectedAntTyp = "ha";
                                break;
                            case "radioButton6":
                                selectedAntTyp = "fa";
                                break;
                        }
                    }

                    if (radioButton.Parent.Name == "gbKontinent")
                    {
                        switch (radioButton.Name)
                        {
                            case "radioButton7":
                                selectedKont = 1;
                                break;
                            case "radioButton8":
                                selectedKont = 2;
                                break;
                            case "radioButton9":
                                selectedKont = 3;
                                break;
                            case "radioButton10":
                                selectedKont = 4;
                                break;
                            case "radioButton11":
                                selectedKont = 5;
                                break;
                            case "radioButton12":
                                selectedKont = 6;
                                break;
                            case "radioButton13":
                                selectedKont = 100;
                                break;
                            default: selectedKont = 100;
                                break;
                        }
                    }
                }
            }
        }


        // Methode zum Deaktivieren aller RadioButtons
        private void DeselectAllRadioButtons()
        {
            var gbFrageTypRbs = gbFrageTyp.Controls.OfType<RadioButton>();
            foreach (var rb in gbFrageTypRbs)
            {
                rb.Checked = false;
            }

            var gbAntTypRbs = gbAntTyp.Controls.OfType<RadioButton>();
            foreach (var rb in gbAntTypRbs)
            {
                rb.Checked = false;
            }
        }

        // Eventhandler für den Start-Button
        private void btnStart_Click(object sender, EventArgs e)
        {
            List<Frage> frageList = new List<Frage>();

            // Schleife zur Generierung von Fragen
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    // Abrufen der Liste der Länder basierend auf dem ausgewählten Kontinent
                    List<Land> LandList = db.getLand(selectedKont);

                    if (LandList.Count > 0)
                    {
                        // Logik zur Generierung von Fragen basierend auf den Auswahlkriterien
                        if (selectedFrTyp == "lf")
                        {
                            Frage neueFrage = new Frage(LandList[0].LName, "", "", "", "", "");

                            if (selectedAntTyp == "ha")
                            {
                                neueFrage.FRichtingAnt = LandList[0].LHauptstadt;
                                neueFrage.FOption1 = LandList[0].LHauptstadt;
                                neueFrage.FOption2 = LandList[1].LHauptstadt;
                                neueFrage.FOption3 = LandList[2].LHauptstadt;
                                neueFrage.FOption4 = LandList[3].LHauptstadt;

                            }
                            else if (selectedAntTyp == "fa")
                            {
                                fa = true;
                                neueFrage.FRichtingAnt = LandList[0].LFlagge.ToString();
                                neueFrage.FOption1 = LandList[0].LFlagge.ToString();
                                neueFrage.FOption2 = LandList[1].LFlagge.ToString();
                                neueFrage.FOption3 = LandList[2].LFlagge.ToString();
                                neueFrage.FOption4 = LandList[3].LFlagge.ToString();
                            }

                            frageList.Add(neueFrage);
                        }
                        else if (selectedFrTyp == "hf")
                        {
                            Frage neueFrage = new Frage(LandList[0].LHauptstadt, "", "", "", "", "");

                            if (selectedAntTyp == "la")
                            {
                                neueFrage.FRichtingAnt = LandList[0].LName;
                                neueFrage.FOption1 = LandList[0].LName;
                                neueFrage.FOption2 = LandList[1].LName;
                                neueFrage.FOption3 = LandList[2].LName;
                                neueFrage.FOption4 = LandList[3].LName;

                            }
                            else if (selectedAntTyp == "fa")
                            {
                                fa = true;
                                neueFrage.FRichtingAnt = LandList[0].LFlagge.ToString();
                                neueFrage.FOption1 = LandList[0].LFlagge.ToString();
                                neueFrage.FOption2 = LandList[1].LFlagge.ToString();
                                neueFrage.FOption3 = LandList[2].LFlagge.ToString();
                                neueFrage.FOption4 = LandList[3].LFlagge.ToString();
                            }


                            frageList.Add(neueFrage);
                        }
                        else if (selectedFrTyp == "ff")
                        {
                            Frage neueFrage = new Frage(LandList[0].LFlagge.ToString(), "", "", "", "", "");
                            ff = true;

                            if (selectedAntTyp == "ha")
                            {
                                neueFrage.FRichtingAnt = LandList[0].LHauptstadt;
                                neueFrage.FOption1 = LandList[0].LHauptstadt;
                                neueFrage.FOption2 = LandList[1].LHauptstadt;
                                neueFrage.FOption3 = LandList[2].LHauptstadt;
                                neueFrage.FOption4 = LandList[3].LHauptstadt;

                            }
                            else if (selectedAntTyp == "la")
                            {
                                neueFrage.FRichtingAnt = LandList[0].LName;
                                neueFrage.FOption1 = LandList[0].LName;
                                neueFrage.FOption2 = LandList[1].LName;
                                neueFrage.FOption3 = LandList[2].LName;
                                neueFrage.FOption4 = LandList[3].LName;
                            }
                            frageList.Add(neueFrage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Diesem Kontinent sind keine Länder hinzugefügt.", "No countries are added to this continent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Diesem Kontinent wurden weniger als 4 Länder hinzugefügt. Es können keine Fragen generiert werden.", "Not enough countries", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Übertragen der generierten Fragen in ein neues Form zur weiteren Anzeige
            var fragenDisplayForm = new FragenDisplayForm(frageList, ff, fa);
            fragenDisplayForm.Show();
        }
    }
}