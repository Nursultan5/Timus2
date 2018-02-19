using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1820_done_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse( input.Split()[0]);
            int k = int.Parse(input.Split()[1]);
            double rez = 0;
            if (n <= k) rez = 2;
            else {
                if (n % k == 0) rez = n / k * 2;
                else
                {
                    double q = (double)2*n / k;
                    /*if ((q == 1) & ((n-k)>k/2)) rez = 4;
                    if ((q == 1) & ((n - k) <= k / 2)) rez = 3;
                    if ((q != 1) & ((n - k) <= k / 2)) rez = 2 * q + 3;
                    if ((q != 1) & ((n - k) > k / 2)) rez = 2 * q + 4;*/
                    rez = Math.Ceiling(q);
                }
            }
            Console.WriteLine(rez);
           // Console.ReadLine();
        }
    }
}
