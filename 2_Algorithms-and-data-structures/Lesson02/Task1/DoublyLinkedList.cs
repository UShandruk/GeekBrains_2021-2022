using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Двусвязный список, реализующий интерфейс ILinkedList (дан в задании 1)
    /// </summary>
    public class DoublyLinkedList:ILinkedList
    {
        /// <summary>
        /// Количество элементов в списке
        /// </summary>
        private int count;

        /// <summary>
        /// Начальный (нулевой) элемент в списке
        /// </summary>
        public Node StartNode;

        /// <summary>
        /// Конечный элемент в списке
        /// </summary>
        public Node EndNode;

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns>Количество элементов в списке</returns>
        public int GetCount()
        {
            return count;
        }

        /// <summary>
        /// Добавляет новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            Node node = new Node(value);
            if (StartNode == null)
                StartNode = node;
            else if (EndNode == null)
            {
                EndNode = node;
                StartNode.NextNode = node;
                EndNode.PrevNode = StartNode;
            }
            else
            {
                EndNode.NextNode = node;
                node.PrevNode = EndNode;
            }
            count++;
        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node">новый элемент</param>
        /// <param name="value">значение узла (не индекс)</param>
        public void AddNodeAfter(Node node, int value)
        {
            // если кол-во узлов меньше 2, значит нет начального и/или конечного узла, этот случай уже обработан в методе AddNode().
            if (count<2)
                AddNode(node.Value);
            else
            {
                // найти по int value узел, после которого нужно вставлять. Этот узел станет предыдущим.
                Node nodeWillBePrevios = FindNode(node.Value);
                // найти узел, который будет следующим
                Node nodeWillBeNext = nodeWillBePrevios.NextNode;

                // прописать вставляемому узлу NextNode 
                node.NextNode = nodeWillBeNext;
                // прописать вставляемому узлу PrevNode
                node.PrevNode = nodeWillBePrevios;
                // прописать вставляемый узел в NextNode узла nodeWillBePrevios
                nodeWillBePrevios.NextNode = node;
                // прописать вставляемый узел в PrevNode узла nodeWillBeNext, если nodeWillBeNext есть
                if (nodeWillBeNext != null)
                {
                    nodeWillBeNext.PrevNode = node;
                }
            }
            count++;
        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру (индексу)
        /// </summary>
        /// <param name="index">Порядковый номер (индекс)</param>
        public void RemoveNode(int index)
        {
            Node nodeForRemove = FindNodeByIndex(index);
            rmNode(nodeForRemove);
        }

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        public void RemoveNode(Node node)
        {
            rmNode(node);
        }

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue">Значение (не индекс)</param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            Node currentNode = StartNode;

            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;                
            }
            return null; // достигли последнего элемента в списке, но не нашли нужный элемент
        }

        /// <summary>
        /// Ищет элемент по его индексу
        /// </summary>
        /// <param name="searchIndex">Индекс</param>
        /// <returns></returns>
        public Node FindNodeByIndex(int searchIndex)
        {
            Node currentNode = StartNode;

            for (int i = 0; i <= count; i++)
            {
                if (i == searchIndex)
                {
                    return currentNode;
                }
                else if (i != searchIndex && currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            return null; // достигли последнего элемента в списке, но не нашли нужный элемент
        }

        /// <summary>
        /// Удаляет элемент (проставляет связи в обход удаляемого элемента)
        /// </summary>
        /// <param name="node"></param>
        private void rmNode (Node nodeForRemove)
        {
            Node nodeWillBePrevios = nodeForRemove.PrevNode;
            Node nodeWillBeNext = nodeForRemove.NextNode;
            if (nodeWillBePrevios != null)
            {
                nodeWillBePrevios.NextNode = nodeWillBeNext;
            }
            if (nodeWillBeNext != null)
            {
                nodeWillBeNext.PrevNode = nodeWillBePrevios;
            }
            count--;
        }
    }
}