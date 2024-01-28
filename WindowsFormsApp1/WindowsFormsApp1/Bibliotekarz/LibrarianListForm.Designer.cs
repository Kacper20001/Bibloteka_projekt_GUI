namespace WindowsFormsApp1.Bibliotekarz
{
    partial class LibrarianListForm
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
            this.SrcReaderBtn = new System.Windows.Forms.Button();
            this.SrcLibrariansTxt = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LibrariansDataGrid = new System.Windows.Forms.DataGridView();
            this.SelectCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LibrariansDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SrcReaderBtn
            // 
            this.SrcReaderBtn.Location = new System.Drawing.Point(145, 29);
            this.SrcReaderBtn.Name = "SrcReaderBtn";
            this.SrcReaderBtn.Size = new System.Drawing.Size(75, 23);
            this.SrcReaderBtn.TabIndex = 8;
            this.SrcReaderBtn.Text = "Search";
            this.SrcReaderBtn.UseVisualStyleBackColor = true;
            this.SrcReaderBtn.Click += new System.EventHandler(this.SrcReaderBtn_Click);
            // 
            // SrcLibrariansTxt
            // 
            this.SrcLibrariansTxt.Location = new System.Drawing.Point(25, 29);
            this.SrcLibrariansTxt.Name = "SrcLibrariansTxt";
            this.SrcLibrariansTxt.Size = new System.Drawing.Size(100, 20);
            this.SrcLibrariansTxt.TabIndex = 7;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(685, 26);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 9;
            this.BackBtn.Text = "Back To Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LibrariansDataGrid
            // 
            this.LibrariansDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrariansDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCheckbox});
            this.LibrariansDataGrid.Location = new System.Drawing.Point(61, 150);
            this.LibrariansDataGrid.Name = "LibrariansDataGrid";
            this.LibrariansDataGrid.Size = new System.Drawing.Size(971, 136);
            this.LibrariansDataGrid.TabIndex = 10;
            // 
            // SelectCheckbox
            // 
            this.SelectCheckbox.HeaderText = "Select";
            this.SelectCheckbox.Name = "SelectCheckbox";
            // 
            // LibrarianListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.LibrariansDataGrid);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SrcReaderBtn);
            this.Controls.Add(this.SrcLibrariansTxt);
            this.Name = "LibrarianListForm";
            this.Text = "LibrarianListForm";
            ((System.ComponentModel.ISupportInitialize)(this.LibrariansDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SrcReaderBtn;
        private System.Windows.Forms.TextBox SrcLibrariansTxt;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView LibrariansDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCheckbox;
    }
}