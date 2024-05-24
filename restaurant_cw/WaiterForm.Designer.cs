namespace restaurant_cw
{
    partial class WaiterForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.groupBoxSorting = new System.Windows.Forms.GroupBox();
            this.btnSortInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSortTypeReceiving = new System.Windows.Forms.ComboBox();
            this.cmbSortPrice = new System.Windows.Forms.ComboBox();
            this.lblSortPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSortTopicality = new System.Windows.Forms.ComboBox();
            this.cmbSortStatus = new System.Windows.Forms.ComboBox();
            this.DataIntoGridView = new System.Windows.Forms.DataGridView();
            this.tabPageBanquets = new System.Windows.Forms.TabPage();
            this.dataGridViewBanquet = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.groupBoxSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataIntoGridView)).BeginInit();
            this.tabPageBanquets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanquet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOrders);
            this.tabControl1.Controls.Add(this.tabPageBanquets);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1375, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.Khaki;
            this.tabPageOrders.Controls.Add(this.groupBoxSorting);
            this.tabPageOrders.Controls.Add(this.DataIntoGridView);
            this.tabPageOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(1367, 485);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Замовлення";
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackMenu.BackColor = System.Drawing.Color.White;
            this.btnBackMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBackMenu.Location = new System.Drawing.Point(1109, 536);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(261, 37);
            this.btnBackMenu.TabIndex = 37;
            this.btnBackMenu.Text = "Назад";
            this.btnBackMenu.UseVisualStyleBackColor = false;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // groupBoxSorting
            // 
            this.groupBoxSorting.Controls.Add(this.btnSortInfo);
            this.groupBoxSorting.Controls.Add(this.label4);
            this.groupBoxSorting.Controls.Add(this.cmbSortTypeReceiving);
            this.groupBoxSorting.Controls.Add(this.cmbSortPrice);
            this.groupBoxSorting.Controls.Add(this.lblSortPrice);
            this.groupBoxSorting.Controls.Add(this.label2);
            this.groupBoxSorting.Controls.Add(this.label1);
            this.groupBoxSorting.Controls.Add(this.cmbSortTopicality);
            this.groupBoxSorting.Controls.Add(this.cmbSortStatus);
            this.groupBoxSorting.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBoxSorting.Location = new System.Drawing.Point(6, 319);
            this.groupBoxSorting.Name = "groupBoxSorting";
            this.groupBoxSorting.Size = new System.Drawing.Size(745, 134);
            this.groupBoxSorting.TabIndex = 31;
            this.groupBoxSorting.TabStop = false;
            this.groupBoxSorting.Text = "Сортування";
            // 
            // btnSortInfo
            // 
            this.btnSortInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSortInfo.BackColor = System.Drawing.Color.White;
            this.btnSortInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSortInfo.Location = new System.Drawing.Point(226, 91);
            this.btnSortInfo.Name = "btnSortInfo";
            this.btnSortInfo.Size = new System.Drawing.Size(261, 37);
            this.btnSortInfo.TabIndex = 32;
            this.btnSortInfo.Text = "Застосувати";
            this.btnSortInfo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "За типом отримання";
            // 
            // cmbSortTypeReceiving
            // 
            this.cmbSortTypeReceiving.FormattingEnabled = true;
            this.cmbSortTypeReceiving.Items.AddRange(new object[] {
            "Самовивіз",
            "Доставлення"});
            this.cmbSortTypeReceiving.Location = new System.Drawing.Point(553, 51);
            this.cmbSortTypeReceiving.Name = "cmbSortTypeReceiving";
            this.cmbSortTypeReceiving.Size = new System.Drawing.Size(178, 28);
            this.cmbSortTypeReceiving.TabIndex = 35;
            // 
            // cmbSortPrice
            // 
            this.cmbSortPrice.FormattingEnabled = true;
            this.cmbSortPrice.Items.AddRange(new object[] {
            "Найдорожчі",
            "Найдешевші"});
            this.cmbSortPrice.Location = new System.Drawing.Point(384, 51);
            this.cmbSortPrice.Name = "cmbSortPrice";
            this.cmbSortPrice.Size = new System.Drawing.Size(152, 28);
            this.cmbSortPrice.TabIndex = 34;
            // 
            // lblSortPrice
            // 
            this.lblSortPrice.AutoSize = true;
            this.lblSortPrice.Location = new System.Drawing.Point(380, 28);
            this.lblSortPrice.Name = "lblSortPrice";
            this.lblSortPrice.Size = new System.Drawing.Size(87, 20);
            this.lblSortPrice.TabIndex = 33;
            this.lblSortPrice.Text = "За ціною";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(175, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "За статусом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "За актуальністю";
            // 
            // cmbSortTopicality
            // 
            this.cmbSortTopicality.FormattingEnabled = true;
            this.cmbSortTopicality.Items.AddRange(new object[] {
            "Нові замовлення",
            "Старі замовлення"});
            this.cmbSortTopicality.Location = new System.Drawing.Point(11, 51);
            this.cmbSortTopicality.Name = "cmbSortTopicality";
            this.cmbSortTopicality.Size = new System.Drawing.Size(152, 28);
            this.cmbSortTopicality.TabIndex = 27;
            // 
            // cmbSortStatus
            // 
            this.cmbSortStatus.FormattingEnabled = true;
            this.cmbSortStatus.Items.AddRange(new object[] {
            "Схвалено",
            "Відхилено",
            "Доставлено"});
            this.cmbSortStatus.Location = new System.Drawing.Point(179, 51);
            this.cmbSortStatus.Name = "cmbSortStatus";
            this.cmbSortStatus.Size = new System.Drawing.Size(178, 28);
            this.cmbSortStatus.TabIndex = 30;
            // 
            // DataIntoGridView
            // 
            this.DataIntoGridView.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.DataIntoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataIntoGridView.Location = new System.Drawing.Point(6, 23);
            this.DataIntoGridView.Name = "DataIntoGridView";
            this.DataIntoGridView.RowHeadersWidth = 51;
            this.DataIntoGridView.RowTemplate.Height = 24;
            this.DataIntoGridView.Size = new System.Drawing.Size(1355, 290);
            this.DataIntoGridView.TabIndex = 0;
            // 
            // tabPageBanquets
            // 
            this.tabPageBanquets.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPageBanquets.Controls.Add(this.dataGridViewBanquet);
            this.tabPageBanquets.Location = new System.Drawing.Point(4, 29);
            this.tabPageBanquets.Name = "tabPageBanquets";
            this.tabPageBanquets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBanquets.Size = new System.Drawing.Size(1367, 485);
            this.tabPageBanquets.TabIndex = 1;
            this.tabPageBanquets.Text = "Банкети";
            // 
            // dataGridViewBanquet
            // 
            this.dataGridViewBanquet.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridViewBanquet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanquet.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewBanquet.Name = "dataGridViewBanquet";
            this.dataGridViewBanquet.RowHeadersWidth = 51;
            this.dataGridViewBanquet.RowTemplate.Height = 24;
            this.dataGridViewBanquet.Size = new System.Drawing.Size(1355, 290);
            this.dataGridViewBanquet.TabIndex = 1;
            // 
            // WaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1382, 580);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 585);
            this.Name = "WaiterForm";
            this.Text = "Сторінка офіціанта";
            this.Load += new System.EventHandler(this.WaiterForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.groupBoxSorting.ResumeLayout(false);
            this.groupBoxSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataIntoGridView)).EndInit();
            this.tabPageBanquets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanquet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageBanquets;
        private System.Windows.Forms.DataGridView DataIntoGridView;
        private System.Windows.Forms.GroupBox groupBoxSorting;
        private System.Windows.Forms.ComboBox cmbSortStatus;
        private System.Windows.Forms.ComboBox cmbSortTopicality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSortTypeReceiving;
        private System.Windows.Forms.ComboBox cmbSortPrice;
        private System.Windows.Forms.Label lblSortPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortInfo;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.DataGridView dataGridViewBanquet;
    }
}