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
    public partial class isterLibrarianForm : Form
    {
        private int currentLibrarianId;
        public isterLibrarianForm(int librarianId)
        {
            currentLibrarianId = librarianId;
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int employeeNumber = Convert.ToInt32(LoginTxt.Text);
            string password = PasswordTxt.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            DateTime dateOfBirth = DateOdBirthTxt.Value;
            string email = EmailTxt.Text;
            string phoneNumber = PhoneNumberTxt.Text;
            string street = StreetTxt.Text;
            string city = CityTxt.Text;
            string houseNumber = HouseNumberTxt.Text;
            string postalCode = PostalCodeTxt.Text;
            string country = CountryTxt.Text;


            StringBuilder sb = new StringBuilder();

            /*if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                sb.AppendLine("Hasło jest wymagane i musi mieć co najmniej 6 znaków.");

            if (password != confirmPassword)
                sb.AppendLine("Hasła nie są zgodne.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                sb.AppendLine("Adres email jest niepoprawny.");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            /*else
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    string passwordHash = HashPasswords.GetHash(sha256Hash, password);*/

                  /*  Address address = new Address(street, houseNumber, postalCode, city, country);
                    Librarian librarian = new Librarian(password, firstName, lastName, dateOfBirth, phoneNumber, email, address, employeeNumber);*/
                    Address address = new Address(street, houseNumber, postalCode, city, country);
                    Librarian librarian = new Librarian(password, firstName, lastName, dateOfBirth, phoneNumber, email, address, employeeNumber);
                    SaveLibrarianInDatabase(librarian);
              /*  }
            }*/
        }
        private void SaveLibrarianInDatabase(Librarian librarian)
        {
            string insertDataQuery = "INSERT INTO Librarians (EmployeeNumber, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, Street, City, HouseNumber, PostalCode, Country) VALUES (@EmployeeNumber, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Street, @City, @HouseNumber, @PostalCode, @Country)";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@EmployeeNumber", librarian.EmployeeNumber);
                    insertDataCommand.Parameters.AddWithValue("@Password", librarian.Password);
                    insertDataCommand.Parameters.AddWithValue("@FirstName", librarian.FirstName);
                    insertDataCommand.Parameters.AddWithValue("@LastName", librarian.LastName);
                    insertDataCommand.Parameters.AddWithValue("@DateOfBirth", librarian.DateOfBirth);
                    insertDataCommand.Parameters.AddWithValue("@Email", librarian.Email);
                    insertDataCommand.Parameters.AddWithValue("@PhoneNumber", librarian.PhoneNumber);
                    insertDataCommand.Parameters.AddWithValue("@Street", librarian.Address.Street);
                    insertDataCommand.Parameters.AddWithValue("@City", librarian.Address.City);
                    insertDataCommand.Parameters.AddWithValue("@HouseNumber", librarian.Address.HouseNumber);
                    insertDataCommand.Parameters.AddWithValue("@PostalCode", librarian.Address.PostalCode);
                    insertDataCommand.Parameters.AddWithValue("@Country", librarian.Address.Country);

                    try
                    {
                        insertDataCommand.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zarejestrowano");
                        ClearBtn_Click(this, EventArgs.Empty);
                        this.Hide();
                        StartForm startForm = new StartForm();
                        startForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd przy dodawaniu danych: {ex.Message}");
                    }
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LoginTxt.Text = "";
            PasswordTxt.Text = "";
            ConfirmPasswordTxt.Text = "";
            FirstNameTxt.Text = "";
            LastNameTxt.Text = "";
            DateOdBirthTxt.Value = DateTime.Now;
            EmailTxt.Text = "";
            PhoneNumberTxt.Text = "";
            StreetTxt.Text = "";
            CityTxt.Text = "";
            HouseNumberTxt.Text = "";
            PostalCodeTxt.Text = "";
            CountryTxt.Text = "";
        }

        private void BackToStartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianMenu librarianMenu = new LibrarianMenu(currentLibrarianId);
            librarianMenu.Show();
        }
    }
}
