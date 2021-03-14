using System;


namespace _1225
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ulong[] arr = new ulong[n];
           arr[0] = 2; 
           if(arr.Length>1) arr[1] = 2;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            Console.WriteLine(arr[n-1]);
            Console.ReadLine();
        }
    }
}
