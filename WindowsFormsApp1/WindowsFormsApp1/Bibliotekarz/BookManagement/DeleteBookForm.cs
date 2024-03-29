﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1.Bibliotekarz.BookManagement
{
    public partial class DeleteBookForm : Form
    {
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        private int currentLibraryId;
        public DeleteBookForm(int id)
        {
            InitializeComponent();
            currentLibraryId = id;
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibraryId);
            librarianMenu.Show();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianBooks librarianBooks = new LibrarianBooks(currentLibraryId);
            librarianBooks.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            IBookHandle bookHandle = new BookHandle(connectionString);
            try
            {
                int id = Convert.ToInt32(IdTxt.Text);
                bookHandle.DeleteBook(id);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID");
            }
        }
    }
}
