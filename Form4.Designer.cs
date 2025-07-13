namespace QuizSoftware
{
    partial class Form4
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
            lbFLNr = new Label();
            groupBox1 = new GroupBox();
            lbFAnzeige = new Label();
            groupBox2 = new GroupBox();
            rbFOption4 = new RadioButton();
            rbFOption3 = new RadioButton();
            rbFOption2 = new RadioButton();
            rbFOption1 = new RadioButton();
            pbFlaggeLand = new PictureBox();
            lbFFLText = new Label();
            btnFNext = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlaggeLand).BeginInit();
            SuspendLayout();
            // 
            // lbFLNr
            // 
            lbFLNr.AutoSize = true;
            lbFLNr.Location = new Point(231, 23);
            lbFLNr.Name = "lbFLNr";
            lbFLNr.Size = new Size(83, 20);
            lbFLNr.TabIndex = 0;
            lbFLNr.Text = "Frage: 1/10";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.BackgroundImage = Properties.Resources.geoquizQ;
            groupBox1.Controls.Add(lbFAnzeige);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pbFlaggeLand);
            groupBox1.Controls.Add(lbFFLText);
            groupBox1.Controls.Add(lbFLNr);
            groupBox1.Location = new Point(83, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 298);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quiz";
            // 
            // lbFAnzeige
            // 
            lbFAnzeige.AutoSize = true;
            lbFAnzeige.Location = new Point(37, 255);
            lbFAnzeige.Name = "lbFAnzeige";
            lbFAnzeige.Size = new Size(82, 20);
            lbFAnzeige.TabIndex = 4;
            lbFAnzeige.Text = "Viel Erfolg!";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(rbFOption4);
            groupBox2.Controls.Add(rbFOption3);
            groupBox2.Controls.Add(rbFOption2);
            groupBox2.Controls.Add(rbFOption1);
            groupBox2.Location = new Point(33, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 144);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Antwortmöglichkeiten";
            // 
            // rbFOption4
            // 
            rbFOption4.AutoSize = true;
            rbFOption4.Location = new Point(18, 113);
            rbFOption4.Name = "rbFOption4";
            rbFOption4.Size = new Size(84, 24);
            rbFOption4.TabIndex = 3;
            rbFOption4.TabStop = true;
            rbFOption4.Text = "Option4";
            rbFOption4.UseVisualStyleBackColor = true;
            // 
            // rbFOption3
            // 
            rbFOption3.AutoSize = true;
            rbFOption3.Location = new Point(17, 86);
            rbFOption3.Name = "rbFOption3";
            rbFOption3.Size = new Size(84, 24);
            rbFOption3.TabIndex = 2;
            rbFOption3.TabStop = true;
            rbFOption3.Text = "Option3";
            rbFOption3.UseVisualStyleBackColor = true;
            // 
            // rbFOption2
            // 
            rbFOption2.AutoSize = true;
            rbFOption2.Location = new Point(17, 58);
            rbFOption2.Name = "rbFOption2";
            rbFOption2.Size = new Size(84, 24);
            rbFOption2.TabIndex = 1;
            rbFOption2.TabStop = true;
            rbFOption2.Text = "Option2";
            rbFOption2.UseVisualStyleBackColor = true;
            // 
            // rbFOption1
            // 
            rbFOption1.AutoSize = true;
            rbFOption1.Location = new Point(17, 28);
            rbFOption1.Name = "rbFOption1";
            rbFOption1.Size = new Size(84, 24);
            rbFOption1.TabIndex = 0;
            rbFOption1.TabStop = true;
            rbFOption1.Text = "Option1";
            rbFOption1.UseVisualStyleBackColor = true;
            // 
            // pbFlaggeLand
            // 
            pbFlaggeLand.BackColor = Color.Transparent;
            pbFlaggeLand.Location = new Point(393, 50);
            pbFlaggeLand.Name = "pbFlaggeLand";
            pbFlaggeLand.Size = new Size(195, 181);
            pbFlaggeLand.SizeMode = PictureBoxSizeMode.Zoom;
            pbFlaggeLand.TabIndex = 2;
            pbFlaggeLand.TabStop = false;
            // 
            // lbFFLText
            // 
            lbFFLText.AutoSize = true;
            lbFFLText.Location = new Point(37, 58);
            lbFFLText.Name = "lbFFLText";
            lbFFLText.Size = new Size(268, 20);
            lbFFLText.TabIndex = 1;
            lbFFLText.Text = "Zu welchem Land gehört diese Flagge?";
            // 
            // btnFNext
            // 
            btnFNext.BackColor = Color.Silver;
            btnFNext.Location = new Point(621, 382);
            btnFNext.Name = "btnFNext";
            btnFNext.Size = new Size(94, 29);
            btnFNext.TabIndex = 2;
            btnFNext.Text = "Nächste";
            btnFNext.UseVisualStyleBackColor = false;
            btnFNext.Click += btnFNext_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFNext);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Quiztyp: Flagge - Land";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlaggeLand).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbFLNr;
        private GroupBox groupBox1;
        private Label lbFFLText;
        private PictureBox pbFlaggeLand;
        private GroupBox groupBox2;
        private RadioButton rbFOption4;
        private RadioButton rbFOption3;
        private RadioButton rbFOption2;
        private RadioButton rbFOption1;
        private Label lbFAnzeige;
        private Button btnFNext;
    }
}