using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402_邹君诚_250428_图书管理系统_继承与多态
{
    class Teacher : Reader
    {
        public Teacher(string readerID, string readerName) : base(readerID, readerName)
        {
        }
        public override void BorrowBook(Book book)
        {
            if (book.CurrentStatus == EBookStatus.AtLibrary)
            {
                Borrowbook = book;
                book.CurrentStatus = EBookStatus.Borrowed;
                book.BorrowDate = DateTime.Today;
                book.ReturnDate = DateTime.Today.AddDays(90);
                Console.WriteLine($"{ReaderName}（老师）借阅了《{book.BookName}》，应还日期：{book.ReturnDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"《{book.BookName}》已经被借出，无法借阅。");
            }
        }
    }
}

