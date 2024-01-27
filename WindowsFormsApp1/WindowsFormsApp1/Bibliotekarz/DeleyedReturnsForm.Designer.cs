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
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.BackMenuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectBookCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeleyedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridDeleyedBook
            // 
            this.DataGridDeleyedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDeleyedBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectBookCheck});
            this.DataGridDeleyedBook.Location = new System.Drawing.Point(37, 121);
            this.DataGridDeleyedBook.Name = "DataGridDeleyedBook";
            this.DataGridDeleyedBook.Size = new System.Drawing.Size(738, 150);
            this.DataGridDeleyedBook.TabIndex = 0;
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.Location = new System.Drawing.Point(629, 65);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(85, 25);
            this.ReturnBookBtn.TabIndex = 1;
            this.ReturnBookBtn.Text = "Return Book";
            this.ReturnBookBtn.UseVisualStyleBackColor = true;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.Location = new System.Drawing.Point(629, 27);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(85, 23);
            this.BackMenuBtn.TabIndex = 2;
            this.BackMenuBtn.Text = "Back to Menu";
            this.BackMenuBtn.UseVisualStyleBackColor = true;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deleyed Returns";
            // 
            // SelectBookCheck
            // 
            this.SelectBookCheck.HeaderText = "Select";
            this.SelectBookCheck.Name = "SelectBookCheck";
            this.SelectBookCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectBookCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleyedReturnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.DataGridDeleyedBook);
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