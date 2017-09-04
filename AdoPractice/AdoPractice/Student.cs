using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoPractice
{
   public class Student
    {
        public SqlHelper sqlHelper;
        public string sqlQuery;
        public Student()
        {
            sqlHelper = new SqlHelper();
        }
        public void getData()
        {  //{
            sqlQuery = "select * from [Table]";
            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);

            while (sqlReader.Read())
            {
                //Console.WriteLine("count of rows is{0}", sqlReader[0]);
               Console.WriteLine(string.Format("roll no {0}\t name {1}\t marks {2}\t", sqlReader[0], sqlReader[1], sqlReader[2]));
            }
            sqlReader.Close();
            //sqlQuery = "select * from [Table]";
            //var sqlReader = sqlHelper.ExecuteScalar(sqlQuery);
            //Console.WriteLine("roll no  ", sqlReader);
        }
        public void SaveData()
        {
            Console.WriteLine("enter roll no");
            string rno = Console.ReadLine();
            sqlQuery = string.Format(@"insert into [Table] values ({0},'{1}',{2},'{3}')",rno,"ankush",102,"123456");
            var result = sqlHelper.ExecuteNonquery(sqlQuery);
            Console.WriteLine(result);
        }
        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt = sqlHelper.getDataSet(sqlQuery);
            foreach(DataRow d in dt.Rows)
            {

                Console.WriteLine(string.Format("roll no {0}\t name {1}\t marks {2}\t", d[0].ToString(), d[1].ToString(), d[2].ToString()));
            }

            dt.WriteXml("student.xls");
        }
        public void updateData()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            sqlQuery =string.Format( @"update [Table] set Stud_name='{0}' where Stud_name='{1}'",name,"amara");
           var result= sqlHelper.update(sqlQuery);
            Console.WriteLine(result);
        }
        public void delete()
        {
            Console.WriteLine("enter the roll no to be deleted");
        }
    }
}
