using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrak
{
     public class printers : Printer
    {
        public override void print()
        {
            Console.WriteLine("\n{0} Printer Printing...", merk);
        }

        public override void show()
        {
            if (merk == "Epson")
            {
                dimension = "10*11";
            }
            else if (merk == "Canon")
            {
                dimension = "9.5*12";
            }
            else
            {
                dimension = "12*12";
            }
            Console.WriteLine("{0} printer display dimension : {1}", merk, dimension);

        }
    }
}
