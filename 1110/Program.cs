using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _1110
{
    class Program
    {
        public static void Gen(int n, int m, int y)
        {
            bool flag = false;
            List<int> rez = new List<int>();
            int st = 0;
            
            for (int i = 0; i < m; i++)
            {
                
                    BigInteger b = 1; BigInteger a = (BigInteger)(i % m);
                    for (int j = 0; j < n; j++)
                    {
                        b *= a;
                    }
                    b = b % (BigInteger)m;
                    if (b ==gfg (BigInteger)) { rez.Add(i); flag = true; }
                
            }
            String s = "";

            if (flag)
            {
                int[] qwe = rez.ToArray();
                Array.Sort(qwe);
                foreach (var item in qwe)
                {
                    Console.Write(item + " ");
                }
              
            }
           else Console.Write("-1");
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s.Split()[0]);
            int m = int.Parse(s.Split()[1]);
            int y = int.Parse(s.Split()[2]);

            for (int i = 0; i < m; i++)
            {

            }



            Console.ReadLine();
        }
    }
}
