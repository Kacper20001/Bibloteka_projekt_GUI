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
        string connectionString = "Data Source=DESKTOP-3QM33ET\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False";
        private void logSubmit_Click(object sender, EventArgs e)
        {
            string username = logLogin.Text; 
            string password = logPassword.Text;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string passwordHash = HashPasswords.GetHash(sha256Hash, password);
                //Reader reader = Reader.GetReader(username, passwordHash);
                Reader reader = Reader.GetReader(username, password, connectionString);

                if (reader != null)
                {
                    MessageBox.Show("Logged in successfully.");
                    this.Hide();
                    ReaderMenu readerMenu = new ReaderMenu(reader.ReaderId);
                    readerMenu.Show();
                }
                else
                {
                    MessageBox.Show("Login error. Please check your login credentials.");
                }
            }
        }


        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
