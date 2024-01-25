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

namespace WindowsFormsApp1.Bibliotekarz
{
    public partial class LibrarianInfoView : Form
    {
        private int currentLibrarianId;
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security = True";

        public LibrarianInfoView(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
            LoadLibrarianData();
        }

        private void LibrarianInfoView_Load(object sender, EventArgs e)
        {

        }
        private void LoadLibrarianData()
        {
            var librarian = Librarian.GetLibrarianById(currentLibrarianId, connectionString);
            if (librarian != null)
            {
                EmployeeLoginTxt.Text = librarian.EmployeeLogin.ToString();
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
                MessageBox.Show("Reader not found.");
            }
        }

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarian = new LibrarianMenu(currentLibrarianId);
            librarian.Show();
        }
        private void UserInfoChangePassword_Click(object sender, EventArgs e)
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
        }
        private bool ValidateNewPassword()
        {
            if (NewPasswordTxt.Text != ConfirmNewPasswordTxt.Text)
            {
                MessageBox.Show("passwords are not the same");
                return false;
            }
            if (NewPasswordTxt.Text.Length < 6)
            {
                MessageBox.Show("Password is too short.");
                return false;
            }
            return true;
        }
        private bool IsCurrentPasswordValid(string currentPasswordHash)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Librarians WHERE ID = @LibrarianId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LibrarianId", currentLibrarianId);
                    connection.Open();
                    string storedPasswordHash = command.ExecuteScalar() as string;
                    return storedPasswordHash == currentPasswordHash;
                }
            }
        }
        private void UpdatePasswordInDatabase(string newPasswordHash)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Librarians SET Password = @NewPassword WHERE Id = @LibrarianID";
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPasswordHash);
                        command.Parameters.AddWithValue("@LibrarianId", currentLibrarianId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
