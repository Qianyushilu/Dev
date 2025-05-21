using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250519作业
{
    internal class Student
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }
        
        public Student() { }
        public Student(string name, string sex, int age,int id, double score)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.Id = id;
            this.Score = score;
        }
    }

}
