using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1712
{
    class Program
    {
        public static void turn( ref bool[,] a)
        {
            bool[,] temp = a;
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[j, 3 - i] = temp[i, j];
                }
            }
            
        }
        static void Main(string[] args)
        {
            bool[,] lattice = new bool[4, 4];
            char[,] gen = new char[4, 4];
            for (int i = 0; i < 4; i++)
            {
                string temp = Console.ReadLine();

                for (int j = 0; j < 4; j++)
                {
                    if (temp[j] == '.') lattice[i,j] = false; else lattice[i,j] = true;
                }
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(lattice[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("SDFSDFSDFSDFSDFSD");
            turn(ref lattice);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(lattice[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
