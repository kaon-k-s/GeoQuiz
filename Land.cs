using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Land
    {
        private int lId;
        private string lName;
        private string lHauptstadt;
        private int lFlagge;
        private int lKontinentFK;

        // Eigenschaften für öffentliche Zugriffe auf die privaten Variablen
        public int LId { get => lId; set => lId = value; }
        public string LName { get => lName; set => lName = value; }
        public string LHauptstadt { get => lHauptstadt; set => lHauptstadt = value; }
        public int LFlagge { get => lFlagge; set => lFlagge = value; }
        public int LKontinentFK { get => lKontinentFK; set => lKontinentFK = value; }

        // Konstruktor der Klasse Land
        public Land(int lId, string lName, string lHauptstadt, int lFlagge, int lKontinentFK)
        {
            LId = lId;
            LName = lName;
            LHauptstadt = lHauptstadt;
            LFlagge = lFlagge;
            LKontinentFK = lKontinentFK;
        }
    }
}
