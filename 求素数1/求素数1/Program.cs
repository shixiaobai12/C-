using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求素数1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            bool[] a = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                a[i] = true;
            for (int i = 2; i < n; i++)
            {if (a[i])
                    for (int j = i * 2; j <= n; j += i)
                        a[j] = false;
            }
            for (int i = 2; i < n; i++)
                if (a[i])
                    Console.Write(i + " ");
            Console.ReadKey();
        }   
    }
}
