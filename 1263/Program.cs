using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1263
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split()[0]);
            int m = int.Parse(input.Split()[1]);
            int[] a = new int[m];
            for (int i=0;i< m; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(a);
            int[] fn = new int[n];
            int count = 0;
            for (int j = 1; j <= n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (a[i] == j) count++; 
                }
                fn[j-1] = count; count = 0;
            }
            foreach (int i in fn) Console.WriteLine("{0:0.00%}",(double)i / m );
            Console.ReadLine();
        }
    }
}
