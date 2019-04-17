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
    public partial class form_ordersList : Form
    {
        public form_ordersList()
        {
            InitializeComponent();
        }

        private void form_ordersList_Load(object sender, EventArgs e)
        {
            lvl_postValue.Text = userData.userPost;
        }
    }
}
