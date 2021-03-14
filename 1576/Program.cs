using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1576
{
    class Program
    {
        static public int Gen(string time)
        {
            int rez = 0;
            int h = int.Parse(time.Split(':')[0]);
            int m = int.Parse(time.Split(':')[1]);
            if ((h == 0) && (m < 6)) rez = 0;

            return rez;
        }



        static void Main(string[] args)
        {
            int a1, a2, a3;//абонентская плата
            int c1, c2;//плата за минуту
            int f2;//количество бесплатных минут

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

            }
        }
    }
}
