namespace myTest_app
{
    partial class form_buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_buy));
            this.btn_showFormPriceList = new System.Windows.Forms.Button();
            this.btn_showFormBuy = new System.Windows.Forms.Button();
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showFormPriceList
            // 
            this.btn_showFormPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormPriceList.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormPriceList.Location = new System.Drawing.Point(178, 119);
            this.btn_showFormPriceList.Name = "btn_showFormPriceList";
            this.btn_showFormPriceList.Size = new System.Drawing.Size(221, 45);
            this.btn_showFormPriceList.TabIndex = 60;
            this.btn_showFormPriceList.Text = "Посмотреть список изделий";
            this.btn_showFormPriceList.UseVisualStyleBackColor = false;
            // 
            // btn_showFormBuy
            // 
            this.btn_showFormBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormBuy.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormBuy.Location = new System.Drawing.Point(178, 170);
            this.btn_showFormBuy.Name = "btn_showFormBuy";
            this.btn_showFormBuy.Size = new System.Drawing.Size(221, 45);
            this.btn_showFormBuy.TabIndex = 59;
            this.btn_showFormBuy.Text = "Изменить заказы";
            this.btn_showFormBuy.UseVisualStyleBackColor = false;
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(278, 11);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 58;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(185, 11);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 57;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(375, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 56;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 12);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(121, 246);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 55;
            this.picBox_logo.TabStop = false;
            // 
            // form_buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(522, 267);
            this.Controls.Add(this.btn_showFormPriceList);
            this.Controls.Add(this.btn_showFormBuy);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.picBox_logo);
            this.Name = "form_buy";
            this.Text = "form_buy";
            this.Load += new System.EventHandler(this.form_buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_showFormPriceList;
        private System.Windows.Forms.Button btn_showFormBuy;
        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.PictureBox picBox_logo;
    }
}