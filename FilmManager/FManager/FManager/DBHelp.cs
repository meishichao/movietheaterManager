using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FManager
{
    public  class DBHelp
    {
        //使用读配置文件的方式从配置文件中读取连续字符串
        string conStr = ConfigurationManager.ConnectionStrings["sqlConStr"].ToString();
        //用来执行查询命令,并返回一个DataTable
        public DataTable GetTableBySql(string sql)
        {
            //声明一个连接对象
            SqlConnection conn = new SqlConnection(conStr);
            //声明一个适配器对象
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //声明一个表格对象
            DataTable table = new DataTable();
            //执行命令填充表格
            da.Fill(table);
            return table;
        }
        //用来执行增删改操作，并返回一个影响行数
        public int ExecuteIDUBySql(string sql)
        {
            //声明一个连接对象
            SqlConnection conn = new SqlConnection(conStr);
            //声明一个命令对象
            SqlCommand comm = new SqlCommand(sql, conn);
            //打开连接
            conn.Open();
            //执行命令
            int count = comm.ExecuteNonQuery();
            //关闭连接
            conn.Close();
            return count;

        }
    }
}
