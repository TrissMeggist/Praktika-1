using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало диапазона: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечную цифру: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if ((i - x) % 10 == 0) Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
