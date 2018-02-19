using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace temp
{
    class Program
    {
        static void Slag(string strPrefix, int iSummatorMax, int iLeft, int iRight)
        {
            string strPrefix0 = string.Concat((string.IsNullOrEmpty(strPrefix) ? "" : strPrefix + "+"), iLeft.ToString());
            Console.WriteLine(string.Concat(strPrefix0, "+", iRight.ToString()));

            iSummatorMax = Math.Max(iLeft, iSummatorMax);
            if (iRight > iSummatorMax)
            {
                for (int i = 1; i <= iRight / 2; i++)
                {
                    if (i >= iSummatorMax)
                        Slag(strPrefix0, iSummatorMax, i, iRight - i);
                }
            }
        }
        static void Slag0(int iRepeat, int iDepth, int iLeft, int iRight)
        {
            for (int i = 0; i < iDepth - 1; i++)
                Console.Write("{0}+", iRepeat);
            Console.Write("{0}+{1}", iLeft, iRight);
            Console.WriteLine();

            iRepeat = Math.Max(iLeft, iRepeat);
            if (iRight > iRepeat)
            {
                for (int i = 1; i <= iRight / 2; i++)
                {
                    if (i >= iRepeat)
                        Slag0(iRepeat, iDepth + 1, i, iRight - i);
                }
            }
        }


        static void Main(string[] args)
        {
            int iX = 7;
            int iSummatorMax = 0;
            Console.WriteLine("X={0}", iX.ToString());
            for (int i = 1; i <= iX / 2; i++)
            {
                string strPrefix0 = "";
                Slag(strPrefix0, iSummatorMax, i, iX - i);
            }
            Console.WriteLine();
            Console.WriteLine("X={0}", iX.ToString());
            for (int i = 1; i <= iX / 2; i++)
            {
                Slag0(i, 1, i, iX - i);
            }
            Console.ReadLine();
        }

        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
            Console.WriteLine("Факториал числа {0} равен {1}", x, result);
            Thread.Sleep(300);
        }
    }
}
