//namespace ADO
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}

using System;
using System.Data.SqlClient;
namespace TestDBMSConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Getting Connection ...");

            var datasource = @"LAPTOP-TDSQ0O3D"; // your server
            var database = "dotnet_d1"; // your database name
            //var username = "DESKTOP-LCNNVH9\\kk"; // username of server to connect
            //var password = ""; // password

            // Create your connection string
            string connString = @"Data Source=" + datasource +
                ";Initial Catalog=" + database + "; Trusted_Connection=True;";


            Console.WriteLine(connString);

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection successful!");
                InsertStaff(conn);
                displayStaff(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
        static void InsertStaff(SqlConnection conn)
        {
            Console.Write("Enter the Staff Name...");

            string myname = "7, 'Otto', 'Veg'";
            string querry = "insert into food_table values (" +myname+ ")";
            SqlCommand cm = new SqlCommand(querry, conn);
            //cm.Parameters.AddWithValue("@name", myname);
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Inseted record successfully");
            }


        }
        static void displayStaff(SqlConnection conn)
        {
            string query = "select * from food_table";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader reader = cm.ExecuteReader();
            Console.WriteLine("Staff :");
            while (reader.Read())
            {
                {
                    Console.WriteLine($"Name :{reader["Name"]}");

                }
            }
        }
    }
}


