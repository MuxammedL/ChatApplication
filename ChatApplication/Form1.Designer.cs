namespace ChatApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invalidText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordLoginInput = new System.Windows.Forms.TextBox();
            this.emailLoginInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Registration = new System.Windows.Forms.Button();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.choosePhoto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.xMark = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(40, 20);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(175, 40);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(265, 20);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(175, 40);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.invalidText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passwordLoginInput);
            this.panel1.Controls.Add(this.emailLoginInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 448);
            this.panel1.TabIndex = 2;
            // 
            // invalidText
            // 
            this.invalidText.AutoSize = true;
            this.invalidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidText.ForeColor = System.Drawing.Color.Red;
            this.invalidText.Location = new System.Drawing.Point(55, 203);
            this.invalidText.Name = "invalidText";
            this.invalidText.Size = new System.Drawing.Size(326, 22);
            this.invalidText.TabIndex = 6;
            this.invalidText.Text = "Please check your email and password.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(117, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // passwordLoginInput
            // 
            this.passwordLoginInput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.passwordLoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginInput.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordLoginInput.Location = new System.Drawing.Point(164, 166);
            this.passwordLoginInput.Name = "passwordLoginInput";
            this.passwordLoginInput.PasswordChar = '*';
            this.passwordLoginInput.Size = new System.Drawing.Size(275, 27);
            this.passwordLoginInput.TabIndex = 3;
            // 
            // emailLoginInput
            // 
            this.emailLoginInput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.emailLoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLoginInput.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.emailLoginInput.Location = new System.Drawing.Point(164, 94);
            this.emailLoginInput.Name = "emailLoginInput";
            this.emailLoginInput.Size = new System.Drawing.Size(275, 27);
            this.emailLoginInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.Registration);
            this.panel2.Controls.Add(this.confirmPassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lastName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.firstName);
            this.panel2.Controls.Add(this.firstNamelabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.choosePhoto);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 448);
            this.panel2.TabIndex = 6;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.SpringGreen;
            this.Registration.FlatAppearance.BorderSize = 0;
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(117, 390);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(250, 50);
            this.Registration.TabIndex = 14;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.White;
            this.confirmPassword.Location = new System.Drawing.Point(164, 323);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(250, 27);
            this.confirmPassword.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(56, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Confirm";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.DarkSlateGray;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(164, 274);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(250, 27);
            this.password.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.DarkSlateGray;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(164, 224);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(250, 27);
            this.email.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.White;
            this.lastName.Location = new System.Drawing.Point(164, 174);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(250, 27);
            this.lastName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.White;
            this.firstName.Location = new System.Drawing.Point(164, 124);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(250, 27);
            this.firstName.TabIndex = 5;
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.ForeColor = System.Drawing.Color.White;
            this.firstNamelabel.Location = new System.Drawing.Point(55, 127);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(92, 20);
            this.firstNamelabel.TabIndex = 1;
            this.firstNamelabel.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registeration";
            // 
            // choosePhoto
            // 
            this.choosePhoto.AutoSize = true;
            this.choosePhoto.BackColor = System.Drawing.Color.White;
            this.choosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePhoto.Location = new System.Drawing.Point(205, 45);
            this.choosePhoto.MaximumSize = new System.Drawing.Size(76, 76);
            this.choosePhoto.MinimumSize = new System.Drawing.Size(76, 76);
            this.choosePhoto.Name = "choosePhoto";
            this.choosePhoto.Size = new System.Drawing.Size(76, 76);
            this.choosePhoto.TabIndex = 16;
            this.choosePhoto.Text = "Choose Photo";
            this.choosePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choosePhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(205, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(40, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 3);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(265, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 3);
            this.panel4.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // xMark
            // 
            this.xMark.BackColor = System.Drawing.Color.Transparent;
            this.xMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xMark.BackgroundImage")));
            this.xMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xMark.FlatAppearance.BorderSize = 0;
            this.xMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xMark.Location = new System.Drawing.Point(457, 2);
            this.xMark.Name = "xMark";
            this.xMark.Size = new System.Drawing.Size(23, 23);
            this.xMark.TabIndex = 7;
            this.xMark.UseVisualStyleBackColor = false;
            this.xMark.Click += new System.EventHandler(this.xMark_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(291, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(265, 356);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Show password";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(482, 533);
            this.Controls.Add(this.xMark);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailLoginInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordLoginInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button xMark;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label invalidText;
        private System.Windows.Forms.Label choosePhoto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

