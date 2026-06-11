using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Class
{
    class sqlexcute
    {
        SqlCommand p_cmd;
        public DataTable getData(string vSql)
        {
            DataTable dt = new DataTable();
            using (p_cmd=new SqlCommand(vSql, variables.p_con))
            {
                if (variables.p_con.State == ConnectionState.Closed)
                {
                    variables.p_con.Open();
                }
                p_cmd.CommandTimeout = 99999999;
                dt.Load(p_cmd.ExecuteReader());
                variables.p_con.Close();
            }
           return dt;
        }

        public DataTable proc_getData(string vproc_name,string[] param)
        {
            DataTable dt = new DataTable();
            string str = vproc_name + " ";
            for(int i=0; i < param.Length; i++)
            {
                str = str + "N'" + param[i] + "',";
            }
            str = str.Substring(0,str.Length-1);
            using (p_cmd = new SqlCommand(str, variables.p_con))
            {
                if (variables.p_con.State == ConnectionState.Closed)
                {
                    variables.p_con.Open();
                }
                p_cmd.CommandTimeout = 99999999;
                dt.Load(p_cmd.ExecuteReader());
                variables.p_con.Close();
            }
            return dt;
        }

    }
}
