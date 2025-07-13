using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSoftware
{
    public class HoechstePunktzahl
    {
        private int spielerID;
        private string spielername;
        private int hoechstePunktezahl;

        public int SpielerID { get => spielerID; set => spielerID = value; }
        public string Spielername { get => spielername; set => spielername = value; }
        public int HoechstePunktezahl { get => hoechstePunktezahl; set => hoechstePunktezahl = value; }


        public HoechstePunktzahl(int spielerID, string spielername, int hoechstePunktzahl)
        {
            this.spielerID = spielerID;
            this.spielername = spielername;
            this.hoechstePunktezahl = hoechstePunktzahl;
        }
    }
}
