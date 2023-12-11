using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Two_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;

            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("-------------------Swapped--------------------");
            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            Console.ReadLine();

        }
    }
}
