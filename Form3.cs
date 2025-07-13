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
    public partial class Form3 : Form
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

        public Form3(string quizTyp, Spieler s, string beschraenkung)
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
                Quiz q = new Quiz(-1,spielerInfo.SpielerId,quizTyp,gesamtpunkte);
                int quizLastIndex =  db.guizInsert(q);
                Punkte p = new Punkte(-1, spielerInfo.SpielerId, quizLastIndex, gesamtpunkte);
                db.punkteInsert(p);

                MessageBox.Show("Quiz beendet! Gesamtpunkte: " + gesamtpunkte);

                this.Hide();
                Form2 form2 = new Form2(spielerInfo); 
                form2.ShowDialog();
                this.Close();
                return;

            }
            lbFNummer.Text = "Frage " + (aktuelleFrage + 1) + " von 10";
            if (quizTyp == "Land-Hauptstadt")
            {
               
                if (beschraenkung == "Weltweit")
                {
                    lbFText.Text = "Was ist die Hauptstadt von " + liLandinfo[aktuelleFrage].LandName + " ?";

                    liDreiOptionen = db.getOptionen(liLandinfo[aktuelleFrage]);
                    liDreiOptionen.Add(liLandinfo[aktuelleFrage]);

                   
                    Random zufall = new Random();
                    liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();

                    rbOption1.Text = liDreiOptionen[0].Hauptstadt;
                    rbOption2.Text = liDreiOptionen[1].Hauptstadt;
                    rbOption3.Text = liDreiOptionen[2].Hauptstadt;
                    rbOption4.Text = liDreiOptionen[3].Hauptstadt;

                  
                    rbOption1.Checked = false;
                    rbOption2.Checked = false;
                    rbOption3.Checked = false;
                    rbOption4.Checked = false;
                }
                else
                {
                    lbFText.Text = "Was ist die Hauptstadt von " + liLandinfoBeschraenkt[aktuelleFrage].LandName + " ?";

                    liDreiOptionen = db.getOptionenBeschraenkt(liLandinfoBeschraenkt[aktuelleFrage], beschraenkung);
                    liDreiOptionen.Add(liLandinfoBeschraenkt[aktuelleFrage]); 

                
                    Random zufall = new Random();
                    liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();

                    rbOption1.Text = liDreiOptionen[0].Hauptstadt;
                    rbOption2.Text = liDreiOptionen[1].Hauptstadt;
                    rbOption3.Text = liDreiOptionen[2].Hauptstadt;
                    rbOption4.Text = liDreiOptionen[3].Hauptstadt;

                    
                    rbOption1.Checked = false;
                    rbOption2.Checked = false;
                    rbOption3.Checked = false;
                    rbOption4.Checked = false;

                }
             
            }
            else if (quizTyp == "Hauptstadt-Land")
            {
                if(beschraenkung == "Weltweit")
                {
                    lbFText.Text = "Zu welchem Land gehört die Hauptstadt " + liLandinfo[aktuelleFrage].Hauptstadt + " ?";

                    liDreiOptionen = db.getOptionen(liLandinfo[aktuelleFrage]);
                    liDreiOptionen.Add(liLandinfo[aktuelleFrage]); 

                  
                    Random zufall = new Random();
                    liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();

                    rbOption1.Text = liDreiOptionen[0].LandName;
                    rbOption2.Text = liDreiOptionen[1].LandName;
                    rbOption3.Text = liDreiOptionen[2].LandName;
                    rbOption4.Text = liDreiOptionen[3].LandName;

                 
                    rbOption1.Checked = false;
                    rbOption2.Checked = false;
                    rbOption3.Checked = false;
                    rbOption4.Checked = false;
                }
                else
                {
                    lbFText.Text = "Zu welchem Land gehört die Hauptstadt " + liLandinfoBeschraenkt[aktuelleFrage].Hauptstadt + " ?";

                    liDreiOptionen = db.getOptionenBeschraenkt(liLandinfo[aktuelleFrage], beschraenkung);
                    liDreiOptionen.Add(liLandinfoBeschraenkt[aktuelleFrage]); 

                   
                    Random zufall = new Random();
                    liDreiOptionen = liDreiOptionen.OrderBy(x => zufall.Next()).ToList();

                    rbOption1.Text = liDreiOptionen[0].LandName;
                    rbOption2.Text = liDreiOptionen[1].LandName;
                    rbOption3.Text = liDreiOptionen[2].LandName;
                    rbOption4.Text = liDreiOptionen[3].LandName;

                   
                    rbOption1.Checked = false;
                    rbOption2.Checked = false;
                    rbOption3.Checked = false;
                    rbOption4.Checked = false;

                }
                   
            }
            else if(quizTyp == "Flagge-Land")
            {

                this.Hide();
                Form4 form4 = new Form4(quizTyp,spielerInfo, beschraenkung);
                form4.ShowDialog();
                this.Close();
                
                return; 
               
            }
            else if(quizTyp == "Land-Flagge")
            {
                this.Hide();
                Form5 form5 = new Form5(quizTyp, spielerInfo, beschraenkung);
                form5.ShowDialog();
                this.Close();
                return;
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!rbOption1.Checked && !rbOption2.Checked && !rbOption3.Checked && !rbOption4.Checked)
            {
                MessageBox.Show("Bitte wähle eine Antwort aus!");
                return;
            }

            if (quizTyp == "Land-Hauptstadt")
            {
                if(beschraenkung == "Weltweit")
                {
                    string richtigeAntwort = liLandinfo[aktuelleFrage].Hauptstadt;
                    string ausgewaehlteAntwort = "";

                    if (rbOption1.Checked) ausgewaehlteAntwort = rbOption1.Text;
                    else if (rbOption2.Checked) ausgewaehlteAntwort = rbOption2.Text;
                    else if (rbOption3.Checked) ausgewaehlteAntwort = rbOption3.Text;
                    else if (rbOption4.Checked) ausgewaehlteAntwort = rbOption4.Text;

                    if (ausgewaehlteAntwort == richtigeAntwort)
                    {
                        gesamtpunkte += 4;
                        lbAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                    }
                    else
                    {
                        lbAnzeige.Text = "Falsch! Die richtige Antwort ist: " + richtigeAntwort;
                    }
                }
                else
                {
                    string richtigeAntwort = liLandinfoBeschraenkt[aktuelleFrage].Hauptstadt;
                    string ausgewaehlteAntwort = "";

                    if (rbOption1.Checked) ausgewaehlteAntwort = rbOption1.Text;
                    else if (rbOption2.Checked) ausgewaehlteAntwort = rbOption2.Text;
                    else if (rbOption3.Checked) ausgewaehlteAntwort = rbOption3.Text;
                    else if (rbOption4.Checked) ausgewaehlteAntwort = rbOption4.Text;

                    if (ausgewaehlteAntwort == richtigeAntwort)
                    {
                        gesamtpunkte += 4;
                        lbAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                    }
                    else
                    {
                        lbAnzeige.Text = "Falsch! Die richtige Antwort ist: " + richtigeAntwort;
                    }
                }
            }
            else if (quizTyp == "Hauptstadt-Land")
            {
                if(beschraenkung== "Weltweit")
                {
                    string richtigeAntwort = liLandinfo[aktuelleFrage].LandName;
                    string ausgewaehlteAntwort = "";

                    if (rbOption1.Checked) ausgewaehlteAntwort = rbOption1.Text;
                    else if (rbOption2.Checked) ausgewaehlteAntwort = rbOption2.Text;
                    else if (rbOption3.Checked) ausgewaehlteAntwort = rbOption3.Text;
                    else if (rbOption4.Checked) ausgewaehlteAntwort = rbOption4.Text;

                    if (ausgewaehlteAntwort == richtigeAntwort)
                    {
                        gesamtpunkte += 4;
                        lbAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                    }
                    else
                    {
                        lbAnzeige.Text = "Falsch! Die richtige Antwort ist: " + richtigeAntwort;
                    }
                }
                else
                {
                    string richtigeAntwort = liLandinfoBeschraenkt[aktuelleFrage].LandName;
                    string ausgewaehlteAntwort = "";

                    if (rbOption1.Checked) ausgewaehlteAntwort = rbOption1.Text;
                    else if (rbOption2.Checked) ausgewaehlteAntwort = rbOption2.Text;
                    else if (rbOption3.Checked) ausgewaehlteAntwort = rbOption3.Text;
                    else if (rbOption4.Checked) ausgewaehlteAntwort = rbOption4.Text;

                    if (ausgewaehlteAntwort == richtigeAntwort)
                    {
                        gesamtpunkte += 4;
                        lbAnzeige.Text = "Richtig! Du hast " + gesamtpunkte + " Punkte.";
                    }
                    else
                    {
                        lbAnzeige.Text = "Falsch! Die richtige Antwort ist: " + richtigeAntwort;
                    }
                }
             
            }

            aktuelleFrage++;
            frageAnzeigen();
        }
    }
}

