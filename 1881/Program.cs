using System;
using System.Collections;
using System.Collections.Generic;

namespace _1881
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = 0, b = 0;
            int h = int.Parse(s.Split()[0]);//количество строк
            int w = int.Parse(s.Split()[1]);//количество символов в строке
            int n = int.Parse(s.Split()[2]);//количество слов
            double counth = 0; int countw = 0;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                int length = Console.ReadLine().Length;
                temp += length;//вписываем слово в строку
                if (temp < w) temp++;//если есть место вставляем пробел, тк он 100% будет
                if (temp >= w)
                {
                    countw++;
                    if (temp == w) temp = 0;
                    else temp = length + 1;
                }
            }
            if (temp != 0) countw++;//если осталась последняя строка
            counth = (Math.Ceiling( (double)countw/h));
            Console.WriteLine(counth);
           
            
           // Console.ReadLine();

        }
    }
}
