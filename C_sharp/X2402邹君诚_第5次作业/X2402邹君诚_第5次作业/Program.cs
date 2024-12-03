using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_第5次作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义变量
            int Ranking;                      //名次
            string result="";                 //最终输出结果
            //输出提示信息
            Console.WriteLine("令狐冲去参加比武大赛，他的名次决定了他的去处。");    
            Console.WriteLine("请输入令狐冲的名次（数字）：");                       
            Ranking = int.Parse(Console.ReadLine());                                   
            //执行判断并决定结果
            if (Ranking <= 0)
            {
                result = "成绩非法！什么都没有发生。";
            }
            else if (Ranking == 1)
            {
                result = "获得第一名！将出任武林盟主。";
            }
            else if (Ranking == 2)
            {
                result = "获得第二名！将出任武当掌门。";
            }
            else if (Ranking == 3)
            {
                result = "获得第三名！将出任峨眉掌门";
            }
            else
            {
                result = "名次太低了，您将被逐出师门。";
            }
      
            Console.WriteLine(result);
            //暂停查看结果
            Console.ReadLine();
        }

    }
}
