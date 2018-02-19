using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1502
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) s += Console.ReadLine();

            
            Console.WriteLine(s.GroupBy(c => c).OrderByDescending(g => g.Count()).First().Key);
            //Console.ReadKey();
        }
    }
}
