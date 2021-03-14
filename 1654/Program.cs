using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1654
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<char> listInput = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {

                if (listInput.Count > 0 && input[i] == listInput.Last())
                {
                    listInput.RemoveAt(listInput.Count - 1);
                }
                else listInput.Add(input[i]);
            }

            foreach (var item in listInput)
            {
                Console.Write(item);
            }

            Console.ReadLine();


        }
    }
}
