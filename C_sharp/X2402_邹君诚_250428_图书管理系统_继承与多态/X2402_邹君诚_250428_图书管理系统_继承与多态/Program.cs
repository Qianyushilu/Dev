using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402_邹君诚_250428_图书管理系统_继承与多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("B001", "C#基础教程");
            Book book2 = new Book("B002", "C#高级编程");

            // 创建普通读者
            Reader reader = new Reader("R001", "张三");
            // 创建学生读者
            Student student = new Student("S001", "言叶");
            // 创建老师读者
            Teacher teacher = new Teacher("T001", "王老师");

            
            reader.BorrowBook(book1);
            reader.Display();

            
            student.BorrowBook(book2);
            student.Display();

            
            teacher.BorrowBook(book1);  // book1已经被借出，所以提示无法借阅

            
            Book book3 = new Book("B003", "C#设计模式");
            teacher.BorrowBook(book3);
            teacher.Display();

            Console.ReadKey();
        }
    }
}
