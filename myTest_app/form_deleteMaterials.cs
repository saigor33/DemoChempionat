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
    public partial class form_deleteMaterials : Form
    {
        public form_deleteMaterials()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}