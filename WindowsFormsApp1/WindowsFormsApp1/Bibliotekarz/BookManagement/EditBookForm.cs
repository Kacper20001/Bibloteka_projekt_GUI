using System;
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
    public partial class EditBookForm : Form
    {
        private int currentLibrarianId;
        private int id;
        public EditBookForm(int currentLibrarianId)
        {
            InitializeComponent();
            this.currentLibrarianId = id;
        }


        private void FindBtn_Click(object sender, EventArgs e)
        {
            id = int.Parse(IdTxt.Text);
            Book bookToEdit = Book.GetBookById(id);
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
                TitleTxt.Text = "";
                AuthorTxt.Text = "";
                YearTxt.Text = "";
                DescriptionTxt.Text = "";
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Book.EditBook(id, TitleTxt.Text, AuthorTxt.Text, DescriptionTxt.Text, Convert.ToInt32(YearTxt.Text.ToString()));
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
