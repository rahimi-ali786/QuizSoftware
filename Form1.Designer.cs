namespace QuizSoftware
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnRegister = new Button();
            btnLogin = new Button();
            txtSPasswort = new TextBox();
            txtSName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            pbquiz1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbquiz1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtSPasswort);
            groupBox1.Controls.Add(txtSName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Spieler";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Silver;
            btnRegister.Location = new Point(193, 204);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.Location = new Point(193, 164);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSPasswort
            // 
            txtSPasswort.Location = new Point(193, 119);
            txtSPasswort.Name = "txtSPasswort";
            txtSPasswort.Size = new Size(193, 27);
            txtSPasswort.TabIndex = 3;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(193, 76);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(193, 27);
            txtSName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 119);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Passwort:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 76);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Spieler Name:";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Location = new Point(40, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(188, 39);
            btnExit.TabIndex = 1;
            btnExit.Text = "Programm Schließen";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pbquiz1
            // 
            pbquiz1.BackColor = Color.Transparent;
            pbquiz1.Location = new Point(230, 324);
            pbquiz1.Name = "pbquiz1";
            pbquiz1.Size = new Size(138, 119);
            pbquiz1.SizeMode = PictureBoxSizeMode.Zoom;
            pbquiz1.TabIndex = 3;
            pbquiz1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(759, 444);
            Controls.Add(pbquiz1);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Log in";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbquiz1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSName;
        private Label label2;
        private TextBox txtSPasswort;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pbquiz1;
    }
}
