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
            //userData = new userData();
            // MessageBox.Show(userData.userPost);
            lvl_postValue.Text = userData.userPost;
        }
    }
}
