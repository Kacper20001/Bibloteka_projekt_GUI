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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // BooksBtn
            // 
            this.BooksBtn.Location = new System.Drawing.Point(47, 155);
            this.BooksBtn.Name = "BooksBtn";
            this.BooksBtn.Size = new System.Drawing.Size(81, 96);
            this.BooksBtn.TabIndex = 1;
            this.BooksBtn.Text = "Books";
            this.BooksBtn.UseVisualStyleBackColor = true;
            this.BooksBtn.Click += new System.EventHandler(this.BooksBtn_Click);
            // 
            // BookManagementBtn
            // 
            this.BookManagementBtn.Location = new System.Drawing.Point(157, 155);
            this.BookManagementBtn.Name = "BookManagementBtn";
            this.BookManagementBtn.Size = new System.Drawing.Size(81, 96);
            this.BookManagementBtn.TabIndex = 2;
            this.BookManagementBtn.Text = "Book Management";
            this.BookManagementBtn.UseVisualStyleBackColor = true;
            this.BookManagementBtn.Click += new System.EventHandler(this.BookManagementBtn_Click);
            // 
            // borrowedBooksBtn
            // 
            this.borrowedBooksBtn.Location = new System.Drawing.Point(277, 155);
            this.borrowedBooksBtn.Name = "borrowedBooksBtn";
            this.borrowedBooksBtn.Size = new System.Drawing.Size(81, 96);
            this.borrowedBooksBtn.TabIndex = 3;
            this.borrowedBooksBtn.Text = "Borrowed Books";
            this.borrowedBooksBtn.UseVisualStyleBackColor = true;
            this.borrowedBooksBtn.Click += new System.EventHandler(this.borrowedBooksBtn_Click);
            // 
            // DeleyedReturnsBtn
            // 
            this.DeleyedReturnsBtn.Location = new System.Drawing.Point(384, 155);
            this.DeleyedReturnsBtn.Name = "DeleyedReturnsBtn";
            this.DeleyedReturnsBtn.Size = new System.Drawing.Size(81, 96);
            this.DeleyedReturnsBtn.TabIndex = 4;
            this.DeleyedReturnsBtn.Text = "Deleyed Returns";
            this.DeleyedReturnsBtn.UseVisualStyleBackColor = true;
            this.DeleyedReturnsBtn.Click += new System.EventHandler(this.DeleyedReturnsBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(630, 12);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(135, 46);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ReadersManagementBtn
            // 
            this.ReadersManagementBtn.Location = new System.Drawing.Point(498, 155);
            this.ReadersManagementBtn.Name = "ReadersManagementBtn";
            this.ReadersManagementBtn.Size = new System.Drawing.Size(81, 96);
            this.ReadersManagementBtn.TabIndex = 6;
            this.ReadersManagementBtn.Text = "Readers Management";
            this.ReadersManagementBtn.UseVisualStyleBackColor = true;
            // 
            // AddLibrarianBtn
            // 
            this.AddLibrarianBtn.Location = new System.Drawing.Point(595, 155);
            this.AddLibrarianBtn.Name = "AddLibrarianBtn";
            this.AddLibrarianBtn.Size = new System.Drawing.Size(81, 96);
            this.AddLibrarianBtn.TabIndex = 7;
            this.AddLibrarianBtn.Text = "Add New Librarian";
            this.AddLibrarianBtn.UseVisualStyleBackColor = true;
            // 
            // LibrarainInfoBtn
            // 
            this.LibrarainInfoBtn.Location = new System.Drawing.Point(693, 155);
            this.LibrarainInfoBtn.Name = "LibrarainInfoBtn";
            this.LibrarainInfoBtn.Size = new System.Drawing.Size(81, 96);
            this.LibrarainInfoBtn.TabIndex = 8;
            this.LibrarainInfoBtn.Text = "Your Info";
            this.LibrarainInfoBtn.UseVisualStyleBackColor = true;
            this.LibrarainInfoBtn.Click += new System.EventHandler(this.LibrarainInfoBtn_Click);
            // 
            // LibrarianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LibrarainInfoBtn);
            this.Controls.Add(this.AddLibrarianBtn);
            this.Controls.Add(this.ReadersManagementBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.DeleyedReturnsBtn);
            this.Controls.Add(this.borrowedBooksBtn);
            this.Controls.Add(this.BookManagementBtn);
            this.Controls.Add(this.BooksBtn);
            this.Controls.Add(this.label1);
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
    }
}