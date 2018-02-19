using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint q=0;
            string input = Console.ReadLine();
            long a =long.Parse( input.Split()[0]);
            long b =long.Parse( input.Split()[1]);
           
            if (a <= b) Console.WriteLine("1");
            else
            {
                long k = 1;
                while (a > 0)
                {
                    a =a- k;
                    if ((k < b)&& (k<<1>0)) k = k * 2;
                    else  k = b;
                    q++;
                }
            }
            Console.WriteLine(q);
           //Console.ReadLine();
        }
    }
}
