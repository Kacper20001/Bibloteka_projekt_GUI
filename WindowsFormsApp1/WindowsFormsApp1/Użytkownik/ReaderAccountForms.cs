using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using WindowsFormsApp1.Klasy;
using WindowsFormsApp1.Interfejsy;

namespace WindowsFormsApp1
{
    public partial class ReaderAccountForms : Form
    {
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        private int currentReaderId;
        private HandlePassword handlePassword;

        public ReaderAccountForms(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            LoadReaderData();
            handlePassword = new HandlePassword(connectionString); 

        }


        private void ReaderAccountForms_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderMenu readerMenu = new ReaderMenu(currentReaderId);
            readerMenu.Show();
        }
        private void UserInfoChangePassword_Click(object sender, EventArgs e)
        {
            string currentPasswordHash;
            string newPasswordHash;
            string ConfirmNewPasswordHash;
            currentPasswordHash = UserInfoPassword.Text;
            newPasswordHash = UserInfoNewPassword.Text;
            ConfirmNewPasswordHash = UserInfoConfirmNewPassord.Text;
            if (!HandlePassword.ValidateNewPassword(newPasswordHash, ConfirmNewPasswordHash))
            {
                return;
            }

            /*{using (SHA256 sha256Hash = SHA256.Create())
            
                currentPasswordHash = HashPasswords.GetHash(sha256Hash, UserInfoPassword.Text);
                newPasswordHash = HashPasswords.GetHash(sha256Hash, UserInfoNewPassword.Text);
            }*/   //hashowane


            string query = "SELECT Password FROM Readers WHERE ReaderId = @Id";
            if (!handlePassword.IsCurrentPasswordValid(query, currentReaderId, currentPasswordHash))
            {
                MessageBox.Show("Obecne hasło jest niepoprawne.");
                return;
            }
            string updateQuery = "UPDATE Readers SET Password = @NewPassword WHERE ReaderId = @Id";
            handlePassword.UpdatePasswordInDatabase(updateQuery, currentReaderId, newPasswordHash);
            MessageBox.Show("Hasło zostało zmienione.");
            UserInfoPassword.Text = "";
            UserInfoNewPassword.Text = "";
            UserInfoConfirmNewPassord.Text = "";
        }

        private void LoadReaderData()
        {
            IReaderHandle readerHandle = new ReaderHandle();
            var reader = readerHandle.GetReaderById(currentReaderId, connectionString);
            if (reader != null)
            {
                UserInfoFirstName.Text = reader.FirstName;
                UserInfoLastName.Text = reader.LastName;
                UserInfoUsername.Text = reader.Username;
                UserInfoDateofBirth.Text = reader.DateOfBirth.ToString("dd-MM-yyyy");
                UserInfoEmail.Text = reader.Email;
                UserInfoPhoneNumber.Text = reader.PhoneNumber;
                UserInfoStreet.Text = reader.Address.Street;
                UserInfoCity.Text = reader.Address.City;
                UserInfoHouseNumber.Text = reader.Address.HouseNumber;
                UserInfoPostalCode.Text = reader.Address.PostalCode;
                UserInfoCountry.Text = reader.Address.Country;
            }
            else
            {
                MessageBox.Show("Nie znaleziono czytelnika.");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            IReaderHandle readerHandle = new ReaderHandle();
            readerHandle.EditReader(connectionString, currentReaderId, UserInfoLastName.Text, UserInfoPhoneNumber.Text, UserInfoStreet.Text, UserInfoHouseNumber.Text, UserInfoPostalCode.Text, UserInfoCity.Text, UserInfoCountry.Text);
            MessageBox.Show("Update successful");
            LoadReaderData();
        }
    }
}
