using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            int[] db1;
            int[] db2;
       
            int n = int.Parse(Console.ReadLine());
            int[] temp = new int[n];

            db1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                db1[i] = int.Parse(Console.ReadLine());
                temp[i] = 10000 - db1[i];
                
            }
            int m = int.Parse(Console.ReadLine());
            db2 = new int[m];
            for (int i = 0; i < m; i++)
            {
                db2[i] = int.Parse(Console.ReadLine());
                
            }

            IEnumerable<int> aa = db2;
            IEnumerable<int> ab = temp;
            IEnumerable<int> cc = aa.Intersect(ab);
            if (cc.Count<int>() > 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
           
           // Console.ReadLine();

        }
    }
}
