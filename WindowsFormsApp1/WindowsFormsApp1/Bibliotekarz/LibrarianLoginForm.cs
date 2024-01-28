using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1
{
    public partial class LibrarianLoginForm : Form
    {
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        public LibrarianLoginForm()
        {
            InitializeComponent();
        }

        private void SubmitLogin_Click(object sender, EventArgs e)
        {
            ILibrarianHandle librarianHandle = new LibrarianHandle(connectionString);
            int employeeNumber = Convert.ToInt32(EmployeeNumberTxt.Text);
            string password = PasswordTxt.Text;
            /*using (SHA256 sha256Hash = SHA256.Create())
            {
                string passwordHash = HashPasswords.GetHash(sha256Hash, password);
                Librarian librarian = librarianHandle.GetLibrarian(employeeNumber, passwordHash);

                if(librarian != null)
                {
                    MessageBox.Show("Zalogowano pomyślnie");
                    this.Hide();
                    LibrarianMenu librarianMenu = new LibrarianMenu(librarian.Id);
                    librarianMenu.Show();
                } 
                else
                {
                    MessageBox.Show("Bład logowania. Sprawdź dane logowania");
                }
            }*/
            using (SHA256 sha256Hash = SHA256.Create())
            {
                Librarian librarian = librarianHandle.GetLibrarian(employeeNumber, password);

                if(librarian != null)
                {
                    MessageBox.Show("Logged in successfully");
                    this.Hide();
                    LibrarianMenu librarianMenu = new LibrarianMenu(librarian.LibrarianId);
                    librarianMenu.Show();
                } 
                else
                {
                    MessageBox.Show("Login error. Please check your login credentials.");
                }
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
