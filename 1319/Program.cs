using System;


namespace _1319
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] db = new int[n,n]; 
            for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) db[i, j] = 0;
            int diag = 0;
            ///решение
            ///
            for (int i=0;i< n; i++)
            {
                int count = n;
                for(int j=diag;j< n; j++)
                {
                    db[i, j] = (int)(count * (count - 1)) / 2+i+1;count--;
                }
                diag++;
            }
            db[n - 1, 0] = n * n; int temp = 2;

            for (int i = n - 2; i > 0; i--)//формирование гавного столба
            {
                db[i, 0] = db[i +1,0] - temp;temp++;
            }
            temp = 1;

            int countuu = 1;
            diag = n-1; 
            for(int i=n-1;i>0; i--)
            {

                for (int j = 1; j < diag; j++)
                {
                    db[i, j] = db[i, j - 1] - temp;temp += 1;  
                }
                countuu++;temp = countuu; diag--;
            }
           

            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write(db[i, j] + " ");
                Console.WriteLine();
            }

            //Console.ReadLine();

        }
    }
}
