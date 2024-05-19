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
    public partial class RegistrationForm : Form
    {
        private Form1 mainform;
        public RegistrationForm(Form1 form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
 
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLoginClient.Text;
            string password = txtPasswordClient.Text;
            string name = txtNameClient.Text;
            string surname = txtSurnameClient.Text;
            string email = txtEmailClient.Text;
            string phoneNumber = txtPhoneClient.Text;

            if (login != "" && password != "" && name != "" && name != "" && surname != "" && email != "" && phoneNumber != "")
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();

                    string query = "INSERT INTO client (login, password, name, surname, email, phone_number) VALUES (@login, @password, @name, @surname, @email, @phoneNumber)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успішна реєстрація!", "Зареєстровано", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtLoginClient.Clear();
                    txtPasswordClient.Clear();
                    txtNameClient.Clear();
                    txtSurnameClient.Clear();
                    txtEmailClient.Clear(); 
                    txtPhoneClient.Clear(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалось зареєструватись. Помилка: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
