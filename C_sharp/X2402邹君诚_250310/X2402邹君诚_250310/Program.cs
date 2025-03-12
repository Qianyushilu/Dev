using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250310
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double[] chengji;
            double sum=0,avg=0;
            Console.WriteLine("请输入学生的人数：");
            num=int.Parse(Console.ReadLine());
            chengji = new double[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("请输入第{0}名学成成绩：",i+1);
                chengji[i]=double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++) {
                sum += chengji[i];         
            }
            avg = sum / num;
            Sort(chengji);
            Console.WriteLine("总分为：{0}，平均分为：{1}", sum, avg);
            Console.WriteLine("成绩最高为：{0}，\n最低为：{1}", chengji[num-1], chengji[0]);
            
            Console.ReadLine();

        }

        public static void Sort(double[] arr) {
            int n=arr.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double k = arr[j];
                        arr[j]= arr[j + 1];
                        arr[j+1]= k;
                    }
                }
            }
        }

       
    }

}
