using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double d = 123.456;
            Console.WriteLine("{0,5:c}", d);
            Console.WriteLine("{0:E4}", d);
            Console.WriteLine("{0:f4}", d);
            Console.WriteLine("{0:n}", d);
            Console.WriteLine("{0:f2}", d);
        }
    }
}
