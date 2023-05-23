using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в последовальности:");
            int kolvo = int.Parse(Console.ReadLine());
            int Min;
            int chislo;
            Console.WriteLine($"Введите 1 число:");
            chislo = int.Parse(Console.ReadLine());
            Min = chislo;
            int i = 2;
            while (i <= kolvo)
            {
                Console.WriteLine($"Введите {i} число:");
                chislo = int.Parse(Console.ReadLine());
                if (chislo < Min) Min = chislo;
                i++;
            }
            Console.WriteLine($"Миниманое введёное число: {Min}");
            Console.ReadKey();
        }
    }
}
