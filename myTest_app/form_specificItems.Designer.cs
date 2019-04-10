namespace myTest_app
{
    partial class form_specificItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_specificItems));
            this.lvl_postValue = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.tab_ = new System.Windows.Forms.TabControl();
            this.tab_Specific = new System.Windows.Forms.TabPage();
            this.dgridView_materialsInstruction = new System.Windows.Forms.DataGridView();
            this.tab_historySpecific = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.tab_.SuspendLayout();
            this.tab_Specific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_materialsInstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // lvl_postValue
            // 
            this.lvl_postValue.AutoSize = true;
            this.lvl_postValue.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_postValue.Location = new System.Drawing.Point(674, 10);
            this.lvl_postValue.Name = "lvl_postValue";
            this.lvl_postValue.Size = new System.Drawing.Size(78, 35);
            this.lvl_postValue.TabIndex = 51;
            this.lvl_postValue.Text = "Менеджер";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_post.Location = new System.Drawing.Point(581, 10);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(104, 35);
            this.lbl_post.TabIndex = 50;
            this.lbl_post.Text = "Вы вошли как: ";
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btn_out.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_out.Location = new System.Drawing.Point(784, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(143, 34);
            this.btn_out.TabIndex = 49;
            this.btn_out.Text = "Выйти из аккаунта";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btn_back.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(24, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 45);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "<-Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(24, 63);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(121, 364);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 52;
            this.picBox_logo.TabStop = false;
            // 
            // tab_
            // 
            this.tab_.Controls.Add(this.tab_Specific);
            this.tab_.Controls.Add(this.tab_historySpecific);
            this.tab_.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_.Location = new System.Drawing.Point(170, 48);
            this.tab_.Name = "tab_";
            this.tab_.SelectedIndex = 0;
            this.tab_.Size = new System.Drawing.Size(765, 427);
            this.tab_.TabIndex = 53;
            // 
            // tab_Specific
            // 
            this.tab_Specific.Controls.Add(this.dgridView_materialsInstruction);
            this.tab_Specific.Location = new System.Drawing.Point(4, 44);
            this.tab_Specific.Name = "tab_Specific";
            this.tab_Specific.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Specific.Size = new System.Drawing.Size(757, 379);
            this.tab_Specific.TabIndex = 0;
            this.tab_Specific.Text = "Текущие спецификации";
            this.tab_Specific.UseVisualStyleBackColor = true;
            // 
            // dgridView_materialsInstruction
            // 
            this.dgridView_materialsInstruction.AllowUserToAddRows = false;
            this.dgridView_materialsInstruction.AllowUserToDeleteRows = false;
            this.dgridView_materialsInstruction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.dgridView_materialsInstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView_materialsInstruction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dgridView_materialsInstruction.Location = new System.Drawing.Point(15, 6);
            this.dgridView_materialsInstruction.Name = "dgridView_materialsInstruction";
            this.dgridView_materialsInstruction.ReadOnly = true;
            this.dgridView_materialsInstruction.Size = new System.Drawing.Size(736, 364);
            this.dgridView_materialsInstruction.TabIndex = 55;
            // 
            // tab_historySpecific
            // 
            this.tab_historySpecific.Location = new System.Drawing.Point(4, 44);
            this.tab_historySpecific.Name = "tab_historySpecific";
            this.tab_historySpecific.Padding = new System.Windows.Forms.Padding(3);
            this.tab_historySpecific.Size = new System.Drawing.Size(757, 379);
            this.tab_historySpecific.TabIndex = 1;
            this.tab_historySpecific.Text = "История изменения спецификаций";
            this.tab_historySpecific.UseVisualStyleBackColor = true;
            // 
            // form_specificItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.tab_);
            this.Controls.Add(this.picBox_logo);
            this.Controls.Add(this.lvl_postValue);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_back);
            this.Name = "form_specificItems";
            this.Text = "Спецификация изготовления изделий";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.tab_.ResumeLayout(false);
            this.tab_Specific.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridView_materialsInstruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lvl_postValue;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.TabControl tab_;
        private System.Windows.Forms.TabPage tab_Specific;
        private System.Windows.Forms.DataGridView dgridView_materialsInstruction;
        private System.Windows.Forms.TabPage tab_historySpecific;
    }
}