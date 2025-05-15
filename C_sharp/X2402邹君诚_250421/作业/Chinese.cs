using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class Chinese:Person
    {
        //属性
        private string shengx;
        public string Shengx
        {
            get { return shengx; }
            set { shengx = value; }
        }
        //构造方法
        public Chinese() { }
        public Chinese(string shengx) { 
            this.shengx = shengx;
        }
        public Chinese(string name, char sex, int age) : base(name, sex, age)
        {
            shengx = CalculateShengx(age);
           
        }
        //方法
        private  string CalculateShengx(int age)
        {
            int birthYear = 2025 - age;
            string[] zodiacs = { "猴", "鸡", "狗", "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊" };
            int index = (birthYear - 1900) % 12; 
            if (index < 0)
            {
                index += 12;
            }

            return zodiacs[index];
        }
    
        public override void sayHello()
        {
            Console.WriteLine($"你好！我是{Name}，性别{Sex}，今年{Age}岁，我的生肖是{shengx}。");
        }
    }
}
