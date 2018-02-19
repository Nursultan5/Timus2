using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1991
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0, w = 0;
            string input = Console.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int k = int.Parse(input.Split()[1]);
            input = Console.ReadLine();
            int[] a = new int[n];
            string[] db = input.Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(db[i]);
                if (k > a[i]) q += (k - a[i]);
                else w += (a[i] - k);
            }
           
            Console.WriteLine(w + " " + q);
           // Console.ReadLine();
        }
    }
}
