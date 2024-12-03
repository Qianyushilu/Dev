using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_1130_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years, months, days;
            int result = 0;
            int[] dayInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("请输入年（数字）：");
            years = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入月（数字）：");
            months = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入日（数字）：");
            days = int.Parse(Console.ReadLine());
            if ((years % 4 == 0 && years % 100 != 0) || years % 400 == 0)
            {
                dayInMonth[1] = 29;
            }
            else
            {
                dayInMonth[1] = 28;
            }
            for (int i = 0; i < months-1; i++)
            {
                result+= dayInMonth[i];
            }
            result += days;
            Console.WriteLine("{0}年{1}月{2}号是该年的第{3}天",years,months,days,result);
        }

    }
}
