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
        string[] tables = { "Books", "Librarians", "Readers", "BorrowedBooks" };

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
            DataExportToCSV exporter = new DataExportToCSV(connectionString);
            exporter.ExportData(tables);

            MessageBox.Show("Eksport danych zakończony.");

        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            ImportFromCSV importer = new ImportFromCSV(connectionString);
            try
            {
                importer.ImportData(tables);
                MessageBox.Show("Data imported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
