namespace Datastructure_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student(10, "Uday", 52);
            Student S2 = new Student(20, "Mano", 34);
            Student S3 = new Student(30, "Dev", 56);

            List<Student> student_list = new List<Student>();

            student_list.Add(S1);
            student_list.Add(S2);
            student_list.Add(S3);

            //Console.WriteLine(student_list);

            Console.WriteLine("S1     S2      S3");

            foreach (Student student in student_list)
            {
                
                Console.Write(student.student_id + "   ");
                Console.Write(student.student_name + "   ");
                Console.Write(student.student_marks + "   ");
                Console.WriteLine("\n");

            }



            //Console.WriteLine("Enter S1 ID :");
            //S1.student_id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter S1 Name:");
            //S1.student_name = Console.ReadLine();
            //Console.WriteLine("Enter Marks in list form");
            //S1.student_marks = Convert.ToList(Console.ReadLine());
            // store and display student class - list retrieve and display of student objects - 3


        }
    }
}
