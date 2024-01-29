using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class DataForm : Form
    {
        private int currentLibrarianId;
        public string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";

        public DataForm(int librarianId)
        {
            InitializeComponent();
            currentLibrarianId = librarianId;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            string[] tables = { "Books","Librarians", "Readers", "BorrowedBooks" };
            DataExportToCSV exporter = new DataExportToCSV(connectionString);
            exporter.ExportData(tables);

            MessageBox.Show("Eksport danych zakończony.");

        }
    }
}
