using System;
using System.Collections.Generic;
using System.Text;

namespace Skillbox
{
    class Task
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int sumMatrix1 = 0;
            int sumMatrix2 = 0;
            int resultSum = 0;

            Console.Write("Количество строк: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[line, column];
            int[,] matrix2 = new int[line, column];

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(1, 25);
                    Console.Write(matrix[i, j] + " ");

                    sumMatrix1 += matrix[i, j];
                }
                Console.WriteLine();

            }

            Console.WriteLine($"Сумма всех элементов: {sumMatrix1}");

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = random.Next(1, 25);
                    Console.Write(matrix2[i, j] + " ");
                    sumMatrix2 += matrix2[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов: {sumMatrix2}");

            Console.WriteLine($"Сумма матриц: {resultSum = sumMatrix1 + sumMatrix2}");
        }
    }
}

