using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurant_cw
{
    public partial class WaiterForm : Form
    {
        private Form1 mainform;
        public WaiterForm(int userId, Form1 form)
        {
            InitializeComponent();
            mainform = form;
            AddButtonsToDataGridView(); 
            btnSortInfo.Click += new System.EventHandler(this.btnSortInfo_Click); 
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
            DataIntoGridView.Columns["№"].Width = DataIntoGridView.Columns["№"].Width / 4;

        }

        private void LoadDataIntoGridView(string orderBy = "o.order_id DESC")
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = $@"SELECT 
                    o.order_id AS №,
                    o.surname AS Прізвище,
                    o.name AS ""Ім'я"",
                    o.phone_number AS Телефон,
                    o.address AS Адреса,
                    o.order_price AS Ціна,
                    o.order_datetime AS ""Час оформлення"",
                    r.type AS ""Тип отримання"",
                    s.type AS Статус,
                    p.name AS ""Назва продукту"",
                    oi.quantity AS ""Кількість продукту""
                FROM 
                    `order` o
                INNER JOIN 
                    receiving_type r ON o.fk_receiving_type_id = r.receiving_type_id
                INNER JOIN 
                    status s ON o.fk_status_id = s.status_id
                INNER JOIN 
                    order_item oi ON o.order_id = oi.fk_order_id
                INNER JOIN 
                    product p ON oi.fk_product_id = p.product_id
                ORDER BY {orderBy};";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataIntoGridView.DataSource = dataTable;

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

        private void AddButtonsToDataGridView()
        {
            if (DataIntoGridView.Columns["approveButtonColumn"] == null &&
                DataIntoGridView.Columns["cancelButtonColumn"] == null &&
                DataIntoGridView.Columns["doneButtonColumn"] == null)
            {
                DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn();
                approveButtonColumn.HeaderText = "Схвалити";
                approveButtonColumn.Name = "approveButtonColumn";
                approveButtonColumn.Text = "Схвалити";
                approveButtonColumn.UseColumnTextForButtonValue = true;
                DataIntoGridView.Columns.Add(approveButtonColumn);

                DataGridViewButtonColumn cancelButtonColumn = new DataGridViewButtonColumn();
                cancelButtonColumn.HeaderText = "Відхилити";
                cancelButtonColumn.Name = "cancelButtonColumn";
                cancelButtonColumn.Text = "Відхилити";
                cancelButtonColumn.UseColumnTextForButtonValue = true;
                DataIntoGridView.Columns.Add(cancelButtonColumn);

                DataGridViewButtonColumn doneButtonColumn = new DataGridViewButtonColumn();
                doneButtonColumn.HeaderText = "Виконано";
                doneButtonColumn.Name = "doneButtonColumn";
                doneButtonColumn.Text = "Виконано";
                doneButtonColumn.UseColumnTextForButtonValue = true;
                DataIntoGridView.Columns.Add(doneButtonColumn);
            }

            DataIntoGridView.CellContentClick += dataGridView1_CellContentClick;
            DataIntoGridView.CellFormatting += DataIntoGridView_CellFormatting;

        }

        private void DataIntoGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (DataIntoGridView.Columns[e.ColumnIndex].Name == "approveButtonColumn")
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "cancelButtonColumn")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "doneButtonColumn")
                {
                    e.CellStyle.BackColor = Color.Blue;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (DataIntoGridView.Columns[e.ColumnIndex].Name == "approveButtonColumn")
                {
                    int orderId = Convert.ToInt32(DataIntoGridView.Rows[e.RowIndex].Cells["№"].Value);
                    UpdateOrderStatus(orderId, "Схвалено");
                }
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "cancelButtonColumn")
                {
                    int orderId = Convert.ToInt32(DataIntoGridView.Rows[e.RowIndex].Cells["№"].Value);
                    UpdateOrderStatus(orderId, "Відхилено");
                }
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "doneButtonColumn")
                {
                    int orderId = Convert.ToInt32(DataIntoGridView.Rows[e.RowIndex].Cells["№"].Value);
                    UpdateOrderStatus(orderId, "Виконано");
                }
            }
        }

        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string existingStatus = ""; 
            bool statusUpdated = false;

            try
            {
                conn.Open();

                string getStatusQuery = "SELECT s.type FROM `order` o INNER JOIN status s ON o.fk_status_id = s.status_id WHERE o.order_id = @orderId";
                MySqlCommand getStatusCmd = new MySqlCommand(getStatusQuery, conn);
                getStatusCmd.Parameters.AddWithValue("@orderId", orderId);
                object result = getStatusCmd.ExecuteScalar();
                if (result != null)
                {
                    existingStatus = result.ToString();
                }

                if (existingStatus != newStatus)
                {
                    string updateQuery = "UPDATE `order` SET fk_status_id = @newStatus WHERE order_id = @orderId";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newStatus", GetStatusId(newStatus));
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0 && rowsAffected < 2)
                    {
                        statusUpdated = true;
                    }
                    else
                    {
                        MessageBox.Show($"Не вдалося оновити статус замовлення №{orderId}.");
                    }
                }
                else
                {
                    statusUpdated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            if (statusUpdated)
            {
                MessageBox.Show($"Статус замовлення №{orderId} було оновлено на '{newStatus}'.");
                LoadDataIntoGridView();
            }
        }



        private int GetStatusId(string statusType)
        {
            int statusId = -1;

            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = "SELECT status_id FROM status WHERE type = @statusName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@statusName", statusType);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    statusId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show($"Статус з назвою '{statusType}' не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return statusId;
        }

        private void btnSortInfo_Click(object sender, EventArgs e)
        {
            string orderBy = "o.order_id DESC"; 

            if (cmbSortTopicality.SelectedItem != null)
            {
                string selectedTopicality = cmbSortTopicality.SelectedItem.ToString();
                if (selectedTopicality == "Нові замовлення")
                {
                    orderBy = "o.order_datetime DESC";
                }
                else if (selectedTopicality == "Старі замовлення")
                {
                    orderBy = "o.order_datetime ASC";
                }
            }

            if (cmbSortStatus.SelectedItem != null)
            {
                string selectedStatus = cmbSortStatus.SelectedItem.ToString();
                if (selectedStatus == "Схвалено")
                {
                    orderBy = "s.type = 'Схвалено' DESC, " + orderBy;
                }
                else if (selectedStatus == "Відхилено")
                {
                    orderBy = "s.type = 'Відхилено' DESC, " + orderBy;
                }
                else if (selectedStatus == "Доставлено")
                {
                    orderBy = "s.type = 'Доставлено' DESC, " + orderBy;
                }
            }

            if (cmbSortPrice.SelectedItem != null)
            {
                string selectedPrice = cmbSortPrice.SelectedItem.ToString();
                if (selectedPrice == "Найдорожчі")
                {
                    orderBy = "o.order_price DESC, " + orderBy;
                }
                else if (selectedPrice == "Найдешевші")
                {
                    orderBy = "o.order_price ASC, " + orderBy;
                }
            }

            if (cmbSortTypeReceiving.SelectedItem != null)
            {
                string selectedTypeReceiving = cmbSortTypeReceiving.SelectedItem.ToString();
                if (selectedTypeReceiving == "Самовивіз")
                {
                    orderBy = "r.type = 'Самовивіз' DESC, " + orderBy;
                }
                else if (selectedTypeReceiving == "Доставлення")
                {
                    orderBy = "r.type = 'Доставлення' DESC, " + orderBy;
                }
            }

            LoadDataIntoGridView(orderBy);

        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }
    }
}
