using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ver1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Tkachenko Lena IS-73\n");
            System.Console.Write("Start.\n");

            Console.WriteLine("\n");
            SmartSystem system = new SmartSystem();
            Console.WriteLine("\n");
            SmartSystem system1 = new SmartSystem(" "," "," ",0," ",0," ",0," "," "," "," "," ",0,0,0," "," "," "," ");
            Console.WriteLine("\n");
            SmartSystem system2 = new SmartSystem(system1);
            Console.WriteLine("\n");

            Console.WriteLine("Finish");
            Console.ReadLine();
        }
}
        }
