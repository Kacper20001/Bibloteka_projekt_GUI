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
            this.BorrowCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SrcReturnBtn = new System.Windows.Forms.Button();
            this.Borrowbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrcBooks
            // 
            this.txtSrcBooks.Location = new System.Drawing.Point(75, 98);
            this.txtSrcBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSrcBooks.Name = "txtSrcBooks";
            this.txtSrcBooks.Size = new System.Drawing.Size(139, 25);
            this.txtSrcBooks.TabIndex = 0;
            // 
            // SrcBooksBtn
            // 
            this.SrcBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SrcBooksBtn.ForeColor = System.Drawing.Color.White;
            this.SrcBooksBtn.Location = new System.Drawing.Point(234, 94);
            this.SrcBooksBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcBooksBtn.Name = "SrcBooksBtn";
            this.SrcBooksBtn.Size = new System.Drawing.Size(100, 30);
            this.SrcBooksBtn.TabIndex = 1;
            this.SrcBooksBtn.Text = "Search";
            this.SrcBooksBtn.UseVisualStyleBackColor = false;
            this.SrcBooksBtn.Click += new System.EventHandler(this.SrcBooksBtn_Click);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToOrderColumns = true;
            this.booksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowCheckbox});
            this.booksDataGridView.Location = new System.Drawing.Point(100, 174);
            this.booksDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(898, 238);
            this.booksDataGridView.TabIndex = 2;
            this.booksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellContentClick);
            // 
            // BorrowCheckbox
            // 
            this.BorrowCheckbox.HeaderText = "Select";
            this.BorrowCheckbox.Name = "BorrowCheckbox";
            this.BorrowCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SrcReturnBtn
            // 
            this.SrcReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SrcReturnBtn.ForeColor = System.Drawing.Color.White;
            this.SrcReturnBtn.Location = new System.Drawing.Point(898, 23);
            this.SrcReturnBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcReturnBtn.Name = "SrcReturnBtn";
            this.SrcReturnBtn.Size = new System.Drawing.Size(100, 30);
            this.SrcReturnBtn.TabIndex = 3;
            this.SrcReturnBtn.Text = "Back";
            this.SrcReturnBtn.UseVisualStyleBackColor = false;
            this.SrcReturnBtn.Click += new System.EventHandler(this.SrcReturnBtn_Click);
            // 
            // Borrowbtn
            // 
            this.Borrowbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Borrowbtn.ForeColor = System.Drawing.Color.White;
            this.Borrowbtn.Location = new System.Drawing.Point(342, 94);
            this.Borrowbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Borrowbtn.Name = "Borrowbtn";
            this.Borrowbtn.Size = new System.Drawing.Size(100, 30);
            this.Borrowbtn.TabIndex = 4;
            this.Borrowbtn.Text = "Borrow";
            this.Borrowbtn.UseVisualStyleBackColor = false;
            this.Borrowbtn.Click += new System.EventHandler(this.Borrowbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(475, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(71, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter search term";
            // 
            // SearchBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1048, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Borrowbtn);
            this.Controls.Add(this.SrcReturnBtn);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.SrcBooksBtn);
            this.Controls.Add(this.txtSrcBooks);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button Borrowbtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BorrowCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}