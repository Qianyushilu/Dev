
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250512_P101实训
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainBoard mb = new MainBoard("B490M");
            UDisk udisk = new UDisk("SanDisk3.0");
            MP3 mp3 = new MP3("Dx160");
            Console.WriteLine("主板" + mb.Name + "连接U盘");
            mb.useUSB(udisk);
            mb.stopUSB(udisk);
            Console.WriteLine("主板" + mb.Name + "连接MP3");
            mb.useUSB(mp3);
            mb.stopUSB(mp3);

            KeyAdapter ka=new KeyAdapter();
            ka.Key=new Key("D-Key");
            ka.insert();
            ka.quit();

            Console.ReadLine();


        }
    }
}
