using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1581
{
    class Program
    {

        static void Main(string[] args)
        {
            // int n = int.Parse(Console.ReadLine());
            // string s = Console.ReadLine();

            string s = "";

            for (int i = 0; i < 1; i++) s += "1 ";
            
            for (int i = 0; i < 1; i++) s += "4 ";
            for (int i = 0; i < 1; i++) s += "5 ";

            s += "6";

            string[] a = s.Split();
            Console.WriteLine(s);
            s = "";
            int count = 1;
            if (a.Length == 1)
            {
                Console.Write("1 " + a[0]);
            }

            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == a[i + 1])

                    if ((i+1) != a.Length -1) count++;
                    else { count++; s += count.ToString() + " " + a[i].ToString() + " "; break; }

                else
                {
                    if ((i+1) != a.Length-1 ) { s = s + count.ToString() + " " + a[i].ToString() + " "; count = 1; }
                    else { s += 1 + " " + a[a.Length - 1].ToString() + " "; break; }
                }

            }

            Console.WriteLine(s);
            Console.WriteLine("re");
            Console.ReadLine();
        }
    }
}
