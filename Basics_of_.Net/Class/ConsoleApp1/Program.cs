using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Class1 c = new Class1
            {
                Name = "Uday",
                Age = 23
                
            };

            Console.WriteLine($"Your name is {c.Name}, age is {c.Age}");
        }
    }
}
