using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое число:");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            bool rezultat;
            int i = 1;
            while (b < 0) 
            {
                if (b == 0)
                {
                    Console.WriteLine("Вы ввели 0.");
                }
                if (b < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число.");
                }
                b = int.Parse(Console.ReadLine());
            }
            while (i <= b)
            {
                if (b % i == 0)
                {
                    count++;
                }
                i++;
            }
            if (count < 3) rezultat = true;
            else rezultat = false;

            if (rezultat == true)
            {
                Console.WriteLine($"Число {b} простое число.");
            }
            else
            {
                Console.WriteLine($"Число {b} не является простым числом.");
            }
            Console.ReadKey();
        }
    }
}
