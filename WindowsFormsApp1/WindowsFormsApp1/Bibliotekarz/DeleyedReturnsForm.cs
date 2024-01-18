using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class DeleyedReturnsForm : Form
    {
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True";
        public DeleyedReturnsForm()
        {
            InitializeComponent();
            LoadOverdueBooksData();
        }
        private void LoadOverdueBooksData()
        {
            DataGridDeleyedBook.DataSource = Book.LoadOverdueBooks();
        }
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridDeleyedBook.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectBookCheck"].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                    Book.ReturnBook(bookId, connectionString);
                }
            }
            Book.LoadOverdueBooks();
        }
    }
}
