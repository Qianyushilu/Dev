﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 40; i++)
            {
                for(int j = 1; j <= 30; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
        }
    }
}
