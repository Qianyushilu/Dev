using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X2402邹君诚_250317作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameShow(); //显示界面


            string[] PlayerNemes = new string[2];

            GetPlayerNames(PlayerNemes);

            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", PlayerNemes[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerNemes[1]);


            DrawMap();
            Console.WriteLine("玩家{0}按任意键开始掷骰子", PlayerNemes[0]);


        }
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("******第一个飞行棋项目******");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************");
            
        }

        public static void GetPlayerNames(string[] PlayerNames)
        {
            Console.WriteLine("请输入玩家A的姓名：");
            PlayerNames[0]=Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家的姓名不得为空，请重新输入：");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名：");
            PlayerNames[1]=Console.ReadLine();
            while(PlayerNames[1] == "")
            {
                Console.WriteLine("玩家的姓名不得为空，请重新输入：");
                PlayerNames[1] = Console.ReadLine();
            }
            while (PlayerNames[1] == PlayerNames[0])
            {
                Console.WriteLine("姓名不能重复，请重新输入玩家B的姓名：");
                PlayerNames[1] = Console.ReadLine();
            }
        }

        public static void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 30; i++)
            {
                Console.Write("□");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("□");
                Console.WriteLine();
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("□");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
               
                Console.Write("□");
                Console.WriteLine();
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("□");
            }
            Console.WriteLine();

        }
        
    }
}
