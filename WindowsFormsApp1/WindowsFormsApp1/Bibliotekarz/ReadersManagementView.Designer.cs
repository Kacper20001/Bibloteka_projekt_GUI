namespace WindowsFormsApp1.Bibliotekarz
{
    partial class ReadersManagementView
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.SrcReaderBtn = new System.Windows.Forms.Button();
            this.SrcReaderstxt = new System.Windows.Forms.TextBox();
            this.ReaderDataGrid = new System.Windows.Forms.DataGridView();
            this.SelectCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(801, 18);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(122, 30);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back To Menu";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SrcReaderBtn
            // 
            this.SrcReaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SrcReaderBtn.ForeColor = System.Drawing.Color.White;
            this.SrcReaderBtn.Location = new System.Drawing.Point(232, 95);
            this.SrcReaderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcReaderBtn.Name = "SrcReaderBtn";
            this.SrcReaderBtn.Size = new System.Drawing.Size(100, 32);
            this.SrcReaderBtn.TabIndex = 6;
            this.SrcReaderBtn.Text = "Search";
            this.SrcReaderBtn.UseVisualStyleBackColor = false;
            this.SrcReaderBtn.Click += new System.EventHandler(this.SrcReaderBtn_Click);
            // 
            // SrcReaderstxt
            // 
            this.SrcReaderstxt.Location = new System.Drawing.Point(69, 98);
            this.SrcReaderstxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SrcReaderstxt.Name = "SrcReaderstxt";
            this.SrcReaderstxt.Size = new System.Drawing.Size(155, 25);
            this.SrcReaderstxt.TabIndex = 5;
            // 
            // ReaderDataGrid
            // 
            this.ReaderDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ReaderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCheckbox});
            this.ReaderDataGrid.Location = new System.Drawing.Point(69, 150);
            this.ReaderDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReaderDataGrid.Name = "ReaderDataGrid";
            this.ReaderDataGrid.Size = new System.Drawing.Size(854, 255);
            this.ReaderDataGrid.TabIndex = 8;
            // 
            // SelectCheckbox
            // 
            this.SelectCheckbox.HeaderText = "Select";
            this.SelectCheckbox.Name = "SelectCheckbox";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(340, 95);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(139, 32);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete Reader";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter search term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(394, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Readers Management";
            // 
            // ReadersManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(999, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReaderDataGrid);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SrcReaderBtn);
            this.Controls.Add(this.SrcReaderstxt);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReadersManagementView";
            this.Text = "ReadersManagementView";
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SrcReaderBtn;
        private System.Windows.Forms.TextBox SrcReaderstxt;
        private System.Windows.Forms.DataGridView ReaderDataGrid;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}