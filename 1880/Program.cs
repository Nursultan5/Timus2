using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1880
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input1 = Console.ReadLine().Split();

            int m = int.Parse(Console.ReadLine());
            string[] input2 = Console.ReadLine().Split();

            int k = int.Parse(Console.ReadLine());
            string[] input3 = Console.ReadLine().Split();
            
            
            List<string> rez = new List<string>();
            if((n<=m)&(n<=k))
            for (int i = 0; i < n; i++)
            {
                if ((input2.Contains(input1[i])) && ((input3.Contains(input1[i])))) rez.Add(input1[i]); 
            }
            else if ((m <= n) & (m <= k))
                for (int i = 0; i < m; i++)
                {
                    if ((input1.Contains(input2[i])) && ((input3.Contains(input2[i])))) rez.Add(input1[i]);
                }
            else if ((k <= m) & (k <= n))
                for (int i = 0; i < k; i++)
                {
                    if ((input2.Contains(input3[i])) && ((input1.Contains(input3[i])))) rez.Add(input1[i]);
                }
            Console.WriteLine(rez.Count());
            

        }
    }
}
