﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myTest_app
{
    public partial class form_director : Form
    {
        //userData userData;
        public form_director()
        {
           
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_director_Load(object sender, EventArgs e)
        {
            lvl_postValue.Text = userData.userPost;
        }
        public void showMessage(string str)
        {
            MessageBox.Show(str);
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_showFormDeleteMaterials_Click(object sender, EventArgs e)
        {
            form_deleteMaterials form_deleteMaterials = new form_deleteMaterials();
            this.Hide();
            form_deleteMaterials.ShowDialog();
            this.Show();
        }

        private void btn_showFormMaterials_Click(object sender, EventArgs e)
        {
            form_materials form_materials = new form_materials();
            this.Hide();
            form_materials.ShowDialog();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_showOrders_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_construct form_construct = new form_construct();
            this.Hide();
            form_construct.ShowDialog();
            this.Show();
        }
    }
}
