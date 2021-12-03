using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер карты:");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Пики");
                    break;
                case 2:
                    Console.WriteLine("Трефы");
                    break;
                case 3:
                    Console.WriteLine("Бубны");
                    break;
                case 4:
                    Console.WriteLine("Червы");
                    break;
                default:
                    Console.WriteLine("Введите правильный номер карты");
                    break;
            }
            Console.ReadLine();
        }
    }
}
    
