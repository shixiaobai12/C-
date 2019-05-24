using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = -1234;
            Console.Write("a={0:g}  ", a);
            Console.WriteLine("b={0:g}",b);
            Console.Write("a={0:D5}  ",a);
            Console.WriteLine("b={0:D5}",b);
            Console.Write("a={0,7:c}  ", a);
            Console.WriteLine("b={0,6:c}", b);
        }
    }
}
