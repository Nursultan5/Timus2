using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1893
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char a = input[input.Length-1];
            int b = int.Parse(input.Substring(0, input.Length - 1));

            if (b < 3)
            {
                if (a == 'A' | a == 'D') Console.WriteLine("window");
                else Console.WriteLine("aisle");
            }
            else if (b < 21)
            {
                if (a == 'A' | a == 'F') Console.WriteLine("window");
                else Console.WriteLine("aisle");
            }
            else
            {
                if (a == 'A' | a == 'K') Console.WriteLine("window");
                else if (a == 'C' | a == 'D' | a == 'G' | a == 'H') Console.WriteLine("aisle");
                else Console.WriteLine("neither");

            }

            //Console.ReadLine();

        }
    }
}
