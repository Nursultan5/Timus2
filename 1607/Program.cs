using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1607
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            short a = short.Parse(input[0]);
            short b = short.Parse(input[1]);
            short c = short.Parse(input[2]);
            short d = short.Parse(input[3]);

            if (a >=c) Console.WriteLine(a);
            else
            {
                while (true)
                {
                    if (a + b < c) a += b; else { Console.WriteLine(c); break; }
                    if (a >= c) { Console.WriteLine(a); break; }
                    else
                    {
                        if (c - d > a) c -= d; else { Console.WriteLine(a); break; }
                        if (c <= a) { Console.WriteLine(a); break; }
                    }
                  //  if (a > c) { Console.WriteLine(a); flag = true; }
                }
                
            }
           // Console.ReadLine();
        }
    }
}
