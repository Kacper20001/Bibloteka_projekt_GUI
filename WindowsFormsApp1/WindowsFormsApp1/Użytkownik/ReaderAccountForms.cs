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

namespace WindowsFormsApp1
{
    public partial class ReaderAccountForms : Form
    {
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security = True";
        private int currentReaderId;
        public ReaderAccountForms(int readerId)
        {
            InitializeComponent();
            currentReaderId = readerId;
            Reader.GetReaderById(currentReaderId, connectionString);
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
            if (!ValidateNewPassword())
            {
                return;
            }
            string currentPasswordHash;
            string newPasswordHash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                currentPasswordHash = HashPasswords.GetHash(sha256Hash, UserInfoPassword.Text);
                newPasswordHash = HashPasswords.GetHash(sha256Hash, UserInfoNewPassword.Text);
            }
            if (!IsCurrentPasswordValid(currentPasswordHash))
            {
                MessageBox.Show("Obecne hasło jest niepoprawne.");
                return;
            }

            UpdatePasswordInDatabase(newPasswordHash);
            MessageBox.Show("Hasło zostało zmienione.");
        }
        private bool ValidateNewPassword()
        {
            if (UserInfoNewPassword.Text != UserInfoConfirmNewPassord.Text)
            {
                MessageBox.Show("passwords are not the same");
                return false;
            }
            if (UserInfoNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Password is too short.");
                return false;
            }
            return true;
        }
        private bool IsCurrentPasswordValid(string currentPasswordHash)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Readers WHERE ID = @ReaderId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReaderId", currentReaderId);
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
                string updateQuery = "UPDATE Readers SET Password = @NewPassword WHERE Id = @ReaderID";
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPasswordHash);
                        command.Parameters.AddWithValue("@ReaderId", currentReaderId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
