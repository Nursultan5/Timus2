using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100
{
    class twist
    {
       public int a;
       public int b;
        public twist(int y, int u)
        {
            a = y;b = u;
        }
        public override string ToString()
        {
            return string.Format(a.ToString() + " " + b.ToString());
        }
         
        
    }
  
    class Program
    {
        static public int[] sort(twist[] input)
        {
            int[] a = new int[input.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = input[i].b;
            }
            Array.Sort(a);
            return a;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            twist[] a = new twist[n];
            for (int i=0;i< n; i++)
            {
                string r = Console.ReadLine();
                a[i] = new twist(int.Parse(r.Split()[0]), int.Parse(r.Split()[1]));
            }
            int[] temp = sort(a);
            string[] output = new string[a.Length];
            int count = 0;
            for (int i=0;i<a.Length;i++)
            {
                for(int j = a.Length-1; j >= 0; j--)
                {
                    if (a[j].b == temp[i])
                    {
                        output[count] = a[j].ToString();count++ ;a[j] = new twist(0, 0);break;
                    }
                }
            }
            for (int i = output.Length - 1; i >= 0; i--) Console.WriteLine(output[i]);

          
           // foreach (twist i in a) Console.WriteLine(i.ToString());
            //Console.ReadLine();
            


            
          
        }

       
    }
}
