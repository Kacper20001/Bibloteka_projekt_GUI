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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using WindowsFormsApp1.Interfejsy;
using WindowsFormsApp1.Klasy;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";

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
            /*if (dateOfBirth.Date > DateTime.Now.Date.AddYears(-age)) age--;
            if (age < 12)
            {
                sb.AppendLine("The minimum age is 12 years old.");
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(houseNumber) || string.IsNullOrWhiteSpace(postalCode) || string.IsNullOrWhiteSpace(country))
            {
                sb.AppendLine("All fields are required.");
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                sb.AppendLine("A password is required and must have at least 6 characters.");

            if (password != confirmPassword)
                sb.AppendLine("The passwords are not similar");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                sb.AppendLine("The email address is invalid.");*/

            //zakomentowane w celu przyspieszenia testowania

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(),"Validation errors.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    /*using (SHA256 sha256Hash = SHA256.Create())
                    {
                        string passwordHash = HashPasswords.GetHash(sha256Hash, password);*/
                    IReaderHandle readerHandle = new ReaderHandle(connectionString);
                    Address address = new Address(street, houseNumber, postalCode, city, country);
                    //Reader reader = new Reader(firstName, lastName, dateOfBirth, phoneNumber, email, address, passwordHash, username);
                    Reader reader = new Reader(firstName, lastName, dateOfBirth, phoneNumber, email, address, password, username);
                    readerHandle.SaveReaderInDatabase(reader);
                    regClear_Click(this, EventArgs.Empty);
                    this.Hide();
                    Logowanie logowanie = new Logowanie();
                    logowanie.Show();
                    /* }*/
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Aplication Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /*private void SaveReaderInDatabese(Reader reader)
        {
            string insertDataQuery = "INSERT INTO dbo.Readers (Username, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) VALUES (@Username, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Street, @City, @HouseNumber, @PostalCode, @Country)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@Username", reader.Username);
                    insertDataCommand.Parameters.AddWithValue("@Password", reader.Password);
                    insertDataCommand.Parameters.AddWithValue("@FirstName", reader.FirstName);
                    insertDataCommand.Parameters.AddWithValue("@LastName", reader.LastName);
                    insertDataCommand.Parameters.AddWithValue("@DateOfBirth", reader.DateOfBirth.ToString("yyyy-MM-dd"));
                    insertDataCommand.Parameters.AddWithValue("@Email", reader.Email);
                    insertDataCommand.Parameters.AddWithValue("@PhoneNumber", reader.PhoneNumber);

                    insertDataCommand.Parameters.AddWithValue("@Street", reader.Address.Street);
                    insertDataCommand.Parameters.AddWithValue("@City", reader.Address.City);
                    insertDataCommand.Parameters.AddWithValue("@HouseNumber", reader.Address.HouseNumber);
                    insertDataCommand.Parameters.AddWithValue("@PostalCode", reader.Address.PostalCode);
                    insertDataCommand.Parameters.AddWithValue("@Country", reader.Address.Country);
                    try
                    {
                        insertDataCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully registered.");
                        regClear_Click(this, EventArgs.Empty);
                        this.Hide();
                        Logowanie logowanie = new Logowanie();
                        logowanie.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while adding data {ex.Message}");
                    }
                }

            }
        }*/

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
