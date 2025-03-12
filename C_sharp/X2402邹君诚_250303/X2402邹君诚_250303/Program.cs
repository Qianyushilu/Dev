using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sayhello();
            int a;
            a=int.Parse(Console.ReadLine());

            Console.WriteLine(Sumjiecheng(a));
        }
        public static void Sayhello()
        {
            Console.WriteLine("Hello World");
        }
        public static long Sumjiecheng(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else {
                return x*Sumjiecheng(x-1);
            }
        }
    }
}
