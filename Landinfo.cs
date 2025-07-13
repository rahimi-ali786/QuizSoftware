using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSoftware
{
    public class Landinfo
    {
        private int landID;
        private string landName;
        private string hauptstadt;
        private string flagge;
        private string kontinent;

        public int LandID { get => landID; set => landID = value; }
        public string LandName { get => landName; set => landName = value; }
        public string Hauptstadt { get => hauptstadt; set => hauptstadt = value; }
        public string Flagge { get => flagge; set => flagge = value; }
        public string Kontinent { get => kontinent; set => kontinent = value; }

        public Landinfo(int landID, string landName, string hauptstadt, string flagge, string kontinent)
        {
            this.landID = landID;
            this.landName = landName;
            this.hauptstadt = hauptstadt;
            this.flagge = flagge;
            this.kontinent = kontinent;
            
        }
    }
}
