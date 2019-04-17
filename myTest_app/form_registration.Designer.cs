namespace myTest_app
{
    partial class form_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_registration));
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.lbl_passwordTwo = new System.Windows.Forms.Label();
            this.tbx_passwordTwo = new System.Windows.Forms.TextBox();
            this.btn_registration = new System.Windows.Forms.Button();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.tbx_telephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(197, 99);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(60, 35);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Пароль";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_login.Location = new System.Drawing.Point(204, 58);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(53, 35);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.Text = "Логин";
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbx_password.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_password.Location = new System.Drawing.Point(288, 100);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(196, 35);
            this.tbx_password.TabIndex = 8;
            this.tbx_password.Text = "1234";
            // 
            // tbx_login
            // 
            this.tbx_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.tbx_login.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_login.Location = new System.Drawing.Point(288, 59);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(196, 35);
            this.tbx_login.TabIndex = 7;
            this.tbx_login.Text = "krot";
            // 
            // lbl_passwordTwo
            // 
            this.lbl_passwordTwo.AutoSize = true;
            this.lbl_passwordTwo.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_passwordTwo.Location = new System.Drawing.Point(156, 140);
            this.lbl_passwordTwo.Name = "lbl_passwordTwo";
            this.lbl_passwordTwo.Size = new System.Drawing.Size(110, 35);
            this.lbl_passwordTwo.TabIndex = 12;
            this.lbl_passwordTwo.Text = "Повтор пароль";
            // 
            // tbx_passwordTwo
            // 
            this.tbx_passwordTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbx_passwordTwo.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_passwordTwo.Location = new System.Drawing.Point(288, 141);
            this.tbx_passwordTwo.Name = "tbx_passwordTwo";
            this.tbx_passwordTwo.Size = new System.Drawing.Size(196, 35);
            this.tbx_passwordTwo.TabIndex = 11;
            this.tbx_passwordTwo.Text = "1234";
            // 
            // btn_registration
            // 
            this.btn_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_registration.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_registration.Location = new System.Drawing.Point(311, 235);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(158, 45);
            this.btn_registration.TabIndex = 13;
            this.btn_registration.Text = "Зарегистрироваться";
            this.btn_registration.UseVisualStyleBackColor = false;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 3);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(133, 271);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 14;
            this.picBox_logo.TabStop = false;
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_telephone.Location = new System.Drawing.Point(156, 181);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(119, 35);
            this.lbl_telephone.TabIndex = 16;
            this.lbl_telephone.Text = "Номер телефона";
            // 
            // tbx_telephone
            // 
            this.tbx_telephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.tbx_telephone.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_telephone.Location = new System.Drawing.Point(288, 182);
            this.tbx_telephone.MaxLength = 11;
            this.tbx_telephone.Name = "tbx_telephone";
            this.tbx_telephone.Size = new System.Drawing.Size(196, 35);
            this.tbx_telephone.TabIndex = 15;
            this.tbx_telephone.Text = "11111111111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Регистрация";
            // 
            // form_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(496, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_telephone);
            this.Controls.Add(this.tbx_telephone);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.lbl_passwordTwo);
            this.Controls.Add(this.tbx_passwordTwo);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_login);
            this.Name = "form_registration";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.form_registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.Label lbl_passwordTwo;
        private System.Windows.Forms.TextBox tbx_passwordTwo;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.TextBox tbx_telephone;
        private System.Windows.Forms.Label label1;
    }
}