using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402_邹君诚_250428_图书管理系统_继承与多态
{
    class Reader
    {
        public string ReaderID { get; set; }
        public string ReaderName { get; set; }
        public Book Borrowbook { get; set; }   //所借图书是Book类型
        public Reader(string readerID, string readerName)
        {
            ReaderID = readerID;
            ReaderName = readerName;
        }

      
        

        //写一个归还书的虚方法
        public virtual void BorrowBook(Book book)
        {

            if (book.CurrentStatus == EBookStatus.AtLibrary)
            {
                Borrowbook = book;
                book.CurrentStatus = EBookStatus.Borrowed;
                book.BorrowDate = DateTime.Today;
                book.ReturnDate = DateTime.Today.AddDays(30);
                Console.WriteLine($"{ReaderName} 借阅了《{book.BookName}》，应还日期：{book.ReturnDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"《{book.BookName}》已经被借出，无法借阅。");
            }
            

        }
        public void Display()
        {
            Console.WriteLine($"读者证号：{ReaderID}");
            Console.WriteLine($"读者姓名：{ReaderName}");
            if (Borrowbook == null)
            {
                Console.WriteLine("暂无借阅图书。");
            }
            else
            {
                Console.WriteLine($"所借图书：{Borrowbook.BookName}");
                Console.WriteLine($"借出日期：{Borrowbook.BorrowDate.ToShortDateString()}");
                Console.WriteLine($"应还日期：{Borrowbook.ReturnDate.ToShortDateString()}");
            }
        }
    
    }
}
