using BookStore.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            variables.p_Connection = "Server=JOINCODER-SV;User=sa;Password=love;Database=bookstore";
            variables.p_con.ConnectionString = variables.p_Connection;
            variables.p_con.Open();
            variables.p_con.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlogin());
        }
    }
}
