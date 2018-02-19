using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1001
{
    class Program
    {
       static public double sqrt(double n)
        {
            
            const double EPS = 1E-4;
            double x = 1;
            for (;;)
            {
                double nx = (x + n / x) / 2;
                if (Math.Abs(x - nx) < EPS) break;
                x = Math.Round( nx,4);
            }
            
            return x;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)//0-48. 9-57
        {
            string input ="d"+ Console.In.ReadToEnd();
            double s = 0;
            for (int i = input.Length - 1; i >= 1; --i)
            {
                int kode = (int)input[i];
                if ((kode <= 57) && (kode >= 48)) s=10* int.Parse(((char)input[i]).ToString()) +s ;
                else
                {
                    if (s!=0)
                    {
                        Console.WriteLine(sqrt(s));
                        s = 0;
                    }
                }
            }

            Console.ReadLine();
           
           
            
        }
    }
}
