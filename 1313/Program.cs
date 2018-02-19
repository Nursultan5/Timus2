using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] db = new int[n,n];
            for(int i=0;i< n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++) db[i, j] = int.Parse(input.Split()[j]);
            }
            int[] fb = new int[n * n];
            int count = 0; int chet = 0;
            while (count < n + n)
            {
                for (int i=0;i< n; i++)
                {
                    for (int j=0;j< n; j++)
                    {
                        if (i + j == count) { fb[chet] = db[j, i]; chet++; }
                    }
                }
                count++;
            }

            foreach (int aaa in fb) Console.Write(aaa + " ");
            //Console.ReadLine();
        }
    }
}
