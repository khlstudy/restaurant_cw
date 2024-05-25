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
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace restaurant_cw
{
    public partial class ManagerForm : Form
    {
        private Form1 mainform;

        public ManagerForm(int userId, Form1 form)
        {
            InitializeComponent();
            mainform = form;
            MySqlConnection conn = DBUtils.GetDBConnection();
            LoadStatisticTypes();
            ShowCustomerStatistics();
            ShowTotalRevenueStatistics();
            ShowPopularItemsStatistics();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            LoadDataGridViewEmployee();
            LoadDataGridViewClients();
            ShowProducts();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog.FileName;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            string priceText = txtPrice.Text;
            string categoryName = cmbCategory.SelectedItem?.ToString();
            string imagePath = txtImagePath.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Будь ласка заповніть всі поля та виберіть зображення");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Будь ласка введіть коректну ціну");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    string categoryQuery = "SELECT category_id FROM category WHERE name = @categoryName";
                    MySqlCommand categoryCmd = new MySqlCommand(categoryQuery, conn);
                    categoryCmd.Parameters.AddWithValue("@categoryName", categoryName);
                    object result = categoryCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Invalid category selected.");
                        return;
                    }

                    int categoryId = Convert.ToInt32(result);

                    string newImagePath = Path.Combine("F:\\projects\\2course\\restaurant_cw\\restaurant_cw\\Resources", Path.GetFileName(imagePath));

                    File.Copy(imagePath, newImagePath, true);

                    string query = "INSERT INTO product (name, description, price, fk_category_id, image_path) VALUES (@name, @description, @price, @categoryId, @image_path)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@image_path", newImagePath);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Продукт був успішно доданий!");

                    txtName.Clear();
                    txtDescription.Clear();
                    txtPrice.Clear();
                    cmbCategory.SelectedIndex = -1;
                    txtImagePath.Clear();

                    mainform.UpdateMenu();
                    ShowProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось додати продукт. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private int GetCategoryIdByName(string categoryName)
        {
            int categoryId = -1;

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT category_id FROM category WHERE name = @categoryName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoryName", categoryName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    categoryId = Convert.ToInt32(result);
                }
            }

            return categoryId;
        }

        private string GetCategoryNameById(int categoryId)
        {
            string categoryName = null;

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT name FROM category WHERE category_id = @categoryId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    categoryName = result.ToString();
                }
            }

            return categoryName;
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }
        private void ResetAutoIncrement(string tableName, string primaryKeyColumn)
        {
            string queryMaxId = $"SELECT IFNULL(MAX({primaryKeyColumn}), 0) FROM {tableName}";
            int maxId = 0;

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    MySqlCommand cmdMaxId = new MySqlCommand(queryMaxId, conn);
                    object result = cmdMaxId.ExecuteScalar();
                    if (result != null)
                    {
                        maxId = Convert.ToInt32(result);
                    }

                    string queryResetAutoIncrement = $"ALTER TABLE {tableName} AUTO_INCREMENT = {maxId + 1}";
                    MySqlCommand cmdResetAutoIncrement = new MySqlCommand(queryResetAutoIncrement, conn);
                    cmdResetAutoIncrement.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось оновити AUTO_INCREMENT. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProduct_Click_1(object sender, EventArgs e)
        {
            string editName = txtNameEditDelete.Text;

            if (string.IsNullOrEmpty(editName))
            {
                MessageBox.Show("Будь ласка, введіть назву продукту для редагування.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM product WHERE name = @editName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@editName", editName);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Продукт з такою назвою не знайдено.");
                        return;
                    }

                    string currentName = reader["name"].ToString();
                    string currentDescription = reader["description"].ToString();
                    decimal currentPrice = Convert.ToDecimal(reader["price"]);
                    int currentCategoryId = Convert.ToInt32(reader["fk_category_id"]);
                    string currentImagePath = reader["image_path"].ToString();

                    reader.Close();

                    bool isAnyFieldUpdated = !string.IsNullOrEmpty(txtName.Text) ||
                                             !string.IsNullOrEmpty(txtDescription.Text) ||
                                             !string.IsNullOrEmpty(txtPrice.Text) ||
                                             cmbCategory.SelectedItem != null ||
                                             !string.IsNullOrEmpty(txtImagePath.Text);

                    if (!isAnyFieldUpdated)
                    {
                        MessageBox.Show("Будь ласка, введіть нову інформацію у поля зліва для редагування продукту.");
                        return;
                    }

                    string newName = string.IsNullOrEmpty(txtName.Text) ? currentName : txtName.Text;
                    string newDescription = string.IsNullOrEmpty(txtDescription.Text) ? currentDescription : txtDescription.Text;
                    decimal newPrice = string.IsNullOrEmpty(txtPrice.Text) ? currentPrice : Convert.ToDecimal(txtPrice.Text);
                    int newCategoryId = cmbCategory.SelectedItem == null ? currentCategoryId : GetCategoryIdByName(cmbCategory.SelectedItem.ToString());
                    string newImagePath = string.IsNullOrEmpty(txtImagePath.Text) ? currentImagePath : txtImagePath.Text;

                    if (!string.IsNullOrEmpty(txtImagePath.Text) && !txtImagePath.Text.Equals(currentImagePath))
                    {
                        string updatedImagePath = Path.Combine("F:\\projects\\2course\\restaurant_cw\\restaurant_cw\\Resources", Path.GetFileName(newImagePath));
                        File.Copy(newImagePath, updatedImagePath, true);
                        newImagePath = updatedImagePath;
                    }

                    string updateQuery = @"
                UPDATE product SET 
                    name = @newName,
                    description = @newDescription,
                    price = @newPrice,
                    fk_category_id = @newCategoryId,
                    image_path = @newImagePath
                WHERE name = @editName";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newName", newName);
                    updateCmd.Parameters.AddWithValue("@newDescription", newDescription);
                    updateCmd.Parameters.AddWithValue("@newPrice", newPrice);
                    updateCmd.Parameters.AddWithValue("@newCategoryId", newCategoryId);
                    updateCmd.Parameters.AddWithValue("@newImagePath", newImagePath);
                    updateCmd.Parameters.AddWithValue("@editName", editName);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Продукт був успішно відредагований!");

                    txtName.Clear();
                    txtDescription.Clear();
                    txtPrice.Clear();
                    cmbCategory.SelectedIndex = -1;
                    txtImagePath.Clear();

                    mainform.UpdateMenu();
                    ShowProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось відредагувати продукт. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            string deleteName = txtNameEditDelete.Text;

            if (string.IsNullOrEmpty(deleteName))
            {
                MessageBox.Show("Будь ласка, введіть назву продукту для видалення.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string deleteOrderItemsQuery = @"
                DELETE FROM order_item 
                WHERE fk_product_id = (SELECT product_id FROM product WHERE name = @deleteName)";
                    MySqlCommand deleteOrderItemsCmd = new MySqlCommand(deleteOrderItemsQuery, conn);
                    deleteOrderItemsCmd.Parameters.AddWithValue("@deleteName", deleteName);
                    deleteOrderItemsCmd.ExecuteNonQuery();

                    string deleteProductQuery = "DELETE FROM product WHERE name = @deleteName";
                    MySqlCommand deleteProductCmd = new MySqlCommand(deleteProductQuery, conn);
                    deleteProductCmd.Parameters.AddWithValue("@deleteName", deleteName);

                    int rowsAffected = deleteProductCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Продукт був успішно видалений!");
                    }
                    else
                    {
                        MessageBox.Show("Продукт з такою назвою не знайдено.");
                    }

                    ResetAutoIncrement("product", "product_id");
                    mainform.UpdateMenu();
                    ShowProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось видалити продукт. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRegEmployee_Click(object sender, EventArgs e)
        {
            string login = txtLoginEmployee.Text;
            string password = txtPasswordEmployee.Text;
            string surname = txtSurnameEmployee.Text;
            string name = txtNameEmployee.Text;
            string phoneNumber = txtPhoneEmployee.Text;
            string employeeType = cmbEmployeeType.SelectedItem?.ToString();

            if (!ValidateFields(login, password, surname, name, phoneNumber, employeeType))
            {
                return;
            }

            string hashedPassword = HashPassword(password);

            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();

                string getTypeQuery = "SELECT employee_type_id FROM employee_type WHERE type = @employeeType";
                MySqlCommand getTypeCmd = new MySqlCommand(getTypeQuery, conn);
                getTypeCmd.Parameters.AddWithValue("@employeeType", employeeType);
                object result = getTypeCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Не вдалось знайти ідентифікатор типу працівника для назви " + employeeType, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int employeeTypeId = Convert.ToInt32(result);

                string query = "INSERT INTO employee (login, password, surname, name, phone_number, fk_employee_type_id) VALUES (@login, @password, @surname, @name, @phoneNumber, @employeeTypeId)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@employeeTypeId", employeeTypeId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Успішна реєстрація працівника!", "Зареєстровано", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLoginEmployee.Clear();
                txtPasswordEmployee.Clear();
                txtSurnameEmployee.Clear();
                txtNameEmployee.Clear();
                txtPhoneEmployee.Clear();
                cmbEmployeeType.SelectedIndex = -1;

                LoadDataGridViewEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось зареєструвати працівника. Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private bool ValidateFields(string login, string password, string surname, string name, string phoneNumber, string employeeType)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(employeeType))
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

            return true;
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string editLogin = txtEditDeleteLogin.Text;

            if (string.IsNullOrEmpty(editLogin))
            {
                MessageBox.Show("Будь ласка, введіть логін працівника для редагування.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM employee WHERE login = @editLogin";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@editLogin", editLogin);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Працівника з таким логіном не знайдено.");
                        return;
                    }

                    int employeeId = Convert.ToInt32(reader["employee_id"]);
                    string currentLogin = reader["login"].ToString();
                    string currentPassword = reader["password"].ToString();
                    string currentSurname = reader["surname"].ToString();
                    string currentName = reader["name"].ToString();
                    string currentPhoneNumber = reader["phone_number"].ToString();
                    string currentEmployeeType = reader["fk_employee_type_id"].ToString();

                    reader.Close();
                    string newLogin = string.IsNullOrEmpty(txtLoginEmployee.Text) ? currentLogin : txtLoginEmployee.Text;
                    string newPassword = string.IsNullOrEmpty(txtPasswordEmployee.Text) ? currentPassword : HashPassword(txtPasswordEmployee.Text);
                    string newSurname = string.IsNullOrEmpty(txtSurnameEmployee.Text) ? currentSurname : txtSurnameEmployee.Text;
                    string newName = string.IsNullOrEmpty(txtNameEmployee.Text) ? currentName : txtNameEmployee.Text;
                    string newPhoneNumber = string.IsNullOrEmpty(txtPhoneEmployee.Text) ? currentPhoneNumber : txtPhoneEmployee.Text;
                    string newEmployeeType = cmbEmployeeType.SelectedItem == null ? currentEmployeeType : cmbEmployeeType.SelectedItem.ToString();

                    query = "UPDATE employee SET login = @newLogin, password = @newPassword, surname = @newSurname, name = @newName, phone_number = @newPhoneNumber, fk_employee_type_id = @newEmployeeType WHERE employee_id = @employeeId";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@newLogin", newLogin);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@newSurname", newSurname);
                    cmd.Parameters.AddWithValue("@newName", newName);
                    cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                    cmd.Parameters.AddWithValue("@newEmployeeType", newEmployeeType);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Інформація про працівника оновлена!", "Оновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoginEmployee.Clear();
                    txtPasswordEmployee.Clear();
                    txtSurnameEmployee.Clear();
                    txtNameEmployee.Clear();
                    txtPhoneEmployee.Clear();
                    cmbEmployeeType.SelectedIndex = -1;
                    LoadDataGridViewEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось відредагувати працівника. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string deleteLogin = txtEditDeleteLogin.Text;

            if (string.IsNullOrEmpty(deleteLogin))
            {
                MessageBox.Show("Будь ласка, введіть логін працівника для видалення.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string deleteEmployeeQuery = "DELETE FROM employee WHERE login = @deleteLogin";
                    MySqlCommand deleteEmployeeCmd = new MySqlCommand(deleteEmployeeQuery, conn);
                    deleteEmployeeCmd.Parameters.AddWithValue("@deleteLogin", deleteLogin);

                    int rowsAffected = deleteEmployeeCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Працівника був успішно видалений!");
                    }
                    else
                    {
                        MessageBox.Show("Працівника з таким логіном не знайдено.");
                    }
                    ResetAutoIncrement("employee", "employee_id");
                    LoadDataGridViewEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось видалити працівника. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGridViewEmployee()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = @"
                SELECT e.employee_id AS '№', 
                e.login AS 'Логін', 
                e.surname AS 'Прізвище',
                e.name AS 'Ім\'я',
                e.phone_number AS 'Номер телефону',
                et.type AS 'Тип працівника'
                FROM employee e
                JOIN employee_type et ON e.fk_employee_type_id = et.employee_type_id;
            ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewEmployee.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void LoadDataGridViewClients()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = @"
                SELECT client_id AS '№ клієнта', 
       login AS 'Логін', 
       surname AS 'Прізвище', 
       name AS 'Ім''я', 
       email AS 'Електронна пошта', 
       phone_number AS 'Номер телефону' 
FROM client;
            ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewClints.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void LoadStatisticTypes()
        {
            cmbStatisticType.Items.Add("За останній місяць");
            cmbStatisticType.Items.Add("За останній рік");
            cmbStatisticType.Items.Add("За весь час");
        }

        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            string selectedStatisticType = cmbStatisticType.SelectedItem.ToString();

            switch (selectedStatisticType)
            {
                case "За останній місяць":
                    ShowOrdersForLastMonthStatistics();
                    break;
                case "За останній рік":
                    ShowOrdersForLastYearStatistics();
                    break;
                case "За весь час":
                    ShowAllTimeOrdersStatistics();
                    break;
            }
        }
        private void ShowOrdersForLastMonthStatistics()
        {
            string query = "SELECT COUNT(*) FROM `order` WHERE MONTH(order_datetime) = MONTH(CURDATE()) AND YEAR(order_datetime) = YEAR(CURDATE())";

            ExecuteAndDisplayQueryResult(query, lblTotalOrders);
        }

        private void ShowOrdersForLastYearStatistics()
        {
            string query = "SELECT COUNT(*) FROM `order` WHERE YEAR(order_datetime) = YEAR(CURDATE())";

            ExecuteAndDisplayQueryResult(query, lblTotalOrders);
        }

        private void ShowAllTimeOrdersStatistics()
        {
            string query = "SELECT COUNT(*) FROM `order`";

            ExecuteAndDisplayQueryResult(query, lblTotalOrders);
        }
        private void ExecuteAndDisplayQueryResult(string query, Label label)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    label.Text = result.ToString();
                }
                else
                {
                    label.Text = "No data found.";
                }
            }
            catch (Exception ex)
            {
                label.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void ShowCustomerStatistics()
        {
            string query = "SELECT COUNT(*) FROM client";

            ExecuteAndDisplayQueryResult(query, lblTotalCustomers);
        }

        private void ShowTotalRevenueStatistics()
        {
            string query = "SELECT SUM(oi.quantity * p.price) " +
                           "FROM order_item oi " +
                           "JOIN product p ON oi.fk_product_id = p.product_id " +
                           "JOIN `order` o ON oi.fk_order_id = o.order_id " +
                           "WHERE o.fk_status_id = 3";

            ExecuteAndDisplayQueryResult(query, lblTotalRevenue);
        }

        private void ShowPopularItemsStatistics()
        {
            string query = "SELECT p.name, SUM(oi.quantity) AS total_quantity " +
                           "FROM order_item oi " +
                           "JOIN product p ON oi.fk_product_id = p.product_id " +
                           "GROUP BY oi.fk_product_id " +
                           "ORDER BY total_quantity DESC " +
                           "LIMIT 5"; 
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string itemName = reader.GetString(0);
                    int itemQuantity = reader.GetInt32(1);
                    lblPopularItems.Text += itemName + ": " + itemQuantity + "\n";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                lblPopularItems.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void ShowProducts()
        {
            string query = "SELECT p.product_id AS 'ID продукту', " +
                           "p.name AS 'Назва', " +
                           "p.description AS 'Опис', " +
                           "p.price AS 'Ціна', " +
                           "p.image_path AS 'Шлях до зображення', " +
                           "c.name AS 'Категорія' " +
                           "FROM product p " +
                           "JOIN category c ON p.fk_category_id = c.category_id";

            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewProducts.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось завантажити продукти. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}



