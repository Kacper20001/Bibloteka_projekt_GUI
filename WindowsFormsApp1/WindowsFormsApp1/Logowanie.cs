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

namespace WindowsFormsApp1
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void logSubmit_Click(object sender, EventArgs e)
        {
            string username = logLogin.Text;
            string password = logPassword.Text;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string passwordHash = GetHash(sha256Hash, password);
                Reader reader = GetReader(username, passwordHash);

                if (reader != null)
                {
                    MessageBox.Show("Zalogowano pomyślnie.");
                    /*ReaderMenu readerMenu = new ReaderMenu(reader);
                    readerMenu.Show();
                    this.Hide();*/
                }
                else
                {
                    MessageBox.Show("Błąd logowania. Sprawdź dane logowania.");
                }
            }
        }

        internal Reader GetReader(string username, string passwordHash)
        {
            Reader foundReader = null;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security=True"))
            {
                string query = "SELECT * FROM Readers WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", passwordHash);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundReader = new Reader(
                                reader["FirstName"].ToString(), reader["LastName"].ToString(),
                                Convert.ToDateTime(reader["DateOfBirth"]), reader["PhoneNumber"].ToString(),
                                reader["Email"].ToString(),
                                new Address(reader["Street"].ToString(), reader["HouseNumber"].ToString(),
                                reader["PostalCode"].ToString(), reader["City"].ToString(),
                                reader["Country"].ToString()),
                                reader["Password"].ToString(), reader["Username"].ToString());
                        }
                    }
                }
            }
            return foundReader;
        }

        static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            foreach (byte b in data)
            {
                sBuilder.Append(b.ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
