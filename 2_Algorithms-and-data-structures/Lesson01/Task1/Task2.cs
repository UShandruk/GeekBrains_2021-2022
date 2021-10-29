using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // 2. Посчитайте сложность функции
    // Вычислите асимптотическую сложность функции из примера ниже.

    public class Task2
    {
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(i(N))
            {
                for (int j = 0; j < inputArray.Length; j++) // O(j(N))
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(k(N))
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;// O(1)
                        }
                        sum += inputArray[i] + i + k + j + y;// O(1)
                    }
                }
            }
            return sum;
        }
    }
}
// Асимптотическая сложность:
// O(i(N)) * O(j(N)) * O(k(N)) = O(N3), т.е. O (N в кубе),
// т.к. в методе есть три цикла, вложенных друг в друга.