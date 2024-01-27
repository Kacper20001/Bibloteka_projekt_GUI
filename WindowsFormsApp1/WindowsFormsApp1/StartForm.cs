using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void LibrarianBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianLoginForm loginform = new LibrarianLoginForm();
            loginform.Show();
        }
    }
}
