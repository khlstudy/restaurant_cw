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
            this.Clients = new System.Windows.Forms.TabControl();
            this.Клієнти = new System.Windows.Forms.TabPage();
            this.Адміністратори = new System.Windows.Forms.TabPage();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Clients.SuspendLayout();
            this.Клієнти.SuspendLayout();
            this.Адміністратори.SuspendLayout();
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
            // Clients
            // 
            this.Clients.Controls.Add(this.Клієнти);
            this.Clients.Controls.Add(this.Адміністратори);
            this.Clients.Location = new System.Drawing.Point(30, 27);
            this.Clients.Name = "Clients";
            this.Clients.SelectedIndex = 0;
            this.Clients.Size = new System.Drawing.Size(704, 423);
            this.Clients.TabIndex = 19;
            // 
            // Клієнти
            // 
            this.Клієнти.Controls.Add(this.txtLogin);
            this.Клієнти.Controls.Add(this.btnAuthentication);
            this.Клієнти.Controls.Add(this.label1);
            this.Клієнти.Controls.Add(this.label2);
            this.Клієнти.Controls.Add(this.txtPassword);
            this.Клієнти.Location = new System.Drawing.Point(4, 29);
            this.Клієнти.Name = "Клієнти";
            this.Клієнти.Padding = new System.Windows.Forms.Padding(3);
            this.Клієнти.Size = new System.Drawing.Size(696, 390);
            this.Клієнти.TabIndex = 0;
            this.Клієнти.Text = "Клієнти";
            this.Клієнти.UseVisualStyleBackColor = true;
            // 
            // Адміністратори
            // 
            this.Адміністратори.Controls.Add(this.textBox1);
            this.Адміністратори.Controls.Add(this.button1);
            this.Адміністратори.Controls.Add(this.label3);
            this.Адміністратори.Controls.Add(this.label4);
            this.Адміністратори.Controls.Add(this.textBox2);
            this.Адміністратори.Location = new System.Drawing.Point(4, 29);
            this.Адміністратори.Name = "Адміністратори";
            this.Адміністратори.Padding = new System.Windows.Forms.Padding(3);
            this.Адміністратори.Size = new System.Drawing.Size(696, 390);
            this.Адміністратори.TabIndex = 1;
            this.Адміністратори.Text = "Адміністратори";
            this.Адміністратори.UseVisualStyleBackColor = true;
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthentication.Location = new System.Drawing.Point(257, 235);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(176, 49);
            this.btnAuthentication.TabIndex = 18;
            this.btnAuthentication.Text = "Увійти";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 28);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логін";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(214, 97);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(261, 28);
            this.txtLogin.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 28);
            this.textBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(263, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "Увійти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Логін";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Пароль";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 28);
            this.textBox2.TabIndex = 22;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 538);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.btnBackMain);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(815, 585);
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід в акаунт";
            this.Clients.ResumeLayout(false);
            this.Клієнти.ResumeLayout(false);
            this.Клієнти.PerformLayout();
            this.Адміністратори.ResumeLayout(false);
            this.Адміністратори.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.TabControl Clients;
        private System.Windows.Forms.TabPage Клієнти;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAuthentication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabPage Адміністратори;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}