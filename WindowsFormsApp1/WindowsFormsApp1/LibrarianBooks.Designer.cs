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
            this.BooksDataGrid.Location = new System.Drawing.Point(50, 88);
            this.BooksDataGrid.Name = "BooksDataGrid";
            this.BooksDataGrid.Size = new System.Drawing.Size(651, 150);
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
            this.BackMenuBtn.Location = new System.Drawing.Point(634, 33);
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
            // LibrarianBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSrcBooks);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.SrcBooksBtn);
            this.Controls.Add(this.BooksDataGrid);
            this.Name = "LibrarianBooks";
            this.Text = "LibrarianBooks";
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
    }
}