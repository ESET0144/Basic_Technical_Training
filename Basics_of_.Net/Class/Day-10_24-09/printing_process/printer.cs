using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing_process
{
    internal class printer: Iprint_interface
    {
        public void print()
        {
            Console.WriteLine("It's a print from printer class");
        }
    }
}
