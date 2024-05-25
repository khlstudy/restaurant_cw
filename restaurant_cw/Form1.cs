using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurant_cw
{
    public partial class Form1 : Form
    {
        private RegistrationForm regform;
        private AuthenticationForm authform;
        private MenuForm menuform;
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public Form1()
        {
            InitializeComponent();
            regform = new RegistrationForm(this);
            menuform = new MenuForm(this, userId); 
            authform = new AuthenticationForm(this, menuform); 


        }

        //RegistrationForm regform = new RegistrationForm();
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Getting Connection...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                //MessageBox.Show("Openning Connection...");
                conn.Open();
                //MessageBox.Show("Connection successful!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrationForm_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            regform.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAuthorizationForm_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            authform.Show();
        }

        private void btnMenuForm_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menuform.Show();
        }

        public void UpdateMenu()
        {
            if (menuform != null)
            {
                menuform.RefreshMenu();
            }
        }

    }
}
