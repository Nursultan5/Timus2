using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1496
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, bool> dic = new Dictionary<string, bool>();

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                if (dic.ContainsKey(key))
                {
                    bool isWrited = dic[key];
                    if (!isWrited) Console.WriteLine(key);
                    isWrited = true;
                    dic[key] = isWrited;
                }
                else
                {
                    dic.Add(key, false);
                }
            }

        }
    }
}
