using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Task1
{
    // 1. Написать консольное приложение Task Manager, которое
    // выводит на экран запущенные процессы и позволяет завершить указанный процесс.
    // Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
    // В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Процессы:");
            ShowRunningProcesses();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Чтобы завершить процесс введите его ID:");
                string id = Console.ReadLine();
                EndProcess(id);
            }
        }

        /// <summary>
        /// Получить список запущенных процессов
        /// </summary>
        private static void ShowRunningProcesses()
        {
            List<Process> activeProcesses = Process.GetProcesses().OrderBy(x => x.ProcessName).ToList<Process>();
            foreach (var p in activeProcesses)
            {
                Console.WriteLine(p.Id + "   " + p.ProcessName);
            }
        }

        /// <summary>
        /// Завершить процесс
        /// </summary>
        private static void EndProcess(string rawData)
        {
            int id;
            if (int.TryParse(rawData, out id))
            {
                try
                {
                    Process p = Process.GetProcessById(id);
                    p.Kill();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"\"{rawData}\" не является числом");
                Console.WriteLine();
            }
        }
    }
}