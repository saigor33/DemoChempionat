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
    public partial class form_login : Form
    {
        //databaseConnect databaseConnect;
        public form_login()
        {
            InitializeComponent();
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_entery_Click(object sender, EventArgs e)
        {
            string sql_query = "select * from users where users_login='" + textBox_login.Text + "' and users_password='" + textBox_password.Text + "';";
            bool statusEntery = false;
            uint countStr = 0;
            DataSet data_query = new DataSet();
            data_query= databaseConnect.select_dbAllTable(sql_query, "users");
            if (data_query != null)
            {
                countStr = (uint)data_query.Tables[0].Rows.Count;
                //Если по запросу найдено одно совпадение, то пользователь входит в систему
                if (countStr == 1)
                {
                    //userData userData = new userData();
                    userData.userLogin = data_query.Tables[0].Rows[0]["users_login"].ToString();
                    userData.userPost = data_query.Tables[0].Rows[0]["users_post"].ToString();
                    MessageBox.Show(userData.userLogin + " " + userData.userPost);
                    this.Hide();
                    switch (userData.userPost)
                    {
                        case userData.POST_DIRECTOR:
                            {
                                form_director formDirector = new form_director();
                                formDirector.ShowDialog();
                                break;
                            }
                        case userData.POST_MANAGER:
                            {
                                form_manager formManager = new form_manager();
                                formManager.Show();
                                break;
                            }
                        case userData.POST_RESIDESITEM:
                            {
                                form_résidusItems formRésidusItems = new form_résidusItems();
                                formRésidusItems.ShowDialog();
                                break;
                            }
                        case userData.POST_CLIENT:
                            {
                                form_priseList formPriseList = new form_priseList();
                                formPriseList.ShowDialog();
                                
                                break;
                            }
                    }

                    try
                    {
                        this.Show();
                    }
                    catch
                    {
                        // MessageBox.Show("eror");
                    }

                }
                else
                {
                    showMessage("Вы ввели неправильный логин или пароль.Повторите попытку.");
                }
            }
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            form_registration form_registration = new form_registration();
            this.Hide();
            form_registration.ShowDialog();
            this.Show();
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        public void showMessage(string str)
        {
            MessageBox.Show(str);
        }
    }
}
