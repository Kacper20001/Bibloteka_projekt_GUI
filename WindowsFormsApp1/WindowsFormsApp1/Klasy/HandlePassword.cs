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
              
        public static bool ValidateNewPassword(string newPassword, string confirmNewPassword)
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

        public static bool IsCurrentPasswordValid(string query, int currentId, string currentPasswordHash, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //string query = "SELECT Password FROM Readers WHERE ID = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", currentId);   //Pamiętać, przy tworzeniu zapytania o użyciu "@Id"
                    connection.Open();
                    string storedPasswordHash = command.ExecuteScalar() as string;
                    return storedPasswordHash == currentPasswordHash;
                }
            }
        }

        public static void UpdatePasswordInDatabase(string updateQuery, int currentId, string newPasswordHash, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //string updateQuery = "UPDATE Readers SET Password = @NewPassword WHERE Id = @ID";
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPasswordHash); //Pamiętać przy tworzeiu zaoytania o użyciu "@NewPassword"
                        command.Parameters.AddWithValue("@Id", currentId); //Pamiętać przy tworzeiu zaoytania o użyciu "@Id"
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
