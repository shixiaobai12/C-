using System;

namespace 练习
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Random s = new Random();
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = s.Next(1, 20);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine( " ");
            }
            Console.WriteLine(" ");
            int b = 0;
            for (int i = 0; i < 4; i++)
            {    
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > b)
                    {
                        b = a[i, j];
                    }
                }
            }
            Console.WriteLine("最大值是{0}", b);]
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] == b)
                    {
                         a[i, j]=0;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.ReadKey();
           }
    }
}
