using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1196
{
    class Program
    {
        static void BinarySearch_Iter(int[] array, int key, ref int rez)
        {
            int left = 0;
            int right = array.Length;
            int mid = 0;

            while (!(left >= right))
            {
                mid = left + (right - left) / 2;

                if (array[mid] == key)
                    rez++;

                if (array[mid] > key)
                    right = mid;
                else
                    left = mid + 1;
            }

            
        }
        static void Main(string[] args)
        {
            int rez = 0;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] b = new int[m];
            for (int i = 0; i < m; i++) b[i] = int.Parse(Console.ReadLine());

            a.Distinct();
            Array.Sort(b);
           
            for(int i = 0; i < b.Length; i++)
            {
                BinarySearch_Iter(a, b[i], ref rez);
            }
            Console.WriteLine(rez);
           // Console.ReadLine();
        }
    }
}
