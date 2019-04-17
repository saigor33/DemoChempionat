namespace myTest_app
{
    partial class form_login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.btn_entery = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.btn_registration = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entery
            // 
            this.btn_entery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_entery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_entery.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_entery.Location = new System.Drawing.Point(149, 137);
            this.btn_entery.Name = "btn_entery";
            this.btn_entery.Size = new System.Drawing.Size(111, 45);
            this.btn_entery.TabIndex = 0;
            this.btn_entery.Text = "Войти";
            this.btn_entery.UseVisualStyleBackColor = false;
            this.btn_entery.Click += new System.EventHandler(this.btn_entery_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.textBox_login.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(254, 49);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(144, 40);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.Text = "saigor33";
            // 
            // picBox_logo
            // 
            this.picBox_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 1);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(116, 223);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 2;
            this.picBox_logo.TabStop = false;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.textBox_password.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(254, 93);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(144, 40);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.Text = "1234";
            // 
            // btn_registration
            // 
            this.btn_registration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_registration.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_registration.Location = new System.Drawing.Point(259, 137);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(158, 45);
            this.btn_registration.TabIndex = 4;
            this.btn_registration.Text = "Зарегистрироваться";
            this.btn_registration.UseVisualStyleBackColor = false;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_login.Location = new System.Drawing.Point(182, 52);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(53, 35);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Text = "Логин";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(182, 96);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(60, 35);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Пароль";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(435, 236);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.btn_entery);
            this.Name = "form_login";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entery;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
    }
}

