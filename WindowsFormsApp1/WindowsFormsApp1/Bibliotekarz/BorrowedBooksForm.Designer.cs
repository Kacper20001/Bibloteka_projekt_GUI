namespace WindowsFormsApp1.Bibliotekarz
{
    partial class BorrowedBooksForm
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
            this.DataGridBorrowed = new System.Windows.Forms.DataGridView();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.ReturnBooksBtn = new System.Windows.Forms.Button();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverdueFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectToReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of books that are currently on loan.";
            // 
            // DataGridBorrowed
            // 
            this.DataGridBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.ReaderId,
            this.borrowDate,
            this.ReturnDate,
            this.OverdueFee,
            this.SelectToReturn});
            this.DataGridBorrowed.Location = new System.Drawing.Point(12, 59);
            this.DataGridBorrowed.Name = "DataGridBorrowed";
            this.DataGridBorrowed.Size = new System.Drawing.Size(626, 204);
            this.DataGridBorrowed.TabIndex = 1;
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Location = new System.Drawing.Point(685, 29);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(93, 27);
            this.BackToMenuBtn.TabIndex = 2;
            this.BackToMenuBtn.Text = "Back To Menu ";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // ReturnBooksBtn
            // 
            this.ReturnBooksBtn.Location = new System.Drawing.Point(685, 76);
            this.ReturnBooksBtn.Name = "ReturnBooksBtn";
            this.ReturnBooksBtn.Size = new System.Drawing.Size(93, 29);
            this.ReturnBooksBtn.TabIndex = 3;
            this.ReturnBooksBtn.Text = "Return books";
            this.ReturnBooksBtn.UseVisualStyleBackColor = true;
            this.ReturnBooksBtn.Click += new System.EventHandler(this.ReturnBooksBtn_Click);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "Book ID";
            this.book_id.Name = "book_id";
            // 
            // ReaderId
            // 
            this.ReaderId.HeaderText = "Reader ID";
            this.ReaderId.Name = "ReaderId";
            // 
            // borrowDate
            // 
            this.borrowDate.HeaderText = "Borrow Date";
            this.borrowDate.Name = "borrowDate";
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // OverdueFee
            // 
            this.OverdueFee.HeaderText = "OverdueFee";
            this.OverdueFee.Name = "OverdueFee";
            // 
            // SelectToReturn
            // 
            this.SelectToReturn.HeaderText = "Select";
            this.SelectToReturn.Name = "SelectToReturn";
            // 
            // BorrowedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnBooksBtn);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.DataGridBorrowed);
            this.Controls.Add(this.label1);
            this.Name = "BorrowedBooksForm";
            this.Text = "BorrowedBooksForm";
            this.Load += new System.EventHandler(this.BorrowedBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridBorrowed;
        private System.Windows.Forms.Button BackToMenuBtn;
        private System.Windows.Forms.Button ReturnBooksBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverdueFee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectToReturn;
    }
}