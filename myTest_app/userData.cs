using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest_app
{
    public static class userData
    {
 
        private static string login;
        private static string post;

        public const string POST_DIRECTOR = "Директор";
        public const string POST_MANAGER = "Манаджер";
        public const string POST_CLIENT = "Заказчик";
        public const string POST_RESIDESITEM = "Кладовщик";

        public static String userLogin
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public static String userPost
        {
            get
            {
                return post;
            }
            set
            {
                post = value;
            }
        }
        /*  public userData()
          {

          }*/
    }
}
