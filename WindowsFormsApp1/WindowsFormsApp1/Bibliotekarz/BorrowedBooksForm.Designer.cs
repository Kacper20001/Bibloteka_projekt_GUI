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
            this.SelectToReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.ReturnBooksBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(124, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of books that are currently on loan";
            // 
            // DataGridBorrowed
            // 
            this.DataGridBorrowed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DataGridBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectToReturn});
            this.DataGridBorrowed.Location = new System.Drawing.Point(65, 171);
            this.DataGridBorrowed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DataGridBorrowed.Name = "DataGridBorrowed";
            this.DataGridBorrowed.Size = new System.Drawing.Size(763, 252);
            this.DataGridBorrowed.TabIndex = 1;
            // 
            // SelectToReturn
            // 
            this.SelectToReturn.HeaderText = "Select";
            this.SelectToReturn.Name = "SelectToReturn";
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackToMenuBtn.ForeColor = System.Drawing.Color.White;
            this.BackToMenuBtn.Location = new System.Drawing.Point(696, 71);
            this.BackToMenuBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(132, 30);
            this.BackToMenuBtn.TabIndex = 2;
            this.BackToMenuBtn.Text = "Back To Menu ";
            this.BackToMenuBtn.UseVisualStyleBackColor = false;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // ReturnBooksBtn
            // 
            this.ReturnBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ReturnBooksBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnBooksBtn.Location = new System.Drawing.Point(65, 128);
            this.ReturnBooksBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ReturnBooksBtn.Name = "ReturnBooksBtn";
            this.ReturnBooksBtn.Size = new System.Drawing.Size(132, 33);
            this.ReturnBooksBtn.TabIndex = 3;
            this.ReturnBooksBtn.Text = "Return books";
            this.ReturnBooksBtn.UseVisualStyleBackColor = false;
            this.ReturnBooksBtn.Click += new System.EventHandler(this.ReturnBooksBtn_Click);
            // 
            // BorrowedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(883, 479);
            this.Controls.Add(this.ReturnBooksBtn);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.DataGridBorrowed);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectToReturn;
    }
}