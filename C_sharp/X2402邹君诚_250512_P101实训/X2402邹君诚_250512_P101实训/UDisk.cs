using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250512_P101实训
{
    internal class UDisk:IUsb
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public UDisk() { }
        public UDisk(string name) 
        {
            this.name = name;
        }
        public void insert()
        {
            Console.WriteLine("U盘"+this.name+"已插入");
        }
        public void quit()
        {
            Console.WriteLine("U盘" + this.name + "已拔出");
        }


    }
}
