using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSoftware
{
    public partial class Form4 : Form
    {
        Datenbank db = new Datenbank();
        List<Landinfo> liLandinfo = new List<Landinfo>();
        List<Landinfo> liLandinfoBeschraenkt = new List<Landinfo>();
        List<Landinfo> liDreiOptionen = new List<Landinfo>();
        List<Quiz> liQuiz = new List<Quiz>();

        private string quizTyp;
        Spieler spielerInfo; 
        private string beschraenkung;
        

        private int aktuelleFrage = 0;
        private int gesamtpunkte = 0;
        public Form4(string quizTyp, Spieler s, string beschraenkung)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.quizTyp = quizTyp;
            this.spielerInfo = s;
            this.beschraenkung = beschraenkung;
            liLandinfo = db.landinfoEinlesen();
            liLandinfoBeschraenkt = db.landinfoBeschraenktEinlesen(beschraenkung);
           
            frageAnzeigen();

            string bildpfad1;
            bildpfad1 = @"pics\geoquizBackground.jpg";
            this.BackgroundImage = Image.FromFile(bildpfad1);
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        public void frageAnzeigen()
        {
            if (aktuelleFrage >= liLandinfo.Count || aktuelleFrage >= 10)
            {
                Quiz q = new Quiz(-1, spielerInfo.SpielerId, quizTyp, gesamtpunkte);
                int quizLastIndex = db.guizInsert(q);
                Punkte p = new Punkte(-1, spielerInfo.SpielerId, quizLastIndex, gesamtpunkte);
                db.punkteInsert(p);
                MessageBox.Show("Quiz beendet! Gesamtpunkte: " + gesamtpunkte);

                this.Hide();
                Form2 form2 = new Form2(spielerInfo); 
                form2.ShowDialog(); 
                this.Close();
                return;
            }
            if(beschraenkung == "Weltweit")
            {
                lbFLNr.Text = "Frage " + (aktuelleFrage + 1) + " von 10";
                lbFFLText.Text = "Zu welchem Land gehört diese Flagge ?";
                liDreiOptionen = db.getOptionen(liLandinfo[aktuelleFrage]);
                liDreiOptionen.Add(liLandinfo[aktuelleFrage]); 
                                                              
                Random zufall = new Random();
                liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();
                string bildpfad;


                bildpfad = @"flaggen\" + liLandinfo[aktuelleFrage].Flagge;
                pbFlaggeLand.Image = Image.FromFile(bildpfad);


                rbFOption1.Text = liDreiOptionen[0].LandName;
                rbFOption2.Text = liDreiOptionen[1].LandName;
                rbFOption3.Text = liDreiOptionen[2].LandName;
                rbFOption4.Text = liDreiOptionen[3].LandName;
             
                rbFOption1.Checked = false;
                rbFOption2.Checked = false;
                rbFOption3.Checked = false;
                rbFOption4.Checked = false;
            }
            else
            {
                lbFLNr.Text = "Frage " + (aktuelleFrage + 1) + " von 10";
                lbFFLText.Text = "Zu welchem Land gehört diese Flagge ?";
                liDreiOptionen = db.getOptionenBeschraenkt(liLandinfoBeschraenkt[aktuelleFrage], beschraenkung);
                liDreiOptionen.Add(liLandinfoBeschraenkt[aktuelleFrage]); 
                Random zufall = new Random();
                liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();
                string bildpfad;


                bildpfad = @"flaggen\" + liLandinfoBeschraenkt[aktuelleFrage].Flagge;
                pbFlaggeLand.Image = Image.FromFile(bildpfad);


                rbFOption1.Text = liDreiOptionen[0].LandName;
                rbFOption2.Text = liDreiOptionen[1].LandName;
                rbFOption3.Text = liDreiOptionen[2].LandName;
                rbFOption4.Text = liDreiOptionen[3].LandName;
               
                rbFOption1.Checked = false;
                rbFOption2.Checked = false;
                rbFOption3.Checked = false;
                rbFOption4.Checked = false;

            }
         
        }


        private void btnFNext_Click(object sender, EventArgs e)
        {
            if (!rbFOption1.Checked && !rbFOption2.Checked && !rbFOption3.Checked && !rbFOption4.Checked)
            {
                MessageBox.Show("Bitte wähle eine Antwort aus!");
                return;
            }
            if (beschraenkung == "Weltweit")
            {
                string richtigeAntwort = liLandinfo[aktuelleFrage].LandName;
                string ausgewaehlteAntwort = "";
                if (rbFOption1.Checked) ausgewaehlteAntwort = rbFOption1.Text;
                else if (rbFOption2.Checked) ausgewaehlteAntwort = rbFOption2.Text;
                else if (rbFOption3.Checked) ausgewaehlteAntwort = rbFOption3.Text;
                else if (rbFOption4.Checked) ausgewaehlteAntwort = rbFOption4.Text;
                if (ausgewaehlteAntwort == richtigeAntwort)
                {
                    gesamtpunkte += 4;
                    lbFAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                }
                else
                {
                    lbFAnzeige.Text = "Falsch! Die richtige Antwort ist: " + richtigeAntwort;
                }
            }
            else
            {
                string richtigeAntwort = liLandinfoBeschraenkt[aktuelleFrage].LandName;
                string ausgewaehlteAntwort = "";
                if (rbFOption1.Checked) ausgewaehlteAntwort = rbFOption1.Text;
                else if (rbFOption2.Checked) ausgewaehlteAntwort = rbFOption2.Text;
                else if (rbFOption3.Checked) ausgewaehlteAntwort = rbFOption3.Text;
                else if (rbFOption4.Checked) ausgewaehlteAntwort = rbFOption4.Text;
                if (ausgewaehlteAntwort == richtigeAntwort)
                {
                    gesamtpunkte += 4;
                    lbFAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                }
                else
                {
                    lbFAnzeige.Text = "Falsch! Die richtige Antwort ist: " + richtigeAntwort;
                }
            }

            aktuelleFrage++;
            frageAnzeigen();

        }
    }
}
