﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_Square_Star_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");

            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    if (i == 1 || i == a) Console.Write("*");
                    else if (j == 1 || j == a) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
