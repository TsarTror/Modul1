using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Zad2
{
    internal class Program
    {
        static string[] Reverse(string text)
        {
            string[] WordsMatrix = text.Split(' ');
            return WordsMatrix;
        }
        static string ReversWords(string inputPhrase)
        {
            string[] OldString = Reverse(inputPhrase);
            string[] NewString = new string[OldString.Length];
            for (int i = 0; i < OldString.Length; i++)
            {
                NewString[i] = OldString[OldString.Length - (1 + i)];
            }
            string ResultString = NewString[0] + ' '; ;
            for (int i = 1; i < NewString.Length; i++)
                ResultString += NewString[i] + ' ';
            return ResultString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputPhrase = Console.ReadLine();
            Console.WriteLine("Перевёрнутое предложение:");
            Console.WriteLine(ReversWords(inputPhrase));
            Console.ReadKey();
        }
    }
}
