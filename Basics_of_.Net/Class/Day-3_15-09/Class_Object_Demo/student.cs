using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Demo
{
    internal class student
    {
        private int student_id;
        public string student_name;
        private string DOB;
        string emailid;


        public student() // default constructor to manage null object of student
        {

        }
        public student(int student_id, string student_name, string dOB, string emailid) // parameterized constructor
        {
            this.student_id = student_id;
            this.student_name = student_name;
            DOB = dOB;
            this.emailid = emailid;
        }

        public void initialize()
        {
            student_id = 10;
            student_name = "Uday";
        }
        public void showDisplay()
        {
            Console.WriteLine("Display Object L");
            Console.WriteLine(student_name);
        }
        public void Avg_marks()
        {

        }

        public void Avg_age()
        {

        }

        public void Avg_height()
        {

        }
    }
}