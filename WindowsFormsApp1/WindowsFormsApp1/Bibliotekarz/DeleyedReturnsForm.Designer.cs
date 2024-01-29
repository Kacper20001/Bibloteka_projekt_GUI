namespace WindowsFormsApp1.Bibliotekarz
{
    partial class DeleyedReturnsForm
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
            this.DataGridDeleyedBook = new System.Windows.Forms.DataGridView();
            this.SelectBookCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.BackMenuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeleyedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridDeleyedBook
            // 
            this.DataGridDeleyedBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DataGridDeleyedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDeleyedBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectBookCheck});
            this.DataGridDeleyedBook.Location = new System.Drawing.Point(49, 158);
            this.DataGridDeleyedBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridDeleyedBook.Name = "DataGridDeleyedBook";
            this.DataGridDeleyedBook.Size = new System.Drawing.Size(815, 283);
            this.DataGridDeleyedBook.TabIndex = 0;
            // 
            // SelectBookCheck
            // 
            this.SelectBookCheck.HeaderText = "Select";
            this.SelectBookCheck.Name = "SelectBookCheck";
            this.SelectBookCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectBookCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ReturnBookBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnBookBtn.Location = new System.Drawing.Point(693, 84);
            this.ReturnBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(113, 33);
            this.ReturnBookBtn.TabIndex = 1;
            this.ReturnBookBtn.Text = "Return Book";
            this.ReturnBookBtn.UseVisualStyleBackColor = false;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackMenuBtn.ForeColor = System.Drawing.Color.White;
            this.BackMenuBtn.Location = new System.Drawing.Point(693, 34);
            this.BackMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(113, 30);
            this.BackMenuBtn.TabIndex = 2;
            this.BackMenuBtn.Text = "Back to Menu";
            this.BackMenuBtn.UseVisualStyleBackColor = false;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(304, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deleyed Returns";
            // 
            // DeleyedReturnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(922, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.DataGridDeleyedBook);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleyedReturnsForm";
            this.Text = "DeleyedReturnsForm";
            this.Load += new System.EventHandler(this.DeleyedReturnsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeleyedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridDeleyedBook;
        private System.Windows.Forms.Button ReturnBookBtn;
        private System.Windows.Forms.Button BackMenuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectBookCheck;
    }
}