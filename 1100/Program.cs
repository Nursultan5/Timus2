using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100
{


    class Program
    {

        static void Main(string[] args)
        {


            doit2();

            //Console.ReadLine();
        }
        static public void doit2()
        {
            List<string>[] asd = new List<string>[101];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string f = Console.ReadLine();
                byte count = byte.Parse(f.Split(' ')[1]);
                if (asd[count] == null) asd[count] = new List<string>();
                asd[count].Add(f);
                //if (i % 300 == 0) GC.Collect();

            }

            for (int i = 100; i >= 0; i--)
            {
                if (asd[i] != null)
                    foreach (var item in asd[i])
                    {
                        Console.WriteLine(item);
                    }
            }
        }
       


    }
}
