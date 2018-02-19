using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2073
{
    class triple
    {
        Char res;

    }
    class parser
    {
        public string name;
        public string date;
        public int zad;
        public int resh;
        public char[] rez = new char[13];
        public string[] temp;
        public parser(params string[] db)
        {
            temp = new string[db.Length - 3];
            name = db[0]; date = db[1]; zad = int.Parse(db[2].Split()[0]);
            resh = int.Parse(db[2].Split()[1]);int q = 0;
            for (int i = 3; i < db.Length; i++)
            {
                temp[q] = db[i];q++;
            }
        }
        public override string ToString()
        {
            string res="";
            res = name + Environment.NewLine + date + Environment.NewLine + zad.ToString() + " " + resh.ToString()+Environment.NewLine;
            for (int i = 0; i < temp.Length; i++)
            {
                if (i!=temp.Length-1)res += temp[i] + Environment.NewLine;
                else res += temp[i];
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("1.txt");
            int n = int.Parse(input[0]);//кол-во олимпиад
            parser[] a = new parser[n];
            
            Console.ReadLine();
        }
    }
}
