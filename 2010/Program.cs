using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iopats = System.IO.Path;

namespace _2010
{
    class Program
    {
//        King: 8   король
//        Knight: 6 конь
//        Bishop: 9 слон
//        Rook: 14  ладья
//        Queen: 23 ферзь 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int x = int.Parse(input.Split()[0]);
            int y = int.Parse(input.Split()[1]);
            King(n, x, y);
            Console.ReadLine();

        }

       static public void King(int n, int x, int y)
        {
           
            int count = 8;
            if ((x == 1) | (x == n)) count -= 3;
            if ((y == 1) | (y == n)) count -= 3;
            Console.WriteLine("King: " + count);
        }
        static public void Knight(int n, int x,int y)
        {

        }
    }
}
