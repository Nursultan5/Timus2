using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2100
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
               if(temp.Length>4) temp = temp.Substring(temp.Length - 4, 4);
                count++;
                if (temp == "+one") count++;
            }
            if (count == 13) count++;
            count = count * 100;
            Console.Write(count);

            
           
        }
    }
}
