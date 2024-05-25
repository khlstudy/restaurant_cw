using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

            if (ValidateFields(login, password, name, surname, email, phoneNumber))
            {
                string hashedPassword = HashPassword(password);

                MySqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();

                    string query = "INSERT INTO client (login, password, name, surname, email, phone_number) VALUES (@login, @password, @name, @surname, @email, @phoneNumber)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
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
                    MessageBox.Show("Не вдалось зареєструватись. Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool ValidateFields(string login, string password, string name, string surname, string email, string phoneNumber)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (login.Length > 45)
            {
                MessageBox.Show("Логін не може бути довшим за 45 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password.Length > 45)
            {
                MessageBox.Show("Пароль не може бути довшим за 45 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (name.Length < 2 || name.Length > 30)
            {
                MessageBox.Show("Ім'я повинно містити від 2 до 30 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (surname.Length < 2 || surname.Length > 45)
            {
                MessageBox.Show("Прізвище повинно містити від 2 до 45 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(phoneNumber, @"^0\d{9}$"))
            {
                MessageBox.Show("Номер телефону повинен починатися з нуля і містити 10 цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Некоректна електронна пошта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
