namespace myTest_app
{
    partial class form_deleteMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_deleteMaterials));
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgridView_materialsDelete = new System.Windows.Forms.DataGridView();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deleteMaterials = new System.Windows.Forms.Button();
            this.lvl_orderNumberValue = new System.Windows.Forms.Label();
            this.lvl_sumValue = new System.Windows.Forms.Label();
            this.lvl_sum = new System.Windows.Forms.Label();
            this.lvl_orderNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_materialsDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(751, 10);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 56;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(658, 10);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 55;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(861, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 54;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_back.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 45);
            this.btn_back.TabIndex = 53;
            this.btn_back.Text = "<-Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgridView_materialsDelete
            // 
            this.dgridView_materialsDelete.AllowUserToAddRows = false;
            this.dgridView_materialsDelete.AllowUserToDeleteRows = false;
            this.dgridView_materialsDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dgridView_materialsDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView_materialsDelete.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dgridView_materialsDelete.Location = new System.Drawing.Point(138, 67);
            this.dgridView_materialsDelete.Name = "dgridView_materialsDelete";
            this.dgridView_materialsDelete.ReadOnly = true;
            this.dgridView_materialsDelete.Size = new System.Drawing.Size(634, 351);
            this.dgridView_materialsDelete.TabIndex = 57;
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 67);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(116, 351);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 58;
            this.picBox_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deleteMaterials);
            this.panel1.Controls.Add(this.lvl_orderNumberValue);
            this.panel1.Controls.Add(this.lvl_sumValue);
            this.panel1.Controls.Add(this.lvl_sum);
            this.panel1.Controls.Add(this.lvl_orderNumber);
            this.panel1.Location = new System.Drawing.Point(790, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 347);
            this.panel1.TabIndex = 59;
            // 
            // btn_deleteMaterials
            // 
            this.btn_deleteMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_deleteMaterials.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deleteMaterials.Location = new System.Drawing.Point(9, 135);
            this.btn_deleteMaterials.Name = "btn_deleteMaterials";
            this.btn_deleteMaterials.Size = new System.Drawing.Size(229, 45);
            this.btn_deleteMaterials.TabIndex = 63;
            this.btn_deleteMaterials.Text = "Списать";
            this.btn_deleteMaterials.UseVisualStyleBackColor = false;
            // 
            // lvl_orderNumberValue
            // 
            this.lvl_orderNumberValue.AutoSize = true;
            this.lvl_orderNumberValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_orderNumberValue.Location = new System.Drawing.Point(90, 26);
            this.lvl_orderNumberValue.Name = "lvl_orderNumberValue";
            this.lvl_orderNumberValue.Size = new System.Drawing.Size(148, 35);
            this.lvl_orderNumberValue.TabIndex = 62;
            this.lvl_orderNumberValue.Text = "lvl_orderNumberValue";
            // 
            // lvl_sumValue
            // 
            this.lvl_sumValue.AutoSize = true;
            this.lvl_sumValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_sumValue.Location = new System.Drawing.Point(147, 61);
            this.lvl_sumValue.Name = "lvl_sumValue";
            this.lvl_sumValue.Size = new System.Drawing.Size(91, 35);
            this.lvl_sumValue.TabIndex = 62;
            this.lvl_sumValue.Text = "lvl_sumValue";
            // 
            // lvl_sum
            // 
            this.lvl_sum.AutoSize = true;
            this.lvl_sum.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_sum.Location = new System.Drawing.Point(3, 61);
            this.lvl_sum.Name = "lvl_sum";
            this.lvl_sum.Size = new System.Drawing.Size(138, 35);
            this.lvl_sum.TabIndex = 61;
            this.lvl_sum.Text = "Списание на сумму: ";
            // 
            // lvl_orderNumber
            // 
            this.lvl_orderNumber.AutoSize = true;
            this.lvl_orderNumber.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_orderNumber.Location = new System.Drawing.Point(3, 26);
            this.lvl_orderNumber.Name = "lvl_orderNumber";
            this.lvl_orderNumber.Size = new System.Drawing.Size(94, 35);
            this.lvl_orderNumber.TabIndex = 60;
            this.lvl_orderNumber.Text = "Заказ номер:";
            // 
            // form_deleteMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1043, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.dgridView_materialsDelete);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_back);
            this.Name = "form_deleteMaterials";
            this.Text = "form_deleteMaterials";
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_materialsDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgridView_materialsDelete;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lvl_sumValue;
        private System.Windows.Forms.Label lvl_sum;
        private System.Windows.Forms.Label lvl_orderNumber;
        private System.Windows.Forms.Button btn_deleteMaterials;
        private System.Windows.Forms.Label lvl_orderNumberValue;
    }
}