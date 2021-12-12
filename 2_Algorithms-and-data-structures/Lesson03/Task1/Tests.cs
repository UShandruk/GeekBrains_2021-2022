using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Tests
    {
        // Генерация данных заранее, чтобы расчёт шёл с различными значениями,
        // но сам код генерации выполнялся вне участка кода, время которого будет тестироваться.
        // приходится объявлять тут, т.к. у методов-тестов не должно быть аргументов
        List<PointClassFloat> pointClassFloatList = DataStorage.GetPointClassFloatList();
        List<PointStructFloat> pointStructFloatList = DataStorage.GetPointStructFloatList();
        List<PointStructDouble> pointStructDoubleList = DataStorage.GetPointStructDoubleList();

        /// <summary>
        /// 1. Расчёт дистанции со ссылочным типом (PointClass — координаты типа float).
        /// </summary>
        [Benchmark] // не работает со static, у метода не должно быть аргументов
        public double PointClassFloatTest()
        {
            PointClassFloat pointOne = pointClassFloatList[0];
            PointClassFloat pointTwo = pointClassFloatList[1];
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            double result = Math.Sqrt((x * x) + (y * y));
            return result;
        }

        /// <summary>
        /// 2. Расчёт дистанции со значимым типом (PointStruct — координаты типа float).
        /// </summary>
        [Benchmark]
        public float PointStructFloatTest()
        {
            PointStructFloat pointOne = pointStructFloatList[0];
            PointStructFloat pointTwo = pointStructFloatList[1];
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            float result = ((float)Math.Sqrt((x * x) + (y * y)));
            return result;
        }

        /// <summary>
        /// 3. Расчёт дистанции со значимым типом (PointStruct — координаты типа double).
        /// </summary>
        [Benchmark]
        public double PointStructDoubleTest()
        {
            PointStructDouble pointOne = pointStructDoubleList[0];
            PointStructDouble pointTwo = pointStructDoubleList[1];
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            double result = Math.Sqrt((x * x) + (y * y));
            return result;
        }

        /// <summary>
        /// 4. Расчёт дистанции без Math.Sqrt со значимым типом (PointStruct — координаты типа float).
        /// </summary>
        [Benchmark]
        public float PointStructFloatNoSqrtTest()
        {
            PointStructFloat pointOne = pointStructFloatList[0];
            PointStructFloat pointTwo = pointStructFloatList[1];
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            float result = fsrt(((x * x) + (y * y)));
            return result;
        }

        /// <summary>
        /// Квадратный корень без Math.Sqrt
        /// </summary>
        public float fsrt(float z)
        {
            if (z == 0) return 0;
            FloatIntUnion u;
            u.i = 0;
            u.f = z;
            u.i -= 1 << 23; // Subtract 2^m.
            u.i >>= 1; // Divide by 2.
            u.i += 1 << 29; // Add ((b + 1) / 2) * 2^m.
            return u.f;
        }

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public struct FloatIntUnion
        {
            [FieldOffset(0)]
            public int i;
            [FieldOffset(0)]
            public float f;
        }
    }
}