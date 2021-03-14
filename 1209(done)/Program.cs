using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1209_done_
{
    class Program
    {
        static StringBuilder a = new StringBuilder();
      
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
                CheckForZero(UInt64.Parse(Console.ReadLine()));

            }
            Console.Write(a);
		
		}

		private static void CheckForZero(UInt64 v)
		{
            UInt64 controlValue = 8 * v - 7;
            if (IsPerferctSquare(controlValue)) a.Append("1 ");
            else a.Append("0 ");

            
		}

        public static bool IsPerferctSquare(UInt64 number)
        {
            return (Math.Sqrt(number) % 1 == 0);
        }
    }
}
