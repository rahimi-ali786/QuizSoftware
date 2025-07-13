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
    public partial class Form5 : Form
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
        public Form5(string quizTyp, Spieler s, string beschraenkung)
        {
            InitializeComponent();

            this.ControlBox = false;

            this.quizTyp = quizTyp;
            this.spielerInfo = s;

            this.beschraenkung = beschraenkung;
            liLandinfo = db.landinfoEinlesen();
            liLandinfoBeschraenkt = db.landinfoBeschraenktEinlesen(beschraenkung);
            if (beschraenkung != "Weltweit" && (liLandinfoBeschraenkt == null || liLandinfoBeschraenkt.Count == 0))
            {
                MessageBox.Show("Für die gewählte Einschränkung sind keine Länder vorhanden.");
                this.Close();
                return;
            }
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
                lbLFNr.Text = "Frage " + (aktuelleFrage + 1) + " von 10";
                lbFLFText.Text = "Wie sieht die Flagge dieses Land: " + liLandinfo[aktuelleFrage].LandName + " aus?";
                liDreiOptionen = db.getOptionen(liLandinfo[aktuelleFrage]);
                liDreiOptionen.Add(liLandinfo[aktuelleFrage]);

                Random zufall = new Random();
                liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();
                string bildpfad1;
                string bildpfad2;
                string bildpfad3;
                string bildpfad4;


                bildpfad1 = @"flaggen\" + liDreiOptionen[0].Flagge;
                bildpfad2 = @"flaggen\" + liDreiOptionen[1].Flagge;
                bildpfad3 = @"flaggen\" + liDreiOptionen[2].Flagge;
                bildpfad4 = @"flaggen\" + liDreiOptionen[3].Flagge;
                pbFlagge1.Image = Image.FromFile(bildpfad1);
                pbFlagge2.Image = Image.FromFile(bildpfad2);
                pbFlagge3.Image = Image.FromFile(bildpfad3);
                pbFlagge4.Image = Image.FromFile(bildpfad4);

                rbLOption1.Checked = false;
                rbLOption2.Checked = false;
                rbLOption3.Checked = false;
                rbLOption4.Checked = false;
            }
            else
            {
                lbLFNr.Text = "Frage " + (aktuelleFrage + 1) + " von 10";
                lbFLFText.Text = "Wie sieht die Flagge dieses Land: " + liLandinfoBeschraenkt[aktuelleFrage].LandName + " aus?";
                liDreiOptionen = db.getOptionenBeschraenkt(liLandinfoBeschraenkt[aktuelleFrage], beschraenkung);
                liDreiOptionen.Add(liLandinfoBeschraenkt[aktuelleFrage]);

                Random zufall = new Random();
                liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();
                string bildpfad1;
                string bildpfad2;
                string bildpfad3;
                string bildpfad4;


                bildpfad1 = @"flaggen\" + liDreiOptionen[0].Flagge;
                bildpfad2 = @"flaggen\" + liDreiOptionen[1].Flagge;
                bildpfad3 = @"flaggen\" + liDreiOptionen[2].Flagge;
                bildpfad4 = @"flaggen\" + liDreiOptionen[3].Flagge;
                pbFlagge1.Image = Image.FromFile(bildpfad1);
                pbFlagge2.Image = Image.FromFile(bildpfad2);
                pbFlagge3.Image = Image.FromFile(bildpfad3);
                pbFlagge4.Image = Image.FromFile(bildpfad4);

                rbLOption1.Checked = false;
                rbLOption2.Checked = false;
                rbLOption3.Checked = false;
                rbLOption4.Checked = false;
            }
        }
        private void btnLFNext_Click(object sender, EventArgs e)
        {
            if (!rbLOption1.Checked && !rbLOption2.Checked && !rbLOption3.Checked && !rbLOption4.Checked)
            {
                MessageBox.Show("Bitte wähle eine Antwort aus!");
                return;
            }
            if (beschraenkung == "Weltweit")
            {
                string richtigeAntwort = liLandinfo[aktuelleFrage].Flagge;
                string ausgewaehlteAntwort = "";
                if (rbLOption1.Checked) ausgewaehlteAntwort = liDreiOptionen[0].Flagge;
                else if (rbLOption2.Checked) ausgewaehlteAntwort = liDreiOptionen[1].Flagge;
                else if (rbLOption3.Checked) ausgewaehlteAntwort = liDreiOptionen[2].Flagge;
                else if (rbLOption4.Checked) ausgewaehlteAntwort = liDreiOptionen[3].Flagge;
                if (ausgewaehlteAntwort == richtigeAntwort)
                {
                    gesamtpunkte += 4;
                    lbLFAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                    string pfad;
                    pfad = @"flaggen\" + liLandinfo[aktuelleFrage].Flagge;
                    pbFlaggeAntwort.Image = Image.FromFile(pfad);
                }
                else
                {

                    lbLFAnzeige.Text = "Falsch! Die richtige Antwort ist ==> ";
                    string pfad;
                    pfad = @"flaggen\" + liLandinfo[aktuelleFrage].Flagge;
                    pbFlaggeAntwort.Image = Image.FromFile(pfad);
                }
            }
            else
            {
                string richtigeAntwort = liLandinfoBeschraenkt[aktuelleFrage].Flagge;
                string ausgewaehlteAntwort = "";
                if (rbLOption1.Checked) ausgewaehlteAntwort = liDreiOptionen[0].Flagge;
                else if (rbLOption2.Checked) ausgewaehlteAntwort = liDreiOptionen[1].Flagge;
                else if (rbLOption3.Checked) ausgewaehlteAntwort = liDreiOptionen[2].Flagge;
                else if (rbLOption4.Checked) ausgewaehlteAntwort = liDreiOptionen[3].Flagge;
                if (ausgewaehlteAntwort == richtigeAntwort)
                {
                    gesamtpunkte += 4;
                    lbLFAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                    string pfad;
                    pfad = @"flaggen\" + liLandinfoBeschraenkt[aktuelleFrage].Flagge;
                    pbFlaggeAntwort.Image = Image.FromFile(pfad);
                }
                else
                {

                    lbLFAnzeige.Text = "Falsch! Die richtige Antwort ist ==> ";
                    string pfad;
                    pfad = @"flaggen\" + liLandinfoBeschraenkt[aktuelleFrage].Flagge;
                    pbFlaggeAntwort.Image = Image.FromFile(pfad);
                }
            }

            aktuelleFrage++;
            frageAnzeigen();

        }
    }
}
