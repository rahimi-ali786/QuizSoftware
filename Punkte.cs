using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSoftware
{
    public class Punkte
    {
        private int punkteID;
        private int spielerID;
        private int quizID;
        private int gesamtPunkte;

        public int PunkteID { get => punkteID; set => punkteID = value; }
        public int SpielerID { get => spielerID; set => spielerID = value; }
        public int QuizID { get => quizID; set => quizID = value; }
        public int GesamtPunkte { get => gesamtPunkte; set => gesamtPunkte = value; }
    
    
        public Punkte(int punkteID, int spielerID, int quizID, int gesamtPunkte)
        {
            this.punkteID = punkteID;
            this.spielerID = spielerID;
            this.quizID = quizID;
            this.gesamtPunkte = gesamtPunkte;
           
        }
    }
}
