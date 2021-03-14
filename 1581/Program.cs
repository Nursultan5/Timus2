using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1581
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numString = Console.ReadLine()+" -1";
            int[] numArray = numString.Split(' ').Select(x => int.Parse(x)).ToArray();
            List<int> resultArr = new List<int>();

            int count = 1;
            for (int i = 0; i < numArray.Length-1; i++)
            {
                if (numArray[i] == numArray[i + 1]) 
                    count++;
                else
                {
                    resultArr.Add(count);
                    resultArr.Add(numArray[i]);
                    count = 1;
                }
            }

            foreach (var item in resultArr)
            {
                Console.Write(item+" ");
            }


            //Console.ReadLine();
        }
    }
}
