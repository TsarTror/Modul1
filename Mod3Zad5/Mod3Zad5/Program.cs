using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра заключается в угадываии случайного числа из диапазона от 0 до чила указанного вами.(Максимальное число не учитывается)");
            Console.WriteLine("Введите максимальное число:");
            int Max = int.Parse(Console.ReadLine());
            Random igra = new Random();
            int cifra = igra.Next(Max);
            int variant;
            do
            {
                Console.WriteLine($"ВВедитее число:");
                variant = int.Parse(Console.ReadLine());
                if (variant > cifra)
                {
                    Console.WriteLine("Ввдённое число больше загаданого.");
                }
                else if (variant < cifra)
                {
                    Console.WriteLine("Ввдённое число меньше загаданого.");
                }
                else
                {
                    Console.WriteLine("Вы угадали.");
                    break;
                }
            }
            while (true);
            Console.WriteLine($"Было загадано число {cifra}");
            Console.ReadKey();
        }
    }
}
