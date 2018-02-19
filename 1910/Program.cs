using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1910
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] db = new int[n];
            for (int i = 0; i < n; i++)
            {
                db[i] = int.Parse(input.Split()[i]);
            }
            int summ = -1, k = 0;
            for (int i = 0; i < n - 2; i++)
            {
                int f = db[i] + db[i + 1] + db[i + 2];
                if(f>summ) { summ = f; k = i + 2; }
            }
            Console.Write(summ + " " + k);
           // Console.ReadLine();
            
        }
    }
}
