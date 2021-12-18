using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据库原理课设
{
    internal class Mytools
    {
        public SqlConnection Connection()
        {
            string str = "Data Source=LIUYIXUAN-13932\\SQLEXPRESS;Initial Catalog=design;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open(); //打开数据库连接
            return sc;
        }


        public SqlCommand command(string sql)
        {
            SqlCommand sc = new SqlCommand(sql, Connection());
            return sc;
        }

        //用于 delete update insert 语句
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //用于select 语句
        public SqlDataReader select(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}