using System;
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
    public partial class EditBookForm : Form
    {
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        private int currentLibrarianId;
        private int id;
        public EditBookForm(int currentLibrarianId)
        {
            InitializeComponent();
            this.currentLibrarianId = currentLibrarianId;
        }


        private void FindBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(IdTxt.Text);
            IBookHandle bookHandle = new BookHandle(connectionString);

            Book bookToEdit = bookHandle.GetBookById(Convert.ToInt32(id)); //tutaj
            if (bookToEdit != null)
            {
                TitleTxt.Text = bookToEdit.Title;
                AuthorTxt.Text = bookToEdit.Author;
                YearTxt.Text = bookToEdit.Year.ToString();
                DescriptionTxt.Text = bookToEdit.Description;
            }
            else
            {
                MessageBox.Show("Id doesn't exist");
                IdTxt.Text = "";
                TitleTxt.Text = "";
                AuthorTxt.Text = "";
                YearTxt.Text = "";
                DescriptionTxt.Text = "";
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            IBookHandle bookHandle = new BookHandle(connectionString);
            bookHandle.EditBook(id, TitleTxt.Text, AuthorTxt.Text, DescriptionTxt.Text, Convert.ToInt32(YearTxt.Text));
            MessageBox.Show("Update successful");
            TitleTxt.Text = "";
            AuthorTxt.Text = "";
            YearTxt.Text = "";
            DescriptionTxt.Text = "";
        }

        private void BookListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianBooks librarianBooks = new LibrarianBooks(currentLibrarianId);
            librarianBooks.Show();
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }
    }
}
