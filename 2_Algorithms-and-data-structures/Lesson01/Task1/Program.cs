using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

namespace Task1
{
    //1. Напишите на C# функцию согласно блок-схеме
    //Требуется реализовать на C# функцию согласно блок-схеме.
    //Блок-схема описывает алгоритм проверки, простое число или нет.
    //1. Написать консольное приложение.
    //2. Алгоритм реализовать отдельно в функции согласно блок-схеме.
    //3. Написать проверочный код в main функции.
    //4. Код выложить на GitHub.

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите число:");
                int n = 0;
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Введите натуральное (целое положительное) число");
                }
                string result = n + (isPrimeNumber(n) ? " простое" : " не простое") + " число.";
                Console.WriteLine(result);

                // Тесты
                bool result1 = isPrimeNumber(11) == true;
                Console.ForegroundColor = result1 ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine("Test 1 - " + (result1 ? "VALID TEST" : "INVALID TEST"));

                bool result2 = isPrimeNumber(6) == false;
                Console.ForegroundColor = result2 ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine("Test 2 - " + (result2 ? "VALID TEST" : "INVALID TEST"));

                // 0 - не простое число, т.к. не натуральное
                bool result3 = isPrimeNumber(0) == false;
                Console.ForegroundColor = result3 ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine("Test 3 - " + (result3 ? "VALID TEST" : "INVALID TEST"));

                // 1 — не является ни простым, ни составным числом, так как у него только один делитель — 1
                bool result4 = isPrimeNumber(1) == false;
                Console.ForegroundColor = result4 ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine("Test 3 - " + (result4 ? "VALID TEST" : "INVALID TEST"));                
            }
        }

        /// <summary>
        /// Функция определяет, является ли число простым.
        /// Простое число — натуральное (целое положительное) число,
        /// имеющее ровно два различных натуральных делителя — единицу и самого себя.
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <returns></returns>
        private static bool isPrimeNumber(int number)
        {
            // 0 и 1 не являются простыми числами, алгоритм это не учитывает.
            if(number == 0 || number == 1)
            {
                return false;
            }

            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }

            bool result = d == 0;
            return result;
        }
    }
}