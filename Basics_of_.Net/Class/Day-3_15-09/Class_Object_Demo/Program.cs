namespace Class_Object_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student first = new student();
            first.showDisplay();
            first.initialize();
            first.student_name = "Raj";


            Console.WriteLine("Hello, World!");
        }
    }
}
