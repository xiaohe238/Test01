using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    class DataOperator
    {
        private static string connString = @"Server=localhost;Database=db_MyQQ;Trusted_Connection=True;";
        public static SqlConnection connection = new SqlConnection(connString);
        //执行sql语句，返行第一行第一列
        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed) 
            connection.Open();
            int num = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return num;
        }
        //执行sql语句，返回受影响的行数
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed) 
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        //
        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            return ds;
        }
        //从数据库中获取信息
        public SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql,connection);
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();
            SqlDataReader datareader = command.ExecuteReader();
            return datareader;
        }
    }
}
