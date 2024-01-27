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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SelectCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1116, 22);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back To Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SrcReaderBtn
            // 
            this.SrcReaderBtn.Location = new System.Drawing.Point(179, 22);
            this.SrcReaderBtn.Name = "SrcReaderBtn";
            this.SrcReaderBtn.Size = new System.Drawing.Size(75, 23);
            this.SrcReaderBtn.TabIndex = 6;
            this.SrcReaderBtn.Text = "Search";
            this.SrcReaderBtn.UseVisualStyleBackColor = true;
            this.SrcReaderBtn.Click += new System.EventHandler(this.SrcReaderBtn_Click);
            // 
            // SrcReaderstxt
            // 
            this.SrcReaderstxt.Location = new System.Drawing.Point(59, 22);
            this.SrcReaderstxt.Name = "SrcReaderstxt";
            this.SrcReaderstxt.Size = new System.Drawing.Size(100, 20);
            this.SrcReaderstxt.TabIndex = 5;
            // 
            // ReaderDataGrid
            // 
            this.ReaderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCheckbox});
            this.ReaderDataGrid.Location = new System.Drawing.Point(12, 118);
            this.ReaderDataGrid.Name = "ReaderDataGrid";
            this.ReaderDataGrid.Size = new System.Drawing.Size(1224, 150);
            this.ReaderDataGrid.TabIndex = 8;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(935, 22);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(133, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete Reader";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SelectCheckbox
            // 
            this.SelectCheckbox.HeaderText = "Select";
            this.SelectCheckbox.Name = "SelectCheckbox";
            // 
            // ReadersManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReaderDataGrid);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SrcReaderBtn);
            this.Controls.Add(this.SrcReaderstxt);
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
    }
}