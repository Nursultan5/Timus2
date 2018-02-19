using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1636
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            int a = int.Parse(input.Split()[0]);
            int b = int.Parse(input.Split()[1]);
            input = Console.ReadLine();
            string[] db = input.Split();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count += int.Parse(db[i])*20;
            }
            b -= count;
            if (a <= b) Console.WriteLine("No chance.");
            else Console.WriteLine("Dirty debug :(");
           // Console.ReadLine();


        }
    }
}
