using System;
using System.Collections.Generic;

namespace Task1_2_5
{
    // 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
    // 2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
    ////// 3. Определить, является ли введённое пользователем число чётным.
    ////// 4. Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете
    ////// и схематично нарисуйте его в консоли, только за место динамических, по вашему мнению, данных
    ////// (это может быть дата, название магазина, сумма покупок)
    ////// подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
    // 5. (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
    ////// 6. (*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели,
    ////// к примеру, чтобы описать работу какого либо офиса.
    ////// Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья
    ////// и выведите его на экран консоли.
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> months = new Dictionary<int, string>();
            months.Add(1, "Январь");
            months.Add(2, "Февраль");
            months.Add(3, "Март");
            months.Add(4, "Апрель");
            months.Add(5, "Май");
            months.Add(6, "Июнь");
            months.Add(7, "Июль");
            months.Add(8, "Август");
            months.Add(9, "Сентябрь");
            months.Add(10, "Октябрь");
            months.Add(11, "Ноябрь");
            months.Add(12, "Декабрь");

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите минимальную температуру за сутки");
                    int minTemperature = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите максимальную температуру за сутки");
                    int maxTemperature = Int32.Parse(Console.ReadLine());
                    int avgTemperature = (minTemperature + maxTemperature) / 2;
                    Console.WriteLine("Введите номер текущего месяца");
                    int monthNumber = Int32.Parse(Console.ReadLine());

                    Console.WriteLine($"Среднесуточная температура: {avgTemperature}");
                    Console.WriteLine($"Месяц: {months[monthNumber]}");

                    if (avgTemperature > 0 || monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    Console.WriteLine(); // отступ
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Пожалуйста, вводите только целые числа");
                }
            }
        }
    }
}
