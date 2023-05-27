using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            int a, b;
            int[,] MatrixA;
            long sum = 0;
            Random x = new Random();
            Console.WriteLine("Первое задание.");
            Console.Write("Двумерная матрица состоит из столшбцов и строкю");
            Console.Write("Введите количество строк: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            b = int.Parse(Console.ReadLine());
            MatrixA =  new int[a,b];
            for (int i = 0; i < a; i++) 
            {for (int j = 0; j < b; j++)
                {
                    MatrixA[i, j] = x.Next(1000);
                    Console.Write($"{MatrixA[i, j]} ");
                    sum += MatrixA[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех чисел матрицы = {sum}");
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();

            //Второе задание
            int[,] MatrixB = new int[a,b];
            int[,] MatrixSum = new int[a,b];
            Console.WriteLine("Второе задание.");
            Console.WriteLine("Матрица А.");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{MatrixA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица В.");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    MatrixB[i, j] = x.Next(1000);
                    Console.Write($"{MatrixB[i, j]} ");
                    MatrixSum[i,j] = MatrixA[i, j] + MatrixB[i,j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица С = А + В.");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{MatrixSum[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
