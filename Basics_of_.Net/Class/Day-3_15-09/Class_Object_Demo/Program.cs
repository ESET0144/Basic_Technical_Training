namespace Class_Object_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student first = new student(1, "Uday", "01/01/2020", "abc@gmail.com");
            first.showDisplay();
            first.initialize();
            first.student_name = "Raj";


            Console.WriteLine("Hello, World!");
        }
    }
}
