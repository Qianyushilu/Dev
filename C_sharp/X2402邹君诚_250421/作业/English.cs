using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class English:Person
    {
        //属性
        private string zodiac;
        public string Zodiac
        {
            get { return zodiac; }
            set { zodiac = value; }
        }
        //构造方法
        public English() { }
        public English(string xinz)
        {
            this.zodiac = xinz;
        }
        public English(string name,char sex,int age,string xinz) 
            :base(name,sex,age) 
        {
            this.zodiac = xinz;

        }
        // 私有方法：将性别从中文转换为英文
        
        //方法
        public override void sayHello()
        {
            Console.WriteLine("Hello! My name is {0},I am {1} years old, my gender is {2}, and my zodiac sign is {3}.",base.Name,base.Age,base.Sex,this.zodiac);
        }

    }
}
