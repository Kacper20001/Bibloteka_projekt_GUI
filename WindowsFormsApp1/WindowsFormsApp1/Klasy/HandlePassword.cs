using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Klasy
{
    internal class HandlePassword
    {
        private string connectionString;
        private int currentId;

        public HandlePassword( string connectionString, int currentId )
        {
            this.connectionString = connectionString;
            this.currentId = currentId;
        }
        public bool ValidateNewPassword(string newPassword, string confirmNewPassword)
        {
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Passwords are not the same");
                return false;
            }
            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password is too short.");
                return false;
            }
            return true;
        }

        public bool IsCurrentPasswordValid(string currentPasswordHash)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Readers WHERE ID = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RId", currentId);
                    connection.Open();
                    string storedPasswordHash = command.ExecuteScalar() as string;
                    return storedPasswordHash == currentPasswordHash;
                }
            }
        }

        public void UpdatePasswordInDatabase(string newPasswordHash)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Readers SET Password = @NewPassword WHERE Id = @ID";
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPasswordHash);
                        command.Parameters.AddWithValue("@Id", currentId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
