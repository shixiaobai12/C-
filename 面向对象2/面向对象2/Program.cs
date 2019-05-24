using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象2
{
    class Program
    {
        static void Main(string[] args)
        {//创建分数对象
            Fraction f1 = new Fraction(12, 16);
            Fraction f2 = new Fraction(2, 5);
           Fraction result= f2.subtract (f1);
            result .Print();
            


        }
    }
}
