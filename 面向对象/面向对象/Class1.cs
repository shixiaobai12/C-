using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    
        public class Person
        {
             public  string Name;
            public void name(string name)
            {
                Name = name;
            }
            public void say(string N)
            {
                Console.WriteLine(Name + "说：" + N);
            }
    }
}
