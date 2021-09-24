using System;

namespace Homework
{
    class Program
    {
        // Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
        // Имя пользователя сохранить из консоли в промежуточную переменную.
        // Поставить точку останова и посмотреть значение этой переменной в режиме отладки.
        // Запустить исполняемый файл через системный терминал.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя.");
            string userName = Console.ReadLine();
            DateTime date = DateTime.Now;
            //Console.WriteLine("Привет, " + userName + ", сегодня " + date);
            Console.WriteLine($"Привет, {userName}, сегодня {date}");
        }
    }
}