using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Frage
    {
        private string fFrage;
        private string fRichtingAnt;
        private string fOption1;
        private string fOption2;
        private string fOption3;
        private string fOption4;

        // Eigenschaften für öffentliche Zugriffe auf die privaten Variablen
        public string FFrage { get => fFrage; set => fFrage = value; }
        public string FRichtingAnt { get => fRichtingAnt; set => fRichtingAnt = value; }
        public string FOption1 { get => fOption1; set => fOption1 = value; }
        public string FOption2 { get => fOption2; set => fOption2 = value; }
        public string FOption3 { get => fOption3; set => fOption3 = value; }
        public string FOption4 { get => fOption4; set => fOption4 = value; }

        // Konstruktor der Klasse Frage
        public Frage(string fFrage, string fRichtingAnt, string fOption1, string fOption2, string fOption3, string fOptiin4)
        {
            FFrage = fFrage;
            FRichtingAnt = fRichtingAnt;
            FOption1 = fOption1;
            FOption2 = fOption2;
            FOption3 = fOption3;
            FOption4 = fOption4;
        }
    }
}