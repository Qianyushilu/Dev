using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x2402邹君诚_250519
{
    internal class Students
    {
        private string name;
        public string Name { get { return name; } }

        private string sex;
        public string Sex {  get { return sex; } }
        private int age;
        public int Age { get { return age; } }
        public Students() { }
        public Students(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

    }
}
