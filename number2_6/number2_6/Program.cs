﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало диапазона: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0 && i % 2 == 0) Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
