﻿namespace WindowsFormsApp1
{
    partial class ReaderBorrowedBooksForm
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
            this.borrowedBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectBookDataGridCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.returnBookbtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wypożyczone książki";
            // 
            // borrowedBooksDataGridView
            // 
            this.borrowedBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.rentalDate,
            this.returnDate,
            this.Fee,
            this.selectBookDataGridCheckbox});
            this.borrowedBooksDataGridView.Location = new System.Drawing.Point(38, 86);
            this.borrowedBooksDataGridView.Name = "borrowedBooksDataGridView";
            this.borrowedBooksDataGridView.Size = new System.Drawing.Size(643, 150);
            this.borrowedBooksDataGridView.TabIndex = 1;
            this.borrowedBooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowedBooksDataGridView_CellContentClick);
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
            // rentalDate
            // 
            this.rentalDate.HeaderText = "Rental Date";
            this.rentalDate.Name = "rentalDate";
            // 
            // returnDate
            // 
            this.returnDate.HeaderText = "Return Date";
            this.returnDate.Name = "returnDate";
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            // 
            // selectBookDataGridCheckbox
            // 
            this.selectBookDataGridCheckbox.HeaderText = "select";
            this.selectBookDataGridCheckbox.Name = "selectBookDataGridCheckbox";
            // 
            // returnBookbtn
            // 
            this.returnBookbtn.Location = new System.Drawing.Point(493, 25);
            this.returnBookbtn.Name = "returnBookbtn";
            this.returnBookbtn.Size = new System.Drawing.Size(145, 23);
            this.returnBookbtn.TabIndex = 2;
            this.returnBookbtn.Text = "Return Books";
            this.returnBookbtn.UseVisualStyleBackColor = true;
            this.returnBookbtn.Click += new System.EventHandler(this.returnBookbtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(673, 24);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReaderBorrowedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.returnBookbtn);
            this.Controls.Add(this.borrowedBooksDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ReaderBorrowedBooksForm";
            this.Text = "ReaderBorrowedBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView borrowedBooksDataGridView;
        private System.Windows.Forms.Button returnBookbtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBookDataGridCheckbox;
    }
}