using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250421
{
    internal class students : Person
    {
        private string stuid;
        public string Stuid
        {
            get { return stuid; }
            set { stuid = value; }
        }
        private string stuclass;
        public string Stuclass
        {
            get { return stuclass; }
            set { stuclass = value; }
        }
        //构造方法
        public students()
        {

        }
        public students(string stuid, string stuclass)
        {
            this.stuid = stuid;
            this.stuclass = stuclass;
        }

        public students(string name, char sex, int age ,string stuid,string stuclass) 
            : base(name, sex, age)
        {
            this.stuid = stuid;
            this.stuclass = stuclass;  
        }

        //方法
        public void study()
        {
            Console.WriteLine("{0}正在好好学习。",base.Name);
        }
    }
}
