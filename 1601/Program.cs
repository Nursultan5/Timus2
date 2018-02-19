using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1601
{
    class Program
    {
        public static bool check(char a)
        {
            bool flag = false;
            if ((a == '!') || (a == '.') || (a == '?')) flag = true;
            return flag; 
        }
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToLower().ToCharArray();
            s[0] =Convert.ToChar( s[0].ToString().ToUpper());
            for (int i=1;i< s.Length-1;i++)
            {
                if ((s[i].ToString()==".")&&(s[i+1].ToString()==" ")) s[i+2] = Convert.ToChar(s[i+2].ToString().ToUpper());
            }
            
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
