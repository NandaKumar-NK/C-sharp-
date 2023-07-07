using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbConnect
{
    internal class DB
    {
        SqlConnection conn;

       
        public void OpenConnection()
        {
            conn = new SqlConnection(@"data source = LAPTOP-KR3SF32I\SQLEXPRESS; " +
            "database=Student;" +
            "integrated security=SSPI");
            try
            {
                conn.Open();
                Console.WriteLine("Opened");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }


        public void CreateTable()
        {

            SqlCommand cmd = new SqlCommand("Create table student_details(rno int, name nvarchar(20))", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created");
            }

        }
        public void InsertTable()
        {
            SqlCommand cmd = new SqlCommand("Insert into  student_details values(200, 'mari')", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Values Inserted");
            }

        }
        public void UpdateTable()
        {
            SqlCommand cmd = new SqlCommand("update student_details set name='Spark' where rno=100", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Updated");
            }
        }


        public void ReadTable()
        {
            SqlCommand cmd = new SqlCommand("select * from student_details", conn);
            if (conn != null)
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                Console.WriteLine(sdr.HasRows);
                if (!sdr.HasRows)
                {
                    Console.WriteLine("Data set is Empty");
                }
                else
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["rno"] + " " + sdr["name"]);
                    }
                }
            }
        }
        public void DeleteTable()
        {
            SqlCommand cmd = new SqlCommand("delete student_details", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Rows get deleted");
            }
        }
        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                Console.WriteLine("Closed");
            }

        }
    }
}
//public void OpenConnection()
//        {
//            SqlConnection conn = new
//            SqlConnection("data source=LAPTOP-KR3SF32I\\SQLEXPRESS;" +
//            "database=student;" +
//            "integrated security=SSPI");
//            try
//            {
//                conn.Open();
//                Console.WriteLine("opened");
//            }
//            catch (SqlException ex)
//            { 
//                Console.WriteLine(ex.Message);
//                Console.WriteLine(ex.StackTrace);
//                Console.WriteLine("connection not established");
//            }

//        }
//        public void CreateTable()
//        {
//            SqlCommand cmd = new SqlCommand("Create table stud_detials(rollno int,name varchar(20) ) ", conn);
//            cmd.ExecuteNonQuery();
//            Console.WriteLine("Table Created");
//        }
//        public void insertValues()
//        {
//           SqlCommand cmd = new SqlCommand("insert into stud_details values((1,'nanda')", conn);
//            cmd.ExecuteNonQuery();
//            Console.WriteLine("Values inserted into table");
//        }
//        public void updateValues()
//        {
//            SqlCommand cmd = new SqlCommand("(update stud_details set name='abi' where rollno=1)",conn);
//            cmd.ExecuteNonQuery();
//            Console.WriteLine("Values updated into table");
//        }
//        public void deleteValues()
//        {
//            SqlCommand cmd = new SqlCommand("delete stud_details column name='abi' where rollno=1");
//            cmd.ExecuteNonQuery();
//            Console.WriteLine("should get deleted");
//            conn.Close();
//        }
//        public void ReadTable()
//        {
//            SqlCommand cmd = new SqlCommand("(select*from stud_details)");
//           SqlDataReader sdr= cmd.ExecuteReader();
//            Console.WriteLine(sdr.HasRows);
//            if(!sdr.HasRows )
//            {
//                Console.WriteLine("table is empty");
//            }
//            while (sdr.Read())
//            {
//                Console.WriteLine(sdr["rollno"]+" " + sdr["name"]);
                
                
//            }

//        }
//    }
//}
