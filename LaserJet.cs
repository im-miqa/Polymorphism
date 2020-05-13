using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism2595;

namespace Polymorphism2595
{
    public class LaserJet : IPrinterWindows
    {
        public void print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public void show()
        {
            Console.WriteLine("LaserJet printer printing . . . .");
        }
    }
}
