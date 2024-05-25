using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
using System.Net;

namespace restaurant_cw
{
    public partial class MenuForm : Form
    {
        private int currentPageDishes = 1;
        private int currentPageDrinks = 1;
        private const int itemsPerPage = 4;
        private TableLayoutPanel tableDishes;
        private TableLayoutPanel tableDrinks;
        private Form1 mainform;
        private int userId;

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblOrderType;
        private ComboBox cmbOrderType;
        private Label lblDeliveryAddress;
        private TextBox txtDeliveryAddress;

        private Dictionary<string, decimal> productPrices; 
        private Dictionary<string, int> orderedProducts;

        private bool isClient;
        public MenuForm(Form1 form, int userId)
        {
            InitializeComponent();
            mainform = form;
            this.userId = userId;

            btnPrevDishes.Enabled = false;
            btnNextDishes.Enabled = false;
            btnPrevDrinks.Enabled = false;
            btnNextDrinks.Enabled = false;

            productPrices = new Dictionary<string, decimal>(); 
            orderedProducts = new Dictionary<string, int>(); 

            LoadProducts(currentPageDishes, "Страва");
            LoadProducts(currentPageDrinks, "Напій");

            bool isClient = CheckClientExists(userId);
            DisplayFields(isClient);

            this.isClient = isClient;
        }

        private void LoadClientData(int clientId)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                string query = "SELECT name, surname, phone_number FROM client WHERE client_id = @clientId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@clientId", clientId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["name"].ToString();
                        txtLastName.Text = reader["surname"].ToString();
                        txtPhoneNumber.Text = reader["phone_number"].ToString();
                        txtFirstName.ReadOnly = true;
                        txtLastName.ReadOnly = true;
                        txtPhoneNumber.ReadOnly = true;
                    }
                    else
                    {
                        txtFirstName.ReadOnly = false;
                        txtLastName.ReadOnly = false;
                        txtPhoneNumber.ReadOnly = false;
                    }
                }
            }
        }
        private bool CheckClientExists(int clientId)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM client WHERE client_id = @clientId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@clientId", clientId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadClientData(userId);
        }

        private void LoadProducts(int page, string categoryName)
        {
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
                        MessageBox.Show("Помилка: категорії не існує");
                        return;
                    }

                    int categoryId = Convert.ToInt32(result);

                    int totalProducts = GetTotalProducts(categoryId);
                    int totalPages = (int)Math.Ceiling((double)totalProducts / itemsPerPage);

                    if (page < 1) page = 1;
                    if (page > totalPages) page = totalPages;

                    int offset = (page - 1) * itemsPerPage;
                    if (offset < 0) offset = 0;

                    string query = "SELECT name, description, price, image_path FROM product WHERE fk_category_id = @categoryId LIMIT @limit OFFSET @offset";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@limit", itemsPerPage);
                    cmd.Parameters.AddWithValue("@offset", offset);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    TableLayoutPanel table = null;
                    TabPage currentTab = null;

                    if (categoryName == "Страва")
                    {
                        table = tableDishes;
                        currentTab = tabPageDish;
                    }
                    else if (categoryName == "Напій")
                    {
                        table = tableDrinks;
                        currentTab = tabPageDrink;
                    }

                    if (table != null)
                    {
                        currentTab.Controls.Remove(table);
                        table.Dispose();
                    }

                    table = new TableLayoutPanel
                    {
                        RowCount = 2,
                        ColumnCount = 2,
                        AutoSize = true,
                        CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                        Anchor = AnchorStyles.None
                    };

                    int row = 0, col = 0;

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string description = reader["description"].ToString();
                        decimal price = reader.GetDecimal("price");
                        string imagePath = reader["image_path"].ToString();
                        Image productImage = Image.FromFile(imagePath);

                        Panel panel = new Panel
                        {
                            Width = 350,
                            Height = 300,
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        PictureBox pictureBox = new PictureBox
                        {
                            Width = 330,
                            Height = 180,
                            Image = productImage,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(10, 10)
                        };

                        Label lblName = new Label
                        {
                            Text = name,
                            Location = new Point(10, 200),
                            Width = 330,
                        };

                        Label lblDescription = new Label
                        {
                            Text = description,
                            Location = new Point(10, 220),
                            Width = 330
                        };

                        Label lblPrice = new Label
                        {
                            Text = "Ціна: " + price.ToString("C"),
                            Location = new Point(10, 240),
                            Width = 330
                        };

                        Button btnAddItemOrder = new Button
                        {
                            Text = "+",
                            Location = new Point(10, 265),
                            Width = 30,
                            Height = 30,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.Tomato,
                            ForeColor = Color.White

                        };

                        Label lblAmount = new Label
                        {
                            Text = "Кількість:",
                            Location = new Point(60, 270),
                            Width = 80
                        };
                        TextBox txtAmount = new TextBox
                        {
                            Location = new Point(150, 268),
                            Width = 50
                        };

                        Button btnDeleteItemOrder = new Button
                        {
                            Text = "-",
                            Location = new Point(230, 265),
                            Width = 30,
                            Height = 30,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.Tomato,
                            ForeColor = Color.White
                        };

                        btnAddItemOrder.Click += (s, e) => UpdateProductQuantity(name, txtAmount, +1, price);
                        btnDeleteItemOrder.Click += (s, e) => UpdateProductQuantity(name, txtAmount, -1, price);

                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(lblName);
                        panel.Controls.Add(lblDescription);
                        panel.Controls.Add(lblPrice);
                        panel.Controls.Add(btnAddItemOrder);
                        panel.Controls.Add(lblAmount);
                        panel.Controls.Add(txtAmount);
                        panel.Controls.Add(btnDeleteItemOrder);

                        table.Controls.Add(panel, col, row);

                        col++;
                        if (col > 1)
                        {
                            col = 0;
                            row++;
                        }

                        if (!productPrices.ContainsKey(name))
                        {
                            productPrices[name] = price;
                        }
                    }

                    currentTab.Controls.Add(table);
                    table.Location = new Point((currentTab.ClientSize.Width - table.Width) / 2, 20);

                    UpdateNavigationButtons(categoryName, page, totalPages);

                    if (categoryName == "Страва")
                    {
                        tableDishes = table;
                        currentPageDishes = page;
                    }
                    else if (categoryName == "Напій")
                    {
                        tableDrinks = table;
                        currentPageDrinks = page;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час завантаження продуктів: " + ex.Message);
            }
        }

        private void UpdateNavigationButtons(string categoryName, int currentPage, int totalPages)
        {
            if (categoryName == "Страва")
            {
                btnNextDishes.Enabled = currentPage < totalPages;
                btnPrevDishes.Enabled = currentPage > 1;
            }
            else if (categoryName == "Напій")
            {
                btnNextDrinks.Enabled = currentPage < totalPages;
                btnPrevDrinks.Enabled = currentPage > 1;
            }
        }

        private int GetTotalProducts(int categoryId)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM product WHERE fk_category_id = @categoryId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        private void btnBackMain_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }

        public void RefreshMenu()
        {
            LoadProducts(currentPageDishes, "Страва");
            LoadProducts(currentPageDrinks, "Напій");
        }

        private void btnNextDrinks_Click_1(object sender, EventArgs e)
        {
            currentPageDrinks++;
            LoadProducts(currentPageDrinks, "Напій");
        }

        private void btnNextDishes_Click_1(object sender, EventArgs e)
        {
            currentPageDishes++;
            LoadProducts(currentPageDishes, "Страва");
        }

        private void btnPrevDishes_Click_1(object sender, EventArgs e)
        {
            currentPageDishes--;
            LoadProducts(currentPageDishes, "Страва");
        }

        private void btnPrevDrinks_Click_1(object sender, EventArgs e)
        {
            currentPageDrinks--;
            LoadProducts(currentPageDrinks, "Напій");
        }

        private void UpdateProductQuantity(string productName, TextBox txtAmount, int change, decimal price)
        {
            int amount;
            if (!int.TryParse(txtAmount.Text, out amount))
            {
                amount = change;
            }
            else
            {
                amount = Math.Max(1, amount) * change;
            }

            if (orderedProducts.ContainsKey(productName))
            {
                orderedProducts[productName] += amount;
                if (orderedProducts[productName] <= 0)
                {
                    orderedProducts.Remove(productName);
                }
            }
            else if (amount > 0)
            {
                orderedProducts[productName] = amount;
            }

            UpdateProductList();
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal currentTotalPrice = 0;
            foreach (var product in orderedProducts)
            {
                string productName = product.Key;
                int quantity = product.Value;
                if (productPrices.ContainsKey(productName))
                {
                    decimal price = productPrices[productName];
                    currentTotalPrice += price * quantity;
                }
            }

            lblPriceOrder.Text = $"Загальна ціна: {currentTotalPrice:C}";
        }

        private void UpdateProductList()
        {
            productList.Items.Clear();
            foreach (var product in orderedProducts)
            {
                productList.Items.Add($"{product.Key}: {product.Value}");
            }
        }

        private void DisplayFields(bool isClient)
        {
            lblFirstName = new Label
            {
                Text = "Ім'я:",
                Location = new Point(30, 346),
                AutoSize = true
            };
            txtFirstName = new TextBox
            {
                Text = "",
                Location = new Point(lblFirstName.Location.X, lblFirstName.Bottom + 5),
                Width = 261
            };

            lblLastName = new Label
            {
                Text = "Прізвище:",
                Location = new Point(30, txtFirstName.Bottom + 10),
                AutoSize = true
            };
            txtLastName = new TextBox
            {
                Text = "",
                Location = new Point(lblLastName.Location.X, lblLastName.Bottom + 5),
                Width = 261
            };

            lblPhoneNumber = new Label
            {
                Text = "Номер телефона:",
                Location = new Point(30, txtLastName.Bottom + 10),
                AutoSize = true
            };
            txtPhoneNumber = new TextBox
            {
                Text = "",
                Location = new Point(lblPhoneNumber.Location.X, lblPhoneNumber.Bottom + 5),
                Width = 261
            };

            lblOrderType = new Label
            {
                Text = "Отримання замовлення:",
                Location = new Point(30, txtPhoneNumber.Bottom + 10),
                AutoSize = true
            };
            cmbOrderType = new ComboBox
            {
                Location = new Point(lblOrderType.Location.X, lblOrderType.Bottom + 5),
                Width = 261,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbOrderType.Items.AddRange(new string[] { "Самовивіз", "Доставлення" });

            lblDeliveryAddress = new Label
            {
                Text = "Адреса доставлення:",
                Location = new Point(30, cmbOrderType.Bottom + 10),
                AutoSize = true
            };
            txtDeliveryAddress = new TextBox
            {
                Location = new Point(lblDeliveryAddress.Location.X, lblDeliveryAddress.Bottom + 5),
                Width = 261
            };

            groupBoxOrder.Controls.Add(lblFirstName);
            groupBoxOrder.Controls.Add(txtFirstName);
            groupBoxOrder.Controls.Add(lblLastName);
            groupBoxOrder.Controls.Add(txtLastName);
            groupBoxOrder.Controls.Add(lblPhoneNumber);
            groupBoxOrder.Controls.Add(txtPhoneNumber);
            groupBoxOrder.Controls.Add(lblOrderType);
            groupBoxOrder.Controls.Add(cmbOrderType);
            groupBoxOrder.Controls.Add(lblDeliveryAddress);
            groupBoxOrder.Controls.Add(txtDeliveryAddress);
        }
        private decimal CalculateOrderPrice()
        {
            decimal currentTotalPrice = 0;
            foreach (var product in orderedProducts)
            {
                string productName = product.Key;
                int quantity = product.Value;
                if (productPrices.ContainsKey(productName))
                {
                    decimal price = productPrices[productName];
                    currentTotalPrice += price * quantity;
                }
            }
            return currentTotalPrice;
        }


        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrder(isClient);
        }
        private void MakeOrder(bool isClient)
        {
            string name = txtFirstName.Text;
            string surname = txtLastName.Text;
            string phone_number = txtPhoneNumber.Text;
            string order_type = cmbOrderType.SelectedItem?.ToString();
            string address = txtDeliveryAddress.Text;
            decimal order_price = CalculateOrderPrice();

            bool isDelivery = order_type == "Доставлення";
            bool isPickup = order_type == "Самовивіз";
            bool areFieldsValid = !string.IsNullOrEmpty(name) &&
                                  !string.IsNullOrEmpty(surname) &&
                                  !string.IsNullOrEmpty(phone_number) &&
                                  !string.IsNullOrEmpty(order_type) &&
                                  (isPickup || (!string.IsNullOrEmpty(address)));

            if (areFieldsValid)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();

                    string query;
                    if (isClient)
                    {
                        query = @"INSERT INTO `order` (surname, name, phone_number, address, order_price, order_datetime, fk_receiving_type_id, fk_status_id, fk_client_id) 
                          VALUES (@surname, @name, @phone_number, @address, @order_price, NOW(), @fk_receiving_type_id, @fk_status_id, @fk_client_id); 
                          SELECT LAST_INSERT_ID();";
                    }
                    else
                    {
                        query = @"INSERT INTO `order` (surname, name, phone_number, address, order_price, order_datetime, fk_receiving_type_id, fk_status_id) 
                          VALUES (@surname, @name, @phone_number, @address, @order_price, NOW(), @fk_receiving_type_id, @fk_status_id); 
                          SELECT LAST_INSERT_ID();";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@phone_number", phone_number);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@order_price", order_price);
                    cmd.Parameters.AddWithValue("@fk_receiving_type_id", GetReceivingTypeId(order_type));
                    cmd.Parameters.AddWithValue("@fk_status_id", GetDefaultStatusId());

                    if (isClient)
                    {
                        cmd.Parameters.AddWithValue("@fk_client_id", userId);
                    }

                    int lastInsertedOrderId = Convert.ToInt32(cmd.ExecuteScalar());

                    InsertOrderItems(lastInsertedOrderId);

                    MessageBox.Show("Замовлення успішно зроблено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhoneNumber.Clear();
                    txtDeliveryAddress.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося створити замовлення. Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private int GetReceivingTypeId(string orderType)
        {
            int receivingTypeId = -1;
            string query = "SELECT receiving_type_id FROM receiving_type WHERE type = @type";

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@type", orderType);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        receivingTypeId = Convert.ToInt32(result);
                    }
                }
            }

            return receivingTypeId;
        }

        private int GetDefaultStatusId()
        {
            int defaultStatusId = -1;
            string query = "SELECT status_id FROM status WHERE type = 'В обробці'";

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        defaultStatusId = Convert.ToInt32(result);
                    }
                }
            }

            return defaultStatusId;
        }

        private void InsertOrderItems(int orderId)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                try
                {
                    while (orderedProducts.Count > 0)
                    {
                        var product = orderedProducts.First();

                        orderedProducts.Remove(product.Key);

                        string productName = product.Key;
                        int productId = GetProductIdByName(productName);

                        if (productId != -1)
                        {
                            int quantity = product.Value;

                            string query = "INSERT INTO order_item (fk_order_id, fk_product_id, quantity) VALUES (@fk_order_id, @fk_product_id, @quantity)";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@fk_order_id", orderId);
                                cmd.Parameters.AddWithValue("@fk_product_id", productId);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("InsertOrderItems не працює, ТОМУ ЩО " + ex);
                }
            }
        }

        private int GetProductIdByName(string productName)
        {
            int productId = -1;
            string query = "SELECT product_id FROM product WHERE name = @name";

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", productName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        productId = Convert.ToInt32(result);
                        //MessageBox.Show("Айді продукта на ім'я " + productName + "=" + productId);
                    }
                }
            }

            return productId;

        }

    }
}
