using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Элемент списка (дан в задании)
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Следующий элемент
        /// </summary>
        public Node NextNode { get; set; }

        /// <summary>
        /// Предыдущий элемент
        /// </summary>
        public Node PrevNode { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value">Значение</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
