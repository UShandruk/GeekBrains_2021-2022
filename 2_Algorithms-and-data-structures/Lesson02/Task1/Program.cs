using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

namespace Task1
{
    //1. Двусвязный список
    //Требуется реализовать класс двусвязного списка
    //и операции вставки, удаления и поиска элемента в нём
    //в соответствии с интерфейсом (дан интерфейс ILinkedList)

    class Program
    {
        static void Main(string[] args)
        {
            // Тесты
            bool result1 = Tests.GetCountTest();
            Console.ForegroundColor = result1 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("GetCountTest() - " + (result1 ? "VALID TEST" : "INVALID TEST"));

            bool result2 = Tests.AddNodeTest();
            Console.ForegroundColor = result2 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("AddNodeTest() - " + (result2 ? "VALID TEST" : "INVALID TEST"));

            bool result3 = Tests.AddNodeAfterTest();
            Console.ForegroundColor = result3 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("AddNodeAfterTest() - " + (result3 ? "VALID TEST" : "INVALID TEST"));

            bool result4 = Tests.RemoveNodeByIndexTest();
            Console.ForegroundColor = result4 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("RemoveNodeByIndexTest() - " + (result4 ? "VALID TEST" : "INVALID TEST"));

            bool result5 = Tests.RemoveNodeTest();
            Console.ForegroundColor = result5 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("RemoveNodeTest() - " + (result5 ? "VALID TEST" : "INVALID TEST"));

            bool result6 = Tests.FindNodeTest();
            Console.ForegroundColor = result6 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("FindNodeTest() - " + (result6 ? "VALID TEST" : "INVALID TEST"));

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}