using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoPractice
{
    public class SqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public string sqlQuery = null;
        public SqlDataAdapter sqlAdapter;
        public string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False";
        public SqlHelper()
        {
            sqlConnection = new SqlConnection(conString);

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
                Console.WriteLine("connection open");
            }
        }
            public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection;
            return sqlCommand.ExecuteReader();
        }
        public string ExecuteScalar(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            return sqlCommand.ExecuteScalar().ToString();

        }
        public bool ExecuteNonquery(string sql)
        {
            var result = false;
            sqlCommand = new SqlCommand(sql, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }
        public DataTable getDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            sqlAdapter = new SqlDataAdapter(sqlQuery, conString);
            sqlAdapter.Fill(ds,"student");
            return ds.Tables[0];
        }
        public bool update(string sqlQuery)
        {
            //var ds = new DataSet();
            //sqlAdapter = new SqlDataAdapter(sqlQuery, conString);
            //SqlCommandBuilder sb = new SqlCommandBuilder(sqlAdapter);
            //sqlAdapter.Fill(ds, "student1");
            //DataTable dt = ds.Tables[0];
            ////dt.Rows[0][0] = rno;
            ////dt.Rows[0][1] = name;
            //sqlAdapter.Update(dt);
            var result = false;
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;

        }
   
        }
    }

