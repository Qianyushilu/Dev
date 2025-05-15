using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402_邹君诚_250428_图书管理系统_继承与多态
{

    //枚举类型，是指一组常量的集合，例如：性别，专业，图书的当前状态
    enum EBookStatus
    {
        AtLibrary,   //在馆
        Borrowed,  //借出     
    }
    class Book
    {
        //成员变量有图书编写，图书名称，当前状态（枚举类型-在馆，借出），
        //借出日期，应还日期。（后面两个都日期型变量，DateTime）。
        public string BookID { get; set; }
        public string BookName { get; set; }
        public EBookStatus CurrentStatus { get; set; }//指图书的当前状态


        public DateTime BorrowDate { get; set; }  //借出日期
        public DateTime ReturnDate { get; set; }  //归还日期
        public Book(string bookID, string bookName)
        {
            BookID = bookID;
            BookName = bookName;
            CurrentStatus = EBookStatus.AtLibrary;
        }
    }
}
