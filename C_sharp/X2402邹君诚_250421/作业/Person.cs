using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class Person
    {
        //属性
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private char sex;
        public char Sex
        {
            get { return sex; }
            set
            {
                if (value == '男' || value == '女')
                {
                    sex = value;
                }
                else
                {
                    Console.WriteLine("性别无效");
                }
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 135)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("年龄无效");
                }
            }
        }
        //构造方法
        public Person()
        {

        }
        public Person(string name,char sex,int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        //方法
        public virtual void sayHello()
        {
            Console.WriteLine("你好！我是{0}，性别{1}，今年{2}岁。",this.name,this.sex,this.age);
        }
    }
}
