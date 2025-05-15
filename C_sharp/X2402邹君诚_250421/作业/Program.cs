using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chinese c1 = new Chinese("言叶", '女', 20);
            c1.sayHello();
            English e1 = new English("Yanye", '女', 20, "aquarius");
            e1.sayHello();
        }
    }
}
