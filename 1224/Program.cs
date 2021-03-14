using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1224
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            long res = 0;
            if (n > m) res = m + m - 1;
            else res =(n-1)*2;
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
