using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Logic
    {

        /// <summary>
        /// 1. Просмотр файловой структуры
        /// </summary>
        /// <param name="path">Путь к папке</param>
        /// <param name="folderLine">Символы перед названием папки</param>
        /// <param name="fileLine">Символы перед названием файла</param>
        public static void PrintFileStructure(string path, string folderLine, string fileLine)
        {
            if (Directory.Exists(path))
            {
                fileLine = "  " + fileLine;
                folderLine = "  " + folderLine;

                // Папки
                string[] dirs = Directory.GetDirectories(path);
                foreach (string p in dirs)
                {
                    string innerPath = folderLine + p.Split('\\').Last();
                    Console.WriteLine(innerPath);

                    // Файлы                
                    string[] files = Directory.GetFiles(p);
                    foreach (string fp in files)
                    {
                        string finnerPath = fileLine + fp.Split('\\').Last();
                        Console.WriteLine(finnerPath);
                    }

                    PrintFileStructure(p, folderLine, fileLine);
                }
                // Файлы                
                string[] files1 = Directory.GetFiles(path);
                foreach (string fp in files1)
                {
                    string finnerPath = fileLine + fp.Split('\\').Last();
                    Console.WriteLine(finnerPath);
                }
            }
            else
                Console.WriteLine($"{path} не найден.");
        }

        /// <summary>
        /// 2. Копирование файлов, каталогов;
        /// </summary>
        /// <param name="path">Путь к файлу или папке</param>
        /// <param name="newpath">Новый путь к файлу или папке</param>
        public static void Copy(string path, string newPath)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.CopyTo(path, true);
            }
            else
            {
                Console.WriteLine($"{path} не найден.");
            }
        }

        /// <summary>
        /// 3. Удаление файлов, каталогов;
        /// </summary>
        /// <param name="path">Путь к файлу или папке</param>
        public static void Delete(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
                Console.WriteLine($"{path} удален.");
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (dirInfo.Exists)
                {
                    dirInfo.Delete();
                }
                else
                {
                    Console.WriteLine($"{path} не найден.");
                }
            }
        }

        /// <summary>
        /// 4. Получение информации о размерах, системных атрибутов файла, каталога
        /// </summary>
        /// <param name="path">Путь к файлу или папке</param>
        public static void PrintInfo(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                Console.WriteLine("Размер: {0}", fileInfo.Length);
                Console.WriteLine("Имя: {0}", fileInfo.Name);
                Console.WriteLine("Время создания: {0}", fileInfo.CreationTime);
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (dirInfo.Exists)
                {
                    Console.WriteLine("Имя: {0}", dirInfo.Name);
                    Console.WriteLine("Время создания: {0}", dirInfo.CreationTime);
                }
                else
                {
                    Console.WriteLine($"{path} не найден.");
                }
            }
        }
    }
}