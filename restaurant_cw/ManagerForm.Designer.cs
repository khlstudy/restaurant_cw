namespace restaurant_cw
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.txtNameEditDelete = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPagUsers = new System.Windows.Forms.TabPage();
            this.tabPageMonitor = new System.Windows.Forms.TabPage();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSurnameEmployee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPasswordEmployee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoginEmployee = new System.Windows.Forms.TextBox();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.txtPhoneEmployee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.txtEditDeleteLogin = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.dataGridViewClints = new System.Windows.Forms.DataGridView();
            this.cmbStatisticType = new System.Windows.Forms.ComboBox();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblPopularItems = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.tabControlMenu.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagUsers.SuspendLayout();
            this.tabPageMonitor.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClints)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageMenu);
            this.tabControlMenu.Controls.Add(this.tabPagUsers);
            this.tabControlMenu.Controls.Add(this.tabPageEmployee);
            this.tabControlMenu.Controls.Add(this.tabPageMonitor);
            this.tabControlMenu.Location = new System.Drawing.Point(12, 12);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(773, 514);
            this.tabControlMenu.TabIndex = 1;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.BackColor = System.Drawing.Color.IndianRed;
            this.tabPageMenu.Controls.Add(this.groupBox2);
            this.tabPageMenu.Controls.Add(this.groupBox1);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 29);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(765, 481);
            this.tabPageMenu.TabIndex = 0;
            this.tabPageMenu.Text = "Формування меню";
            // 
            // btnBackMain
            // 
            this.btnBackMain.BackColor = System.Drawing.Color.Brown;
            this.btnBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMain.ForeColor = System.Drawing.Color.White;
            this.btnBackMain.Location = new System.Drawing.Point(666, 8);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(119, 29);
            this.btnBackMain.TabIndex = 16;
            this.btnBackMain.Text = "Вийти";
            this.btnBackMain.UseVisualStyleBackColor = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnEditProduct);
            this.groupBox2.Controls.Add(this.txtNameEditDelete);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(395, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагування або видалення";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Tomato;
            this.btnDeleteProduct.Location = new System.Drawing.Point(184, 127);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(121, 39);
            this.btnDeleteProduct.TabIndex = 15;
            this.btnDeleteProduct.Text = "Видалити";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click_1);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(40, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 51);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введіть назву продукту для редагування або видалення";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Brown;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.ForeColor = System.Drawing.Color.Turquoise;
            this.btnEditProduct.Location = new System.Drawing.Point(44, 127);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(121, 39);
            this.btnEditProduct.TabIndex = 13;
            this.btnEditProduct.Text = "Редагувати";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click_1);
            // 
            // txtNameEditDelete
            // 
            this.txtNameEditDelete.Location = new System.Drawing.Point(44, 93);
            this.txtNameEditDelete.Name = "txtNameEditDelete";
            this.txtNameEditDelete.Size = new System.Drawing.Size(261, 28);
            this.txtNameEditDelete.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtImagePath);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання страви або напою";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Шлях до зображення";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(37, 351);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(261, 28);
            this.txtImagePath.TabIndex = 13;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Brown;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddProduct.Location = new System.Drawing.Point(113, 385);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(116, 39);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Додати";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.ForeColor = System.Drawing.Color.Maroon;
            this.btnChooseImage.Location = new System.Drawing.Point(37, 293);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(261, 29);
            this.btnChooseImage.TabIndex = 11;
            this.btnChooseImage.Text = "Виберіть зображення";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Страва",
            "Напій"});
            this.cmbCategory.Location = new System.Drawing.Point(37, 247);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(261, 28);
            this.cmbCategory.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Категорія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ціна";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(37, 185);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(261, 28);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Опис";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(37, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(261, 28);
            this.txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(37, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 28);
            this.txtName.TabIndex = 0;
            // 
            // tabPagUsers
            // 
            this.tabPagUsers.BackColor = System.Drawing.Color.Bisque;
            this.tabPagUsers.Controls.Add(this.dataGridViewClints);
            this.tabPagUsers.ForeColor = System.Drawing.Color.Black;
            this.tabPagUsers.Location = new System.Drawing.Point(4, 29);
            this.tabPagUsers.Name = "tabPagUsers";
            this.tabPagUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagUsers.Size = new System.Drawing.Size(765, 481);
            this.tabPagUsers.TabIndex = 1;
            this.tabPagUsers.Text = "Користувачі";
            // 
            // tabPageMonitor
            // 
            this.tabPageMonitor.Controls.Add(this.lblTotalRevenue);
            this.tabPageMonitor.Controls.Add(this.label19);
            this.tabPageMonitor.Controls.Add(this.label18);
            this.tabPageMonitor.Controls.Add(this.label17);
            this.tabPageMonitor.Controls.Add(this.label16);
            this.tabPageMonitor.Controls.Add(this.label15);
            this.tabPageMonitor.Controls.Add(this.label14);
            this.tabPageMonitor.Controls.Add(this.lblPopularItems);
            this.tabPageMonitor.Controls.Add(this.lblTotalCustomers);
            this.tabPageMonitor.Controls.Add(this.lblTotalOrders);
            this.tabPageMonitor.Controls.Add(this.btnShowStatistics);
            this.tabPageMonitor.Controls.Add(this.cmbStatisticType);
            this.tabPageMonitor.Location = new System.Drawing.Point(4, 29);
            this.tabPageMonitor.Name = "tabPageMonitor";
            this.tabPageMonitor.Size = new System.Drawing.Size(765, 481);
            this.tabPageMonitor.TabIndex = 2;
            this.tabPageMonitor.Text = "Моніторинг";
            this.tabPageMonitor.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.BackColor = System.Drawing.Color.Brown;
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Controls.Add(this.groupBox4);
            this.tabPageEmployee.Controls.Add(this.groupBox3);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Size = new System.Drawing.Size(765, 481);
            this.tabPageEmployee.TabIndex = 3;
            this.tabPageEmployee.Text = "Працівники";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbEmployeeType);
            this.groupBox3.Controls.Add(this.txtPhoneEmployee);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtNameEmployee);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnRegEmployee);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSurnameEmployee);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtPasswordEmployee);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtLoginEmployee);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(20, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 446);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Реєстрація нового працівника";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Тип співробітника";
            // 
            // btnRegEmployee
            // 
            this.btnRegEmployee.BackColor = System.Drawing.Color.Brown;
            this.btnRegEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmployee.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRegEmployee.Location = new System.Drawing.Point(88, 385);
            this.btnRegEmployee.Name = "btnRegEmployee";
            this.btnRegEmployee.Size = new System.Drawing.Size(152, 39);
            this.btnRegEmployee.TabIndex = 12;
            this.btnRegEmployee.Text = "Зарєструвати";
            this.btnRegEmployee.UseVisualStyleBackColor = false;
            this.btnRegEmployee.Click += new System.EventHandler(this.btnRegEmployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ім\'я";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Прізвище";
            // 
            // txtSurnameEmployee
            // 
            this.txtSurnameEmployee.Location = new System.Drawing.Point(37, 189);
            this.txtSurnameEmployee.Name = "txtSurnameEmployee";
            this.txtSurnameEmployee.Size = new System.Drawing.Size(261, 28);
            this.txtSurnameEmployee.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Пароль";
            // 
            // txtPasswordEmployee
            // 
            this.txtPasswordEmployee.Location = new System.Drawing.Point(37, 122);
            this.txtPasswordEmployee.Name = "txtPasswordEmployee";
            this.txtPasswordEmployee.Size = new System.Drawing.Size(261, 28);
            this.txtPasswordEmployee.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Логін";
            // 
            // txtLoginEmployee
            // 
            this.txtLoginEmployee.Location = new System.Drawing.Point(37, 63);
            this.txtLoginEmployee.Name = "txtLoginEmployee";
            this.txtLoginEmployee.Size = new System.Drawing.Size(261, 28);
            this.txtLoginEmployee.TabIndex = 0;
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(37, 243);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(261, 28);
            this.txtNameEmployee.TabIndex = 15;
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Location = new System.Drawing.Point(37, 297);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(261, 28);
            this.txtPhoneEmployee.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Номер телефона";
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Items.AddRange(new object[] {
            "Менеджер",
            "Офіціант"});
            this.cmbEmployeeType.Location = new System.Drawing.Point(37, 351);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(261, 28);
            this.cmbEmployeeType.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteEmployee);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnEditEmployee);
            this.groupBox4.Controls.Add(this.txtEditDeleteLogin);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(395, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 188);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редагування або видалення";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Tomato;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(184, 127);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(121, 39);
            this.btnDeleteEmployee.TabIndex = 15;
            this.btnDeleteEmployee.Text = "Видалити";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(40, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(280, 43);
            this.label13.TabIndex = 14;
            this.label13.Text = "Введіть логін працівника для редагування або видалення";
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.Brown;
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Turquoise;
            this.btnEditEmployee.Location = new System.Drawing.Point(44, 127);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(121, 39);
            this.btnEditEmployee.TabIndex = 13;
            this.btnEditEmployee.Text = "Редагувати";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // txtEditDeleteLogin
            // 
            this.txtEditDeleteLogin.Location = new System.Drawing.Point(44, 93);
            this.txtEditDeleteLogin.Name = "txtEditDeleteLogin";
            this.txtEditDeleteLogin.Size = new System.Drawing.Size(261, 28);
            this.txtEditDeleteLogin.TabIndex = 13;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(395, 31);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(342, 241);
            this.dataGridViewEmployee.TabIndex = 3;
            // 
            // dataGridViewClints
            // 
            this.dataGridViewClints.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewClints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClints.GridColor = System.Drawing.Color.Bisque;
            this.dataGridViewClints.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewClints.Name = "dataGridViewClints";
            this.dataGridViewClints.RowHeadersWidth = 51;
            this.dataGridViewClints.RowTemplate.Height = 24;
            this.dataGridViewClints.Size = new System.Drawing.Size(753, 241);
            this.dataGridViewClints.TabIndex = 4;
            // 
            // cmbStatisticType
            // 
            this.cmbStatisticType.FormattingEnabled = true;
            this.cmbStatisticType.Location = new System.Drawing.Point(28, 46);
            this.cmbStatisticType.Name = "cmbStatisticType";
            this.cmbStatisticType.Size = new System.Drawing.Size(320, 28);
            this.cmbStatisticType.TabIndex = 0;
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.BackColor = System.Drawing.Color.Brown;
            this.btnShowStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStatistics.ForeColor = System.Drawing.Color.White;
            this.btnShowStatistics.Location = new System.Drawing.Point(28, 102);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(320, 32);
            this.btnShowStatistics.TabIndex = 1;
            this.btnShowStatistics.Text = "Побачити статистику за часом";
            this.btnShowStatistics.UseVisualStyleBackColor = false;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Location = new System.Drawing.Point(221, 79);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(163, 20);
            this.lblTotalOrders.TabIndex = 2;
            this.lblTotalOrders.Text = "Немає інформації";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Location = new System.Drawing.Point(282, 224);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(163, 20);
            this.lblTotalCustomers.TabIndex = 3;
            this.lblTotalCustomers.Text = "Немає інформації";
            // 
            // lblPopularItems
            // 
            this.lblPopularItems.AutoSize = true;
            this.lblPopularItems.Location = new System.Drawing.Point(303, 312);
            this.lblPopularItems.Name = "lblPopularItems";
            this.lblPopularItems.Size = new System.Drawing.Size(163, 20);
            this.lblPopularItems.TabIndex = 5;
            this.lblPopularItems.Text = "Немає інформації";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Кількість замовлень:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(256, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Загальна кількість клієнтів:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 312);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(269, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Топ 5 популярних продуктів:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(295, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Кількість виконаних замовлень:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(220, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "Виберіть проміжок часу";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Brown;
            this.label19.Location = new System.Drawing.Point(28, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Інша статистика";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(329, 268);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(163, 20);
            this.lblTotalRevenue.TabIndex = 12;
            this.lblTotalRevenue.Text = "Немає інформації";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(797, 538);
            this.Controls.Add(this.btnBackMain);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 585);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сторінка менеджера";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagUsers.ResumeLayout(false);
            this.tabPageMonitor.ResumeLayout(false);
            this.tabPageMonitor.PerformLayout();
            this.tabPageEmployee.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.TabPage tabPagUsers;
        private System.Windows.Forms.TabPage tabPageMonitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.TextBox txtNameEditDelete;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.TextBox txtPhoneEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSurnameEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPasswordEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLoginEmployee;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.TextBox txtEditDeleteLogin;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.DataGridView dataGridViewClints;
        private System.Windows.Forms.ComboBox cmbStatisticType;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblPopularItems;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}