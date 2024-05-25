namespace restaurant_cw
{
    partial class ClientForm
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
            this.btnClientOrder = new System.Windows.Forms.Button();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.tabControlClientOrders = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.dataGridViewClientOrders = new System.Windows.Forms.DataGridView();
            this.tabPageBanquet = new System.Windows.Forms.TabPage();
            this.dataGridViewBanquet = new System.Windows.Forms.DataGridView();
            this.btnOrderBanquet = new System.Windows.Forms.Button();
            this.comboBoxTimeBanquet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownGuests = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBanquet = new System.Windows.Forms.DateTimePicker();
            this.txtAdditionalWishes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlClientOrders.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientOrders)).BeginInit();
            this.tabPageBanquet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanquet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientOrder
            // 
            this.btnClientOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClientOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClientOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientOrder.ForeColor = System.Drawing.Color.Wheat;
            this.btnClientOrder.Location = new System.Drawing.Point(489, 363);
            this.btnClientOrder.Name = "btnClientOrder";
            this.btnClientOrder.Size = new System.Drawing.Size(261, 37);
            this.btnClientOrder.TabIndex = 22;
            this.btnClientOrder.Text = "Оформити замовлення";
            this.btnClientOrder.UseVisualStyleBackColor = false;
            this.btnClientOrder.Click += new System.EventHandler(this.btnClientOrder_Click);
            // 
            // btnBackMain
            // 
            this.btnBackMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackMain.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMain.ForeColor = System.Drawing.Color.Wheat;
            this.btnBackMain.Location = new System.Drawing.Point(505, 469);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(261, 37);
            this.btnBackMain.TabIndex = 23;
            this.btnBackMain.Text = "Назад";
            this.btnBackMain.UseVisualStyleBackColor = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // tabControlClientOrders
            // 
            this.tabControlClientOrders.Controls.Add(this.tabPageOrders);
            this.tabControlClientOrders.Controls.Add(this.tabPageBanquet);
            this.tabControlClientOrders.Location = new System.Drawing.Point(12, 24);
            this.tabControlClientOrders.Name = "tabControlClientOrders";
            this.tabControlClientOrders.SelectedIndex = 0;
            this.tabControlClientOrders.Size = new System.Drawing.Size(773, 439);
            this.tabControlClientOrders.TabIndex = 24;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPageOrders.Controls.Add(this.dataGridViewClientOrders);
            this.tabPageOrders.Controls.Add(this.btnClientOrder);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(765, 406);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Ваші замовлення";
            // 
            // dataGridViewClientOrders
            // 
            this.dataGridViewClientOrders.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridViewClientOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientOrders.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridViewClientOrders.Location = new System.Drawing.Point(20, 19);
            this.dataGridViewClientOrders.Name = "dataGridViewClientOrders";
            this.dataGridViewClientOrders.RowHeadersWidth = 51;
            this.dataGridViewClientOrders.RowTemplate.Height = 24;
            this.dataGridViewClientOrders.Size = new System.Drawing.Size(730, 324);
            this.dataGridViewClientOrders.TabIndex = 23;
            // 
            // tabPageBanquet
            // 
            this.tabPageBanquet.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPageBanquet.Controls.Add(this.dataGridViewBanquet);
            this.tabPageBanquet.Controls.Add(this.btnOrderBanquet);
            this.tabPageBanquet.Controls.Add(this.comboBoxTimeBanquet);
            this.tabPageBanquet.Controls.Add(this.label1);
            this.tabPageBanquet.Controls.Add(this.numericUpDownGuests);
            this.tabPageBanquet.Controls.Add(this.dateTimePickerBanquet);
            this.tabPageBanquet.Controls.Add(this.txtAdditionalWishes);
            this.tabPageBanquet.Controls.Add(this.label6);
            this.tabPageBanquet.Controls.Add(this.label3);
            this.tabPageBanquet.Controls.Add(this.label4);
            this.tabPageBanquet.ForeColor = System.Drawing.Color.Black;
            this.tabPageBanquet.Location = new System.Drawing.Point(4, 29);
            this.tabPageBanquet.Name = "tabPageBanquet";
            this.tabPageBanquet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBanquet.Size = new System.Drawing.Size(765, 406);
            this.tabPageBanquet.TabIndex = 1;
            this.tabPageBanquet.Text = "Ваші банкети";
            // 
            // dataGridViewBanquet
            // 
            this.dataGridViewBanquet.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridViewBanquet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanquet.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridViewBanquet.Location = new System.Drawing.Point(17, 41);
            this.dataGridViewBanquet.Name = "dataGridViewBanquet";
            this.dataGridViewBanquet.RowHeadersWidth = 51;
            this.dataGridViewBanquet.RowTemplate.Height = 24;
            this.dataGridViewBanquet.Size = new System.Drawing.Size(451, 324);
            this.dataGridViewBanquet.TabIndex = 24;
            // 
            // btnOrderBanquet
            // 
            this.btnOrderBanquet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrderBanquet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOrderBanquet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderBanquet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderBanquet.ForeColor = System.Drawing.Color.Wheat;
            this.btnOrderBanquet.Location = new System.Drawing.Point(489, 363);
            this.btnOrderBanquet.Name = "btnOrderBanquet";
            this.btnOrderBanquet.Size = new System.Drawing.Size(261, 37);
            this.btnOrderBanquet.TabIndex = 23;
            this.btnOrderBanquet.Text = "Оформити банкет";
            this.btnOrderBanquet.UseVisualStyleBackColor = false;
            this.btnOrderBanquet.Click += new System.EventHandler(this.btnOrderBanquet_Click);
            // 
            // comboBoxTimeBanquet
            // 
            this.comboBoxTimeBanquet.FormattingEnabled = true;
            this.comboBoxTimeBanquet.Items.AddRange(new object[] {
            "9:00",
            "12:00",
            "18:00"});
            this.comboBoxTimeBanquet.Location = new System.Drawing.Point(489, 117);
            this.comboBoxTimeBanquet.Name = "comboBoxTimeBanquet";
            this.comboBoxTimeBanquet.Size = new System.Drawing.Size(261, 28);
            this.comboBoxTimeBanquet.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Час банкету";
            // 
            // numericUpDownGuests
            // 
            this.numericUpDownGuests.Location = new System.Drawing.Point(489, 170);
            this.numericUpDownGuests.Name = "numericUpDownGuests";
            this.numericUpDownGuests.Size = new System.Drawing.Size(261, 28);
            this.numericUpDownGuests.TabIndex = 20;
            this.numericUpDownGuests.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePickerBanquet
            // 
            this.dateTimePickerBanquet.Location = new System.Drawing.Point(489, 62);
            this.dateTimePickerBanquet.Name = "dateTimePickerBanquet";
            this.dateTimePickerBanquet.Size = new System.Drawing.Size(261, 28);
            this.dateTimePickerBanquet.TabIndex = 19;
            // 
            // txtAdditionalWishes
            // 
            this.txtAdditionalWishes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdditionalWishes.Location = new System.Drawing.Point(489, 224);
            this.txtAdditionalWishes.Multiline = true;
            this.txtAdditionalWishes.Name = "txtAdditionalWishes";
            this.txtAdditionalWishes.Size = new System.Drawing.Size(261, 133);
            this.txtAdditionalWishes.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Додаткові побажання";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Кількість гостей";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата банкету";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(797, 538);
            this.Controls.Add(this.tabControlClientOrders);
            this.Controls.Add(this.btnBackMain);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 585);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сторінка клієнта";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControlClientOrders.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientOrders)).EndInit();
            this.tabPageBanquet.ResumeLayout(false);
            this.tabPageBanquet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanquet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientOrder;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.TabControl tabControlClientOrders;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageBanquet;
        private System.Windows.Forms.NumericUpDown numericUpDownGuests;
        private System.Windows.Forms.DateTimePicker dateTimePickerBanquet;
        private System.Windows.Forms.TextBox txtAdditionalWishes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTimeBanquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderBanquet;
        private System.Windows.Forms.DataGridView dataGridViewClientOrders;
        private System.Windows.Forms.DataGridView dataGridViewBanquet;
    }
}