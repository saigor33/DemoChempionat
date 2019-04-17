namespace myTest_app
{
    partial class form_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_orders));
            this.btn_entery = new System.Windows.Forms.Button();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.cbox_items = new System.Windows.Forms.ComboBox();
            this.lbl_items = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cbox_color = new System.Windows.Forms.ComboBox();
            this.nUpDown_contItems = new System.Windows.Forms.NumericUpDown();
            this.btn_showPriceList = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.lbl_sumValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_contItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entery
            // 
            this.btn_entery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_entery.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_entery.Location = new System.Drawing.Point(395, 274);
            this.btn_entery.Name = "btn_entery";
            this.btn_entery.Size = new System.Drawing.Size(111, 45);
            this.btn_entery.TabIndex = 1;
            this.btn_entery.Text = "Заказать";
            this.btn_entery.UseVisualStyleBackColor = false;
            this.btn_entery.Click += new System.EventHandler(this.btn_entery_Click);
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(2, 69);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(116, 142);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 3;
            this.picBox_logo.TabStop = false;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_count.Location = new System.Drawing.Point(133, 177);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(142, 35);
            this.lbl_count.TabIndex = 6;
            this.lbl_count.Text = "Количество изделий";
            this.lbl_count.Click += new System.EventHandler(this.lbl_count_Click);
            // 
            // cbox_items
            // 
            this.cbox_items.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbox_items.FormattingEnabled = true;
            this.cbox_items.Location = new System.Drawing.Point(290, 69);
            this.cbox_items.Name = "cbox_items";
            this.cbox_items.Size = new System.Drawing.Size(205, 43);
            this.cbox_items.TabIndex = 7;
            this.cbox_items.Text = "Выбирите изделие";
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_items.Location = new System.Drawing.Point(200, 72);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(66, 35);
            this.lbl_items.TabIndex = 8;
            this.lbl_items.Text = "Изделие";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_color.Location = new System.Drawing.Point(202, 124);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(48, 35);
            this.lbl_color.TabIndex = 10;
            this.lbl_color.Text = "Цвет";
            // 
            // cbox_color
            // 
            this.cbox_color.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbox_color.FormattingEnabled = true;
            this.cbox_color.Location = new System.Drawing.Point(292, 121);
            this.cbox_color.Name = "cbox_color";
            this.cbox_color.Size = new System.Drawing.Size(205, 43);
            this.cbox_color.TabIndex = 9;
            this.cbox_color.Text = "Выбирите цвет";
            // 
            // nUpDown_contItems
            // 
            this.nUpDown_contItems.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDown_contItems.Location = new System.Drawing.Point(292, 177);
            this.nUpDown_contItems.Name = "nUpDown_contItems";
            this.nUpDown_contItems.Size = new System.Drawing.Size(205, 40);
            this.nUpDown_contItems.TabIndex = 11;
            // 
            // btn_showPriceList
            // 
            this.btn_showPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showPriceList.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showPriceList.Location = new System.Drawing.Point(134, 274);
            this.btn_showPriceList.Name = "btn_showPriceList";
            this.btn_showPriceList.Size = new System.Drawing.Size(229, 45);
            this.btn_showPriceList.TabIndex = 12;
            this.btn_showPriceList.Text = "Посмотреть цены на изделия";
            this.btn_showPriceList.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_back.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 45);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "<-Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(395, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 14;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sum.Location = new System.Drawing.Point(167, 236);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(117, 35);
            this.lbl_sum.TabIndex = 15;
            this.lbl_sum.Text = "Итоговая сумма";
            // 
            // lbl_sumValue
            // 
            this.lbl_sumValue.AutoSize = true;
            this.lbl_sumValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sumValue.Location = new System.Drawing.Point(353, 236);
            this.lbl_sumValue.Name = "lbl_sumValue";
            this.lbl_sumValue.Size = new System.Drawing.Size(93, 35);
            this.lbl_sumValue.TabIndex = 16;
            this.lbl_sumValue.Text = "lbl_sumValue";
            // 
            // form_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(550, 331);
            this.Controls.Add(this.lbl_sumValue);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_showPriceList);
            this.Controls.Add(this.nUpDown_contItems);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.cbox_color);
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.cbox_items);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.btn_entery);
            this.Name = "form_orders";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.form_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_contItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entery;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.ComboBox cbox_items;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox cbox_color;
        private System.Windows.Forms.NumericUpDown nUpDown_contItems;
        private System.Windows.Forms.Button btn_showPriceList;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_sumValue;
    }
}