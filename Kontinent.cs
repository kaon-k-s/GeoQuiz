using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Kontinent
    {
        private int kId;
        private string kName;

        // Eigenschaften für öffentliche Zugriffe auf die privaten Variablen
        public int KId { get => kId; set => kId = value; }
        public string KName { get => kName; set => kName = value; }

        // Konstruktor der Klasse Kontinent
        public Kontinent(int kId, string kName)
        {
            KId = kId;
            KName = kName;
        }
    }
}
