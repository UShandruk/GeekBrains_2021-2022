using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Тесты.
    /// </summary>
    public static class Tests
    {
        private static int[] intArray = new int[] {1,3,6,7,88,90,1001,1200};

        /// <summary>
        /// 1. Тест возврата индекса элементов в списке (значение есть в массиве)
        /// </summary>
        public static bool BinarySearchPositiveTest()
        {
            Searcher searcher = new Searcher();
            
            bool result = searcher.BinarySearch(intArray, 6) == 2;
            return result;
        }

        /// <summary>
        /// 2. Тест возврата индекса элемента в списке (значения нет в массиве)
        /// </summary>
        public static bool BinarySearchNegativeTest()
        {
            Searcher searcher = new Searcher();

            bool result = searcher.BinarySearch(intArray, 2) == -1;
            return result;
        }
    }
}