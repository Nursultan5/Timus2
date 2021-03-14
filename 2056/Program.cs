using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2056
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            
            bool has3 = false;
            bool only5 = true;

            double srb = 0;
            for (int i = 0; i < n && !has3; i++)
            {
                byte valut = byte.Parse(Console.ReadLine());
                if (valut == 3) has3 = true;
                srb += valut;
                if (valut < 5) only5 = false;
            }

            if (has3) Console.WriteLine("None");
            else if (only5) Console.WriteLine("Named");
            else if (srb / n >= 4.5) Console.WriteLine("High");
            else Console.WriteLine("Common");

           // Console.ReadLine();
        }
    }
}
