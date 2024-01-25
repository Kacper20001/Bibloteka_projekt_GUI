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
            this.SprawdzPolaczenieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi, join us!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FirstName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "LastName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "e-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Street";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "House Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Country";
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(164, 35);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(100, 20);
            this.regUsername.TabIndex = 14;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(164, 61);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(100, 20);
            this.regPassword.TabIndex = 15;
            // 
            // regConfPassword
            // 
            this.regConfPassword.Location = new System.Drawing.Point(164, 88);
            this.regConfPassword.Name = "regConfPassword";
            this.regConfPassword.Size = new System.Drawing.Size(100, 20);
            this.regConfPassword.TabIndex = 16;
            // 
            // regFirstName
            // 
            this.regFirstName.Location = new System.Drawing.Point(164, 127);
            this.regFirstName.Name = "regFirstName";
            this.regFirstName.Size = new System.Drawing.Size(100, 20);
            this.regFirstName.TabIndex = 17;
            // 
            // regLastName
            // 
            this.regLastName.Location = new System.Drawing.Point(164, 161);
            this.regLastName.Name = "regLastName";
            this.regLastName.Size = new System.Drawing.Size(100, 20);
            this.regLastName.TabIndex = 18;
            // 
            // regEmail
            // 
            this.regEmail.Location = new System.Drawing.Point(164, 238);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(100, 20);
            this.regEmail.TabIndex = 20;
            // 
            // regPhoneNumber
            // 
            this.regPhoneNumber.Location = new System.Drawing.Point(164, 270);
            this.regPhoneNumber.Name = "regPhoneNumber";
            this.regPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.regPhoneNumber.TabIndex = 21;
            // 
            // regStreet
            // 
            this.regStreet.Location = new System.Drawing.Point(164, 302);
            this.regStreet.Name = "regStreet";
            this.regStreet.Size = new System.Drawing.Size(100, 20);
            this.regStreet.TabIndex = 22;
            // 
            // regHouseNumber
            // 
            this.regHouseNumber.Location = new System.Drawing.Point(164, 335);
            this.regHouseNumber.Name = "regHouseNumber";
            this.regHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.regHouseNumber.TabIndex = 23;
            // 
            // regPostalCode
            // 
            this.regPostalCode.Location = new System.Drawing.Point(164, 361);
            this.regPostalCode.Name = "regPostalCode";
            this.regPostalCode.Size = new System.Drawing.Size(100, 20);
            this.regPostalCode.TabIndex = 24;
            // 
            // regCity
            // 
            this.regCity.Location = new System.Drawing.Point(164, 390);
            this.regCity.Name = "regCity";
            this.regCity.Size = new System.Drawing.Size(100, 20);
            this.regCity.TabIndex = 25;
            // 
            // regCountry
            // 
            this.regCountry.Location = new System.Drawing.Point(164, 416);
            this.regCountry.Name = "regCountry";
            this.regCountry.Size = new System.Drawing.Size(100, 20);
            this.regCountry.TabIndex = 26;
            // 
            // regDateOfBirth
            // 
            this.regDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDateOfBirth.Location = new System.Drawing.Point(164, 191);
            this.regDateOfBirth.Name = "regDateOfBirth";
            this.regDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.regDateOfBirth.TabIndex = 27;
            // 
            // regSubmit
            // 
            this.regSubmit.Location = new System.Drawing.Point(89, 462);
            this.regSubmit.Name = "regSubmit";
            this.regSubmit.Size = new System.Drawing.Size(75, 23);
            this.regSubmit.TabIndex = 28;
            this.regSubmit.Text = "Submit";
            this.regSubmit.UseVisualStyleBackColor = true;
            this.regSubmit.Click += new System.EventHandler(this.regSubmit_Click);
            // 
            // regClear
            // 
            this.regClear.Location = new System.Drawing.Point(180, 462);
            this.regClear.Name = "regClear";
            this.regClear.Size = new System.Drawing.Size(75, 23);
            this.regClear.TabIndex = 29;
            this.regClear.Text = "Clear";
            this.regClear.UseVisualStyleBackColor = true;
            this.regClear.Click += new System.EventHandler(this.regClear_Click);
            // 
            // AlreadyHaveAccountBtn
            // 
            this.AlreadyHaveAccountBtn.Location = new System.Drawing.Point(80, 491);
            this.AlreadyHaveAccountBtn.Name = "AlreadyHaveAccountBtn";
            this.AlreadyHaveAccountBtn.Size = new System.Drawing.Size(184, 23);
            this.AlreadyHaveAccountBtn.TabIndex = 30;
            this.AlreadyHaveAccountBtn.Text = "Already have an Account";
            this.AlreadyHaveAccountBtn.UseVisualStyleBackColor = true;
            this.AlreadyHaveAccountBtn.Click += new System.EventHandler(this.AlreadyHaveAccountBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(283, 30);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 25);
            this.StartBtn.TabIndex = 31;
            this.StartBtn.Text = "Back to Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SprawdzPolaczenieButton
            // 
            this.SprawdzPolaczenieButton.Location = new System.Drawing.Point(326, 109);
            this.SprawdzPolaczenieButton.Name = "SprawdzPolaczenieButton";
            this.SprawdzPolaczenieButton.Size = new System.Drawing.Size(75, 23);
            this.SprawdzPolaczenieButton.TabIndex = 32;
            this.SprawdzPolaczenieButton.Text = "button1";
            this.SprawdzPolaczenieButton.UseVisualStyleBackColor = true;
            //this.SprawdzPolaczenieButton.Click += new System.EventHandler(this.SprawdzPolaczenieButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 531);
            this.Controls.Add(this.SprawdzPolaczenieButton);
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
        private System.Windows.Forms.Button SprawdzPolaczenieButton;
    }
}

