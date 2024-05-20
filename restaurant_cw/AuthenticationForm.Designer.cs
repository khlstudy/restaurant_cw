namespace restaurant_cw
{
    partial class AuthenticationForm
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
            this.btnBackMain = new System.Windows.Forms.Button();
            this.OpenAccontTabContcol = new System.Windows.Forms.TabControl();
            this.OpenClientTabContcol = new System.Windows.Forms.TabPage();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.OpenAdminTabContcol = new System.Windows.Forms.TabPage();
            this.txtLoginAdmin = new System.Windows.Forms.TextBox();
            this.btnAuthenticationAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.сBoxEmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenAccontTabContcol.SuspendLayout();
            this.OpenClientTabContcol.SuspendLayout();
            this.OpenAdminTabContcol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackMain
            // 
            this.btnBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMain.Location = new System.Drawing.Point(629, 467);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(123, 37);
            this.btnBackMain.TabIndex = 15;
            this.btnBackMain.Text = "Назад";
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // OpenAccontTabContcol
            // 
            this.OpenAccontTabContcol.Controls.Add(this.OpenClientTabContcol);
            this.OpenAccontTabContcol.Controls.Add(this.OpenAdminTabContcol);
            this.OpenAccontTabContcol.Location = new System.Drawing.Point(30, 27);
            this.OpenAccontTabContcol.Name = "OpenAccontTabContcol";
            this.OpenAccontTabContcol.SelectedIndex = 0;
            this.OpenAccontTabContcol.Size = new System.Drawing.Size(704, 423);
            this.OpenAccontTabContcol.TabIndex = 19;
            // 
            // OpenClientTabContcol
            // 
            this.OpenClientTabContcol.Controls.Add(this.txtLogin);
            this.OpenClientTabContcol.Controls.Add(this.btnAuthentication);
            this.OpenClientTabContcol.Controls.Add(this.label1);
            this.OpenClientTabContcol.Controls.Add(this.label2);
            this.OpenClientTabContcol.Controls.Add(this.txtPassword);
            this.OpenClientTabContcol.Location = new System.Drawing.Point(4, 29);
            this.OpenClientTabContcol.Name = "OpenClientTabContcol";
            this.OpenClientTabContcol.Padding = new System.Windows.Forms.Padding(3);
            this.OpenClientTabContcol.Size = new System.Drawing.Size(696, 390);
            this.OpenClientTabContcol.TabIndex = 0;
            this.OpenClientTabContcol.Text = "Клієнти";
            this.OpenClientTabContcol.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(211, 98);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(261, 28);
            this.txtLogin.TabIndex = 6;
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthentication.Location = new System.Drawing.Point(254, 236);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(176, 49);
            this.btnAuthentication.TabIndex = 18;
            this.btnAuthentication.Text = "Увійти";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 28);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // OpenAdminTabContcol
            // 
            this.OpenAdminTabContcol.Controls.Add(this.label5);
            this.OpenAdminTabContcol.Controls.Add(this.сBoxEmployeeType);
            this.OpenAdminTabContcol.Controls.Add(this.txtLoginAdmin);
            this.OpenAdminTabContcol.Controls.Add(this.btnAuthenticationAdmin);
            this.OpenAdminTabContcol.Controls.Add(this.label3);
            this.OpenAdminTabContcol.Controls.Add(this.label4);
            this.OpenAdminTabContcol.Controls.Add(this.txtPasswordAdmin);
            this.OpenAdminTabContcol.Location = new System.Drawing.Point(4, 29);
            this.OpenAdminTabContcol.Name = "OpenAdminTabContcol";
            this.OpenAdminTabContcol.Padding = new System.Windows.Forms.Padding(3);
            this.OpenAdminTabContcol.Size = new System.Drawing.Size(696, 390);
            this.OpenAdminTabContcol.TabIndex = 1;
            this.OpenAdminTabContcol.Text = "Працівники";
            this.OpenAdminTabContcol.UseVisualStyleBackColor = true;
            // 
            // txtLoginAdmin
            // 
            this.txtLoginAdmin.Location = new System.Drawing.Point(211, 98);
            this.txtLoginAdmin.Name = "txtLoginAdmin";
            this.txtLoginAdmin.Size = new System.Drawing.Size(261, 28);
            this.txtLoginAdmin.TabIndex = 20;
            // 
            // btnAuthenticationAdmin
            // 
            this.btnAuthenticationAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthenticationAdmin.Location = new System.Drawing.Point(254, 300);
            this.btnAuthenticationAdmin.Name = "btnAuthenticationAdmin";
            this.btnAuthenticationAdmin.Size = new System.Drawing.Size(176, 49);
            this.btnAuthenticationAdmin.TabIndex = 23;
            this.btnAuthenticationAdmin.Text = "Увійти";
            this.btnAuthenticationAdmin.UseVisualStyleBackColor = true;
            this.btnAuthenticationAdmin.Click += new System.EventHandler(this.btnAuthenticationAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Логін";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Пароль";
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Location = new System.Drawing.Point(211, 163);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(261, 28);
            this.txtPasswordAdmin.TabIndex = 22;
            this.txtPasswordAdmin.UseSystemPasswordChar = true;
            // 
            // сBoxEmployeeType
            // 
            this.сBoxEmployeeType.FormattingEnabled = true;
            this.сBoxEmployeeType.Items.AddRange(new object[] {
            "Менеджер",
            "Офіціант"});
            this.сBoxEmployeeType.Location = new System.Drawing.Point(211, 226);
            this.сBoxEmployeeType.Name = "сBoxEmployeeType";
            this.сBoxEmployeeType.Size = new System.Drawing.Size(264, 28);
            this.сBoxEmployeeType.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Посада";
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 538);
            this.Controls.Add(this.OpenAccontTabContcol);
            this.Controls.Add(this.btnBackMain);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 585);
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід в акаунт";
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            this.OpenAccontTabContcol.ResumeLayout(false);
            this.OpenClientTabContcol.ResumeLayout(false);
            this.OpenClientTabContcol.PerformLayout();
            this.OpenAdminTabContcol.ResumeLayout(false);
            this.OpenAdminTabContcol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.TabControl OpenAccontTabContcol;
        private System.Windows.Forms.TabPage OpenClientTabContcol;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAuthentication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabPage OpenAdminTabContcol;
        private System.Windows.Forms.TextBox txtLoginAdmin;
        private System.Windows.Forms.Button btnAuthenticationAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.ComboBox сBoxEmployeeType;
        private System.Windows.Forms.Label label5;
    }
}