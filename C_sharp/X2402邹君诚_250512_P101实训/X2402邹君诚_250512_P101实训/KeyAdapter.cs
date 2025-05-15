using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250512_P101实训
{
    internal class KeyAdapter:IUsb
    {
        public Key Key { get; set; }
        public void insert()
        {
            Key.connect();
        }
        public void quit()
        {
            Key.disconnect();
        }

    }
}
