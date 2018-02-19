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
            input = "1" + input;

            Stack<char> db1 = new Stack<char>();
            Stack<char> db2 = new Stack<char>();

            db2.Push('1');
            foreach (char t in input.ToCharArray())
            {
                db1.Push(t);
            }
            while (db1.Count > 1)
            {
                char t = db1.Pop();
                db2.Push(t);
                char a = db1.Peek();
                char b = db2.Peek();
                if (a == b)
                {
                    db1.Pop();db2.Pop();db1.Push(db2.Pop());
                }
                db2.Push(db1.Pop());

            }
            // db2.Push(db1.Pop());
            int ts = db2.Count;
            for (int i = 0; i <ts; i++)
            {
                Console.Write( db2.Pop());
            }
            
            
            Console.ReadLine();

        }
    }
}
