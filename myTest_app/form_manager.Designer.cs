namespace myTest_app
{
    partial class form_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manager));
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_out = new System.Windows.Forms.Button();
            this.lbl_post = new System.Windows.Forms.Label();
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.dgridView_orders = new System.Windows.Forms.DataGridView();
            this.btn_showFormMaterials = new System.Windows.Forms.Button();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.lbl_loginOrderValue = new System.Windows.Forms.Label();
            this.btn_takeOrders = new System.Windows.Forms.Button();
            this.lbl_loginOrder = new System.Windows.Forms.Label();
            this.btn_showFormDeleteMaterials = new System.Windows.Forms.Button();
            this.btn_showFormConstruct = new System.Windows.Forms.Button();
            this.btn_showFormSpecfic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 10);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(121, 425);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 3;
            this.picBox_logo.TabStop = false;
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(912, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 17;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(709, 10);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 35;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(802, 10);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 36;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // dgridView_orders
            // 
            this.dgridView_orders.AllowUserToAddRows = false;
            this.dgridView_orders.AllowUserToDeleteRows = false;
            this.dgridView_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dgridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView_orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dgridView_orders.Location = new System.Drawing.Point(156, 88);
            this.dgridView_orders.Name = "dgridView_orders";
            this.dgridView_orders.ReadOnly = true;
            this.dgridView_orders.Size = new System.Drawing.Size(576, 296);
            this.dgridView_orders.TabIndex = 37;
            // 
            // btn_showFormMaterials
            // 
            this.btn_showFormMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormMaterials.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormMaterials.Location = new System.Drawing.Point(747, 262);
            this.btn_showFormMaterials.Name = "btn_showFormMaterials";
            this.btn_showFormMaterials.Size = new System.Drawing.Size(315, 45);
            this.btn_showFormMaterials.TabIndex = 42;
            this.btn_showFormMaterials.Text = "Посмотреть текущие остатки по материалам";
            this.btn_showFormMaterials.UseVisualStyleBackColor = false;
            this.btn_showFormMaterials.Click += new System.EventHandler(this.btn_showFormMaterials_Click);
            // 
            // lbl_orders
            // 
            this.lbl_orders.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_orders.Location = new System.Drawing.Point(156, 48);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(633, 37);
            this.lbl_orders.TabIndex = 38;
            this.lbl_orders.Text = "СПИСОК ЗАКАЗОВ";
            this.lbl_orders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_loginOrderValue
            // 
            this.lbl_loginOrderValue.AutoSize = true;
            this.lbl_loginOrderValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_loginOrderValue.Location = new System.Drawing.Point(261, 400);
            this.lbl_loginOrderValue.Name = "lbl_loginOrderValue";
            this.lbl_loginOrderValue.Size = new System.Drawing.Size(100, 35);
            this.lbl_loginOrderValue.TabIndex = 41;
            this.lbl_loginOrderValue.Text = "lbl_loginOrder";
            // 
            // btn_takeOrders
            // 
            this.btn_takeOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_takeOrders.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_takeOrders.Location = new System.Drawing.Point(747, 400);
            this.btn_takeOrders.Name = "btn_takeOrders";
            this.btn_takeOrders.Size = new System.Drawing.Size(315, 45);
            this.btn_takeOrders.TabIndex = 39;
            this.btn_takeOrders.Text = "Принять выбранный заказ";
            this.btn_takeOrders.UseVisualStyleBackColor = false;
            // 
            // lbl_loginOrder
            // 
            this.lbl_loginOrder.AutoSize = true;
            this.lbl_loginOrder.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_loginOrder.Location = new System.Drawing.Point(171, 400);
            this.lbl_loginOrder.Name = "lbl_loginOrder";
            this.lbl_loginOrder.Size = new System.Drawing.Size(75, 35);
            this.lbl_loginOrder.TabIndex = 40;
            this.lbl_loginOrder.Text = "Заказчик:";
            this.lbl_loginOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_showFormDeleteMaterials
            // 
            this.btn_showFormDeleteMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormDeleteMaterials.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormDeleteMaterials.Location = new System.Drawing.Point(747, 109);
            this.btn_showFormDeleteMaterials.Name = "btn_showFormDeleteMaterials";
            this.btn_showFormDeleteMaterials.Size = new System.Drawing.Size(315, 45);
            this.btn_showFormDeleteMaterials.TabIndex = 43;
            this.btn_showFormDeleteMaterials.Text = "Списание материалов";
            this.btn_showFormDeleteMaterials.UseVisualStyleBackColor = false;
            this.btn_showFormDeleteMaterials.Click += new System.EventHandler(this.btn_showFormDeleteMaterials_Click);
            // 
            // btn_showFormConstruct
            // 
            this.btn_showFormConstruct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormConstruct.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormConstruct.Location = new System.Drawing.Point(747, 160);
            this.btn_showFormConstruct.Name = "btn_showFormConstruct";
            this.btn_showFormConstruct.Size = new System.Drawing.Size(315, 45);
            this.btn_showFormConstruct.TabIndex = 44;
            this.btn_showFormConstruct.Text = "Открыть конструктор";
            this.btn_showFormConstruct.UseVisualStyleBackColor = false;
            this.btn_showFormConstruct.Click += new System.EventHandler(this.btn_showFormConstruct_Click);
            // 
            // btn_showFormSpecfic
            // 
            this.btn_showFormSpecfic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormSpecfic.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormSpecfic.Location = new System.Drawing.Point(747, 211);
            this.btn_showFormSpecfic.Name = "btn_showFormSpecfic";
            this.btn_showFormSpecfic.Size = new System.Drawing.Size(315, 45);
            this.btn_showFormSpecfic.TabIndex = 45;
            this.btn_showFormSpecfic.Text = "Спецификация изделий";
            this.btn_showFormSpecfic.UseVisualStyleBackColor = false;
            this.btn_showFormSpecfic.Click += new System.EventHandler(this.btn_showFormSpecfic_Click);
            // 
            // form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1074, 479);
            this.Controls.Add(this.btn_showFormSpecfic);
            this.Controls.Add(this.btn_showFormConstruct);
            this.Controls.Add(this.btn_showFormDeleteMaterials);
            this.Controls.Add(this.dgridView_orders);
            this.Controls.Add(this.btn_showFormMaterials);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.lbl_loginOrderValue);
            this.Controls.Add(this.btn_takeOrders);
            this.Controls.Add(this.lbl_loginOrder);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.picBox_logo);
            this.Name = "form_manager";
            this.Text = "form_manager";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.DataGridView dgridView_orders;
        private System.Windows.Forms.Button btn_showFormMaterials;
        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.Label lbl_loginOrderValue;
        private System.Windows.Forms.Button btn_takeOrders;
        private System.Windows.Forms.Label lbl_loginOrder;
        private System.Windows.Forms.Button btn_showFormDeleteMaterials;
        private System.Windows.Forms.Button btn_showFormConstruct;
        private System.Windows.Forms.Button btn_showFormSpecfic;
    }
}