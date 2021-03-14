using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1327
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int res = (b - a) / 2;
            if (b % 2 == 1 || a%2==1) res++;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
