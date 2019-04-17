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
            this.btn_update = new System.Windows.Forms.Button();
            this.panel_delete = new System.Windows.Forms.Panel();
            this.btn_deleteMaterials = new System.Windows.Forms.Button();
            this.lvl_actNumber = new System.Windows.Forms.Label();
            this.lvl_sumValue = new System.Windows.Forms.Label();
            this.lvl_sum = new System.Windows.Forms.Label();
            this.lvl_orderNumber = new System.Windows.Forms.Label();
            this.cbox_statusDelete = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_materialsDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_delete.SuspendLayout();
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
            this.dgridView_materialsDelete.Location = new System.Drawing.Point(138, 93);
            this.dgridView_materialsDelete.Name = "dgridView_materialsDelete";
            this.dgridView_materialsDelete.ReadOnly = true;
            this.dgridView_materialsDelete.Size = new System.Drawing.Size(634, 351);
            this.dgridView_materialsDelete.TabIndex = 57;
            this.dgridView_materialsDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridView_materialsDelete_CellContentClick);
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(12, 67);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(116, 377);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 58;
            this.picBox_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.panel_delete);
            this.panel1.Controls.Add(this.cbox_statusDelete);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Location = new System.Drawing.Point(778, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 347);
            this.panel1.TabIndex = 59;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_update.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(54, 91);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(121, 41);
            this.btn_update.TabIndex = 61;
            this.btn_update.Text = "Обновить данные";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel_delete
            // 
            this.panel_delete.Controls.Add(this.btn_deleteMaterials);
            this.panel_delete.Controls.Add(this.lvl_actNumber);
            this.panel_delete.Controls.Add(this.lvl_sumValue);
            this.panel_delete.Controls.Add(this.lvl_sum);
            this.panel_delete.Controls.Add(this.lvl_orderNumber);
            this.panel_delete.Location = new System.Drawing.Point(3, 138);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(247, 182);
            this.panel_delete.TabIndex = 66;
            // 
            // btn_deleteMaterials
            // 
            this.btn_deleteMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_deleteMaterials.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deleteMaterials.Location = new System.Drawing.Point(12, 123);
            this.btn_deleteMaterials.Name = "btn_deleteMaterials";
            this.btn_deleteMaterials.Size = new System.Drawing.Size(229, 45);
            this.btn_deleteMaterials.TabIndex = 68;
            this.btn_deleteMaterials.Text = "Списать";
            this.btn_deleteMaterials.UseVisualStyleBackColor = false;
            this.btn_deleteMaterials.Click += new System.EventHandler(this.btn_deleteMaterials_Click);
            // 
            // lvl_actNumber
            // 
            this.lvl_actNumber.AutoSize = true;
            this.lvl_actNumber.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_actNumber.Location = new System.Drawing.Point(93, 14);
            this.lvl_actNumber.Name = "lvl_actNumber";
            this.lvl_actNumber.Size = new System.Drawing.Size(148, 35);
            this.lvl_actNumber.TabIndex = 66;
            this.lvl_actNumber.Text = "lvl_orderNumberValue";
            // 
            // lvl_sumValue
            // 
            this.lvl_sumValue.AutoSize = true;
            this.lvl_sumValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_sumValue.Location = new System.Drawing.Point(150, 49);
            this.lvl_sumValue.Name = "lvl_sumValue";
            this.lvl_sumValue.Size = new System.Drawing.Size(91, 35);
            this.lvl_sumValue.TabIndex = 67;
            this.lvl_sumValue.Text = "lvl_sumValue";
            // 
            // lvl_sum
            // 
            this.lvl_sum.AutoSize = true;
            this.lvl_sum.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_sum.Location = new System.Drawing.Point(6, 49);
            this.lvl_sum.Name = "lvl_sum";
            this.lvl_sum.Size = new System.Drawing.Size(138, 35);
            this.lvl_sum.TabIndex = 65;
            this.lvl_sum.Text = "Списание на сумму: ";
            // 
            // lvl_orderNumber
            // 
            this.lvl_orderNumber.AutoSize = true;
            this.lvl_orderNumber.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_orderNumber.Location = new System.Drawing.Point(29, 14);
            this.lvl_orderNumber.Name = "lvl_orderNumber";
            this.lvl_orderNumber.Size = new System.Drawing.Size(58, 35);
            this.lvl_orderNumber.TabIndex = 64;
            this.lvl_orderNumber.Text = "Акт №";
            // 
            // cbox_statusDelete
            // 
            this.cbox_statusDelete.AutoCompleteCustomSource.AddRange(new string[] {
            "Все",
            "Списанные ",
            "Не списанные"});
            this.cbox_statusDelete.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbox_statusDelete.FormattingEnabled = true;
            this.cbox_statusDelete.Items.AddRange(new object[] {
            "Все",
            "Списанные",
            "Не списанные"});
            this.cbox_statusDelete.Location = new System.Drawing.Point(49, 42);
            this.cbox_statusDelete.Name = "cbox_statusDelete";
            this.cbox_statusDelete.Size = new System.Drawing.Size(166, 43);
            this.cbox_statusDelete.TabIndex = 64;
            this.cbox_statusDelete.Text = "Все";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_type.Location = new System.Drawing.Point(4, 4);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(171, 35);
            this.lbl_type.TabIndex = 65;
            this.lbl_type.Text = "Отобразить материалы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(381, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 60;
            this.label1.Text = "СПИСАНИЕ МАТЕРИАЛОВ";
            // 
            // form_deleteMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1043, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.dgridView_materialsDelete);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_back);
            this.Name = "form_deleteMaterials";
            this.Text = "Списание материалов";
            this.Load += new System.EventHandler(this.form_deleteMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_materialsDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_delete.ResumeLayout(false);
            this.panel_delete.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_delete;
        private System.Windows.Forms.Button btn_deleteMaterials;
        private System.Windows.Forms.Label lvl_actNumber;
        private System.Windows.Forms.Label lvl_sumValue;
        private System.Windows.Forms.Label lvl_sum;
        private System.Windows.Forms.Label lvl_orderNumber;
        private System.Windows.Forms.ComboBox cbox_statusDelete;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_update;
    }
}