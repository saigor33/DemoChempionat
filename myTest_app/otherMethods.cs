using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace myTest_app
{
    public class otherMethods
    {
       /* public otherMethods()
        {
        
        }*/

        public void showMessage(string str)
        {
            MessageBox.Show(str);
        }

        public static bool test_password(string pass)
        {
            Regex rgxPassword = new Regex("(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^.])(?=.{6,})"); //){6,}([!]{1,})
            //MessageBox.Show(rgxPassword.IsMatch(pass).ToString());
            return rgxPassword.IsMatch(pass);
        }

    }
}
