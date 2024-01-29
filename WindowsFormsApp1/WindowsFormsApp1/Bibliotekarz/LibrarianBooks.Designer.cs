namespace WindowsFormsApp1
{
    partial class LibrarianBooks
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
            this.BooksDataGrid = new System.Windows.Forms.DataGridView();
            this.SrcBooksBtn = new System.Windows.Forms.Button();
            this.BackMenuBtn = new System.Windows.Forms.Button();
            this.txtSrcBooks = new System.Windows.Forms.TextBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksDataGrid
            // 
            this.BooksDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGrid.Location = new System.Drawing.Point(54, 243);
            this.BooksDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BooksDataGrid.Name = "BooksDataGrid";
            this.BooksDataGrid.Size = new System.Drawing.Size(857, 197);
            this.BooksDataGrid.TabIndex = 0;
            this.BooksDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGrid_CellContentClick);
            // 
            // SrcBooksBtn
            // 
            this.SrcBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SrcBooksBtn.ForeColor = System.Drawing.Color.White;
            this.SrcBooksBtn.Location = new System.Drawing.Point(210, 155);
            this.SrcBooksBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcBooksBtn.Name = "SrcBooksBtn";
            this.SrcBooksBtn.Size = new System.Drawing.Size(100, 30);
            this.SrcBooksBtn.TabIndex = 1;
            this.SrcBooksBtn.Text = "Search";
            this.SrcBooksBtn.UseVisualStyleBackColor = false;
            this.SrcBooksBtn.Click += new System.EventHandler(this.SrcBooksBtn_Click);
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackMenuBtn.ForeColor = System.Drawing.Color.White;
            this.BackMenuBtn.Location = new System.Drawing.Point(692, 55);
            this.BackMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(219, 30);
            this.BackMenuBtn.TabIndex = 2;
            this.BackMenuBtn.Text = "Back to Menu";
            this.BackMenuBtn.UseVisualStyleBackColor = false;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // txtSrcBooks
            // 
            this.txtSrcBooks.Location = new System.Drawing.Point(55, 160);
            this.txtSrcBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSrcBooks.Name = "txtSrcBooks";
            this.txtSrcBooks.Size = new System.Drawing.Size(132, 25);
            this.txtSrcBooks.TabIndex = 3;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AddBookBtn.ForeColor = System.Drawing.Color.White;
            this.AddBookBtn.Location = new System.Drawing.Point(790, 142);
            this.AddBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(107, 27);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Add New Book";
            this.AddBookBtn.UseVisualStyleBackColor = false;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.EditBookBtn.ForeColor = System.Drawing.Color.White;
            this.EditBookBtn.Location = new System.Drawing.Point(790, 171);
            this.EditBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(107, 26);
            this.EditBookBtn.TabIndex = 5;
            this.EditBookBtn.Text = "Edit Book";
            this.EditBookBtn.UseVisualStyleBackColor = false;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DeleteBookBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBookBtn.Location = new System.Drawing.Point(790, 196);
            this.DeleteBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(107, 26);
            this.DeleteBookBtn.TabIndex = 6;
            this.DeleteBookBtn.Text = "Delete Book";
            this.DeleteBookBtn.UseVisualStyleBackColor = false;
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // Books
            // 
            this.Books.AutoSize = true;
            this.Books.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Books.Location = new System.Drawing.Point(371, 50);
            this.Books.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(83, 32);
            this.Books.TabIndex = 7;
            this.Books.Text = "Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(62, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter search term";
            // 
            // LibrarianBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(958, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.txtSrcBooks);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.SrcBooksBtn);
            this.Controls.Add(this.BooksDataGrid);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibrarianBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianBooks";
            this.Load += new System.EventHandler(this.LibrarianBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksDataGrid;
        private System.Windows.Forms.Button SrcBooksBtn;
        private System.Windows.Forms.Button BackMenuBtn;
        private System.Windows.Forms.TextBox txtSrcBooks;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button EditBookBtn;
        private System.Windows.Forms.Button DeleteBookBtn;
        private System.Windows.Forms.Label Books;
        private System.Windows.Forms.Label label1;
    }
}