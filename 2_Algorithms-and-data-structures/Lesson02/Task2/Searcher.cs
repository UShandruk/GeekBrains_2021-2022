using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Searcher
    {
        /// <summary>
        /// Двоичный поиск
        /// </summary>
        /// <param name="inputArray">Массив, в котором нужно выполнить поиск</param>
        /// <param name="searchValue">Значение, которое нужно найти</param>
        /// <returns>Индекс элемента либо -1, если элемент не найден</returns>
        public int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;// O(1)
            int max = inputArray.Length - 1;
            while (min <= max) // O(i(N))
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}

// Асимптотическая сложность:
// O(N), т.к. в методе есть один цикл.