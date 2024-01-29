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
    public partial class AddBookForm : Form
    {
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        private int currentLibrarianId;
        private int id;
        public AddBookForm(int id)
        {
            InitializeComponent();
            currentLibrarianId = id;
        }

        private void AddNewBookBtn_Click(object sender, EventArgs e)
        {
            IBookHandle bookHandle = new BookHandle(connectionString);
            string title = TitleTxt.Text;
            string author = AuthorTxt.Text; 
            int year = Convert.ToInt32(YearTxt.Text);   
            string description = DescriptionTxt.Text;
            bookHandle.AddBook(title, author, year, description);
            MessageBox.Show("Dodano nową książkę");

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

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
