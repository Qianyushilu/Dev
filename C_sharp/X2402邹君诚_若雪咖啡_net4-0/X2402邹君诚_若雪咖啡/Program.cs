using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X2402邹君诚_若雪咖啡
{
    class Program
    {
        static void Main(string[] args)
        {
            //界面
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-                              -");
            Console.WriteLine("-        模拟自动售货机        -");
            Console.WriteLine("-            若雪咖啡          -");
            Console.WriteLine("-        NO1 2024.11.02        -");
            Console.WriteLine("-                              -");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("-                                -");
            Console.WriteLine("-            喜欢您来            -");
            Console.WriteLine("-        1-美式咖啡     12.0元   -");
            Console.WriteLine("-        2-拿铁咖啡     15.5元   -");
            Console.WriteLine("-        3-香草拿铁     16.5元   -");
            Console.WriteLine("-        4-抹茶拿铁     16.5元   -");
            Console.WriteLine("-        5-退出点餐              -");
            Console.WriteLine("-                                -");
            Console.WriteLine("----------------------------------");

            //功能实现

            //.1 定义变量
            int choise=0;                         //选择
            string[] Names = {"美式咖啡","拿铁咖啡","香草拿铁","抹茶拿铁"};             //商品名称
            double[] Prices = {12.0,15.5,16.5,16.5};                    //商品价格
            string choiseName = " ";
            double choisePrise = 0;
            int num;                              // 商品数量
            double pay,paid,change;               //应付、实付、找零

            Console.WriteLine("请输入您的选择：");
            if (!int.TryParse(Console.ReadLine(), out choise));
            choiseName = Names[choise - 1];
            choisePrise = Prices[choise - 1];
            //.2 输入_个数
            Console.WriteLine("请问您需要几杯{0}？", choiseName); //提示
            num = int.Parse(Console.ReadLine());            //输入
            //.3 计算应付
            pay = num * choisePrise;
            //.4 输入实付
            Console.WriteLine("应付金额为{0},请问您实付金额多少？",pay);  //提示
            paid=double.Parse(Console.ReadLine());                        //输入  
            //.5 计算找零
            change = paid - pay;
            //.6 输出结果
            Console.WriteLine("您一共点了{0}杯{1}。\n账单为：\n应付 {2}元\n实付 {3}元\n找零 {4}元",num,choiseName,pay,paid,change);
            Console.WriteLine("喜欢您来，欢迎下次光临！");

            //暂停页面查看结果
            Console.ReadLine();
            
        }
    }
}
