using System;

namespace Task3
{
    //3. Реализуйте функцию вычисления числа Фибоначчи
    //Требуется реализовать рекурсивную версию и версию без рекурсии(через цикл).
    //Пример чисел Фибоначчи:
    //F(0) = 0,
    //F(1) = 1.
    //Для остальных чисел:
    //F(N) = F(N-2) + F(N-1).
    //То есть для F(2) будет F(2) = F(0) + F(1) = 0 + 1 = 1.
    //F(3) будет F(3) = F(1) + F(2) = 1 + 1 = 2.

    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 1;
            string result = "";
            while (true)
            {
                Console.WriteLine("Сколько чисел должно быть в ряде Фибоначчи?");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput > 0)
                    {
                        int[] row = calcFibonacciRow(userInput);
                        foreach (int i in row)
                        {
                            result = result + i.ToString() + " ";
                        }
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Введите целое положительное число");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое положительное число");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вычислить ряд Фибоначчи (0, 1, 1, 2, 3, 5, 8, 13, 21, 34 ...)
        /// </summary>
        /// <param name="number">Количество чисел в ряду (целое положительное число)</param>
        private static int[] calcFibonacciRow(int number)
        {
            int[] row = new int[number];
            row[0] = 0;
            row[1] = 1;

            for (int i = 2; i < number; ++i)
            {
                row[i] = row[i - 1] + row[i - 2];
            }

            return row;
        }
    }
}