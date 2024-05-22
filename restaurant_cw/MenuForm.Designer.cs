namespace restaurant_cw
{
    partial class MenuForm
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
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.tabPageDish = new System.Windows.Forms.TabPage();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.btnNextDishes = new System.Windows.Forms.Button();
            this.btnPrevDishes = new System.Windows.Forms.Button();
            this.tabPageDrink = new System.Windows.Forms.TabPage();
            this.btnNextDrinks = new System.Windows.Forms.Button();
            this.btnPrevDrinks = new System.Windows.Forms.Button();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.productList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuTabControl.SuspendLayout();
            this.tabPageDish.SuspendLayout();
            this.tabPageDrink.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.tabPageDish);
            this.menuTabControl.Controls.Add(this.tabPageDrink);
            this.menuTabControl.Location = new System.Drawing.Point(12, 12);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(773, 729);
            this.menuTabControl.TabIndex = 18;
            // 
            // tabPageDish
            // 
            this.tabPageDish.Controls.Add(this.btnBackMain);
            this.tabPageDish.Controls.Add(this.btnNextDishes);
            this.tabPageDish.Controls.Add(this.btnPrevDishes);
            this.tabPageDish.Location = new System.Drawing.Point(4, 29);
            this.tabPageDish.Name = "tabPageDish";
            this.tabPageDish.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDish.Size = new System.Drawing.Size(765, 696);
            this.tabPageDish.TabIndex = 0;
            this.tabPageDish.Text = "Страви";
            this.tabPageDish.UseVisualStyleBackColor = true;
            // 
            // btnBackMain
            // 
            this.btnBackMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMain.Location = new System.Drawing.Point(597, 642);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(150, 37);
            this.btnBackMain.TabIndex = 20;
            this.btnBackMain.Text = "На головну";
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click_1);
            // 
            // btnNextDishes
            // 
            this.btnNextDishes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextDishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextDishes.Location = new System.Drawing.Point(135, 642);
            this.btnNextDishes.Name = "btnNextDishes";
            this.btnNextDishes.Size = new System.Drawing.Size(123, 37);
            this.btnNextDishes.TabIndex = 19;
            this.btnNextDishes.Text = "Далі >";
            this.btnNextDishes.UseVisualStyleBackColor = true;
            this.btnNextDishes.Click += new System.EventHandler(this.btnNextDishes_Click_1);
            // 
            // btnPrevDishes
            // 
            this.btnPrevDishes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevDishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevDishes.Location = new System.Drawing.Point(6, 642);
            this.btnPrevDishes.Name = "btnPrevDishes";
            this.btnPrevDishes.Size = new System.Drawing.Size(123, 37);
            this.btnPrevDishes.TabIndex = 18;
            this.btnPrevDishes.Text = "< Назад";
            this.btnPrevDishes.UseVisualStyleBackColor = true;
            this.btnPrevDishes.Click += new System.EventHandler(this.btnPrevDishes_Click_1);
            // 
            // tabPageDrink
            // 
            this.tabPageDrink.Controls.Add(this.btnNextDrinks);
            this.tabPageDrink.Controls.Add(this.btnPrevDrinks);
            this.tabPageDrink.Location = new System.Drawing.Point(4, 29);
            this.tabPageDrink.Name = "tabPageDrink";
            this.tabPageDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrink.Size = new System.Drawing.Size(765, 696);
            this.tabPageDrink.TabIndex = 1;
            this.tabPageDrink.Text = "Напої";
            this.tabPageDrink.UseVisualStyleBackColor = true;
            // 
            // btnNextDrinks
            // 
            this.btnNextDrinks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextDrinks.Location = new System.Drawing.Point(135, 642);
            this.btnNextDrinks.Name = "btnNextDrinks";
            this.btnNextDrinks.Size = new System.Drawing.Size(123, 37);
            this.btnNextDrinks.TabIndex = 19;
            this.btnNextDrinks.Text = "Далі >";
            this.btnNextDrinks.UseVisualStyleBackColor = true;
            this.btnNextDrinks.Click += new System.EventHandler(this.btnNextDrinks_Click_1);
            // 
            // btnPrevDrinks
            // 
            this.btnPrevDrinks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevDrinks.Location = new System.Drawing.Point(6, 642);
            this.btnPrevDrinks.Name = "btnPrevDrinks";
            this.btnPrevDrinks.Size = new System.Drawing.Size(123, 37);
            this.btnPrevDrinks.TabIndex = 18;
            this.btnPrevDrinks.Text = "< Назад";
            this.btnPrevDrinks.UseVisualStyleBackColor = true;
            this.btnPrevDrinks.Click += new System.EventHandler(this.btnPrevDrinks_Click_1);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.productList);
            this.groupBoxOrder.Controls.Add(this.button1);
            this.groupBoxOrder.Location = new System.Drawing.Point(792, 30);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(329, 707);
            this.groupBoxOrder.TabIndex = 19;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Оформити замовлення";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 20;
            this.productList.Location = new System.Drawing.Point(30, 36);
            this.productList.Name = "productList";
            this.productList.ScrollAlwaysVisible = true;
            this.productList.Size = new System.Drawing.Size(261, 304);
            this.productList.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(30, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Замовити";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 753);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.menuTabControl);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuTabControl.ResumeLayout(false);
            this.tabPageDish.ResumeLayout(false);
            this.tabPageDrink.ResumeLayout(false);
            this.groupBoxOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage tabPageDish;
        private System.Windows.Forms.TabPage tabPageDrink;
        private System.Windows.Forms.Button btnNextDrinks;
        private System.Windows.Forms.Button btnPrevDrinks;
        private System.Windows.Forms.Button btnNextDishes;
        private System.Windows.Forms.Button btnPrevDishes;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox productList;
    }
}