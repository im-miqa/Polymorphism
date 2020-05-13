using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism2595;

namespace Polymorphism2595
{
    public class Canon : IPrinterWindows
    {
        public void print()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public void show()
        {
            Console.WriteLine("Canon printer printing . . . .");
        }
    }
}
