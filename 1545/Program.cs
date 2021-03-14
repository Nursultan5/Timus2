using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1545
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char>[] asd = new List<char>[26];//a - 97

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                int index = (int)data[0]-97;
                if (asd[index] == null) asd[index] = new List<char>();
                asd[index].Add(data[1]);

            }
            char asdd = Console.ReadLine()[0];
            int f = (int)asdd-97;

            foreach (var item in asd[f])
            {
                Console.WriteLine(asdd.ToString()+item.ToString());
            }


            Console.ReadLine();
        }
    }
}
