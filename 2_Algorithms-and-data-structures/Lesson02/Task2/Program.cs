using System;

namespace Task2
{
    // 2. Двоичный поиск
    // Требуется написать функцию бинарного поиска,
    // посчитать его асимптотическую сложность
    // и проверить работоспособность функции.

    class Program
    {
        static void Main(string[] args)
        {
            // Тесты
            bool result1 = Tests.BinarySearchPositiveTest();
            Console.ForegroundColor = result1 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("BinarySearchPositiveTest() - " + (result1 ? "VALID TEST" : "INVALID TEST"));

            bool result2 = Tests.BinarySearchNegativeTest();
            Console.ForegroundColor = result2 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("BinarySearchNegativeTest() - " + (result2 ? "VALID TEST" : "INVALID TEST"));

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}