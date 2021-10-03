using System;

namespace Task1
{
    class Program
    {
        // Урок 1, задача 1.
        // Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
        // Имя пользователя сохранить из консоли в промежуточную переменную.
        // Поставить точку останова и посмотреть значение этой переменной в режиме отладки.
        // Запустить исполняемый файл через системный терминал.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя.");
            string userName = Console.ReadLine();
            DateTime date = DateTime.Now;
            string greeting = $"Привет, {userName}! Сегодня {date}.";
            Console.WriteLine(greeting);
        }
    }
}
