namespace WindowsFormsApp1
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
            this.selectBookCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.returnBookbtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(409, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrowed Books";
            // 
            // borrowedBooksDataGridView
            // 
            this.borrowedBooksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.borrowedBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBookCheckbox});
            this.borrowedBooksDataGridView.Location = new System.Drawing.Point(51, 112);
            this.borrowedBooksDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrowedBooksDataGridView.Name = "borrowedBooksDataGridView";
            this.borrowedBooksDataGridView.Size = new System.Drawing.Size(983, 442);
            this.borrowedBooksDataGridView.TabIndex = 1;
            this.borrowedBooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowedBooksDataGridView_CellContentClick);
            // 
            // selectBookCheckbox
            // 
            this.selectBookCheckbox.HeaderText = "select";
            this.selectBookCheckbox.Name = "selectBookCheckbox";
            // 
            // returnBookbtn
            // 
            this.returnBookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.returnBookbtn.ForeColor = System.Drawing.Color.White;
            this.returnBookbtn.Location = new System.Drawing.Point(51, 72);
            this.returnBookbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnBookbtn.Name = "returnBookbtn";
            this.returnBookbtn.Size = new System.Drawing.Size(115, 32);
            this.returnBookbtn.TabIndex = 2;
            this.returnBookbtn.Text = "Return Books";
            this.returnBookbtn.UseVisualStyleBackColor = false;
            this.returnBookbtn.Click += new System.EventHandler(this.returnBookbtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(897, 31);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 30);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReaderBorrowedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.returnBookbtn);
            this.Controls.Add(this.borrowedBooksDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReaderBorrowedBooksForm";
            this.Text = "ReaderBorrowedBooksForm";
            this.Load += new System.EventHandler(this.ReaderBorrowedBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView borrowedBooksDataGridView;
        private System.Windows.Forms.Button returnBookbtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBookCheckbox;
    }
}