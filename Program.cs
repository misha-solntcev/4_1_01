using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 1
В заданной матрице A(N, M) найдите индексы первого элемента, превосходящего
среднее арифметическое всех элементов. */

namespace _4_1_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            int sum = 0;
            foreach (int i in array)
                sum += i;
            double average = sum / array.Length;

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > average)
                    {
                        Console.WriteLine($"Индекс первого " +
                            $"элемента, превосходящего среднее " +
                            $"арифметическое всех элементов  - {array[i, j]}");
                    }
                    break;
                }            
            Console.ReadKey();
        }
    }
}