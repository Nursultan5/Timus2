using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1876
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0; 
            string s = Console.ReadLine();
            int a = int.Parse(s.Split()[0]);
            int b = int.Parse(s.Split()[1]);


            if (a <= b) 
                result = 78 + 39 + (b - 40) * 2 + 2 + 1;

            else 
                result = 78 + 40 + (a - 40) * 2 + 1;



            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
