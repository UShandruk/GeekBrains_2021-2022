using System;

namespace Task3
{
    //////1. Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
    //////Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
    //////2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.
    //////Ввести данные с клавиатуры и вывести результат на экран.
    //3. Написать метод по определению времени года.
    //На вход подаётся число – порядковый номер месяца.
    //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
    //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень).
    //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
    //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
    //////4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
    class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер месяца.");
                string result;

                try
                {
                    int month = Int32.Parse(Console.ReadLine());
                    result = GetSeason(month);
                }
                catch (Exception ex)
                {
                    result = "Ошибка: введите число";
                }

                Console.WriteLine(result);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Определить время года по номеру месяца
        /// </summary>
        static string GetSeason(int monthNumber)
        {
            if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
            {
                return Season.Winter.ToString();
            }
            else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)
            {
                return Season.Spring.ToString();
            }

            if (monthNumber == 6 || monthNumber == 6 || monthNumber == 8)
            {
                return Season.Summer.ToString();
            }

            if (monthNumber == 9 || monthNumber == 10 || monthNumber == 11)
            {
                return Season.Autumn.ToString();
            }
            else return "Ошибка: введите число от 1 до 12";
        }
    }
}