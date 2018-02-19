using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1787
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(input.Split()[0]);
            int n = int.Parse(input.Split()[1]);
            int[] db = new int[n];
           
            input = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                db[i] = int.Parse(input.Split()[i]);
                
            }
       
            for (int i=0;i< n-1; i++)
            {
                if (db[i] >= k)
                
                {
                    db[i + 1] = db[i + 1] + db[i] - k;
                    
                }
            }
            if (db[n - 1] <= k)

                Console.WriteLine(0);
            else Console.WriteLine(db[n - 1] - k);
    
          //  Console.ReadLine();

            

        }
    }
}
