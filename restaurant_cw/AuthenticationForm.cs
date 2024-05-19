using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace restaurant_cw
{
    public partial class AuthenticationForm : Form
    {
        private Form1 mainform;
        public AuthenticationForm(Form1 form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            if (login != "" && password != "")
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();

                    string query = "SELECT client_id FROM client WHERE login = @login AND password = @password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("Успішний вхід!", "Ви увійшли в акаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtLogin.Clear();
                    txtPassword.Clear();
                    int userId = reader.GetInt32("client_id");

                    if (userId.Equals("client_id"))
                    {
                        UserForm userForm = new UserForm(userId); //ось тут помилка
                        userForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалось увійти. Помилка: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


