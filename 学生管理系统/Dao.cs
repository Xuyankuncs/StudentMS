using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace 学生管理系统
{
    internal class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-CDQG3OT3;Initial Catalog=StudentMS;Integrated Security=True";//连接数据库
            sc = new SqlConnection(str);//创建连接对象
            sc.Open();//打开数据库
            return sc;//返回连接对象
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//更新
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取
        {
            return command(sql).ExecuteReader();
        }
        public void LJClose()//关闭连接
        {
            sc.Close();
        }
    }
}
