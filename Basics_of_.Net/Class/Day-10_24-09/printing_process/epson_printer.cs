using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing_process
{
    internal class epson_printer : Iprint_interface
    {
        public void print()
        {
            Console.WriteLine("It's printing from epson printer");
        }

    }
}
