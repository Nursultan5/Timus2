using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> slz = new List<string>();
            List<string> hfl = new List<string>();
            List<string> grf = new List<string>();
            List<string> rvc = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i< n; i++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                if (b == "Gryffindor") grf.Add(a);
                if (b == "Hufflepuff") hfl.Add(a);
                if (b == "Slytherin") slz.Add(a);
                if (b == "Ravenclaw") rvc.Add(a);
            }

            Console.WriteLine("Slytherin:");
            foreach (string s in slz) Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("Hufflepuff:");
            foreach (string s in hfl) Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("Gryffindor:");
            foreach (string s in grf) Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("Ravenclaw:");
            foreach (string s in rvc) Console.WriteLine(s);
           
        }
    }
}
