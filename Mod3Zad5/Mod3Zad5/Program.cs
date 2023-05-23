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
            int variant, win;
            win = 0;
            string da;
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
             Console.WriteLine($"Было загадано число {cifra}");
             win++;
             }
                if (win > 0)
                {
                    Console.WriteLine($"Хотите продлжить? Да(Набрать Да)/Нет(Любой знак или Enteer)");

                    if (Console.ReadLine() == "Да")
                    {
                        win = 0;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                }
                while (true);
            Console.ReadKey();
        }
    }
}
