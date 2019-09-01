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
    public partial class form_deleteMaterials : Form
    {
        int numerikRowSelect = -1;
        string idDeleteMaterials;

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

        private void form_deleteMaterials_Load(object sender, EventArgs e)
        {
            lvl_postValue.Text = userData.userPost;
            btn_update_Click(this, new EventArgs());
        }
        public void showMessage(string str)
        {
            MessageBox.Show(str);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql_statusDel = "where deleteRulons_status =";
            switch (cbox_statusDelete.Text)
            {
                case "Все":
                    {
                        MessageBox.Show("Все");
                        sql_statusDel = "";
                        panel_delete.Visible = false;
                        break;
                    }
                case "Списаные":
                    {
                        sql_statusDel += "'Списано'";
                        //panel_delete.Visible = true;
                        break;
                    }
                case "Не списаные":
                    {
                        sql_statusDel += "'Не списано'";
                        //panel_delete.Visible = false;
                        break;
                    }
                default:
                    {
                        showMessage("В поле выбора статуса списания присутсвуют посторонние символы");
                        sql_statusDel = "";
                        return;
                    }
            }
            string sql_query = "select deleteRulons_id as '№ Акта', rulons_composition as Название ,useRulon_pointers as Размер, deleteRulons_status Статус" +
                " from delete_rulons d_r inner join rulons r on d_r.deleteRulons_idRulons = r.rulons_id and d_r.deleteRulons_idSpecific = r.rulons_idSpecific " +
                    sql_statusDel + ";";

            DataSet data = databaseConnect.select_dbAllTable(sql_query, "delete_rulons");
            dgridView_materialsDelete.DataSource = data;
           // dgridView_materialsDelete.RowHeadersVisible = false;

        }

        private void btn_deleteMaterials_Click(object sender, EventArgs e)
        {
            if (numerikRowSelect !=-1 && (dgridView_materialsDelete["Статус", numerikRowSelect].Value.ToString() == "Не списано"))
            {
                string sql_query = "update delete_rulons d_r set deleteRulons_status='Списано' where deleteRulons_id=" + idDeleteMaterials+";";
                //добавить сумму списания в бд
                int countUpdateRow = databaseConnect.update_data(sql_query);
                if (countUpdateRow !=-1)
                {
                    if (countUpdateRow !=0)
                    {
                        showMessage("Материалы списаны");
                    }
                    else
                    {
                        showMessage("Материалы не списаны");
                    }
                }
            }
            else
            {
                showMessage("Вы не вырали материал для списания или данный материал уже был списан");
                return;
            }
            /// databaseConnect.insert_data(sql_query);

        }

        private void dgridView_materialsDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numerikRowSelect = e.RowIndex;
            idDeleteMaterials = dgridView_materialsDelete[0, numerikRowSelect].Value.ToString();
            lvl_actNumber.Text = idDeleteMaterials; 
            //Добавить:
                //Расчёт площади ткани по точкам
                //Расчёт суммы списания
                //вывод суммы
                
        }

        private void cbox_statusDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 
}
