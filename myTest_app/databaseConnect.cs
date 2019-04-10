using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace myTest_app
{
    public static class databaseConnect
    {
       private static string str_dbConnect = "server=188.242.163.78;port=32769;user ID=demo02;Password=52zyXpt2;database=demo02;";
        //string webAppConnection_string = "server=mysql102.1gb.ru;user ID=gb_56525;Password=af5b8d8zc89a;database=gb_56525;";
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        

      /*  public MySqlDataReader select_db(string sql_query)
        {
            conn = new MySqlConnection(str_dbConnect);
            conn.Open();
           // string sql_query = "select * from items";

            cmd = new MySqlCommand(sql_query, conn);
            MySqlDataReader data_reader= null;
            try
            {
                data_reader = cmd.ExecuteReader();
                //  while (data_reader.Read())
                //  {
                return data_reader;

                //  }

            }
            catch
            {

                MessageBox.Show("Не удалось связаться с сервером. Повторите попытку позже.");

            }
            finally
            {
                conn.Close();
            }
            return data_reader;
        }
        */
        public static DataSet select_dbAllTable(string sql_query, string nameTable)
        {
           // string str_dbConnect = "server=188.242.163.78;port=32769;user ID=demo02;Password=52zyXpt2;database=demo02;";
            conn = new MySqlConnection(str_dbConnect);
            conn.Open();
            // DataGridView dtGridView= new DataGridView();
            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;

            MySqlDataAdapter masterDataAdapter = new MySqlDataAdapter(sql_query, conn);
            masterDataAdapter.Fill(data, nameTable);

           // BindingSource masterBindingSource = new BindingSource();
           // BindingSource dataBindingSource = new BindingSource();

            //masterBindingSource.DataSource = data;
           // masterBindingSource.DataMember = nameTable;

            // dataBindingSource.DataSource = masterBindingSource;

            //dtGridView.DataSource = masterBindingSource;
           
            conn.Close();
            return data;
        }


        public static int insert_data(string sql_query)
        {
            int countInsert = -1 ;
            conn = new MySqlConnection(str_dbConnect);
            conn.Open();
            cmd = new MySqlCommand(sql_query, conn);
            try
            {
                countInsert = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }

            return countInsert;
        }
    }
}
