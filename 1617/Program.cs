using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1617
{
    class Program
    {
        public static void sorting(ref int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;

            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(ref arr, first, j);
            if (i < last) sorting(ref arr, i, last);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] db = new int[n];
            for (int i = 0; i < n; i++)
            {
                db[i] = int.Parse(Console.ReadLine());
            }
            sorting(ref db, 0, db.Length - 1);

            int count = 0; byte temp = 1;

            for (int i = 0; i < db.Length - 1; i++)
            {

                if (db[i] == db[i + 1]) temp++;

                if (db[i] != db[i + 1]) { count += temp / 4; temp = 1;  }
            }
            if (db.Length >= 3)    if (db[db.Length - 2] == db[db.Length - 1]) count += temp / 4;
                Console.WriteLine(count);
               // Console.ReadLine();
            
        }
    }
}
