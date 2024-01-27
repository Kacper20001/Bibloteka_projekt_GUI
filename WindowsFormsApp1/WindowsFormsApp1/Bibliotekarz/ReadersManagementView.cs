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
    public partial class ReadersManagementView : Form
    {
        private int currentLibrarianId;
        public string connectionString ="Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        public ReadersManagementView(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
            LoadReadersData(connectionString);
        }
        public void LoadReadersData(string connectionString, string searchTerm = "")
        {
            ReaderDataGrid.DataSource = Reader.LoadReaders(connectionString, searchTerm);
        }

        private void SrcReaderBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SrcReaderstxt.Text;
            LoadReadersData(connectionString, searchTerm);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ReaderDataGrid.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectCheckbox"].Value);
                if (isSelected)
                {
                    int readerId = Convert.ToInt32(row.Cells["ReaderId"].Value);
                    Reader.DeleteReader(readerId, connectionString);
                }
            }
            LoadReadersData(connectionString);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }
    }
}
