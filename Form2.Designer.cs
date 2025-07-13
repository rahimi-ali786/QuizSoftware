namespace QuizSoftware
{
    partial class Form2
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
            label1 = new Label();
            rbLand = new RadioButton();
            rbHauptstadt = new RadioButton();
            rbFlagge = new RadioButton();
            rbALand = new RadioButton();
            rbAHauptstadt = new RadioButton();
            rbAFlagge = new RadioButton();
            btnStart = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvPunkte = new DataGridView();
            spielerID = new DataGridViewTextBoxColumn();
            spielerName = new DataGridViewTextBoxColumn();
            quizID = new DataGridViewTextBoxColumn();
            gesamtPunkte = new DataGridViewTextBoxColumn();
            lbPunktzahl = new Label();
            dgvHPunktzahl = new DataGridView();
            hspielerID = new DataGridViewTextBoxColumn();
            spielerHName = new DataGridViewTextBoxColumn();
            punkteH = new DataGridViewTextBoxColumn();
            lbHPunktzahl = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            rbAustralien = new RadioButton();
            rbAfrika = new RadioButton();
            rbAsien = new RadioButton();
            rbSuedamerika = new RadioButton();
            rbNordamerika = new RadioButton();
            rbEuropa = new RadioButton();
            btnLogout = new Button();
            lbConfigInfo = new Label();
            lbConfigInfo2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPunkte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHPunktzahl).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 0;
            label1.Text = "Welchen Quiztyp möchten Sie spielen?";
            // 
            // rbLand
            // 
            rbLand.AutoSize = true;
            rbLand.Location = new Point(6, 35);
            rbLand.Name = "rbLand";
            rbLand.Size = new Size(62, 24);
            rbLand.TabIndex = 6;
            rbLand.TabStop = true;
            rbLand.Text = "Land";
            rbLand.UseVisualStyleBackColor = true;
            rbLand.CheckedChanged += rbLand_CheckedChanged;
            // 
            // rbHauptstadt
            // 
            rbHauptstadt.AutoSize = true;
            rbHauptstadt.Location = new Point(6, 60);
            rbHauptstadt.Name = "rbHauptstadt";
            rbHauptstadt.Size = new Size(104, 24);
            rbHauptstadt.TabIndex = 7;
            rbHauptstadt.TabStop = true;
            rbHauptstadt.Text = "Hauptstadt";
            rbHauptstadt.UseVisualStyleBackColor = true;
            rbHauptstadt.CheckedChanged += rbHauptstadt_CheckedChanged;
            // 
            // rbFlagge
            // 
            rbFlagge.AutoSize = true;
            rbFlagge.Location = new Point(6, 84);
            rbFlagge.Name = "rbFlagge";
            rbFlagge.Size = new Size(75, 24);
            rbFlagge.TabIndex = 8;
            rbFlagge.TabStop = true;
            rbFlagge.Text = "Flagge";
            rbFlagge.UseVisualStyleBackColor = true;
            rbFlagge.CheckedChanged += rbFlagge_CheckedChanged;
            // 
            // rbALand
            // 
            rbALand.AutoSize = true;
            rbALand.Location = new Point(6, 33);
            rbALand.Name = "rbALand";
            rbALand.Size = new Size(62, 24);
            rbALand.TabIndex = 9;
            rbALand.TabStop = true;
            rbALand.Text = "Land";
            rbALand.UseVisualStyleBackColor = true;
            rbALand.CheckedChanged += rbALand_CheckedChanged;
            // 
            // rbAHauptstadt
            // 
            rbAHauptstadt.AutoSize = true;
            rbAHauptstadt.Location = new Point(6, 58);
            rbAHauptstadt.Name = "rbAHauptstadt";
            rbAHauptstadt.Size = new Size(104, 24);
            rbAHauptstadt.TabIndex = 10;
            rbAHauptstadt.TabStop = true;
            rbAHauptstadt.Text = "Hauptstadt";
            rbAHauptstadt.UseVisualStyleBackColor = true;
            rbAHauptstadt.CheckedChanged += rbAHauptstadt_CheckedChanged;
            // 
            // rbAFlagge
            // 
            rbAFlagge.AutoSize = true;
            rbAFlagge.Location = new Point(6, 84);
            rbAFlagge.Name = "rbAFlagge";
            rbAFlagge.Size = new Size(75, 24);
            rbAFlagge.TabIndex = 11;
            rbAFlagge.TabStop = true;
            rbAFlagge.Text = "Flagge";
            rbAFlagge.UseVisualStyleBackColor = true;
            rbAFlagge.CheckedChanged += rbAFlagge_CheckedChanged;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DodgerBlue;
            btnStart.Location = new Point(54, 252);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(156, 29);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(52, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 176);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quiztyp";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(rbALand);
            groupBox3.Controls.Add(rbAFlagge);
            groupBox3.Controls.Add(rbAHauptstadt);
            groupBox3.Location = new Point(264, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(157, 125);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Antwort";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(rbLand);
            groupBox2.Controls.Add(rbHauptstadt);
            groupBox2.Controls.Add(rbFlagge);
            groupBox2.Location = new Point(27, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 125);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fragen";
            // 
            // dgvPunkte
            // 
            dgvPunkte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPunkte.BackgroundColor = SystemColors.ActiveCaption;
            dgvPunkte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPunkte.Columns.AddRange(new DataGridViewColumn[] { spielerID, spielerName, quizID, gesamtPunkte });
            dgvPunkte.Location = new Point(89, 363);
            dgvPunkte.Name = "dgvPunkte";
            dgvPunkte.RowHeadersWidth = 51;
            dgvPunkte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPunkte.Size = new Size(834, 149);
            dgvPunkte.TabIndex = 14;
            // 
            // spielerID
            // 
            spielerID.HeaderText = "Spieler ID";
            spielerID.MinimumWidth = 6;
            spielerID.Name = "spielerID";
            // 
            // spielerName
            // 
            spielerName.HeaderText = "Spieler Name";
            spielerName.MinimumWidth = 6;
            spielerName.Name = "spielerName";
            // 
            // quizID
            // 
            quizID.HeaderText = "Quiz ID";
            quizID.MinimumWidth = 6;
            quizID.Name = "quizID";
            // 
            // gesamtPunkte
            // 
            gesamtPunkte.HeaderText = "Punkte";
            gesamtPunkte.MinimumWidth = 6;
            gesamtPunkte.Name = "gesamtPunkte";
            // 
            // lbPunktzahl
            // 
            lbPunktzahl.AutoSize = true;
            lbPunktzahl.Location = new Point(89, 334);
            lbPunktzahl.Name = "lbPunktzahl";
            lbPunktzahl.Size = new Size(211, 20);
            lbPunktzahl.TabIndex = 15;
            lbPunktzahl.Text = "Deine Punktzahl in jedem Quiz";
            // 
            // dgvHPunktzahl
            // 
            dgvHPunktzahl.AllowUserToAddRows = false;
            dgvHPunktzahl.AllowUserToDeleteRows = false;
            dgvHPunktzahl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHPunktzahl.BackgroundColor = SystemColors.ActiveCaption;
            dgvHPunktzahl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHPunktzahl.Columns.AddRange(new DataGridViewColumn[] { hspielerID, spielerHName, punkteH });
            dgvHPunktzahl.Location = new Point(89, 544);
            dgvHPunktzahl.Name = "dgvHPunktzahl";
            dgvHPunktzahl.ReadOnly = true;
            dgvHPunktzahl.RowHeadersWidth = 51;
            dgvHPunktzahl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHPunktzahl.Size = new Size(834, 134);
            dgvHPunktzahl.TabIndex = 16;
            // 
            // hspielerID
            // 
            hspielerID.HeaderText = "Spieler ID";
            hspielerID.MinimumWidth = 6;
            hspielerID.Name = "hspielerID";
            hspielerID.ReadOnly = true;
            // 
            // spielerHName
            // 
            spielerHName.HeaderText = "Spieler Name";
            spielerHName.MinimumWidth = 6;
            spielerHName.Name = "spielerHName";
            spielerHName.ReadOnly = true;
            // 
            // punkteH
            // 
            punkteH.HeaderText = "höchste Punktzahl";
            punkteH.MinimumWidth = 6;
            punkteH.Name = "punkteH";
            punkteH.ReadOnly = true;
            // 
            // lbHPunktzahl
            // 
            lbHPunktzahl.AutoSize = true;
            lbHPunktzahl.Location = new Point(89, 518);
            lbHPunktzahl.Name = "lbHPunktzahl";
            lbHPunktzahl.Size = new Size(451, 20);
            lbHPunktzahl.TabIndex = 17;
            lbHPunktzahl.Text = "Die höchste Gesamtpunktzahl aller Spieler über alle Quizze hinweg";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(545, 67);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(378, 176);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quiztyp";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Silver;
            groupBox5.Controls.Add(rbAustralien);
            groupBox5.Controls.Add(rbAfrika);
            groupBox5.Controls.Add(rbAsien);
            groupBox5.Controls.Add(rbSuedamerika);
            groupBox5.Controls.Add(rbNordamerika);
            groupBox5.Controls.Add(rbEuropa);
            groupBox5.Location = new Point(20, 28);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(311, 133);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kontinente";
            // 
            // rbAustralien
            // 
            rbAustralien.AutoSize = true;
            rbAustralien.Location = new Point(197, 95);
            rbAustralien.Name = "rbAustralien";
            rbAustralien.Size = new Size(96, 24);
            rbAustralien.TabIndex = 5;
            rbAustralien.TabStop = true;
            rbAustralien.Text = "Australien";
            rbAustralien.UseVisualStyleBackColor = true;
            rbAustralien.CheckedChanged += rbAustralien_CheckedChanged;
            // 
            // rbAfrika
            // 
            rbAfrika.AutoSize = true;
            rbAfrika.Location = new Point(200, 65);
            rbAfrika.Name = "rbAfrika";
            rbAfrika.Size = new Size(69, 24);
            rbAfrika.TabIndex = 4;
            rbAfrika.TabStop = true;
            rbAfrika.Text = "Afrika";
            rbAfrika.UseVisualStyleBackColor = true;
            rbAfrika.CheckedChanged += rbAfrika_CheckedChanged;
            // 
            // rbAsien
            // 
            rbAsien.AutoSize = true;
            rbAsien.Location = new Point(200, 34);
            rbAsien.Name = "rbAsien";
            rbAsien.Size = new Size(66, 24);
            rbAsien.TabIndex = 3;
            rbAsien.TabStop = true;
            rbAsien.Text = "Asien";
            rbAsien.UseVisualStyleBackColor = true;
            rbAsien.CheckedChanged += rbAsien_CheckedChanged;
            // 
            // rbSuedamerika
            // 
            rbSuedamerika.AutoSize = true;
            rbSuedamerika.Location = new Point(26, 95);
            rbSuedamerika.Name = "rbSuedamerika";
            rbSuedamerika.Size = new Size(108, 24);
            rbSuedamerika.TabIndex = 2;
            rbSuedamerika.TabStop = true;
            rbSuedamerika.Text = "Südamerika";
            rbSuedamerika.UseVisualStyleBackColor = true;
            rbSuedamerika.CheckedChanged += rbSuedamerika_CheckedChanged;
            // 
            // rbNordamerika
            // 
            rbNordamerika.AutoSize = true;
            rbNordamerika.Location = new Point(26, 65);
            rbNordamerika.Name = "rbNordamerika";
            rbNordamerika.Size = new Size(117, 24);
            rbNordamerika.TabIndex = 1;
            rbNordamerika.TabStop = true;
            rbNordamerika.Text = "Nordamerika";
            rbNordamerika.UseVisualStyleBackColor = true;
            rbNordamerika.CheckedChanged += rbNordamerika_CheckedChanged;
            // 
            // rbEuropa
            // 
            rbEuropa.AutoSize = true;
            rbEuropa.Location = new Point(26, 34);
            rbEuropa.Name = "rbEuropa";
            rbEuropa.Size = new Size(77, 24);
            rbEuropa.TabIndex = 0;
            rbEuropa.TabStop = true;
            rbEuropa.Text = "Europa";
            rbEuropa.UseVisualStyleBackColor = true;
            rbEuropa.CheckedChanged += rbEuropa_CheckedChanged;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Location = new Point(1069, 139);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 45);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Quiz beenden";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbConfigInfo
            // 
            lbConfigInfo.AutoSize = true;
            lbConfigInfo.BackColor = Color.Khaki;
            lbConfigInfo.Location = new Point(311, 259);
            lbConfigInfo.Name = "lbConfigInfo";
            lbConfigInfo.Size = new Size(610, 20);
            lbConfigInfo.TabIndex = 20;
            lbConfigInfo.Text = "Es wurden keine Optionen gewählt. Die Einstellungen aus der config.ini werden verwendet: ";
            // 
            // lbConfigInfo2
            // 
            lbConfigInfo2.AutoSize = true;
            lbConfigInfo2.BackColor = Color.Khaki;
            lbConfigInfo2.Location = new Point(314, 282);
            lbConfigInfo2.Name = "lbConfigInfo2";
            lbConfigInfo2.Size = new Size(192, 20);
            lbConfigInfo2.TabIndex = 21;
            lbConfigInfo2.Text = "QuizTyp = Hauptstadt-Land";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1343, 684);
            Controls.Add(lbConfigInfo2);
            Controls.Add(lbConfigInfo);
            Controls.Add(btnLogout);
            Controls.Add(groupBox4);
            Controls.Add(lbHPunktzahl);
            Controls.Add(dgvHPunktzahl);
            Controls.Add(lbPunktzahl);
            Controls.Add(dgvPunkte);
            Controls.Add(groupBox1);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Quiz Starten";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPunkte).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHPunktzahl).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbLand;
        private RadioButton rbHauptstadt;
        private RadioButton rbFlagge;
        private RadioButton rbALand;
        private RadioButton rbAHauptstadt;
        private RadioButton rbAFlagge;
        private Button btnStart;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dgvPunkte;
        private Label lbPunktzahl;
        private DataGridViewTextBoxColumn spielerID;
        private DataGridViewTextBoxColumn spielerName;
        private DataGridViewTextBoxColumn quizID;
        private DataGridViewTextBoxColumn gesamtPunkte;
        private DataGridView dgvHPunktzahl;
        private Label lbHPunktzahl;
        private DataGridViewTextBoxColumn hspielerID;
        private DataGridViewTextBoxColumn spielerHName;
        private DataGridViewTextBoxColumn punkteH;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private RadioButton rbAustralien;
        private RadioButton rbAfrika;
        private RadioButton rbAsien;
        private RadioButton rbSuedamerika;
        private RadioButton rbNordamerika;
        private RadioButton rbEuropa;
        private Button btnLogout;
        private Label lbConfigInfo;
        private Label lbConfigInfo2;
    }
}