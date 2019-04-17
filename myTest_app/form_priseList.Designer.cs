namespace myTest_app
{
    partial class form_priseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_priseList));
            this.lbl_items = new System.Windows.Forms.Label();
            this.dataGridView_priceList = new System.Windows.Forms.DataGridView();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            this.lbl_sumValue = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.nUpDown_contItems = new System.Windows.Forms.NumericUpDown();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cbox_color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_items = new System.Windows.Forms.ComboBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_entery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_priceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_contItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_items
            // 
            this.lbl_items.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_items.Location = new System.Drawing.Point(105, 35);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(536, 46);
            this.lbl_items.TabIndex = 9;
            this.lbl_items.Text = "Список изделий";
            this.lbl_items.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_items.Click += new System.EventHandler(this.lbl_items_Click);
            // 
            // dataGridView_priceList
            // 
            this.dataGridView_priceList.AllowUserToAddRows = false;
            this.dataGridView_priceList.AllowUserToDeleteRows = false;
            this.dataGridView_priceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_priceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dataGridView_priceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_priceList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dataGridView_priceList.Location = new System.Drawing.Point(105, 84);
            this.dataGridView_priceList.Name = "dataGridView_priceList";
            this.dataGridView_priceList.ReadOnly = true;
            this.dataGridView_priceList.Size = new System.Drawing.Size(536, 290);
            this.dataGridView_priceList.TabIndex = 10;
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 84);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(87, 290);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 11;
            this.picBox_logo.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_back.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(12, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 45);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "<-Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(807, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 15;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(711, 9);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 47;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(618, 9);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 46;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // lbl_sumValue
            // 
            this.lbl_sumValue.AutoSize = true;
            this.lbl_sumValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sumValue.Location = new System.Drawing.Point(835, 289);
            this.lbl_sumValue.Name = "lbl_sumValue";
            this.lbl_sumValue.Size = new System.Drawing.Size(93, 35);
            this.lbl_sumValue.TabIndex = 57;
            this.lbl_sumValue.Text = "lbl_sumValue";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sum.Location = new System.Drawing.Point(672, 289);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(117, 35);
            this.lbl_sum.TabIndex = 56;
            this.lbl_sum.Text = "Итоговая сумма";
            // 
            // nUpDown_contItems
            // 
            this.nUpDown_contItems.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDown_contItems.Location = new System.Drawing.Point(831, 230);
            this.nUpDown_contItems.Name = "nUpDown_contItems";
            this.nUpDown_contItems.Size = new System.Drawing.Size(138, 40);
            this.nUpDown_contItems.TabIndex = 54;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_color.Location = new System.Drawing.Point(674, 177);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(48, 35);
            this.lbl_color.TabIndex = 53;
            this.lbl_color.Text = "Цвет";
            // 
            // cbox_color
            // 
            this.cbox_color.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbox_color.FormattingEnabled = true;
            this.cbox_color.Location = new System.Drawing.Point(764, 174);
            this.cbox_color.Name = "cbox_color";
            this.cbox_color.Size = new System.Drawing.Size(205, 43);
            this.cbox_color.TabIndex = 52;
            this.cbox_color.Text = "Выбирите цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(672, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 51;
            this.label1.Text = "Изделие";
            // 
            // cbox_items
            // 
            this.cbox_items.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbox_items.FormattingEnabled = true;
            this.cbox_items.Location = new System.Drawing.Point(762, 122);
            this.cbox_items.Name = "cbox_items";
            this.cbox_items.Size = new System.Drawing.Size(205, 43);
            this.cbox_items.TabIndex = 50;
            this.cbox_items.Text = "Выбирите изделие";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_count.Location = new System.Drawing.Point(674, 232);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(142, 35);
            this.lbl_count.TabIndex = 49;
            this.lbl_count.Text = "Количество изделий";
            // 
            // btn_entery
            // 
            this.btn_entery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_entery.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_entery.Location = new System.Drawing.Point(695, 344);
            this.btn_entery.Name = "btn_entery";
            this.btn_entery.Size = new System.Drawing.Size(261, 45);
            this.btn_entery.TabIndex = 48;
            this.btn_entery.Text = "Заказать";
            this.btn_entery.UseVisualStyleBackColor = false;
            // 
            // form_priseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(988, 399);
            this.Controls.Add(this.lbl_sumValue);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.nUpDown_contItems);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.cbox_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_items);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_entery);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.dataGridView_priceList);
            this.Controls.Add(this.lbl_items);
            this.Name = "form_priseList";
            this.Text = "Список изделий";
            this.Load += new System.EventHandler(this.form_priseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_priceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_contItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.DataGridView dataGridView_priceList;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Label lbl_sumValue;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.NumericUpDown nUpDown_contItems;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox cbox_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_items;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_entery;
    }
}