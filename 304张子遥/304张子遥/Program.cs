using System;

namespace _304张子遥
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.计算十进制42转换为二进制、十六进制分别对应的值。
            //       二进制 101010   十六进制   2a
            //  2.	计算二进制11010110对应的十进制值。
            //        214
            //3.	计算十六进制0x75对应的十进制值。
            //     117
            //4.	打印下面图形：
            //           *
            //          **
            //         ***

            // for (int i=1;i<=3;i++)
            //{
            //for (int j = 3 - i; j > 0; j--)
           // {
           //  Console.Write(" ");
           //  }
    //            for (int t = 3 - i; t < 3; t++)
     //           {
                    Console.Write(" *");
            //           }
            //          Console.WriteLine();

            //       }
            //            Console.ReadKey();

            //            5.编写一个程序，要求用户输入一个美元数量，然后显示出增加5 % 税率后的相应金额。格式如下所示：
            //           Enter an amount: 100.00
            //            With tax added:$105.00

            //    Console.WriteLine("Enter an amount:");
            //    Double a = Double.Parse(Console.ReadLine());
            //    Double b = a * 1.05;
            //    Console.WriteLine("{ 0,5:c }", b);
            //    Console.ReadKey();
            //6. 编写一个程序，输入1个3位整数, 分别输入个位, 十位, 百位上的值 

            Console.WriteLine("请输入一个三位数");
            int a = int.Parse(Console.ReadLine());
            int b;
            Console.WriteLine("它的个位，十位，百位分别是：");
            while (a != 0)
            {
                b = a % 10;
                a = a / 10;
                Console.Write(b);
            }
            Console.ReadKey();

        }

    }
}
