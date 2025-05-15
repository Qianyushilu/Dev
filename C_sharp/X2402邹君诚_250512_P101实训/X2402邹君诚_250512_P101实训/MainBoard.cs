using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250512_P101实训
{
    internal class MainBoard
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public MainBoard() { }
        public MainBoard(string name)
        {
            this.name = name;
        }
        public void useUSB(IUsb u)
        {
            u.insert();
        }
        public void stopUSB(IUsb u)
        {
            u.quit();
        }
    }
}
