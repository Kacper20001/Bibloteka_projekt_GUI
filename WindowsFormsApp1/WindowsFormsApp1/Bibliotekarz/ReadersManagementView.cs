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
            IReaderHandle readerHandle = new ReaderHandle(connectionString);
            ReaderDataGrid.DataSource = readerHandle.LoadReaders(searchTerm);
        }

        private void SrcReaderBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SrcReaderstxt.Text;
            LoadReadersData(connectionString, searchTerm);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            IReaderHandle readerHandle = new ReaderHandle(connectionString);
            foreach (DataGridViewRow row in ReaderDataGrid.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectCheckbox"].Value);
                if (isSelected)
                {
                    int readerId = Convert.ToInt32(row.Cells["ReaderId"].Value);
                    readerHandle.DeleteReader(readerId);
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
