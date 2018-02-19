using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1924
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool flag = false;
            int summ = 1;
            if (n == 1) Console.WriteLine("grimy");
            else {
                for (int i = 2; i <= n; i++)
                {
                    if (!flag)
                    {
                        if ((summ + i) % 2 != 0) summ += i; else summ -= i;
                        flag = true;
                    }
                    if (!flag)
                    {
                        if ((summ + i) % 2 != 1) summ += i; else summ -= i;
                        flag = false;
                    }
                }
            }
            if (flag) Console.WriteLine("black"); else Console.WriteLine("grimy");
            Console.ReadLine();
        }
    }
}
