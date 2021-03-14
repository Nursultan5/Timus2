using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1925
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int k = int.Parse(input.Split()[1]);
            int summn = k, summk = 0;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                summn += int.Parse(input.Split()[0]);
                summk += int.Parse(input.Split()[1]);
            }
            
                int rez = summn - (2 * (n + 1)) - summk;
            if (rez < 0) Console.WriteLine("Big Bang!");
            else Console.WriteLine(rez);

           // Console.ReadLine();

        }
    }
}
