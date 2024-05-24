using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurant_cw
{
    public partial class ClientForm : Form
    {
        private Form1 mainform;
        private MenuForm menuform;
        private int userId;

        public ClientForm(Form1 form, MenuForm form2, int userId)
        {
            InitializeComponent();
            mainform = form;
            menuform = form2;
            this.userId = userId;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClientOrder_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menuform = new MenuForm(mainform, userId);
            menuform.Show();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            mainform.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderBanquet_Click(object sender, EventArgs e)
        {
            DateTime banquetDateTime = dateTimePickerBanquet.Value.Date; 
            string timeString = comboBoxTimeBanquet.SelectedItem.ToString();
            if (timeString == "9:00")
            {
                banquetDateTime = banquetDateTime.AddHours(9); 
            }
            else if (timeString == "12:00")
            {
                banquetDateTime = banquetDateTime.AddHours(12); 
            }
            else if (timeString == "18:00")
            {
                banquetDateTime = banquetDateTime.AddHours(18); 
            }

            int numberGuests = (int)numericUpDownGuests.Value;

            if (numberGuests > 80)
            {
                MessageBox.Show("На жаль, не можна замовити банкет для більше ніж 80 гостей.");
                return;
            }

            string additionalWishes = txtAdditionalWishes.Text;
            try
            {
                using (MySqlConnection conn = DBUtils.GetDBConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Banquet WHERE banquet_datetime = @banquetDateTime";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@banquetDateTime", banquetDateTime);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("На жаль, цей час на жаль вже зайнятий для банкету.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Banquet (banquet_datetime, number_guests, additional_wishes, sending_datetime, fk_client_id, fk_status_id) " +
                                         "VALUES (@banquetDateTime, @numberGuests, @additionalWishes, @sendingDateTime, @clientId, @statusId)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@banquetDateTime", banquetDateTime);
                        cmd.Parameters.AddWithValue("@numberGuests", numberGuests);
                        cmd.Parameters.AddWithValue("@additionalWishes", additionalWishes);
                        cmd.Parameters.AddWithValue("@sendingDateTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@clientId", userId); 
                        cmd.Parameters.AddWithValue("@statusId", GetStatusId("В обробці"));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Дані про банкет успішно додані до бази даних.");
                        }
                        else
                        {
                            MessageBox.Show("Помилка при додаванні даних про банкет до бази даних.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private int GetStatusId(string statusType)
        {
            int statusId = -1;

            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                string query = "SELECT status_id FROM status WHERE type = @statusName";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
            }

            return statusId;
        }
    }
}
