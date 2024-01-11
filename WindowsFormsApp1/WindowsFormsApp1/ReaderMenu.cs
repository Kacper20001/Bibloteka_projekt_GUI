using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReaderMenu : Form
    {
        private int currentReaderId;

        public ReaderMenu(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userMenuBorrowed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderBorrowedBooksForm readerBorrowedBooksForm = new ReaderBorrowedBooksForm(currentReaderId);
            readerBorrowedBooksForm.Show();
        }

        private void ReaderMenu_Load(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            currentReaderId = 0;
            this.Close();
            Application.OpenForms.Cast<Form>().Where(form => form.Name != "StartForm").ToList().ForEach(form => form.Close());
            
        }

        private void userManuAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderAccountForms readerAccountForms = new ReaderAccountForms(currentReaderId);
            readerAccountForms.Show();
        }

        private void userManuSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBooksForm searchBooksForm = new SearchBooksForm(currentReaderId);
            searchBooksForm.Show();
        }
    }
}
