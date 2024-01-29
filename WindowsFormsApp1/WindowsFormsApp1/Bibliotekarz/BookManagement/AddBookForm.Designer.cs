namespace WindowsFormsApp1.Bibliotekarz.BookManagement
{
    partial class AddBookForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.AuthorTxt = new System.Windows.Forms.TextBox();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.AddNewBookBtn = new System.Windows.Forms.Button();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(105, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(95, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(80, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(95, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(52, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(157, 116);
            this.TitleTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(132, 25);
            this.TitleTxt.TabIndex = 7;
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.Location = new System.Drawing.Point(157, 149);
            this.AuthorTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.Size = new System.Drawing.Size(132, 25);
            this.AuthorTxt.TabIndex = 8;
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(157, 182);
            this.YearTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(132, 25);
            this.YearTxt.TabIndex = 9;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(157, 214);
            this.DescriptionTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(132, 25);
            this.DescriptionTxt.TabIndex = 10;
            // 
            // AddNewBookBtn
            // 
            this.AddNewBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AddNewBookBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewBookBtn.Location = new System.Drawing.Point(150, 259);
            this.AddNewBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewBookBtn.Name = "AddNewBookBtn";
            this.AddNewBookBtn.Size = new System.Drawing.Size(139, 30);
            this.AddNewBookBtn.TabIndex = 12;
            this.AddNewBookBtn.Text = "Add New Book";
            this.AddNewBookBtn.UseVisualStyleBackColor = false;
            this.AddNewBookBtn.Click += new System.EventHandler(this.AddNewBookBtn_Click);
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.backToMenuBtn.ForeColor = System.Drawing.Color.White;
            this.backToMenuBtn.Location = new System.Drawing.Point(315, 13);
            this.backToMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(100, 30);
            this.backToMenuBtn.TabIndex = 13;
            this.backToMenuBtn.Text = "Back to Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = false;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(428, 331);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.AddNewBookBtn);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.AuthorTxt);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox AuthorTxt;
        private System.Windows.Forms.TextBox YearTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Button AddNewBookBtn;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}