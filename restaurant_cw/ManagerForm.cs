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

namespace restaurant_cw
{
    public partial class ManagerForm : Form
    {
        private Form1 mainform;
        public ManagerForm(int userId, Form1 form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
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

                    mainform.UpdateMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось додати продукт. " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }
    }
}


    

