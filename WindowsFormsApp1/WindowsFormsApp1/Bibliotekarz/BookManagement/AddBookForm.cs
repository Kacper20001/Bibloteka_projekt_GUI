﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Bibliotekarz.BookManagement
{
    public partial class AddBookForm : Form
    {
        private int currentLibrarianId;
        private int id;
        public AddBookForm(int id)
        {
            InitializeComponent();
            currentLibrarianId = id;
        }

        private void AddNewBookBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTxt.Text);
            string title = TitleTxt.Text;
            string author = AuthorTxt.Text; 
            int year = Convert.ToInt32(YearTxt.Text);   
            string description = DescriptionTxt.Text;
            
            Book.AddBook(id, title, author, year, description);
            MessageBox.Show("Dodano nową książkę");

            IdTxt.Text = "";
            TitleTxt.Text = "";
            AuthorTxt.Text = "";
            YearTxt.Text = "";
            DescriptionTxt.Text = "";

        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }
    }
}