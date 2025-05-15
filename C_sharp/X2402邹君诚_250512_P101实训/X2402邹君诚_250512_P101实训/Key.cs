using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250512_P101实训
{
    internal class Key
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Key() { }
        public Key(string name)
        {
            this.name = name;
        }
        public void connect()
        {
            Console.WriteLine("键盘" + this.name + "已插入");
        }
        public void disconnect()
        {
            Console.WriteLine("键盘" + this.name + "已拔出");
        }
    }
}
