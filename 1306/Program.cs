using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1306
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bd = new int[n];
            for (int i = 0; i < n; i++) bd[i] = int.Parse(Console.ReadLine());
            Array.Sort(bd);
            double rez = 0;
            if (n % 2 == 1) rez = bd[n / 2 + 1];
            else { double t = (bd[n / 2] + bd[n / 2 + 1]) / 2.0;
                rez = Math.Round(t, 1); }
            Console.WriteLine(rez);
            Console.ReadLine();
        }
    }
}
