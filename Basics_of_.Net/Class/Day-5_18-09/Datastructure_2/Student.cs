using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_2
{
    internal class Student
    {
        public int id;
        public int marks;
        public string name;

        public Student(int id, string name, int marks) // parameterized constructor
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }

        public Student() // default constructor
        {

        }
    }
}
