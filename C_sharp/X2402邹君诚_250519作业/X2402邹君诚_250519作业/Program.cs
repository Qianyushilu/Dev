using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace X2402邹君诚_250519作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            //1.添加学生信息
            Student s1 = new Student("张三","男",18,24401,91);
            Student s2 = new Student("李四","男",16,24402,92);
            Student s3 = new Student("王五","男",19,24403,87);
            Student s4 = new Student("赵六","男",18,24404,84);
            Student s5 = new Student("王笑笑","女",20,24405,83);
            Student s6 = new Student("李立","男",17,24406,84);
            Student s7 = new Student("陈芳","女",19,24407,82);
            Student s8 = new Student("刘若","女",20,24408,97);
            Student s9 = new Student("陈欣怡","女",16,24409,99);
            Student s10 = new Student("言叶","女",15,24410,100);
            
            //将成绩存储在arraylist中
            arr.Add(s1);
            arr.Add(s2);
            arr.Add(s3);
            arr.Add(s4);
            arr.Add(s5);
            arr.Add(s6);
            arr.Add(s7);
            arr.Add(s8);
            arr.Add(s9);
            arr.Add(s10);
            //遍历并打印输出所有元素
            foreach(Student std in arr)
            {
                Console.WriteLine(std.Name+" "+std.Sex + " "+std.Age + " "+std.Id + " "+std.Score);
            }
            //删除第三个学生成绩
            arr.RemoveAt(2);
            Console.WriteLine();
            Console.WriteLine("删除第三个学生成绩后：");
            foreach (Student std in arr)
            {
                Console.WriteLine(std.Name + " " + std.Sex + " " + std.Age + " " + std.Id + " " + std.Score);
            }
            Console.WriteLine();
            //修改索引为4的学生成绩为100
            Student ss = (Student)arr[4];
            ss.Score = 100;
            Console.WriteLine("修改索引为4的学生成绩为100后：");
            foreach (Student std in arr)
            {
                Console.WriteLine(std.Name + " " + std.Sex + " " + std.Age + " " + std.Id + " " + std.Score);
            }

            //统计成绩大于90分以上的学生人数
            Console.WriteLine();
            int ScoreCount = 0;
            foreach (Student std in arr)
            {
                if(std.Score >= 90)
                {
                    ScoreCount++;
                }
            }
            Console.WriteLine("成绩大于90分以上的学生人数为：{0}",ScoreCount);
            Console.WriteLine();
            //判断是否存在100分的同学
            bool maxScoe = false;
            foreach (Student std in arr) 
            {
                if( std.Score == 100)
                {
                    maxScoe = true;
                }
            }
            if (maxScoe)
            {
                Console.WriteLine("存在100分的同学");
            }
            else
            {
                Console.WriteLine("不存在100分的同学");
            }
            Console.ReadLine();

        }
    }
}
