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
    public partial class form_materials : Form
    {
        public form_materials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_résidusItems form_résidusItems = new form_résidusItems();
            form_résidusItems.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_materials_Load(object sender, EventArgs e)
        {
            lvl_postValue.Text = userData.userPost;
            string sql_query = "select rulons_composition as Состав, rulons_color as Цвет, rulons_width as Ширина," +
                "rulons_lenght as Длинна, rulons_count as Кол-во рулонов, rulons_price as Цена за 1шт from rulons";

            dgridView_rulons.DataSource = databaseConnect.select_dbAllTable(sql_query, "rulons");
            dgridView_rulons.RowHeadersVisible = false;

            sql_query = "select items_name as Название, rulons_composition as Состав, items_width as Ширина, items_lenght as Длинна" +
                "items_count as Кол-во, items_price as Цена за 1 шт. from items i inner join materialsInstruction m_i on i.items_idMaterials=m_i.materialsInstruction_id " +
                "inner join rulons r on r.rulons_id = m_i.materialsInstruction_rulonsId and r.rulons_idSpecific = m_i.materialsInstruction_rulonsIdSpecific";

            dgridView_rulons.DataSource = databaseConnect.select_dbAllTable(sql_query, "items");
            dgridView_rulons.RowHeadersVisible = false;

        }
    }
}
