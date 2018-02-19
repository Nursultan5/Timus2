using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a1 = int.Parse( input.Split()[0]);
            int b1 = int.Parse(input.Split()[1]);

            string input1 = Console.ReadLine();
            int a2 = int.Parse(input1.Split()[0]);
            int b2 = int.Parse(input1.Split()[1]);

            string input2 = Console.ReadLine();
            int a3 = int.Parse(input2.Split()[0]);
            int b3 = int.Parse(input2.Split()[1]);

            int af=0, bf=0;

            bf = b1 - b2;
            af = a1 - a3;
            Console.WriteLine(af + " " + bf);

        }
    }
}
