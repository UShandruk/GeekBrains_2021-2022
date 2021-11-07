using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Интерфейс (дан в задании 1)
    /// </summary>
    public interface ILinkedList
    {
        /// <summary>
        /// возвращает количество элементов в списке
        /// </summary>
        /// <returns>количество элементов в списке</returns>
        int GetCount();

        /// <summary>
        /// добавляет новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        void AddNode(int value);

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        void AddNodeAfter(Node node, int value);
        
        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        void RemoveNode(int index);

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        void RemoveNode(Node node);
        
        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        Node FindNode(int searchValue);
    }
}