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
    public partial class form_orders : Form
    {
        public form_orders()
        {
            InitializeComponent();
        }

        private void lbl_count_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
         //   form_login form_login = (form_login)Application.OpenForms["form_login"];
         //   form_login.Show();
            this.Close();
        }

        private void btn_entery_Click(object sender, EventArgs e)
        {
            Show_message("Заказ отправлен");
        }
        private void Show_message(string str_output)
        {
            
            MessageBox.Show(str_output);
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
