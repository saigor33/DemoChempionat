using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace myTest_app
{
    public partial class form_registration : Form
    {
        public form_registration()
        {
            InitializeComponent();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            string login ="";
            string password = "";
            string telephone = "";

            string sql_query = "select *  from users where users_login='"+ tbx_login.Text + "';";
            DataSet data = databaseConnect.select_dbAllTable(sql_query, "users");
            showMessage(data.Tables[0].Rows.Count.ToString());
            if (data.Tables[0].Rows.Count==0)
            {
                login = tbx_login.Text;
            }
            else
            {
                showMessage("Пользователь с таким логином уже зарегистрирован. Придумайте другой логин.");
                return;
            }
            Regex rgxPassword = new Regex("(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^.])(?=.{6,})"); //){6,}([!]{1,})
            if (tbx_password.Text == tbx_passwordTwo.Text)
            {
                if (rgxPassword.IsMatch(tbx_password.Text))
                {
                    password = tbx_password.Text;
                }
                else
                {
                    showMessage("Пароль не удовливторяет условиям надёжности. \nПароль должен состоять из: \n" +
                        " Минимум 6 символов \n Минимум 1 прописная буква  \n Минимум 1 цифра  \n" +
                             " Минимум один символ из набора: ! @ # $ % ^. ");
                    return;
                }
              
            }
            else
            {
                showMessage("Пароли не совпадают. Повторите ввод.");
                return;
            }
            Regex rgxTelephone = new Regex("[1-9]");
            if (rgxTelephone.IsMatch(tbx_telephone.Text))
            {
                telephone = tbx_telephone.Text;
            }
            else
            {
                showMessage("Телефон введён не верно. Повторите попытку");
                return;
            }

            sql_query = "insert into users (users_login, users_password, users_post, users_contactTelephone) value('" +
                login + "','"+password+"','Заказчик','"+telephone+"');";
            int countInsert = databaseConnect.insert_data(sql_query);
            if (countInsert ==1)
            {
                showMessage("Вы успешно зарегистрировались. Используйте форму авторизации для входа в систему");
            }
            else
            {
                showMessage("Зарегистрироваться не удалось. Попробуйте позже.");
                return;
            }
            //вывод сообщения об успешной регистрации. 
            this.Close();
        }
        public void showMessage(string str)
        {
            MessageBox.Show(str);
        }
    }
}
