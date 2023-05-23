using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько карт у Вас на руках:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i < 11; i++)
            {
                Console.WriteLine($"Значение карты {i} = {i}");
            }
            Console.WriteLine($"Значение карты J = 10");
            Console.WriteLine($"Значение карты Q = 10");
            Console.WriteLine($"Значение карты K = 10");
            Console.WriteLine($"Значение карты T = 10");
            int Summ = 0;

            for (int 
                i = 1; i < number + 1; i++)
            {
                Console.Write($"Введите номинал карты номер {i} =  ");
                Summ = Summ + int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Сумма ваших карт = {Summ}");
            Console.ReadKey();
        }
    }
}
