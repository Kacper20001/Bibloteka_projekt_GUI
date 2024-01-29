using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Bibliotekarz;

namespace WindowsFormsApp1
{
    public partial class LibrarianMenu : Form
    {
        private int currentLibrarianId;

        public LibrarianMenu(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianBooks librarianBooks = new LibrarianBooks(currentLibrarianId);
            librarianBooks.Show();
        }

        private void BookManagementBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookManagementView bookManagementView = new BookManagementView(currentLibrarianId);
            bookManagementView.Show();
        }

        private void LibrarianMenu_Load(object sender, EventArgs e)
        {

        }

        private void DeleyedReturnsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleyedReturnsForm deleyedReturnsForm = new DeleyedReturnsForm(currentLibrarianId);
            deleyedReturnsForm.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            currentLibrarianId = 0;
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void LibrarainInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianInfoView librarianInfoView = new LibrarianInfoView(currentLibrarianId);
            librarianInfoView.Show();
        }

        private void borrowedBooksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowedBooksForm borrowedBooksForm = new BorrowedBooksForm(currentLibrarianId);
            borrowedBooksForm.Show();
        }

        private void ReadersManagementBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadersManagementView readersManagementView = new ReadersManagementView(currentLibrarianId);
            readersManagementView.Show();
        }

        private void AddLibrarianBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            isterLibrarianForm isterLibrarianForm = new isterLibrarianForm(currentLibrarianId);
            isterLibrarianForm.Show();
        }

        private void LibrariansListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianListForm librarianList = new LibrarianListForm(currentLibrarianId);
            librarianList.Show();
        }

        private void DataBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataForm dataForm = new DataForm(currentLibrarianId);
            dataForm.Show();
        }
    }
}
