using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试
{
    struct Product  //定义结构体，产品
    {
        public string Name;
        public double Price;
        public Product(string name, double price) //构造函数初始化商品名称和价格
        {
            Name = name;
            Price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //界面
            DisplayWelcomeScreen();  //使用方法输出界面

            //功能实现
            Product[] menu = new Product[]    //定义商品数组
            {
                new Product("美式咖啡",12.0),
                new Product("拿铁咖啡",15.5),
                new Product("香草拿铁",16.5),
                new Product("抹茶拿铁",16.5),
                new Product("意式浓缩",10.0)
            };

            //定义变量
            int choice = 0;           //选择           
            double amount = 0;        //总计
            int totalNum = 0;         //总数量
            double paid = 0;          //实付
            double change = 0;        //找零

            while (true)
            {
                DisplayMenu();  //输出菜单
                Console.WriteLine("请输入您的选择：");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > 6)
                {
                    Console.WriteLine("输入错误，请重新输入：");
                    continue;
                }
                if (choice == 6)
                {
                    break;
                }

                string choiceName = menu[choice - 1].Name;
                double choicePrice = menu[choice - 1].Price;

                Console.WriteLine($"请问您需要几杯{choiceName}？");
                if (!int.TryParse(Console.ReadLine(), out int num) || num <= 0)
                {
                    Console.WriteLine("输入错误，请重新输入：");
                    continue;
                }

                double pay = num * choicePrice;
                amount += pay;
                totalNum += num;

                Console.WriteLine($"您选择了{num}杯{choiceName}，需支付{pay}元，总计{amount}元。");
            }

            Console.WriteLine($"应付金额{amount}元，请问您实付多少？");
            paid = GetValidated();

            while ((change = paid - amount) < 0)
            {
                Console.WriteLine($"支付失败，您需要支付{amount}元");
                Console.WriteLine("请支付：");
                paid = GetValidated();
            }

            Console.WriteLine($"您一共点了{totalNum}杯咖啡。\n账单为：\n应付 {amount}元\n实付 {paid}元\n找零 {change}元");
            Console.WriteLine("喜欢您来，欢迎下次光临！");

            //暂停页面查看结果
            Console.ReadLine();
        }

        static void DisplayWelcomeScreen()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-                                -");
            Console.WriteLine("-        模拟自动售货机          -");
            Console.WriteLine("-            若雪咖啡            -");
            Console.WriteLine("-        NO.5 2024-12-26         -");
            Console.WriteLine("-                                -");
            Console.WriteLine("----------------------------------");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-                                -");
            Console.WriteLine("-            喜欢您来            -");
            Console.WriteLine("-        1-美式咖啡     12.0元   -");
            Console.WriteLine("-        2-拿铁咖啡     15.5元   -");
            Console.WriteLine("-        3-香草拿铁     16.5元   -");
            Console.WriteLine("-        4-抹茶拿铁     16.5元   -");
            Console.WriteLine("-        5-意式浓缩     10.0元   -");
            Console.WriteLine("-        6-退出点餐              -");
            Console.WriteLine("-                                -");
            Console.WriteLine("----------------------------------");
        }

        static double GetValidated()
        {
            double value;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("输入错误，请重新输入：");
                }
            }
        }
    }
}
