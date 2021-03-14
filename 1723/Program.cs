using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1723
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[26];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
            
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int index = (byte)input[i] - 97;
                a[index]++;
            }

            int maxi = 0; int max = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i]; maxi = i;
                }
            }

            Console.WriteLine((char)(maxi+97));
            Console.ReadLine();


        }
    }
}
