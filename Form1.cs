namespace QuizSoftware
{
    public partial class Form1 : Form
    {
        Datenbank db = new Datenbank();
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;

            string bildpfad1;
         
            string bildpfad2;
            bildpfad1 = @"pics\geoquizG.jpeg";
            bildpfad2 = @"pics\geoquizBackground.jpg";

            pbquiz1.Image = Image.FromFile(bildpfad1);
           
            this.BackgroundImage = Image.FromFile(bildpfad2);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string bname = txtSName.Text;
            string passwort = txtSPasswort.Text;

            Spieler b = db.benutzerUberpruefen(bname, passwort);
            if (b != null)
            {
                this.Hide();
                Form2 form2 = new Form2(b);
                form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string bname = txtSName.Text;
            string passwort = txtSPasswort.Text;
            Spieler b = db.benutzerUberpruefen(bname, passwort);
            if (b != null)
            {
                MessageBox.Show("Ein Benutzer mit diesem Namen existiert bereits! Bitte wähle einen anderen Namen");
            }
            else
            {
                Spieler neueBenutzer = new Spieler(-1, bname, passwort);
                db.benutzerInsert(neueBenutzer);
                MessageBox.Show("Benutzer erfolgreich registriert!");

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
