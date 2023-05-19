using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName="Антон Валерьевич Коржов";
            string email="tsartror@mail.ru";
            int age=37;
            double gradProg, gradMath, gradFis;
            gradProg = 4.9;
            gradMath = 4.5;
            gradFis = 4.7;
            string pattern = "ФИО: {0} \nВозраст: {1} \nЭлектронная почта:{2} \nБаллы по программированию {3} \nБаллы по математике {4} \nБаллы по физике {5}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              gradProg,
                              gradMath,
                              gradFis);
            Console.ReadKey();
            double gradSumm, gradSrenee;
            gradSumm = gradProg + gradMath + gradFis;
            gradSrenee = gradSumm / 3;
            string newpattern = "Сумма баллов: {0} \nСредний балл: {1}";
            Console.WriteLine(newpattern,
                             gradSumm,
                             gradSrenee);
            Console.ReadKey();
        }
    }
}
