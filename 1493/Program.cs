using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1493
{
    class Program
    {
        static public bool chd(string input)
        {
            bool rez = false;
            int n = int.Parse(input[0].ToString()) + int.Parse(input[1].ToString()) + int.Parse(input[2].ToString());
            int m = int.Parse(input[3].ToString()) + int.Parse(input[4].ToString()) + int.Parse(input[5].ToString());
            if (n == m) rez = true;
            return rez;
        }
        static public bool check(string input)
        {
            bool rez = false;
            int n = int.Parse(input);
            int a = n + 1;int b = n - 1;
            string aa = a.ToString();
            string bb = b.ToString();
            int k = 6 - aa.Length;
            for (int i = 0; i < k; i++) aa = "0" + aa;
            k = 6 - bb.Length;
            for (int i = 0; i < k; i++) bb = "0" + bb;
            if ((chd(aa) || (chd(bb)))) rez = true;
            return rez;

        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if ((input == "999999") || (input == "000001")) Console.WriteLine("No");
            else
            {
                if (check(input)) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
          //  Console.ReadLine();
        }
    }
}
