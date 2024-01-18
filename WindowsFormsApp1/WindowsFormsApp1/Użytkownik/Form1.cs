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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;InitialCatalog=LibraryDB;Integrated Security = True";

        private void regSubmit_Click(object sender, EventArgs e)
        {
            string username = regUsername.Text;
            string password = regPassword.Text;
            string confirmPassword = regConfPassword.Text;
            string firstName = regFirstName.Text;
            string lastName = regLastName.Text;
            DateTime dateOfBirth = regDateOfBirth.Value;
            string email = regEmail.Text;
            string phoneNumber = regPhoneNumber.Text;
            string street = regStreet.Text;
            string city = regCity.Text;
            string houseNumber = regHouseNumber.Text;
            string postalCode = regPostalCode.Text;
            string country = regCountry.Text;
            int age = DateTime.Now.Year - dateOfBirth.Year;


            StringBuilder sb = new StringBuilder();
            if (dateOfBirth.Date > DateTime.Now.Date.AddYears(-age)) age--;

            if (string.IsNullOrWhiteSpace(username))
                sb.AppendLine("Nazwa użytkownika jest wymagana.");

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                sb.AppendLine("Hasło jest wymagane i musi mieć co najmniej 6 znaków.");

            if (password != confirmPassword)
                sb.AppendLine("Hasła nie są zgodne.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                sb.AppendLine("Adres email jest niepoprawny.");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    string passwordHash = HashPasswords.GetHash(sha256Hash, password);
                    
                    Address address = new Address(street, houseNumber, postalCode, city, country);
                    Reader reader = new Reader(firstName, lastName, dateOfBirth, phoneNumber, email, address, passwordHash, username);
                    SaveReaderInDatabese(reader); 
                }
            }
        }
        private void SaveReaderInDatabese(Reader reader)
        {
            string insertDataQuery = "INSERT INTO Readers (Id, Username, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) " + $"VALUES ('{reader.Id}' ,'{reader.Username}', '{reader.Password}', '{reader.FirstName}', '{reader.LastName}', '{reader.DateOfBirth}', '{reader.Email}', '{reader.PhoneNumber}', '{reader.Address.Street}', '{reader.Address.City}', '{reader.Address.HouseNumber}', '{reader.Address.PostalCode}', '{reader.Address.Country}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
                {
                    try
                    {
                        insertDataCommand.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zarejestrowano");
                        regClear_Click(this, EventArgs.Empty);
                        this.Hide();
                        Logowanie logowanie = new Logowanie();
                        logowanie.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd przy dodawaniu danych: {ex.Message}");
                    }
                }

            }
        }

        private void regClear_Click(object sender, EventArgs e)
        {
            regUsername.Text = "";
            regPassword.Text = "";
            regConfPassword.Text = "";
            regFirstName.Text = "";
            regLastName.Text = "";
            regDateOfBirth.Value = DateTime.Now;
            regEmail.Text = "";
            regPhoneNumber.Text = "";
            regStreet.Text = "";
            regCity.Text = "";
            regHouseNumber.Text = "";
            regPostalCode.Text = "";
            regCountry.Text = "";
        }

       

        private void AlreadyHaveAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
