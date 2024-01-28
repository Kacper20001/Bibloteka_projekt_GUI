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
using System.Data.SqlClient;
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class LibrarianInfoView : Form
    {
        private int currentLibrarianId;
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";

        public LibrarianInfoView(int librarianId)
        {
            InitializeComponent();
            currentLibrarianId = librarianId;
            LoadLibrarianData();
        }

        private void LibrarianInfoView_Load(object sender, EventArgs e)
        {

        }
        private void LoadLibrarianData()
        {
            ILibrarianHandle librarianHandle = new LibrarianHandle();
            var librarian = librarianHandle.GetLibrarianById(currentLibrarianId, connectionString);
            if (librarian != null)
            {
                EmployeeLoginTxt.Text = librarian.EmployeeNumber.ToString();
                FirstNameTxt.Text = librarian.FirstName;
                LastNameTxt.Text = librarian.LastName;
                DateOfBirthTxt.Text = librarian.DateOfBirth.ToString("dd-MM-yyyy");
                EmailTxt.Text = librarian.Email;
                PhoneNumberTxt.Text = librarian.PhoneNumber;
                StreetTxt.Text = librarian.Address.Street;
                CityTxt.Text = librarian.Address.City;
                HouseNumberTxt.Text = librarian.Address.HouseNumber;
                PostalCodeTxt.Text = librarian.Address.PostalCode;
                CountryTxt.Text = librarian.Address.Country;
            }
            else
            {
                MessageBox.Show("Librarian not found.");
            }
        }

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarian = new LibrarianMenu(currentLibrarianId);
            librarian.Show();
        }

       /* private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateNewPassword())
            {
                return;
            }
            string currentPasswordHash;
            string newPasswordHash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                currentPasswordHash = HashPasswords.GetHash(sha256Hash, PasswordTxt.Text);
                newPasswordHash = HashPasswords.GetHash(sha256Hash, NewPasswordTxt.Text);
            }
            if (!IsCurrentPasswordValid(currentPasswordHash))
            {
                MessageBox.Show("The current password is incorrect.");
                return;
            }

            UpdatePasswordInDatabase(newPasswordHash);
            MessageBox.Show("Password has been changed.");
        }*/ // ta  jest z szyfrowankiem zrobic tak jak na dole z obsluzeniem 
        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (!HandlePassword.ValidateNewPassword(NewPasswordTxt.Text, ConfirmNewPasswordTxt.Text))
            {
                return;
            }
            string query = "SELECT Password FROM Librarians WHERE EmployeeID = @Id";
            if (!HandlePassword.IsCurrentPasswordValid(query, currentLibrarianId, PasswordTxt.Text, connectionString))
            {
                MessageBox.Show("The current password is incorrect.");
                return;
            }
            string updateQuery = "UPDATE Librarians SET Password = @NewPassword WHERE EmployeeId = @Id";

            HandlePassword.UpdatePasswordInDatabase(updateQuery, currentLibrarianId, NewPasswordTxt.Text, connectionString);
            MessageBox.Show("Password has been changed.");
            PasswordTxt.Text = "";
            NewPasswordTxt.Text = "";
            ConfirmNewPasswordTxt.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ILibrarianHandle librarianHandle = new LibrarianHandle();
            librarianHandle.EditLibrarian(connectionString, currentLibrarianId, LastNameTxt.Text, PhoneNumberTxt.Text, StreetTxt.Text, HouseNumberTxt.Text, PostalCodeTxt.Text, CityTxt.Text, CountryTxt.Text);
            MessageBox.Show("Update successful");
            LoadLibrarianData();
        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {
            ILibrarianHandle librarianHandle = new LibrarianHandle();
            librarianHandle.DeleteLibrarian(currentLibrarianId, connectionString);
            currentLibrarianId = 0;
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();

        }
    }
}
