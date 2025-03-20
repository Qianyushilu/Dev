using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n;//学生人数
            double sum = 0;
            Console.WriteLine("请输入学生人数:");
            n = long.Parse(Console.ReadLine());
            //请定义一个用来存放若干个学生成绩的数组Score,长度为学生人数
            double[] Score = new double[n];
            for (int i = 0; i < Score.Length; i++)
            {
                Console.WriteLine("请输入第{0}学生成绩:", i + 1);
                Score[i] = double.Parse(Console.ReadLine());
            }
            Sum(Score);
            double max=Max(Score);
            Console.WriteLine("最高分为：{0}",max);
        }
        public static void Sum(double[] Score)
        {
		    double sum=0;
		    for(int i = 0; i < Score.Length; i++)
            {
                sum += Score[i];
            }
            Console.WriteLine("总分为：{0}", sum);
    	}
        public static double Max(double[] score)
        {
            if(score.Length == 0) {  return 0; }
            double max = score[0];
            for(int i = 1; i < score.Length; i++)
            {
                if (max <= score[i])
                {
                    max= score[i];
                }
            }
            return max;
        }
    }
}
