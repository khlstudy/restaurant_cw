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
    public partial class MenuForm : Form
    {
        public MenuForm(Form1 form)
        {
            InitializeComponent();
            LoadProducts();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadProducts()
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                string query = "SELECT name, description, price, amount, image_path FROM product";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                int x = 10, y = 10;

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
                        Location = new Point(x, y),
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

                    this.Controls.Add(panel);

                    y += 280;
                }
            }
    }   }
}
    
