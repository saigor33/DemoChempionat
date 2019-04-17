namespace myTest_app
{
    partial class form_materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_materials));
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgridView_rulons = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_showFormResedisItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_rulons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 57);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(116, 467);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 3;
            this.picBox_logo.TabStop = false;
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(821, 6);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 17;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_back.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(12, 6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 45);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "<-Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgridView_rulons
            // 
            this.dgridView_rulons.AllowUserToAddRows = false;
            this.dgridView_rulons.AllowUserToDeleteRows = false;
            this.dgridView_rulons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dgridView_rulons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView_rulons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dgridView_rulons.Location = new System.Drawing.Point(149, 89);
            this.dgridView_rulons.Name = "dgridView_rulons";
            this.dgridView_rulons.ReadOnly = true;
            this.dgridView_rulons.Size = new System.Drawing.Size(634, 192);
            this.dgridView_rulons.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(152, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(631, 46);
            this.label6.TabIndex = 29;
            this.label6.Text = "Список рулонов на складе";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "Список готовых изделий  на складе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dataGridView1.Location = new System.Drawing.Point(149, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(634, 192);
            this.dataGridView1.TabIndex = 30;
            // 
            // btn_showFormResedisItem
            // 
            this.btn_showFormResedisItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_showFormResedisItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showFormResedisItem.Location = new System.Drawing.Point(810, 473);
            this.btn_showFormResedisItem.Name = "btn_showFormResedisItem";
            this.btn_showFormResedisItem.Size = new System.Drawing.Size(276, 45);
            this.btn_showFormResedisItem.TabIndex = 34;
            this.btn_showFormResedisItem.Text = "Посмотреть остатки рулонов";
            this.btn_showFormResedisItem.UseVisualStyleBackColor = false;
            this.btn_showFormResedisItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(803, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 192);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(803, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 192);
            this.panel2.TabIndex = 36;
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(727, 5);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 38;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(634, 5);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 37;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // form_materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1098, 530);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_showFormResedisItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgridView_rulons);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.picBox_logo);
            this.Name = "form_materials";
            this.Text = "Складские материалы";
            this.Load += new System.EventHandler(this.form_materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_rulons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgridView_rulons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_showFormResedisItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.Label lbl_post;
    }
}