using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象2
{
    public class Fraction
    {
        private int top;
        private int bottom;
        //属性
        public int Top { get => top; set => top = value; }
        public int Bottom { get => bottom; set => bottom = value; }
        //无参构造方法
        public Fraction()
        {

        }
        //有参构造方法
        public Fraction (int t,int b)
        {
            top = t;
            bottom = b;
        }
        //打印
        public void Print()
        {
            Console.WriteLine("{0}/{1}", top, bottom);
        }
        //约分
        public void Reduct()
        {//求最大公约数
            int gcd = 0;
            //     int min = top > bottom ? top : bottom;
            //    for (int i = min; i > 0; i--)
            //    {
            //         if (top % i == 0 && bottom % i == 0)
            //         {
            //             gcd = i;
            //            break;
            //         }

            //     }

            int a = top;
            int b = bottom;
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            gcd = a;
            //约分
            top /= gcd;
            bottom /= gcd;

        }
        //分数相加
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        public Fraction Add(Fraction  f)
        {
            Fraction result = new Fraction();
            result.top = (this.top * f.bottom) + (f.top * this .bottom);
            result.bottom = this .bottom * f.bottom;
            result.Reduct();
            return result;
        }
        //分数相乘
        public Fraction Mul(Fraction f)
        {
            Fraction result = new Fraction();
            result.top = this.top * f.top;
            result.bottom = this.bottom * f.bottom;
            result.Reduct();
            return result;
        }
        //分数相减
        public Fraction subtract(Fraction f)
        {
            Fraction result = new Fraction();
            result.top = (this.top * f.bottom)- (f.top * this.bottom);
            result.bottom = this.bottom * f.bottom;
            result.Reduct();
            return result;
        }
        //分数相除divide
        public Fraction Divide(Fraction f)
        {
            Fraction result = new Fraction();
            result.top = this.top * f.bottom ;
            result.bottom = this.bottom * f.top ;
            result.Reduct();
            return result;
        }

    }
}
