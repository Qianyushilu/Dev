using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_第5次作业_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义并初始化变量
            double Saled = 0;                                                   //实际销售额
            double Bonus = 0;                                                   //奖金
            const double SalesTasks = 20000;                                    //定义销售任务为常量
            //输出提示信息
            Console.WriteLine("请输入您的实际销售额（元）：");
            // 输入并验证是否有效
            if (!double.TryParse(Console.ReadLine(),out Saled) || Saled < 0)
            {
                Console.WriteLine($"输入非法！销售额必须为非负数。");
                return;
            }
            //执行判断并决定结果
            if (Saled >= 2 * SalesTasks)                                         //2倍，发放奖金1000元；
            {
                Bonus = 1000;
                Console.WriteLine($"恭喜您！超额完成任务！您将获得奖金：{Bonus}元。");
            } 
            else if (Saled < 2 * SalesTasks && Saled >= 1.5 * SalesTasks)        //1.5倍与2倍之间，发放奖金500元；
            {
                Bonus = 500;
                Console.WriteLine($"恭喜您！完成任务较好！您将获得奖金：{Bonus}元。");
            }
            else if (Saled < 1.5 * SalesTasks && Saled >= SalesTasks)                    //1倍与1.5倍之间，发放奖金100元
            {
                Bonus = 100;
                Console.WriteLine($"完成了任务，您将获得奖金：{Bonus}元。");
            }
            else                                                              //没有完成任务，则解雇
            {
                Bonus = 0;
                Console.WriteLine("没有完成任务，您将被解雇！");
            }
            //暂停查看结果
            Console.ReadLine();
        }
    }
}
