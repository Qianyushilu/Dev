using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义变量
            const string NAME = "zou";
            const string PASSWD = "123456";
            string name1, passwd1;
            int n;

            //功能实现
            Console.WriteLine("--------------");
            Console.WriteLine("-欢迎进入系统-");
            Console.WriteLine("--------------");
            Console.WriteLine("----请登录----");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入用户名：");
                name1 = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                passwd1 = Console.ReadLine();
                if (name1 == NAME && passwd1 == PASSWD)
                {
                    Console.WriteLine("登陆成功！正在为您跳转中......");
                    Console.WriteLine("--------------");
                    Console.WriteLine("---四则运算---");
                    Console.WriteLine("/t请选择");
                    Console.WriteLine("/t1.+");
                    Console.WriteLine("/t2.-");
                    Console.WriteLine("/t3.*"); 
                    Console.WriteLine("/t4./");
                    Console.WriteLine("/t5.退出");
                    Console.WriteLine("请输入：");
                    n=int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1: plus();
                        case 2: 
                    }

                }
            }

            Console.ReadLine();


        }
        void  Plus()
        {


        }
    }
}
