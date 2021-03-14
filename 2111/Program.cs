using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] strArr = Console.ReadLine().Split(' ');
            long s = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(strArr[i]);
                s += temp;
                a[i] = temp;
            }


            Array.Sort(a);
            long res = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                res += s * a[i];
                s -= a[i];
                res += s * a[i];
            }


            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
