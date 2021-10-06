using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Запись о товаре
    /// </summary>
    public class ProductString
    {
        /// <summary>
        /// Уникальный идентификатор товара
        /// </summary>
        public int Id;

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name;

        /// <summary>
        /// Цена
        /// </summary>
        public double Price;

        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ProductString(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
