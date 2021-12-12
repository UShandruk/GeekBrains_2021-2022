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
    public class PointClassFloat
    {
        /// <summary>
        /// Значение координаты X
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Значение координаты Y
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x">Значение координаты X</param>
        /// <param name="y">Значение координаты Y</param>
        public PointClassFloat(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}