namespace QuizSoftware
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFNummer = new Label();
            groupBox1 = new GroupBox();
            lbAnzeige = new Label();
            lbFText = new Label();
            rbOption1 = new RadioButton();
            groupBox2 = new GroupBox();
            rbOption4 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption2 = new RadioButton();
            btnNext = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbFNummer
            // 
            lbFNummer.AutoSize = true;
            lbFNummer.Location = new Point(297, 23);
            lbFNummer.Name = "lbFNummer";
            lbFNummer.Size = new Size(80, 20);
            lbFNummer.TabIndex = 0;
            lbFNummer.Text = "Frage 1/10";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.geoquizQ;
            groupBox1.Controls.Add(lbAnzeige);
            groupBox1.Controls.Add(lbFText);
            groupBox1.Controls.Add(lbFNummer);
            groupBox1.Location = new Point(162, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 333);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quiz";
            // 
            // lbAnzeige
            // 
            lbAnzeige.AutoSize = true;
            lbAnzeige.Location = new Point(45, 287);
            lbAnzeige.Name = "lbAnzeige";
            lbAnzeige.Size = new Size(82, 20);
            lbAnzeige.TabIndex = 2;
            lbAnzeige.Text = "Viel Erfolg!";
            // 
            // lbFText
            // 
            lbFText.AutoSize = true;
            lbFText.Location = new Point(45, 57);
            lbFText.Name = "lbFText";
            lbFText.Size = new Size(265, 20);
            lbFText.TabIndex = 1;
            lbFText.Text = "1. Was ist die Hauptstadt von Spanien?";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(20, 26);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(84, 24);
            rbOption1.TabIndex = 2;
            rbOption1.TabStop = true;
            rbOption1.Text = "Option1";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(rbOption4);
            groupBox2.Controls.Add(rbOption3);
            groupBox2.Controls.Add(rbOption2);
            groupBox2.Controls.Add(rbOption1);
            groupBox2.Location = new Point(205, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 145);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "antwortMoeglichkeiten";
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(21, 115);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(84, 24);
            rbOption4.TabIndex = 3;
            rbOption4.TabStop = true;
            rbOption4.Text = "Option4";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(21, 86);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(84, 24);
            rbOption3.TabIndex = 4;
            rbOption3.TabStop = true;
            rbOption3.Text = "Option3";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(20, 54);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(84, 24);
            rbOption2.TabIndex = 3;
            rbOption2.TabStop = true;
            rbOption2.Text = "Option2";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGray;
            btnNext.Location = new Point(698, 493);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(133, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Nächte";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1000, 618);
            Controls.Add(btnNext);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Land - Hauptstadt || Hauptstadt - Land";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbFNummer;
        private GroupBox groupBox1;
        private Label lbFText;
        private RadioButton rbOption1;
        private GroupBox groupBox2;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private Label lbAnzeige;
        private RadioButton rbOption4;
        private Button btnNext;
    }
}