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
            this.label1.Location = new System.Drawing.Point(125, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Management";
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(65, 173);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 1;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(239, 172);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBookBtn.TabIndex = 2;
            this.EditBookBtn.Text = "Edit Book";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.Location = new System.Drawing.Point(428, 173);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBookBtn.TabIndex = 3;
            this.DeleteBookBtn.Text = "Delete Book";
            this.DeleteBookBtn.UseVisualStyleBackColor = true;
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.Location = new System.Drawing.Point(471, 40);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(86, 23);
            this.BackMenuBtn.TabIndex = 4;
            this.BackMenuBtn.Text = "Back to Menu";
            this.BackMenuBtn.UseVisualStyleBackColor = true;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // BookManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 300);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.label1);
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