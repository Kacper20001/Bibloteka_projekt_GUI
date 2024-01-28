using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class LibrarianListForm : Form
    {
        private int currentLibrarianId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        public LibrarianListForm(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
            LoadLibrariansData(connectionString);

        }

        private void SrcReaderBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SrcLibrariansTxt.Text;
            LoadLibrariansData(connectionString, searchTerm);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }
        public void LoadLibrariansData(string connectionString, string searchTerm = "")
        {
            ILibrarianHandle librarianHandle = new LibrarianHandle();
            LibrariansDataGrid.DataSource = librarianHandle.LoadLibrarians(connectionString, searchTerm);
        }
    }
}
