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
    public partial class form_manager : Form
    {
        public form_manager()
        {
            InitializeComponent();
        }


        private void btn_showFormMaterials_Click(object sender, EventArgs e)
        {
            form_materials form_materials = new form_materials();
            this.Hide();
            form_materials.ShowDialog();
            this.Show();
           // this.
        }

        private void btn_showFormConstruct_Click(object sender, EventArgs e)
        {
            form_construct form_construct = new form_construct();
            this.Hide();
            form_construct.ShowDialog();
            this.Show();
        }

        private void btn_showFormSpecfic_Click(object sender, EventArgs e)
        {
            form_specificItems form_specificItems = new form_specificItems();
            this.Hide();
            form_specificItems.ShowDialog();
            this.Show();
        }

        private void btn_showFormDeleteMaterials_Click(object sender, EventArgs e)
        {
            form_deleteMaterials form_deleteMaterials = new form_deleteMaterials();
            //form_deleteMaterials.Hide();
            this.Hide();
            form_deleteMaterials.ShowDialog();
            this.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}
