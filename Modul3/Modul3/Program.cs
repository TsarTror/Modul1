using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            if (a%2==0)
                {   
                Console.WriteLine("Число чётное");
                }
            else
                {
                Console.WriteLine("Число нечётное");
                }
            Console.ReadKey();
            Console.WriteLine("Сколько карт у Вас на руках:");
            int number = int.Parse(Console.ReadLine());
            for (i = 2; i < 11; i++)
                {
                Console.WriteLine($"Значение карты {i} = {i}");
                }
            Console.WriteLine($"Значение карты J = 10");
            Console.WriteLine($"Значение карты Q = 10");
            Console.WriteLine($"Значение карты K = 10");
            Console.WriteLine($"Значение карты T = 10");
            int Summ = 0;
           
            for (i = 1; i < number + 1; i++)
                {
                Console.Write($"Введите номинал карты номер {i} =  ");
                Summ = Summ + int.Parse(Console.ReadLine());
                }
            Console.WriteLine($"Сумма ваших карт = {Summ}");
            Console.ReadKey();
            Console.WriteLine("Введите положительное целое число:");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            bool rezultat;
            i = 1;
            while (i<=b)
            {
                if (b % i == 0)
                {
                    count++;
                }
                i++;
            }
            if (b == 0)
            {
                Console.WriteLine("Вы ввели 0.");
            }
            if (b < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число.");
            }
            if (count<3)
            {
                Console.WriteLine($"Число {b} простое число.");
            }
            else
            {
                Console.WriteLine($"Число {b} не является простым числом.");
            }
            Console.ReadKey();
            Console.WriteLine("Введите количество чисел в последовальности:");
            int kolvo = int.Parse(Console.ReadLine());
            if (kolvo < 0) Console.WriteLine("Вы ввели отрицательное число.");
            else
            {
                int Min = 0;
                int chislo;
                i = 1;
                while (i <= kolvo)
                {
                    Console.WriteLine($"Введите {i} число:");
                    chislo = int.Parse(Console.ReadLine());
                    if (chislo < Min) Min = chislo;
                    i++;
                }
                Console.WriteLine($"Миниманое введёное число: {Min}");
            }
            Console.ReadKey();
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
        }
    }
}
