namespace WindowsFormsApp1
{
    partial class ReaderMenu
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
            this.userManuSearch = new System.Windows.Forms.Button();
            this.userMenuBorrowed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userManuAccount = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // userManuSearch
            // 
            this.userManuSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userManuSearch.ForeColor = System.Drawing.Color.White;
            this.userManuSearch.Location = new System.Drawing.Point(89, 104);
            this.userManuSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userManuSearch.Name = "userManuSearch";
            this.userManuSearch.Size = new System.Drawing.Size(112, 94);
            this.userManuSearch.TabIndex = 1;
            this.userManuSearch.Text = "Search";
            this.userManuSearch.UseVisualStyleBackColor = false;
            this.userManuSearch.Click += new System.EventHandler(this.userManuSearch_Click);
            // 
            // userMenuBorrowed
            // 
            this.userMenuBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userMenuBorrowed.ForeColor = System.Drawing.Color.White;
            this.userMenuBorrowed.Location = new System.Drawing.Point(256, 104);
            this.userMenuBorrowed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userMenuBorrowed.Name = "userMenuBorrowed";
            this.userMenuBorrowed.Size = new System.Drawing.Size(112, 94);
            this.userMenuBorrowed.TabIndex = 2;
            this.userMenuBorrowed.Text = "Your borrowed books";
            this.userMenuBorrowed.UseVisualStyleBackColor = false;
            this.userMenuBorrowed.Click += new System.EventHandler(this.userMenuBorrowed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(144, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select an aviable option";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userManuAccount
            // 
            this.userManuAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userManuAccount.ForeColor = System.Drawing.Color.White;
            this.userManuAccount.Location = new System.Drawing.Point(414, 104);
            this.userManuAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userManuAccount.Name = "userManuAccount";
            this.userManuAccount.Size = new System.Drawing.Size(112, 94);
            this.userManuAccount.TabIndex = 4;
            this.userManuAccount.Text = "Your account";
            this.userManuAccount.UseVisualStyleBackColor = false;
            this.userManuAccount.Click += new System.EventHandler(this.userManuAccount_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(488, 16);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(100, 30);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ReaderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(604, 276);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.userManuAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userMenuBorrowed);
            this.Controls.Add(this.userManuSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReaderMenu";
            this.Text = "ReaderMenu";
            this.Load += new System.EventHandler(this.ReaderMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userManuSearch;
        private System.Windows.Forms.Button userMenuBorrowed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button userManuAccount;
        private System.Windows.Forms.Button LogOutBtn;
    }
}