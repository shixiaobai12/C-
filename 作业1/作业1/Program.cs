using System;

namespace 作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个三位数");
            int a = int.Parse(Console.ReadLine());
            int b;
            Console.WriteLine("它的个位，十位，百位分别是：");
            while (a != 0)
            {
                b = a % 10;
                a = a / 10;
                Console.Write( b);
            }
            Console.ReadKey();


        }
    }
}
