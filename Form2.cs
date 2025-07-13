using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace QuizSoftware
{
    public partial class Form2 : Form
    {
        Datenbank db = new Datenbank();
        List<Spieler> liSpieler = new List<Spieler>();
        List<Landinfo> liLandinfo = new List<Landinfo>();
        List<Punkte> liPunkte = new List<Punkte>();
        List<Punkte> liPunkteVonSpieler = new List<Punkte>();
        List<HoechstePunktzahl> liHoechstePunktzahl = new List<HoechstePunktzahl>();
        List<Quiz> liQuiz = new List<Quiz>();

        Spieler spielerInfo;
        private string defaultQuizTyp = "Hauptstadt-Land";
        private string defaultKontinent = "Weltweit";

        public Form2(Spieler s)
        {
            InitializeComponent();
            configInfoMessage();
            this.ControlBox = false;
            this.spielerInfo = s;


            Dictionary<string, string> config = ReadConfig("config.ini");
            string quizTyp;
            if (config.TryGetValue("quizTyp", out quizTyp))
                defaultQuizTyp = quizTyp;
            string kontinent;
            if (config.TryGetValue("kontinent", out kontinent))
                defaultKontinent = kontinent;

            punkteAnzeigen();

            string bildpfad1;
            bildpfad1 = @"pics\geoquizBackground.jpg";
            this.BackgroundImage = Image.FromFile(bildpfad1);
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string ausgewaehlteOption = "";
            string ausgewaehtleAOption = "";
            string ausgewaehlteKontinent = "";

            if (!rbLand.Checked && !rbHauptstadt.Checked && !rbFlagge.Checked)
            {
                ausgewaehlteOption = defaultQuizTyp.Split('-')[0];
            }
            else
            {
                if (rbLand.Checked)
                    ausgewaehlteOption = rbLand.Text;
                else if (rbHauptstadt.Checked)
                    ausgewaehlteOption = rbHauptstadt.Text;
                else if (rbFlagge.Checked)
                    ausgewaehlteOption = rbFlagge.Text;
            }

            if (!rbALand.Checked && !rbAHauptstadt.Checked && !rbAFlagge.Checked)
            {
                ausgewaehtleAOption = defaultQuizTyp.Split('-')[1];
            }
            else
            {
                if (rbALand.Checked)
                    ausgewaehtleAOption = rbALand.Text;
                else if (rbAHauptstadt.Checked)
                    ausgewaehtleAOption = rbAHauptstadt.Text;
                else if (rbAFlagge.Checked)
                    ausgewaehtleAOption = rbAFlagge.Text;
            }

            if (
                !rbEuropa.Checked && !rbNordamerika.Checked && !rbSuedamerika.Checked &&
                !rbAsien.Checked && !rbAfrika.Checked && !rbAustralien.Checked
            )
            {
                ausgewaehlteKontinent = defaultKontinent;
            }
            else
            {
                if (rbEuropa.Checked)
                    ausgewaehlteKontinent = rbEuropa.Text;
                else if (rbNordamerika.Checked)
                    ausgewaehlteKontinent = rbNordamerika.Text;
                else if (rbSuedamerika.Checked)
                    ausgewaehlteKontinent = rbSuedamerika.Text;
                else if (rbAsien.Checked)
                    ausgewaehlteKontinent = rbAsien.Text;
                else if (rbAustralien.Checked)
                    ausgewaehlteKontinent = rbAustralien.Text;
                else if (rbAfrika.Checked)
                    ausgewaehlteKontinent = rbAfrika.Text;
            }

            if (ausgewaehtleAOption == rbAHauptstadt.Text || ausgewaehtleAOption == rbAFlagge.Text)
            {

                MessageBox.Show("Quiztyp: " + ausgewaehlteOption + " anhand der " + ausgewaehtleAOption + " erraten" + '\u263A');
            }
            else if (ausgewaehtleAOption == rbALand.Text)
            {
                MessageBox.Show("Quiztyp: " + ausgewaehlteOption + " anhand des " + ausgewaehtleAOption + " erraten" + '\u263A');
            }
          
            try {
                string quizTyp = ausgewaehlteOption + "-" + ausgewaehtleAOption;
                string beschraenkung = ausgewaehlteKontinent;

                this.Hide();
                Form3 form3 = new Form3(quizTyp, spielerInfo, beschraenkung);
                form3.ShowDialog();
            }
            catch(Exception ex)
            {
                Application.Exit();
            }
            
        }

        private void punkteAnzeigen()
        {
            liPunkteVonSpieler = db.punkteEinlesenVonSpieler(spielerInfo);
            foreach (Punkte p in liPunkteVonSpieler)
            {

                dgvPunkte.Rows.Add(spielerInfo.SpielerId, spielerInfo.SpielerName, p.QuizID, p.GesamtPunkte);
            }

            liHoechstePunktzahl = db.hoechstPunkteEinlesen();
            foreach (HoechstePunktzahl hp in liHoechstePunktzahl)
            {
                dgvHPunktzahl.Rows.Add(hp.SpielerID, hp.Spielername, hp.HoechstePunktezahl);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private Dictionary<string, string> ReadConfig(string path)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (!File.Exists(path))
                return dict;

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith("#"))
                    continue;

                string[] parts = trimmed.Split('=', 2);
                if (parts.Length == 2)
                    dict[parts[0].Trim()] = parts[1].Trim();
            }
            return dict;
        }

        public void configInfoMessage()
        {
            if (
                !rbLand.Checked && !rbHauptstadt.Checked && !rbFlagge.Checked &&
                !rbALand.Checked && !rbAHauptstadt.Checked && !rbAFlagge.Checked &&
                !rbEuropa.Checked && !rbNordamerika.Checked && !rbSuedamerika.Checked &&
                !rbAsien.Checked && !rbAfrika.Checked && !rbAustralien.Checked
              )
            {
                lbConfigInfo.Visible = true;
                lbConfigInfo2.Visible = true;
                lbConfigInfo.Text = "Es wurden kein Quiztyp gewählt. Die Einstellungen aus der config.ini werden verwendet! ";
                lbConfigInfo2.Text = "Quiztyp: " + defaultQuizTyp + " - " + defaultKontinent;
            }

            else if (
                rbLand.Checked || rbHauptstadt.Checked || rbFlagge.Checked ||
                rbALand.Checked || rbAHauptstadt.Checked || rbAFlagge.Checked ||
                rbEuropa.Checked || rbNordamerika.Checked || rbSuedamerika.Checked ||
                rbAsien.Checked || rbAfrika.Checked || rbAustralien.Checked
                )
            {
                lbConfigInfo.Visible = false;
                lbConfigInfo2.Visible = false;

            }
        }
        private void rbLand_CheckedChanged(object sender, EventArgs e)
        {
            rbALand.Enabled = false;
            rbAHauptstadt.Enabled = true;
            rbAFlagge.Enabled = true;
            configInfoMessage();
        }

        private void rbHauptstadt_CheckedChanged(object sender, EventArgs e)
        {

            rbAHauptstadt.Enabled = false;
            rbAFlagge.Enabled = false;
            rbALand.Enabled = true;
            configInfoMessage();
        }

        private void rbFlagge_CheckedChanged(object sender, EventArgs e)
        {
            rbAFlagge.Enabled = false;
            rbAHauptstadt.Enabled = false;
            rbALand.Enabled = true;
            configInfoMessage();
        }
        private void rbALand_CheckedChanged(object sender, EventArgs e){configInfoMessage();}
        private void rbAHauptstadt_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbAFlagge_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbEuropa_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbNordamerika_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbSuedamerika_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbAsien_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbAfrika_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}
        private void rbAustralien_CheckedChanged(object sender, EventArgs e) {configInfoMessage();}

       

    }
}
