using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public MenuForm(Form1 form)
        {
            InitializeComponent();
            mainform = form;

            btnPrevDishes.Enabled = false;
            btnNextDishes.Enabled = false;
            btnPrevDrinks.Enabled = false;
            btnNextDrinks.Enabled = false;

            LoadProducts(currentPageDishes, "Страва");
            LoadProducts(currentPageDrinks, "Напій");
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
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
                            Height = 270,
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

                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(lblName);
                        panel.Controls.Add(lblDescription);
                        panel.Controls.Add(lblPrice);

                        table.Controls.Add(panel, col, row);

                        col++;
                        if (col > 1)
                        {
                            col = 0;
                            row++;
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
    }
}
