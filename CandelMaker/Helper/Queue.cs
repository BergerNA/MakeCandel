using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    /// <summary>
    /// Класс реализующий замкнутую очередь.
    /// </summary>
    /// <typeparam name="T"> Тип объектов очереди. </typeparam>
    internal class Queue<T> where T : class
    {

        private int outputIndex;
        private int inputIndex;
        private int size;
        private int pushLength;
        private T[] List;

        /// <summary>
        /// Конструктор класса Queue<T>
        /// </summary>
        /// <param name="size"> Размер очереди. </param>
        public Queue(int size)
        {
            List = new T[size];
            this.size = size;
            inputIndex = 0;
            outputIndex = 0;
            pushLength = 0;
        }

        /// <summary>
        /// Положить объект в очередь.
        /// </summary>
        /// <param name="obj"> Добавляемый объект. </param>
        /// <returns> Успех операции добавления </returns>
        public bool Push(T obj)
        {
            if (pushLength != size)
            {
                List[inputIndex] = obj;
                if (++inputIndex >= size)
                    inputIndex = 0;
                pushLength++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Извлечь из очереди один объект.
        /// </summary>
        /// <returns> Объект очереди. </returns>
        public T Pop()
        {
            if (pushLength != 0)
            {
                T result = List[outputIndex];
                if (++outputIndex >= size)
                    outputIndex = 0;
                pushLength--;
                return result;
            }
            return null;
        }

        /// <summary>
        /// Проверка переполнения очереди 
        /// </summary>
        /// <returns> Результат. </returns>
        public bool IsEmpty()
        {
            if (pushLength == size)
                return true;
            return false;
        }

        /// <summary>
        /// Размер очереди.
        /// </summary>
        /// <returns> Размер очереди. </returns>
        public int Length()
        {
            return pushLength;
        }
    }
}
