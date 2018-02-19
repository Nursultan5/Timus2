
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1409
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s.Split()[0]);
            int b = int.Parse(s.Split()[1]);
            int c = b - 1;
            int d = a - 1;
            Console.WriteLine(c + " " + d);
           // Console.ReadLine();
        }
    }
}
