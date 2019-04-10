namespace myTest_app
{
    partial class form_director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_director));
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_showFormDeleteMaterials = new System.Windows.Forms.Button();
            this.btn_showFormMaterials = new System.Windows.Forms.Button();
            this.btn_showOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(298, 21);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 41;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(205, 21);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 40;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(408, 23);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 39;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 12);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(121, 371);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 37;
            this.picBox_logo.TabStop = false;
            // 
            // btn_showFormDeleteMaterials
            // 
            this.btn_showFormDeleteMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormDeleteMaterials.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormDeleteMaterials.Location = new System.Drawing.Point(165, 86);
            this.btn_showFormDeleteMaterials.Name = "btn_showFormDeleteMaterials";
            this.btn_showFormDeleteMaterials.Size = new System.Drawing.Size(315, 45);
            this.btn_showFormDeleteMaterials.TabIndex = 45;
            this.btn_showFormDeleteMaterials.Text = "Списание материалов";
            this.btn_showFormDeleteMaterials.UseVisualStyleBackColor = false;
            // 
            // btn_showFormMaterials
            // 
            this.btn_showFormMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormMaterials.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormMaterials.Location = new System.Drawing.Point(165, 137);
            this.btn_showFormMaterials.Name = "btn_showFormMaterials";
            this.btn_showFormMaterials.Size = new System.Drawing.Size(315, 45);
            this.btn_showFormMaterials.TabIndex = 44;
            this.btn_showFormMaterials.Text = "Посмотреть текущие остатки по материалам";
            this.btn_showFormMaterials.UseVisualStyleBackColor = false;
            // 
            // btn_showOrders
            // 
            this.btn_showOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showOrders.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showOrders.Location = new System.Drawing.Point(165, 188);
            this.btn_showOrders.Name = "btn_showOrders";
            this.btn_showOrders.Size = new System.Drawing.Size(315, 45);
            this.btn_showOrders.TabIndex = 46;
            this.btn_showOrders.Text = "Посмореть заказы";
            this.btn_showOrders.UseVisualStyleBackColor = false;
            // 
            // form_director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(560, 395);
            this.Controls.Add(this.btn_showOrders);
            this.Controls.Add(this.btn_showFormDeleteMaterials);
            this.Controls.Add(this.btn_showFormMaterials);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.picBox_logo);
            this.Name = "form_director";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.form_director_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Button btn_showFormDeleteMaterials;
        private System.Windows.Forms.Button btn_showFormMaterials;
        private System.Windows.Forms.Button btn_showOrders;
    }
}