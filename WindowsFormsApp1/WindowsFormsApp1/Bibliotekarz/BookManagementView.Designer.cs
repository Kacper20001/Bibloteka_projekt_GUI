namespace WindowsFormsApp1
{
    partial class BookManagementView
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
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            this.BackMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(158, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AddBookBtn.ForeColor = System.Drawing.Color.White;
            this.AddBookBtn.Location = new System.Drawing.Point(87, 159);
            this.AddBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(100, 90);
            this.AddBookBtn.TabIndex = 1;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = false;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.EditBookBtn.ForeColor = System.Drawing.Color.White;
            this.EditBookBtn.Location = new System.Drawing.Point(207, 159);
            this.EditBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(100, 90);
            this.EditBookBtn.TabIndex = 2;
            this.EditBookBtn.Text = "Edit Book";
            this.EditBookBtn.UseVisualStyleBackColor = false;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DeleteBookBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBookBtn.Location = new System.Drawing.Point(331, 159);
            this.DeleteBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(100, 90);
            this.DeleteBookBtn.TabIndex = 3;
            this.DeleteBookBtn.Text = "Delete Book";
            this.DeleteBookBtn.UseVisualStyleBackColor = false;
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackMenuBtn.ForeColor = System.Drawing.Color.White;
            this.BackMenuBtn.Location = new System.Drawing.Point(387, 13);
            this.BackMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(115, 30);
            this.BackMenuBtn.TabIndex = 4;
            this.BackMenuBtn.Text = "Back to Menu";
            this.BackMenuBtn.UseVisualStyleBackColor = false;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // BookManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(531, 299);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookManagementView";
            this.Text = "BookManagementView";
            this.Load += new System.EventHandler(this.BookManagementView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button EditBookBtn;
        private System.Windows.Forms.Button DeleteBookBtn;
        private System.Windows.Forms.Button BackMenuBtn;
    }
}