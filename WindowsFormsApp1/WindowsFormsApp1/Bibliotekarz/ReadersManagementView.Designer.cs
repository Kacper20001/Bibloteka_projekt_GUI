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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id,
            this.FirstName,
            this.LastName,
            this.DateOfBirth,
            this.Email,
            this.PhoneNumber,
            this.Street,
            this.City,
            this.HouseNumber,
            this.PostalCode,
            this.Country,
            this.SelectCheckbox});
            this.ReaderDataGrid.Location = new System.Drawing.Point(2, 118);
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
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // HouseNumber
            // 
            this.HouseNumber.HeaderText = "HouseNumber";
            this.HouseNumber.Name = "HouseNumber";
            // 
            // PostalCode
            // 
            this.PostalCode.HeaderText = "PostalCode";
            this.PostalCode.Name = "PostalCode";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCheckbox;
    }
}