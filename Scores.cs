using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    public class Scores
    {
        private int scId;
        private string scName;
        private int scScore;
        private DateTime scDatum;

        // Eigenschaften für öffentliche Zugriffe auf die privaten Variablen
        public int ScId { get => scId; set => scId = value; }
        public string ScName { get => scName; set => scName = value; }
        public int ScScore { get => scScore; set => scScore = value; }
        public DateTime ScDatum { get => scDatum; set => scDatum = value; }

        // Konstruktor der Klasse Scores
        public Scores(int scId, string scName, int scScore, DateTime scDatum)
        {
            ScId = scId;
            ScName = scName;
            ScScore = scScore;
            ScDatum = scDatum;
        }
    }
}