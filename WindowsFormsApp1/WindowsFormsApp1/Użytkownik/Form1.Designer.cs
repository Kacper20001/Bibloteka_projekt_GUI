namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regConfPassword = new System.Windows.Forms.TextBox();
            this.regFirstName = new System.Windows.Forms.TextBox();
            this.regLastName = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPhoneNumber = new System.Windows.Forms.TextBox();
            this.regStreet = new System.Windows.Forms.TextBox();
            this.regHouseNumber = new System.Windows.Forms.TextBox();
            this.regPostalCode = new System.Windows.Forms.TextBox();
            this.regCity = new System.Windows.Forms.TextBox();
            this.regCountry = new System.Windows.Forms.TextBox();
            this.regDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.regSubmit = new System.Windows.Forms.Button();
            this.regClear = new System.Windows.Forms.Button();
            this.AlreadyHaveAccountBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi, join us!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(42, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "FirstName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(42, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "LastName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label7.Location = new System.Drawing.Point(42, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label8.Location = new System.Drawing.Point(56, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "e-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label9.Location = new System.Drawing.Point(29, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(45, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Street";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label11.Location = new System.Drawing.Point(41, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "House Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label12.Location = new System.Drawing.Point(41, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label13.Location = new System.Drawing.Point(57, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label14.Location = new System.Drawing.Point(53, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Country";
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(167, 51);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(151, 20);
            this.regUsername.TabIndex = 14;
            this.regUsername.TextChanged += new System.EventHandler(this.regUsername_TextChanged);
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(167, 77);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(151, 20);
            this.regPassword.TabIndex = 15;
            this.regPassword.UseSystemPasswordChar = true;
            this.regPassword.TextChanged += new System.EventHandler(this.regPassword_TextChanged);
            // 
            // regConfPassword
            // 
            this.regConfPassword.Location = new System.Drawing.Point(165, 111);
            this.regConfPassword.Name = "regConfPassword";
            this.regConfPassword.Size = new System.Drawing.Size(153, 20);
            this.regConfPassword.TabIndex = 16;
            this.regConfPassword.UseSystemPasswordChar = true;
            this.regConfPassword.TextChanged += new System.EventHandler(this.regConfPassword_TextChanged);
            // 
            // regFirstName
            // 
            this.regFirstName.Location = new System.Drawing.Point(167, 137);
            this.regFirstName.Name = "regFirstName";
            this.regFirstName.Size = new System.Drawing.Size(151, 20);
            this.regFirstName.TabIndex = 17;
            this.regFirstName.TextChanged += new System.EventHandler(this.regFirstName_TextChanged);
            // 
            // regLastName
            // 
            this.regLastName.Location = new System.Drawing.Point(167, 165);
            this.regLastName.Name = "regLastName";
            this.regLastName.Size = new System.Drawing.Size(153, 20);
            this.regLastName.TabIndex = 18;
            this.regLastName.TextChanged += new System.EventHandler(this.regLastName_TextChanged);
            // 
            // regEmail
            // 
            this.regEmail.Location = new System.Drawing.Point(165, 225);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(153, 20);
            this.regEmail.TabIndex = 20;
            this.regEmail.TextChanged += new System.EventHandler(this.regEmail_TextChanged);
            // 
            // regPhoneNumber
            // 
            this.regPhoneNumber.Location = new System.Drawing.Point(165, 257);
            this.regPhoneNumber.Name = "regPhoneNumber";
            this.regPhoneNumber.Size = new System.Drawing.Size(153, 20);
            this.regPhoneNumber.TabIndex = 21;
            this.regPhoneNumber.TextChanged += new System.EventHandler(this.regPhoneNumber_TextChanged);
            // 
            // regStreet
            // 
            this.regStreet.Location = new System.Drawing.Point(165, 289);
            this.regStreet.Name = "regStreet";
            this.regStreet.Size = new System.Drawing.Size(153, 20);
            this.regStreet.TabIndex = 22;
            this.regStreet.TextChanged += new System.EventHandler(this.regStreet_TextChanged);
            // 
            // regHouseNumber
            // 
            this.regHouseNumber.Location = new System.Drawing.Point(165, 319);
            this.regHouseNumber.Name = "regHouseNumber";
            this.regHouseNumber.Size = new System.Drawing.Size(153, 20);
            this.regHouseNumber.TabIndex = 23;
            this.regHouseNumber.TextChanged += new System.EventHandler(this.regHouseNumber_TextChanged);
            // 
            // regPostalCode
            // 
            this.regPostalCode.Location = new System.Drawing.Point(165, 348);
            this.regPostalCode.Name = "regPostalCode";
            this.regPostalCode.Size = new System.Drawing.Size(153, 20);
            this.regPostalCode.TabIndex = 24;
            this.regPostalCode.TextChanged += new System.EventHandler(this.regPostalCode_TextChanged);
            // 
            // regCity
            // 
            this.regCity.Location = new System.Drawing.Point(165, 377);
            this.regCity.Name = "regCity";
            this.regCity.Size = new System.Drawing.Size(153, 20);
            this.regCity.TabIndex = 25;
            this.regCity.TextChanged += new System.EventHandler(this.regCity_TextChanged);
            // 
            // regCountry
            // 
            this.regCountry.Location = new System.Drawing.Point(165, 403);
            this.regCountry.Name = "regCountry";
            this.regCountry.Size = new System.Drawing.Size(153, 20);
            this.regCountry.TabIndex = 26;
            this.regCountry.TextChanged += new System.EventHandler(this.regCountry_TextChanged);
            // 
            // regDateOfBirth
            // 
            this.regDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDateOfBirth.Location = new System.Drawing.Point(165, 191);
            this.regDateOfBirth.Name = "regDateOfBirth";
            this.regDateOfBirth.Size = new System.Drawing.Size(153, 20);
            this.regDateOfBirth.TabIndex = 27;
            // 
            // regSubmit
            // 
            this.regSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.regSubmit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regSubmit.ForeColor = System.Drawing.Color.White;
            this.regSubmit.Location = new System.Drawing.Point(150, 451);
            this.regSubmit.Name = "regSubmit";
            this.regSubmit.Size = new System.Drawing.Size(92, 32);
            this.regSubmit.TabIndex = 28;
            this.regSubmit.Text = "Submit";
            this.regSubmit.UseVisualStyleBackColor = false;
            this.regSubmit.Click += new System.EventHandler(this.regSubmit_Click);
            // 
            // regClear
            // 
            this.regClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.regClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regClear.ForeColor = System.Drawing.Color.White;
            this.regClear.Location = new System.Drawing.Point(241, 451);
            this.regClear.Name = "regClear";
            this.regClear.Size = new System.Drawing.Size(92, 32);
            this.regClear.TabIndex = 29;
            this.regClear.Text = "Clear";
            this.regClear.UseVisualStyleBackColor = false;
            this.regClear.Click += new System.EventHandler(this.regClear_Click);
            // 
            // AlreadyHaveAccountBtn
            // 
            this.AlreadyHaveAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AlreadyHaveAccountBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyHaveAccountBtn.ForeColor = System.Drawing.Color.White;
            this.AlreadyHaveAccountBtn.Location = new System.Drawing.Point(150, 490);
            this.AlreadyHaveAccountBtn.Name = "AlreadyHaveAccountBtn";
            this.AlreadyHaveAccountBtn.Size = new System.Drawing.Size(183, 32);
            this.AlreadyHaveAccountBtn.TabIndex = 30;
            this.AlreadyHaveAccountBtn.Text = "Already have an Account";
            this.AlreadyHaveAccountBtn.UseVisualStyleBackColor = false;
            this.AlreadyHaveAccountBtn.Click += new System.EventHandler(this.AlreadyHaveAccountBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.StartBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(347, 7);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(91, 25);
            this.StartBtn.TabIndex = 31;
            this.StartBtn.Text = "Back to Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(450, 573);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.AlreadyHaveAccountBtn);
            this.Controls.Add(this.regClear);
            this.Controls.Add(this.regSubmit);
            this.Controls.Add(this.regDateOfBirth);
            this.Controls.Add(this.regCountry);
            this.Controls.Add(this.regCity);
            this.Controls.Add(this.regPostalCode);
            this.Controls.Add(this.regHouseNumber);
            this.Controls.Add(this.regStreet);
            this.Controls.Add(this.regPhoneNumber);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.regLastName);
            this.Controls.Add(this.regFirstName);
            this.Controls.Add(this.regConfPassword);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regConfPassword;
        private System.Windows.Forms.TextBox regFirstName;
        private System.Windows.Forms.TextBox regLastName;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPhoneNumber;
        private System.Windows.Forms.TextBox regStreet;
        private System.Windows.Forms.TextBox regHouseNumber;
        private System.Windows.Forms.TextBox regPostalCode;
        private System.Windows.Forms.TextBox regCity;
        private System.Windows.Forms.TextBox regCountry;
        private System.Windows.Forms.DateTimePicker regDateOfBirth;
        private System.Windows.Forms.Button regSubmit;
        private System.Windows.Forms.Button regClear;
        private System.Windows.Forms.Button AlreadyHaveAccountBtn;
        private System.Windows.Forms.Button StartBtn;
    }
}

