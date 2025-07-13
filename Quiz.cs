using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSoftware
{
    public class Quiz
    {
        private int quizID;
        private int spielerID;
        private string quizTyp;
        private int gesamtPunkte;

        public int QuizID { get => quizID; set => quizID = value; }
        public int SpielerID { get => spielerID; set => spielerID = value; }
        public string QuizTyp { get => quizTyp; set => quizTyp = value; }
        public int GesamtPunkte { get => gesamtPunkte; set => gesamtPunkte = value; }

        public Quiz(int quizID, int spielerID, string quizTyp, int gesamtPunkte)
        {
            this.quizID = quizID;
            this.spielerID = spielerID;
            this.quizTyp = quizTyp;
            this.gesamtPunkte = gesamtPunkte;
        }

    }
}
