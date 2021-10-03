using System;

namespace TaskWithStar
{
    class Program
    {
        // Урок 1, задание со *.
        // Написать программу, преобразующую число из римской системы счисления в арабскую.
        static void Main(string[] args)
        {
            // Бесконечный цикл:
<<<<<<< Updated upstream
            // - чтобы программа не закрывалась сразу же послде вывода результата
=======
            // - чтобы программа не закрывалась сразу же после вывода результата
>>>>>>> Stashed changes
            // - чтобы можно было конвертировать сколько угодно чисел, а не запускать программу для каждого числа
            while (true) 
            {
                Console.WriteLine("Введите число в римской системе счисления и нажмите на \"Enter\".");
                string romanNumber = Console.ReadLine();
                string result = Converter.Convert(romanNumber);                
                Console.WriteLine(result);
                Console.WriteLine(); // Отступ 
            }
        }
    }
}