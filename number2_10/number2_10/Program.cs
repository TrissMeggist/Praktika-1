using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                int a = i;
                int perv = a / 100;
                a %= 100;
                int vtoro = a / 10;
                a %= 10;
                int tret = a / 1;
                a %= 1;
                if (perv == tret || perv == vtoro || vtoro == tret)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
