using System;
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
    public partial class form_résidusItems : Form
    {
        public form_résidusItems()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void form_résidusItems_Load(object sender, EventArgs e)
        {
            lvl_postValue.Text = userData.userPost;


        }
    }
}
