using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_demo
{
    internal class Student
    {
        public int student_id;
        public Dictionary<string, int> student_marks;
        public string student_name;

        public Student(int student_id, string student_name, Dictionary<string, int> student_marks) // parameterized constructor
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.student_marks = student_marks;
        }

        public Student() // default constructor
        {

        }
    }

}
