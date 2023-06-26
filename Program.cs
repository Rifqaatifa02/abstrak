using Abstrak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrak
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new Laserjett();

            epson.merek = "Epson";
            epson.dimension = "10 x 11";
            canon.merek = "Canon";
            canon.dimension = "9.5 x 12";
            laserjet.merek = "LaserJet";
            laserjet.dimension = "12 x 12";

            Console.WriteLine("Beberapa printer yang online");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("\nPilih printer : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
            {
                epson.print();
                epson.show();
            }
            else if (pilih == 2)
            {
                canon.print();
                canon.show();
            }
            else if (pilih == 3)
            {
                laserjet.print();
                laserjet.show();
            }
            else
                Console.WriteLine("Printer {0} tidak tersedia", pilih);

            Console.ReadKey();
        }
    }
}