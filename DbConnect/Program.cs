using System.Data.SqlClient;
using DbConnect;
using System.Configuration;

class Program : ConfigurationSection
{
    public static void Main(string[] args)
    {
        // Console.WriteLine(ConfigurationManager.AppSettings["num1"]);
        //Console.WriteLine(ConfigurationManager.AppSettings["num2"]);
        DB db = new DB();
        db.OpenConnection();
        //db.CreateTable();
        //db.InsertTable();
        //db.UpdateTable();
        //db.ReadTable();
        db.DeleteTable();





    }
}
