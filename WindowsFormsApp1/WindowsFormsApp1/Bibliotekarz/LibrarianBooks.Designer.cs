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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcBooksBtn = new System.Windows.Forms.Button();
            this.BackMenuBtn = new System.Windows.Forms.Button();
            this.txtSrcBooks = new System.Windows.Forms.TextBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksDataGrid
            // 
            this.BooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Author,
            this.Year,
            this.Description,
            this.Availability});
            this.BooksDataGrid.Location = new System.Drawing.Point(52, 188);
            this.BooksDataGrid.Name = "BooksDataGrid";
            this.BooksDataGrid.Size = new System.Drawing.Size(643, 150);
            this.BooksDataGrid.TabIndex = 0;
            this.BooksDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGrid_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Title
            // 
            this.Title.HeaderText = "title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availibility";
            this.Availability.Name = "Availability";
            // 
            // SrcBooksBtn
            // 
            this.SrcBooksBtn.Location = new System.Drawing.Point(184, 33);
            this.SrcBooksBtn.Name = "SrcBooksBtn";
            this.SrcBooksBtn.Size = new System.Drawing.Size(75, 23);
            this.SrcBooksBtn.TabIndex = 1;
            this.SrcBooksBtn.Text = "Search";
            this.SrcBooksBtn.UseVisualStyleBackColor = true;
            this.SrcBooksBtn.Click += new System.EventHandler(this.SrcBooksBtn_Click);
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.Location = new System.Drawing.Point(639, 12);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(164, 23);
            this.BackMenuBtn.TabIndex = 2;
            this.BackMenuBtn.Text = "Back to Menu";
            this.BackMenuBtn.UseVisualStyleBackColor = true;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // txtSrcBooks
            // 
            this.txtSrcBooks.Location = new System.Drawing.Point(68, 36);
            this.txtSrcBooks.Name = "txtSrcBooks";
            this.txtSrcBooks.Size = new System.Drawing.Size(100, 20);
            this.txtSrcBooks.TabIndex = 3;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(639, 41);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(122, 26);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Add New Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(639, 73);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(122, 26);
            this.EditBookBtn.TabIndex = 5;
            this.EditBookBtn.Text = "Edit Book";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.Location = new System.Drawing.Point(639, 105);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(122, 26);
            this.DeleteBookBtn.TabIndex = 6;
            this.DeleteBookBtn.Text = "Delete Book";
            this.DeleteBookBtn.UseVisualStyleBackColor = true;
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // LibrarianBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.txtSrcBooks);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.SrcBooksBtn);
            this.Controls.Add(this.BooksDataGrid);
            this.Name = "LibrarianBooks";
            this.Text = "LibrarianBooks";
            this.Load += new System.EventHandler(this.LibrarianBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.Button SrcBooksBtn;
        private System.Windows.Forms.Button BackMenuBtn;
        private System.Windows.Forms.TextBox txtSrcBooks;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button EditBookBtn;
        private System.Windows.Forms.Button DeleteBookBtn;
    }
}