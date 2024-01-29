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
        private readonly DatabaseHelper dbHelper;

        public HandlePassword(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }

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

        public bool IsCurrentPasswordValid(string query, int currentId, string currentPasswordHash)
        {
            try
            {
                //string query = "SELECT Password FROM Readers WHERE ID = @Id";
                SqlParameter[] parameters = { new SqlParameter("@Id", currentId) }; //Pamiętać, przy tworzeniu zapytania o użyciu "@Id"
            object result = dbHelper.ExecuteScalar(query, parameters);
                if (result != null) {
                    string storedPasswordHash = result as string;
                    return storedPasswordHash == currentPasswordHash;
                }
                else
                {
                    MessageBox.Show("User not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking the current password: {ex.Message}");
                return false;
            }
        }

        public void UpdatePasswordInDatabase(string updateQuery, int currentId, string newPasswordHash)
        {
            try
            {
                //string updateQuery = "UPDATE Readers SET Password = @NewPassword WHERE Id = @ID";
                SqlParameter[] parameters = {
                new SqlParameter("@NewPassword", newPasswordHash), //Pamiętać przy tworzeiu zaoytania o użyciu "@NewPassword"
                new SqlParameter("@Id", currentId)
            }; //Pamiętać przy tworzeiu zaoytania o użyciu "@Id"

            dbHelper.ExecuteNonQuery(updateQuery, parameters);
                MessageBox.Show("Password updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the password: {ex.Message}");
            }
        }
    }
}
