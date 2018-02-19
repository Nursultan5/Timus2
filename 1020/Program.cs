using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020
{
    class Program
    {
       static public double len(double a, double b, double c, double r)
        {
            double res = 0;
            res = Math.Abs(Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow((r - b), 2)));
            return res;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split()[0]);
            double r = double.Parse(input.Split()[1]);
            string[] db = new string[n];
            for (int i = 0; i < n; i++) db[i] = Console.ReadLine();
            double res = 0;
            for (int i=0;i<n;i++)
            {
                if (i < n - 1)
                {
                    double a = double.Parse(db[i].Split()[0]);
                    double b = double.Parse(db[i].Split()[1]);
                    double c = double.Parse(db[i + 1].Split()[0]);
                    double d = double.Parse(db[i + 1].Split()[1]);
                    res += len(a, b, c, d);
                }
                else
                {
                    double a = double.Parse(db[n-1].Split()[0]);
                    double b = double.Parse(db[n-1].Split()[1]);
                    double c = double.Parse(db[0].Split()[0]);
                    double d = double.Parse(db[0].Split()[1]);
                    res += len(a, b, c, d);
                }
            }
            res += 2 * Math.PI * r;
            res = Math.Round(res, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine(res);
            //Console.ReadLine();
        }
    }
}
