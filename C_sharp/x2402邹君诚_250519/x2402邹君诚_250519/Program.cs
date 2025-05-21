using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace x2402邹君诚_250519
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Students s1= new Student("张三","男",19);
            Students s2 = new Student("李四", "男", 15);
            Students s3 = new Student("王一", "女", 21);    
            arr.Add(s1);
            arr.Add(s2);
            arr.Add(s3);
            foreach(Object student in arr)
            {
                Students ss= student as string;
            Console.WriteLine(ss.Name);

            }
        }
    }
}
