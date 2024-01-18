namespace WindowsFormsApp1
{
    partial class SearchBooksForm
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
            this.txtSrcBooks = new System.Windows.Forms.TextBox();
            this.SrcBooksBtn = new System.Windows.Forms.Button();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SrcReturnBtn = new System.Windows.Forms.Button();
            this.Borrowbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrcBooks
            // 
            this.txtSrcBooks.Location = new System.Drawing.Point(61, 33);
            this.txtSrcBooks.Name = "txtSrcBooks";
            this.txtSrcBooks.Size = new System.Drawing.Size(100, 20);
            this.txtSrcBooks.TabIndex = 0;
            // 
            // SrcBooksBtn
            // 
            this.SrcBooksBtn.Location = new System.Drawing.Point(180, 30);
            this.SrcBooksBtn.Name = "SrcBooksBtn";
            this.SrcBooksBtn.Size = new System.Drawing.Size(75, 23);
            this.SrcBooksBtn.TabIndex = 1;
            this.SrcBooksBtn.Text = "Search";
            this.SrcBooksBtn.UseVisualStyleBackColor = true;
            this.SrcBooksBtn.Click += new System.EventHandler(this.SrcBooksBtn_Click);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToOrderColumns = true;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Author,
            this.Year,
            this.Description,
            this.Availability,
            this.BorrowCheckbox});
            this.booksDataGridView.Location = new System.Drawing.Point(51, 106);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(856, 196);
            this.booksDataGridView.TabIndex = 2;
            this.booksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
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
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            // 
            // BorrowCheckbox
            // 
            this.BorrowCheckbox.HeaderText = "Select";
            this.BorrowCheckbox.Name = "BorrowCheckbox";
            this.BorrowCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SrcReturnBtn
            // 
            this.SrcReturnBtn.Location = new System.Drawing.Point(826, 30);
            this.SrcReturnBtn.Name = "SrcReturnBtn";
            this.SrcReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.SrcReturnBtn.TabIndex = 3;
            this.SrcReturnBtn.Text = "Back";
            this.SrcReturnBtn.UseVisualStyleBackColor = true;
            this.SrcReturnBtn.Click += new System.EventHandler(this.SrcReturnBtn_Click);
            // 
            // Borrowbtn
            // 
            this.Borrowbtn.Location = new System.Drawing.Point(717, 33);
            this.Borrowbtn.Name = "Borrowbtn";
            this.Borrowbtn.Size = new System.Drawing.Size(75, 23);
            this.Borrowbtn.TabIndex = 4;
            this.Borrowbtn.Text = "Borrow";
            this.Borrowbtn.UseVisualStyleBackColor = true;
            this.Borrowbtn.Click += new System.EventHandler(this.Borrowbtn_Click);
            // 
            // SearchBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 467);
            this.Controls.Add(this.Borrowbtn);
            this.Controls.Add(this.SrcReturnBtn);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.SrcBooksBtn);
            this.Controls.Add(this.txtSrcBooks);
            this.Name = "SearchBooksForm";
            this.Text = "SearchBooksForm";
            this.Load += new System.EventHandler(this.SearchBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrcBooks;
        private System.Windows.Forms.Button SrcBooksBtn;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Button SrcReturnBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BorrowCheckbox;
        private System.Windows.Forms.Button Borrowbtn;
    }
}