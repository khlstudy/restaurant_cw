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
                    object result = cmd.ExecuteScalar();

                    if (result != null) 
                    {
                        int userId = Convert.ToInt32(result); 
                        MessageBox.Show("Успішний вхід!", "Ви увійшли в акаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtLogin.Clear();
                        txtPassword.Clear();

                        CleintForm clientForm = new CleintForm(userId);
                        clientForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Користувача з таким логіном та паролем не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалось увійти. Помилка: " + ex.Message,"Помилка" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAuthenticationAdmin_Click(object sender, EventArgs e)
        {
            string loginA = txtLoginAdmin.Text;
            string passwordA = txtPasswordAdmin.Text;
            string position = сBoxEmployeeType.SelectedItem?.ToString();

            if (loginA != "" && passwordA != "" && position != "")
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();

                    string query = "SELECT employee_id FROM employee JOIN employee_type ON fk_employee_type_id = employee_type_id WHERE login = @login AND password = @password AND type = @position;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", loginA);
                    cmd.Parameters.AddWithValue("@password", passwordA);
                    cmd.Parameters.AddWithValue("@position", position);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        MessageBox.Show("Успішний вхід!", "Ви увійшли в акаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtLogin.Clear();
                        txtPassword.Clear();

                        if (position == "Менеджер")
                        {
                            ManagerForm managerForm = new ManagerForm(userId, mainform);
                            managerForm.Show();
                        }
                        else if (position == "Офіціант")
                        {
                            WaiterForm waiterForm = new WaiterForm(userId);
                            waiterForm.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Працівника з таким логіном, паролем та посадою не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалось увійти. Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {

        }
    }
}



