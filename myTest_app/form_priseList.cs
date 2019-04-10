using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myTest_app
{
    public partial class form_priseList : Form
    {
        public form_priseList()
        {
           
            InitializeComponent();
        }

        private void lbl_items_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {

                this.Close();
     
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void form_priseList_Load(object sender, EventArgs e)
        {
            string sql_query = "select items_name as Название,rulons_composition as Материял, items_price as Цена, items_width as Ширина, items_lenght as Длинна " +
                "from items as i inner join materialsInstruction as mInstr on i.items_idMaterials=mInstr.materialsInstruction_id" +
                    " inner join rulons  rul on rul.rulons_id = mInstr.materialsInstruction_rulonsId " +
                        "and mInstr.materialsInstruction_rulonsIdSpecific = rul.rulons_idSpecific;";

            //dataGridView_priceList.DataSource = databaseConnect.select_dbAllTable(sql_query, "items");
           // dataGridView_priceList.RowHeadersVisible = false;
           // MySqlDataReader db_data = databaseConnect.select_db();
           // if (db_data != null)
           // {
           /*  while (db_data.Read())
             {

             }*/
           // };
        }
    }
}
