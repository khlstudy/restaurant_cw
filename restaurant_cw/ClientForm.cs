using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
