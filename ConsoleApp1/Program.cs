using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum alpha
        {
            a=0,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z
        }
        static void Main(string[] args)
        {
            char[] shifrWord = Console.ReadLine().ToCharArray();
            int i = 1;
            int temp = (int)shifrWord[0] - 5;
            Console.Write((char)temp);
            while (i < shifrWord.Length)
            {

                //int temp = (int)shifrWord[i];
                i++;
            }

            
            Console.ReadLine();
        }
    }
}
