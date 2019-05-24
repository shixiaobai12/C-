using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_5
{
    class Program
    {
        static void Main(string[] args)
        namepace proj4_5
          struct Stud
        {
            public int sno;
            public string sname;
        };
        class Program
        {
            static void Main(string [] args )
            {
                int i;
                List<Stud> myset = new List<Stud>();
                Stud s1 = new Stud();
                s1.sno = 101;s1.sname = "黎明";
                myset.Add(s1);
                Stud s2 = new Stud();
                s2.sno = 103;s2.sname = "王宏";
                myset.Add(s2);
                Stud s3 = new Stud();
                s3.sno = 108;s3.sname = "那英";
                myset.Add(s3);
                Stud s4 = new Stud();
                s4.sno = 105;s4.sname = "张伟";
                myset.Add(s4);
                Console.WriteLine("元素序列：");
                Console.WriteLine(" 下标 学号 姓名");
                i = 0;
                foreach (Stud st in myset)
                {
                    Console.WriteLine(" {0} {1} {2}", i, st.sno, st.sname);
                    i++;
                }
                Console.WriteLine("容量：{0}", myset.Capacity);
                Console.WriteLine("元素个数：{0}", myset.Count);
                Console.WriteLine("在索引2处插入一个元素");
                Stud s5 = new Stud();
                s5.sno = 106;s5.sname = "陈兵";
                myset.Insert(2, s5);
                Console.WriteLine  ("元素序列：");
                Console.WriteLine(" 下标 学号 姓名");
                i = 0;
                foreach (Stud st in myset)
                {
                    Console.WriteLine("{ 0} { 1} { 2}", i, st.sname, st.sname);
                    i++;
                }
                
          


            }
        }
            
        
    }
}
