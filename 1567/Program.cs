using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1567
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, byte> db = new Dictionary<char, byte>();
            db.Add('a', 1);
            db.Add('b', 2);
            db.Add('c', 3);
            db.Add('d', 1);
            db.Add('e', 2);
            db.Add('f', 3);
            db.Add('g', 1);
            db.Add('h', 2);
            db.Add('i', 3);
            db.Add('j', 1);
            db.Add('k', 2);
            db.Add('l', 3);
            db.Add('m', 1);
            db.Add('n', 2);
            db.Add('o', 3);
            db.Add('p', 1);
            db.Add('q', 2);
            db.Add('r', 3);
            db.Add('s', 1);
            db.Add('t', 2);
            db.Add('u', 3);
            db.Add('v', 1);
            db.Add('w', 2);
            db.Add('x', 3);
            db.Add('y', 1);
            db.Add('z', 2);
            db.Add('!', 3);
            db.Add('.', 1);
            db.Add(',', 2);
            db.Add(' ', 1);
            string s = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                k += db[s[i]];
            }
            Console.WriteLine(k);
            
         
        }
    }
}
