using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_第七次作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;                              //定义变量
            long result = 1;                          //long整形储存结果，初始值为一（1的阶乘为一
            long sum = 0;                             //long整形储存1!+2!+3!+...+n!      
            Console.WriteLine("请输入数字n！：");      //输入    
            num = int.Parse(Console.ReadLine());       
            for (int i = 1; i <= num; i++)            // 使用 for 循环从 1 遍历到用户输入的 num
            {
                result *= i;                          // 每次循环计算当前数字 i 的阶乘，并累乘到 result
                sum += result;                        // 将当前的阶乘结果累加到 sum
            }
            Console.WriteLine("n!={0}",result);          //输出结果
            Console.WriteLine("1!+2!+3!+...+n!={0}",sum);
            Console.ReadLine();                       //暂停查看结果

        }
    }
}
