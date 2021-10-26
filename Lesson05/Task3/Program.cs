using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    //////1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
    //////2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
    //3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
    //////4. (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
    //////5. (*) Список задач (ToDo-list):
    //////● написать приложение для ввода списка задач;
    //////● задачу описать классом ToDo с полями Title и IsDone;
    //////● на старте, если есть файл tasks.json/xml/bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
    //////● если задача выполнена, вывести перед её названием строку «[x]»;
    //////● вывести порядковый номер для каждой задачи;
    //////● при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
    //////● записать актуальный массив задач в файл tasks.json/xml/bin.
  
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 255;

            while (true)
            {
                Console.WriteLine($"Введите числа от {min} до {max} для записи в бинарный файл");
                string rawData = Console.ReadLine();
                byte[] numbers = validateAndConvertToByteArray(rawData, min, max);

                string filename = "text.txt";
                File.WriteAllBytes(filename, numbers);

                Console.WriteLine("Текст записан");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Проверить и конвертировать значения
        /// </summary>
        /// <param name="rawData">Пользовательские данные</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns></returns>
        private static byte[] validateAndConvertToByteArray(string rawData, int min, int max)
        {            
            List<byte> listByte = new List<byte>();
            int tmp;
            string[] numbers = rawData.Split(' ');

            foreach (string s in numbers)
            {
                try
                {
                    tmp = Int32.Parse(s);
                    if(tmp <= max || tmp >= min)
                    {
                        listByte.Add(((byte)tmp));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            byte[] result = listByte.ToArray();

            return result;
        }
    }
}
