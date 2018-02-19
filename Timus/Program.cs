using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            int[] db = new int[9];
            db[0] = a + b + c;
            db[1] = a + b - c;
            db[2] = a + b * c;
            db[3] = a - b + c;
            db[4] = a - b - c;
            db[5] = a - b * c;
            db[6] = a * b + c;
            db[7] = a * b - c;
            db[8] = a * b * c;
            Array.Sort(db);
            Console.WriteLine(db[0]);
           

            

        }
    }
}
