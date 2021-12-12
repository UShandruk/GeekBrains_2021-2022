using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Точка
    /// </summary>
    public struct PointStructDouble
    {
        /// <summary>
        /// Значение координаты X
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Значение координаты Y
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x">Значение координаты X</param>
        /// <param name="y">Значение координаты Y</param>
        public PointStructDouble(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}