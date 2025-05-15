using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250421
{
    internal class Teacher : Person
    {
        private int teaID;
        public int TeaID
        {
            get { return teaID; }
            set { teaID = value; }
        }
        //构造方法
        public Teacher()
        {

        }
        public Teacher(int teaID)
        {
            this.teaID = teaID;
        }
        public Teacher(string name, char sex, int age,int teaID) 
            : base(name, sex, age)
        {
            this.teaID = teaID;
        }
        //方法
        public void teaching()
        {
            Console.WriteLine("{0}正在讲课。", base.Name);
        }
    }
}
