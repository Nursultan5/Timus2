using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1639
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int m = int.Parse(input.Split()[0]);
            int n = int.Parse(input.Split()[1]);
            int c = m * n;
            if (c % 2 == 0) Console.WriteLine("[:=[first]");
            else Console.WriteLine("[second]=:]");
        }
    }
}
