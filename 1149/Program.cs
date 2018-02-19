using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1149
{
    class Program
    {
        static string A(int n)
        {
            // An = sin(1–sin(2+sin(3–sin(4+…sin(n))…)
            string rez = ""; bool flag = false;
            if (n == 1) return "sin(n)";
            else
            {
                string s = "sin(" + n + ")";
               
                    rez += s+A(n-1);
                
                return rez;
            }
        }
        static void Main(string[] args)
        {
            string s = A(3);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
