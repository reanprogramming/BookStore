using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Class
{
    class variables
    {
        public static string p_username_focus = "Enter user name";
        public static string p_userpassword_focus = "Enter password";


        public static string p_Connection = string.Empty;
        public static SqlConnection p_con = new SqlConnection();

    }
}
