using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1837
{
    class Program
    {
        static public Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        static List<string> names = new List<string>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string isenbaev = "";
            for (byte i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                if (temp.Contains("Isenbaev")) isenbaev += " " + temp;
                else if (!names.Contains(temp)) names.Add(temp);
            }

            string[] isenb = isenbaev.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

           if(!string.IsNullOrEmpty(isenbaev)) keyValuePairs.Add("Isenbaev", 0);
            for (int i = 0; i < isenb.Length; i++)
            {
                if (isenb[i] != "Isenbaev" && !keyValuePairs.ContainsKey((isenb[i])))
                    keyValuePairs.Add(isenb[i], 1);
            }





            bool isGood = true;
            int num = 1;
            while (isGood)
            {
                isGood = Analysis(num++);
            }

            string temp2 = "";

            for (int i = 0; i < names.Count; i++)
            {
                temp2 += " " + names[i];
                names.RemoveAt(i);
                i--;
            }
            string[] arr = temp2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(arr[i]))
                    keyValuePairs.Add(arr[i], -1);
            }

            foreach (var item in keyValuePairs.OrderBy(key => key.Key))
            {
                string asd = item.Value == -1 ? "undefined" : item.Value.ToString();
                Console.WriteLine(item.Key + " " + asd);
            }




            Console.ReadLine();
        }

        static bool Analysis(int num)
        {
            bool res = true;
            if (num + 1 <= keyValuePairs.Count)
            {
                var item = keyValuePairs.ElementAt(num);
                string name = item.Key;
                int count = item.Value + 1;
                string temp = "";
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Contains(name))
                    {
                        temp += " " + names[i];
                        names.RemoveAt(i);
                        i--;
                    }

                }

                string[] arr = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                temp = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!keyValuePairs.ContainsKey(arr[i]))
                        keyValuePairs.Add(arr[i], count);
                }


            }
            else
            {
                res = false;
            }

            return res;
        }

    }


}
