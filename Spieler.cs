using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSoftware
{
    public class Spieler
    {
        private int spielerId;
        private string spielerName;
        private string passwort;

        public int SpielerId { get => spielerId; set => spielerId = value; }
        public string SpielerName { get => spielerName; set => spielerName = value; }
        public string Passwort { get => passwort; set => passwort = value; }
      

        public Spieler(int spielerId, string name, string passwort)
        { 
            this.spielerId = spielerId;
            this.spielerName = name;
            this.passwort = passwort;
        }


    }
}
