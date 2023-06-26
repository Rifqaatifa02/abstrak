using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrak
{
    public class Canon : Printer
    {
        public override void print()
        {
            Console.WriteLine("\n{0} Printer Printing...", merek);
        }

        public override void show()
        {
            Console.WriteLine("{0} printer display dimension : {1}", merek, dimension);
        }
    }
}
