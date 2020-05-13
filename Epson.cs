using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism2595;

namespace Polymorphism2595
{
    public class Epson : IPrinterWindows
    {
        public void print()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public void show()
        {
            Console.WriteLine("Epson printer printing . . . .");
        }
    }
}
