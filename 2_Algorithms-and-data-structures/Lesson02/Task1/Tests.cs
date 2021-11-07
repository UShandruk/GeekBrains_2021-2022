using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Тесты.
    /// Вызывать в порядке объявления, т.к. они связаны между собой.
    /// </summary>
    public static class Tests
    {
        private static DoublyLinkedList list = new DoublyLinkedList();
        private static int searchValue = 5;
        private static int addNodeAfterValue = 8;

        /// <summary>
        /// 1. Тест возврата количества элементов в списке
        /// </summary>
        public static bool GetCountTest()
        {
            bool result = list.GetCount() == 0;
            return result;
        }

        /// <summary>
        /// 2. Тест добавления нового элемента списка
        /// (добавляем два узла, чтобы заполнить начальный и конечный узлы, тогда count будет = 2
        /// и в тесте AddNodeAfterTest() метод AddNodeAfter не вызвал метод AddNode, который уже проверяется в даном тесте, AddNodeTest())
        /// </summary>
        public static bool AddNodeTest()
        {
            list.AddNode(searchValue);
            list.AddNode(addNodeAfterValue);
            bool result = list.GetCount() == 2;
            return result;
        }

        /// <summary>
        /// 3. Тест добавления нового элемента списка после определённого элемента
        /// </summary>
        public static bool AddNodeAfterTest()
        {
            Node node = new Node(addNodeAfterValue);
            list.AddNodeAfter(node, 4);
            bool result = list.GetCount() == 3 && list.FindNode(searchValue) != null;
            return result;
        }

        /// <summary>
        /// 4. Тест поиска элемента по его значению
        /// </summary>
        public static bool FindNodeTest()
        {
            bool result = list.FindNode(searchValue) != null;
            return result;
        }

        /// <summary>
        /// 5. Тест удаления элемента по порядковому номеру (индексу)
        /// </summary>
        public static bool RemoveNodeByIndexTest()
        {
            int indexToRemove = 1;
            int countBefore = list.GetCount();
            list.RemoveNode(indexToRemove);
            int countAfter = list.GetCount();
            bool result = countAfter < countBefore;
            return result;
        }

        /// <summary>
        /// 6. Тест удаления указанного элемента
        /// </summary>
        public static bool RemoveNodeTest()
        {
            Node node = list.FindNode(searchValue);
            int countBefore = list.GetCount();
            list.RemoveNode(node);
            int countAfter = list.GetCount();
            bool result = countAfter < countBefore;
            return result;
        }
    }
}