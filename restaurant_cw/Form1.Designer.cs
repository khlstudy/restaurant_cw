namespace restaurant_cw
{
    partial class Form1
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
            this.btnAuthorizationForm = new System.Windows.Forms.Button();
            this.btnRegistrationForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenuForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthorizationForm
            // 
            this.btnAuthorizationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthorizationForm.BackColor = System.Drawing.Color.Tan;
            this.btnAuthorizationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthorizationForm.Location = new System.Drawing.Point(451, 231);
            this.btnAuthorizationForm.Name = "btnAuthorizationForm";
            this.btnAuthorizationForm.Size = new System.Drawing.Size(279, 51);
            this.btnAuthorizationForm.TabIndex = 1;
            this.btnAuthorizationForm.Text = "Вхід";
            this.btnAuthorizationForm.UseVisualStyleBackColor = false;
            this.btnAuthorizationForm.Click += new System.EventHandler(this.btnAuthorizationForm_Click);
            // 
            // btnRegistrationForm
            // 
            this.btnRegistrationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrationForm.BackColor = System.Drawing.Color.Tan;
            this.btnRegistrationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrationForm.Location = new System.Drawing.Point(451, 302);
            this.btnRegistrationForm.Name = "btnRegistrationForm";
            this.btnRegistrationForm.Size = new System.Drawing.Size(279, 51);
            this.btnRegistrationForm.TabIndex = 2;
            this.btnRegistrationForm.Text = "Реєстрація";
            this.btnRegistrationForm.UseVisualStyleBackColor = false;
            this.btnRegistrationForm.Click += new System.EventHandler(this.btnRegistrationForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Tan;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(451, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(279, 51);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::restaurant_cw.Properties.Resources.restoraunt_main;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(75, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.2F);
            this.label2.Location = new System.Drawing.Point(68, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ресторан української кухні \"Лелека\"";
            // 
            // btnMenuForm
            // 
            this.btnMenuForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuForm.BackColor = System.Drawing.Color.Tan;
            this.btnMenuForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuForm.Location = new System.Drawing.Point(451, 156);
            this.btnMenuForm.Name = "btnMenuForm";
            this.btnMenuForm.Size = new System.Drawing.Size(279, 51);
            this.btnMenuForm.TabIndex = 9;
            this.btnMenuForm.Text = "Меню";
            this.btnMenuForm.UseVisualStyleBackColor = false;
            this.btnMenuForm.Click += new System.EventHandler(this.btnMenuForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(797, 538);
            this.Controls.Add(this.btnMenuForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrationForm);
            this.Controls.Add(this.btnAuthorizationForm);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAuthorizationForm;
        private System.Windows.Forms.Button btnRegistrationForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenuForm;
    }
}

