using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp13;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            if (!int.TryParse(Console.ReadLine(), out int lines))
            {
                Console.WriteLine("Некорректные данные. Введите целое число!");
                return;
            }

            Console.Write("Введите количество столбцов: ");
            if (!int.TryParse(Console.ReadLine(), out int columns))
            {
                Console.WriteLine("Некорректные данные. Введите целое число!");
                return;
            }

            int[,] matrix = new int[lines, columns];
            Random random = new Random()
             
            Console.WriteLine("Сгенерированная матрица:"); 
            int sum = 0;
            for (int i = 0; i < lines; i++) // Заполнение матрицы
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 100); 
                    Console.Write(matrix[i, j] + " ");
                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы: {sum}");  // Вывод суммы всех элементов 
        }
    }

