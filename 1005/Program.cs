using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bd = new int[n];
            int amount = 0; int diff = 0;
            string[] sbd = Console.ReadLine().Split();
            for (int i = 0; i < bd.Length; i++)
            {
                bd[i] = int.Parse(sbd[i]);
                amount += bd[i];
            }


            

            int left = 0, right = 0;

           

            Console.WriteLine(Math.Abs(right - left));


            Console.ReadLine();

        }
    }
}
