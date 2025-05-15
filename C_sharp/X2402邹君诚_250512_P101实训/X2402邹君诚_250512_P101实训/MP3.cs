using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250512_P101实训
{
    internal class MP3:IUsb
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public MP3() { }
        public MP3(string name)
        {
            this.name = name;
        }
        public void insert()
        {
            Console.WriteLine("MP3" + this.name + "已插入");
        }
        public void quit()
        {
            Console.WriteLine("MP3" + this.name + "已拔出");
        }
    }
}
