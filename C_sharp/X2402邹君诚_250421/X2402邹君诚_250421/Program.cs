using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("张小小", '女', 17);

            students s1 = new students("X202412", "X2402");
            s1.study();
            students s2 = new students("冯若雪", '女', 16, "X202410", "X2402");
            s2.study();
            Teacher t1 = new Teacher("张三",'男',37,0001);
            t1.teaching();
            Console.ReadLine();
        }
    }
}
