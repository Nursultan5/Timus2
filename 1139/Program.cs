using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1139
{
    class Program
    {
        public static int gcd_1(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd_1(b, a % b);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
             int n = int.Parse(input.Split()[0])-1;
             int m = int.Parse(input.Split()[1])-1;
            int rez =m+n-gcd_1(n, m);
            

            Console.WriteLine(rez);
            
          // Console.ReadLine();
        }
    }
}
