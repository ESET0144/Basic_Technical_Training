using System.Data.SqlClient;
using System;


string connStr = "Server=.; Database=MyDb; Trusted_connection= True;";
using (var conn = new Sqlconnection(connStr))
{
    conn.Open();
    using (var cmd = conn.CreateCommand())
}

public class MeterReading
{
    public int ID { get; set; }
    public decimal mtrreading { get; set; }
    public int Time { get; set; }


}



class Program
{
    static void Main()
    {
        int age = 20;
        double pi = 3.14;
        decimal percent = 99.93;
        string name = "uday";
        bool isActive = true;

        Console.WriteLine($"Name= {name}, Age = {age}, percent = {percent}");

        int j = 0;
        while (j < 4)
        {
            Console.WriteLine($"While j is {j}");
        }


        string[] fruits = { "Apple", "Banana", "Mango" };
        foreach (string f in fruits)
        {
            Console.WriteLine(f);
        }

        
    }



}