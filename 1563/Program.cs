using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1563
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = new string[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                string temp = Console.ReadLine();
                for (int j = 0; j <= i-1; j++)
                    if (data[j] == temp) { flag = true; break; }
                if (flag) count++; else data[i] = temp;

            }
            Console.WriteLine(count);
            //Console.ReadLine();
        }
    }
}
