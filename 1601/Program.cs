using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1601
{
    class Program
    {
        public static bool checkForLetter(char a)
        {
            bool flag = false;
            if (a >= 97 && a <= 122 || (a >= 65 && a <= 90)) flag = true;
            return flag;
        }
        public static bool checkForBigLetter(char a)
        {
            bool flag = false;
            if (a >= 65 && a <= 90) flag = true;
            return flag;
        }

        public static bool checkForSmallLetter(char a)
        {
            bool flag = false;
            if (a >= 97 && a <= 122) flag = true;
            return flag;
        }
        static void Main(string[] args)
        {
            bool flagUp = true;

            char[] s = Console.ReadLine().ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (checkForBigLetter(s[i]) && flagUp) flagUp = false;
                else if (checkForBigLetter(s[i]) && !flagUp) { flagUp = false; s[i] = (char)(s[i] + 32); }

                else if (checkForSmallLetter(s[i]) && flagUp)
                {
                    flagUp = false;
                    s[i] = (char)(s[i] - 32);
                }
                else if (s[i] == '.' || s[i] == '!' || s[i] == '?')
                {
                    flagUp = true;

                }

            }

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
