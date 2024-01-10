namespace WindowsFormsApp1
{
    partial class Logowanie
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
            this.LogForgotPassword = new System.Windows.Forms.Label();
            this.logSubmit = new System.Windows.Forms.Button();
            this.logLogin = new System.Windows.Forms.TextBox();
            this.logPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // LogForgotPassword
            // 
            this.LogForgotPassword.AutoSize = true;
            this.LogForgotPassword.Location = new System.Drawing.Point(44, 133);
            this.LogForgotPassword.Name = "LogForgotPassword";
            this.LogForgotPassword.Size = new System.Drawing.Size(104, 13);
            this.LogForgotPassword.TabIndex = 2;
            this.LogForgotPassword.Text = "I forgot my password";
            // 
            // logSubmit
            // 
            this.logSubmit.Location = new System.Drawing.Point(114, 175);
            this.logSubmit.Name = "logSubmit";
            this.logSubmit.Size = new System.Drawing.Size(75, 23);
            this.logSubmit.TabIndex = 3;
            this.logSubmit.Text = "Submit";
            this.logSubmit.UseVisualStyleBackColor = true;
            this.logSubmit.Click += new System.EventHandler(this.logSubmit_Click);
            // 
            // logLogin
            // 
            this.logLogin.Location = new System.Drawing.Point(114, 41);
            this.logLogin.Name = "logLogin";
            this.logLogin.Size = new System.Drawing.Size(100, 20);
            this.logLogin.TabIndex = 4;
            // 
            // logPassword
            // 
            this.logPassword.Location = new System.Drawing.Point(114, 87);
            this.logPassword.Name = "logPassword";
            this.logPassword.Size = new System.Drawing.Size(100, 20);
            this.logPassword.TabIndex = 5;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 246);
            this.Controls.Add(this.logPassword);
            this.Controls.Add(this.logLogin);
            this.Controls.Add(this.logSubmit);
            this.Controls.Add(this.LogForgotPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LogForgotPassword;
        private System.Windows.Forms.Button logSubmit;
        private System.Windows.Forms.TextBox logLogin;
        private System.Windows.Forms.TextBox logPassword;
    }
}