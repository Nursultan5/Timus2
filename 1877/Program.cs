using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1877
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            if (c1 % 2 == 0 || c2 % 2 != 0)
                Console.WriteLine("yes");
            else if (c1 % 2 != 0 || c2 % 2 == 0)
                Console.WriteLine("no");

            //Console.ReadKey();
        }
    }
}
