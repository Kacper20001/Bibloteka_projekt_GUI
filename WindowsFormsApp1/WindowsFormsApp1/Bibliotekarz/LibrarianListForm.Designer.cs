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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LibrariansDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SrcReaderBtn
            // 
            this.SrcReaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SrcReaderBtn.ForeColor = System.Drawing.Color.White;
            this.SrcReaderBtn.Location = new System.Drawing.Point(198, 99);
            this.SrcReaderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcReaderBtn.Name = "SrcReaderBtn";
            this.SrcReaderBtn.Size = new System.Drawing.Size(100, 30);
            this.SrcReaderBtn.TabIndex = 8;
            this.SrcReaderBtn.Text = "Search";
            this.SrcReaderBtn.UseVisualStyleBackColor = false;
            this.SrcReaderBtn.Click += new System.EventHandler(this.SrcReaderBtn_Click);
            // 
            // SrcLibrariansTxt
            // 
            this.SrcLibrariansTxt.Location = new System.Drawing.Point(37, 99);
            this.SrcLibrariansTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcLibrariansTxt.Name = "SrcLibrariansTxt";
            this.SrcLibrariansTxt.Size = new System.Drawing.Size(132, 25);
            this.SrcLibrariansTxt.TabIndex = 7;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(781, 15);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(110, 28);
            this.BackBtn.TabIndex = 9;
            this.BackBtn.Text = "Back To Menu";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LibrariansDataGrid
            // 
            this.LibrariansDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LibrariansDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrariansDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCheckbox});
            this.LibrariansDataGrid.Location = new System.Drawing.Point(33, 191);
            this.LibrariansDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibrariansDataGrid.Name = "LibrariansDataGrid";
            this.LibrariansDataGrid.Size = new System.Drawing.Size(858, 230);
            this.LibrariansDataGrid.TabIndex = 10;
            // 
            // SelectCheckbox
            // 
            this.SelectCheckbox.HeaderText = "Select";
            this.SelectCheckbox.Name = "SelectCheckbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter search term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Librarians List";
            // 
            // LibrarianListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(922, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LibrariansDataGrid);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SrcReaderBtn);
            this.Controls.Add(this.SrcLibrariansTxt);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}