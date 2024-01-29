namespace WindowsFormsApp1
{
    partial class LibrarianMenu
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
            this.BooksBtn = new System.Windows.Forms.Button();
            this.BookManagementBtn = new System.Windows.Forms.Button();
            this.borrowedBooksBtn = new System.Windows.Forms.Button();
            this.DeleyedReturnsBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ReadersManagementBtn = new System.Windows.Forms.Button();
            this.AddLibrarianBtn = new System.Windows.Forms.Button();
            this.LibrarainInfoBtn = new System.Windows.Forms.Button();
            this.LibrariansListBtn = new System.Windows.Forms.Button();
            this.DataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(191, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Librarian Menu";
            // 
            // BooksBtn
            // 
            this.BooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BooksBtn.ForeColor = System.Drawing.Color.White;
            this.BooksBtn.Location = new System.Drawing.Point(64, 143);
            this.BooksBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BooksBtn.Name = "BooksBtn";
            this.BooksBtn.Size = new System.Drawing.Size(100, 90);
            this.BooksBtn.TabIndex = 1;
            this.BooksBtn.Text = "Books";
            this.BooksBtn.UseVisualStyleBackColor = false;
            this.BooksBtn.Click += new System.EventHandler(this.BooksBtn_Click);
            // 
            // BookManagementBtn
            // 
            this.BookManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BookManagementBtn.ForeColor = System.Drawing.Color.White;
            this.BookManagementBtn.Location = new System.Drawing.Point(172, 143);
            this.BookManagementBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookManagementBtn.Name = "BookManagementBtn";
            this.BookManagementBtn.Size = new System.Drawing.Size(100, 90);
            this.BookManagementBtn.TabIndex = 2;
            this.BookManagementBtn.Text = "Book Management";
            this.BookManagementBtn.UseVisualStyleBackColor = false;
            this.BookManagementBtn.Click += new System.EventHandler(this.BookManagementBtn_Click);
            // 
            // borrowedBooksBtn
            // 
            this.borrowedBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.borrowedBooksBtn.ForeColor = System.Drawing.Color.White;
            this.borrowedBooksBtn.Location = new System.Drawing.Point(280, 143);
            this.borrowedBooksBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrowedBooksBtn.Name = "borrowedBooksBtn";
            this.borrowedBooksBtn.Size = new System.Drawing.Size(100, 90);
            this.borrowedBooksBtn.TabIndex = 3;
            this.borrowedBooksBtn.Text = "Borrowed Books";
            this.borrowedBooksBtn.UseVisualStyleBackColor = false;
            this.borrowedBooksBtn.Click += new System.EventHandler(this.borrowedBooksBtn_Click);
            // 
            // DeleyedReturnsBtn
            // 
            this.DeleyedReturnsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DeleyedReturnsBtn.ForeColor = System.Drawing.Color.White;
            this.DeleyedReturnsBtn.Location = new System.Drawing.Point(388, 143);
            this.DeleyedReturnsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleyedReturnsBtn.Name = "DeleyedReturnsBtn";
            this.DeleyedReturnsBtn.Size = new System.Drawing.Size(100, 90);
            this.DeleyedReturnsBtn.TabIndex = 4;
            this.DeleyedReturnsBtn.Text = "Deleyed Returns";
            this.DeleyedReturnsBtn.UseVisualStyleBackColor = false;
            this.DeleyedReturnsBtn.Click += new System.EventHandler(this.DeleyedReturnsBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(496, 47);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(111, 35);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ReadersManagementBtn
            // 
            this.ReadersManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ReadersManagementBtn.ForeColor = System.Drawing.Color.White;
            this.ReadersManagementBtn.Location = new System.Drawing.Point(388, 241);
            this.ReadersManagementBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReadersManagementBtn.Name = "ReadersManagementBtn";
            this.ReadersManagementBtn.Size = new System.Drawing.Size(100, 90);
            this.ReadersManagementBtn.TabIndex = 6;
            this.ReadersManagementBtn.Text = "Readers Management";
            this.ReadersManagementBtn.UseVisualStyleBackColor = false;
            this.ReadersManagementBtn.Click += new System.EventHandler(this.ReadersManagementBtn_Click);
            // 
            // AddLibrarianBtn
            // 
            this.AddLibrarianBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AddLibrarianBtn.ForeColor = System.Drawing.Color.White;
            this.AddLibrarianBtn.Location = new System.Drawing.Point(64, 241);
            this.AddLibrarianBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddLibrarianBtn.Name = "AddLibrarianBtn";
            this.AddLibrarianBtn.Size = new System.Drawing.Size(100, 90);
            this.AddLibrarianBtn.TabIndex = 7;
            this.AddLibrarianBtn.Text = "Add New Librarian";
            this.AddLibrarianBtn.UseVisualStyleBackColor = false;
            this.AddLibrarianBtn.Click += new System.EventHandler(this.AddLibrarianBtn_Click);
            // 
            // LibrarainInfoBtn
            // 
            this.LibrarainInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LibrarainInfoBtn.ForeColor = System.Drawing.Color.White;
            this.LibrarainInfoBtn.Location = new System.Drawing.Point(172, 241);
            this.LibrarainInfoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibrarainInfoBtn.Name = "LibrarainInfoBtn";
            this.LibrarainInfoBtn.Size = new System.Drawing.Size(100, 90);
            this.LibrarainInfoBtn.TabIndex = 8;
            this.LibrarainInfoBtn.Text = "Your Info";
            this.LibrarainInfoBtn.UseVisualStyleBackColor = false;
            this.LibrarainInfoBtn.Click += new System.EventHandler(this.LibrarainInfoBtn_Click);
            // 
            // LibrariansListBtn
            // 
            this.LibrariansListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LibrariansListBtn.ForeColor = System.Drawing.Color.White;
            this.LibrariansListBtn.Location = new System.Drawing.Point(280, 241);
            this.LibrariansListBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibrariansListBtn.Name = "LibrariansListBtn";
            this.LibrariansListBtn.Size = new System.Drawing.Size(100, 90);
            this.LibrariansListBtn.TabIndex = 9;
            this.LibrariansListBtn.Text = "Librarians List";
            this.LibrariansListBtn.UseVisualStyleBackColor = false;
            this.LibrariansListBtn.Click += new System.EventHandler(this.LibrariansListBtn_Click);
            // 
            // DataBtn
            // 
            this.DataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DataBtn.ForeColor = System.Drawing.Color.White;
            this.DataBtn.Location = new System.Drawing.Point(496, 192);
            this.DataBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataBtn.Name = "DataBtn";
            this.DataBtn.Size = new System.Drawing.Size(100, 90);
            this.DataBtn.TabIndex = 10;
            this.DataBtn.Text = "Data Management";
            this.DataBtn.UseVisualStyleBackColor = false;
            this.DataBtn.Click += new System.EventHandler(this.DataBtn_Click);
            // 
            // LibrarianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(681, 399);
            this.Controls.Add(this.DataBtn);
            this.Controls.Add(this.LibrariansListBtn);
            this.Controls.Add(this.LibrarainInfoBtn);
            this.Controls.Add(this.AddLibrarianBtn);
            this.Controls.Add(this.ReadersManagementBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.DeleyedReturnsBtn);
            this.Controls.Add(this.borrowedBooksBtn);
            this.Controls.Add(this.BookManagementBtn);
            this.Controls.Add(this.BooksBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibrarianMenu";
            this.Text = "LibrarianMenu";
            this.Load += new System.EventHandler(this.LibrarianMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BooksBtn;
        private System.Windows.Forms.Button BookManagementBtn;
        private System.Windows.Forms.Button borrowedBooksBtn;
        private System.Windows.Forms.Button DeleyedReturnsBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button ReadersManagementBtn;
        private System.Windows.Forms.Button AddLibrarianBtn;
        private System.Windows.Forms.Button LibrarainInfoBtn;
        private System.Windows.Forms.Button LibrariansListBtn;
        private System.Windows.Forms.Button DataBtn;
    }
}