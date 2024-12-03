using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241114_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您好！接下来，开始您的注册。");
            string Username,PassWd,PassWd1;
            string PassWd1,PassWd2;
            Console.WriteLine("请输入你的用户名：");
            Username = Console.ReadLine();
            Console.WriteLine("请输入您的密码：");
            PassWd = Console.ReadLine();
            Console.WriteLine("请确认您的密码：");
            PassWd1 = Console.ReadLine();
            if (PassWd != PassWd1) {
                Console.WriteLine("密码错误！请重新输入")
            }


        }
    }
}
