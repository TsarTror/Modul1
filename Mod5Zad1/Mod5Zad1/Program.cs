using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Zad1
{
    
        internal class Program
        {
            static string[] SplitText(string inputPhrase)
            {
                string[] WordsMatrix = inputPhrase.Split(' ');
                return WordsMatrix;
            }
            static void PrintWordMatrix(string[] WordsMatrix)
            {

                for (int i = 0; i < WordsMatrix.Length; ++i)
                {
                    Console.WriteLine(WordsMatrix[i]);
                }

                return;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите предложение:");
                string inputPhrase = Console.ReadLine();
                string[] WordsMatrix = SplitText(inputPhrase);
                PrintWordMatrix(WordsMatrix);
                Console.ReadKey();
            }
        }
       
    
}
