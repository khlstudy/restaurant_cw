using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurant_cw
{
    public partial class WaiterForm : Form
    {
        public WaiterForm(int userId)
        {
            InitializeComponent();
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void LoadDataIntoGridView()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = @"SELECT 
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
    product p ON oi.fk_product_id = p.product_id;
";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataIntoGridView.DataSource = dataTable;

                AddButtonsToDataGridView();
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
                DataIntoGridView.Columns["deliverButtonColumn"] == null)
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

                DataGridViewButtonColumn deliverButtonColumn = new DataGridViewButtonColumn();
                deliverButtonColumn.HeaderText = "Доставлено";
                deliverButtonColumn.Name = "deliverButtonColumn";
                deliverButtonColumn.Text = "Доставлено";
                deliverButtonColumn.UseColumnTextForButtonValue = true;
                DataIntoGridView.Columns.Add(deliverButtonColumn);
            }

            DataIntoGridView.CellContentClick += dataGridView1_CellContentClick;
            DataIntoGridView.CellPainting += DataIntoGridView_CellPainting;
        }

        private void DataIntoGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (DataIntoGridView.Columns[e.ColumnIndex].Name == "approveButtonColumn")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "cancelButtonColumn")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "deliverButtonColumn")
                {
                    e.CellStyle.ForeColor = Color.Blue;
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
                else if (DataIntoGridView.Columns[e.ColumnIndex].Name == "deliverButtonColumn")
                {
                    int orderId = Convert.ToInt32(DataIntoGridView.Rows[e.RowIndex].Cells["№"].Value);
                    UpdateOrderStatus(orderId, "Доставлено");
                }
            }


        }
        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = "UPDATE `order` SET fk_status_id = @newStatus WHERE order_id = @orderId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newStatus", GetStatusId(newStatus)); 
                cmd.Parameters.AddWithValue("@orderId", orderId);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Статус замовлення №{orderId} було оновлено на '{newStatus}'.");
                    LoadDataIntoGridView();
                }
                else
                {
                    MessageBox.Show($"Не вдалося оновити статус замовлення №{orderId}.");
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

    }
}


