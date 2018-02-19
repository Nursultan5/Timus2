using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1785
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 5) Console.WriteLine("few");
            else if (n < 10) Console.WriteLine("several");
            else if (n < 20) Console.WriteLine("pack");
            else if (n < 50) Console.WriteLine("lots");
            else if (n < 100) Console.WriteLine("horde");
            else if (n < 250) Console.WriteLine("throng");
            else if (n < 500) Console.WriteLine("swarm");
            else if (n < 1000) Console.WriteLine("zounds");
            else  Console.WriteLine("legion");
        }
    }
}
