namespace WindowsFormsApp1
{
    partial class LibrarianLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeNumberTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.SubmitLogin = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emlpoyee Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // EmployeeNumberTxt
            // 
            this.EmployeeNumberTxt.Location = new System.Drawing.Point(188, 74);
            this.EmployeeNumberTxt.Name = "EmployeeNumberTxt";
            this.EmployeeNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNumberTxt.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(188, 110);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 4;
            // 
            // SubmitLogin
            // 
            this.SubmitLogin.Location = new System.Drawing.Point(74, 155);
            this.SubmitLogin.Name = "SubmitLogin";
            this.SubmitLogin.Size = new System.Drawing.Size(75, 22);
            this.SubmitLogin.TabIndex = 5;
            this.SubmitLogin.Text = "Submit";
            this.SubmitLogin.UseVisualStyleBackColor = true;
            this.SubmitLogin.Click += new System.EventHandler(this.SubmitLogin_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(198, 153);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back to Start";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LibrarianLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SubmitLogin);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmployeeNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LibrarianLoginForm";
            this.Text = "LibrarianLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeeNumberTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button SubmitLogin;
        private System.Windows.Forms.Button BackBtn;
    }
}