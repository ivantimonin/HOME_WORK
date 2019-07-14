using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Universal_array<T>
    {
        protected T[] array;
        protected int endIndexElement = -1;
        protected int maxSize;

        public Universal_array(int maxSize)
        {
            this.maxSize = maxSize;
            array = new T [maxSize];
        }

        public void Add(T elment)
        {

            if (maxSize < endIndexElement)
            {
                Console.WriteLine("Ошибка заполнения");
            }
            else
            {
                endIndexElement++;
                array[endIndexElement] = elment;

            }
        }

        public void Display()
        {
            for (int i = 0; i <= endIndexElement; i++)
            {
                Console.Write($"{array[i]}   ");
            }
        }

        //Поиск, перебор всех элементов. O(N)
        public int FindIndex(T element)
        {            
            for (int i = 0; i <= endIndexElement; i++)
            {
                if (array[i].Equals(element))
                {
                    return (i);
                }
            }
            return (-1);
        }
        // В худшем случае придется перемещать все элементы. O(N)
        public void Insert(T element, int index)
        {
            if (endIndexElement == -1 || index == endIndexElement + 1)
            {
                Add(element);
            }
            else if (index > endIndexElement + 1 || index < -1)
            {
                Console.WriteLine("Ошибка заполнения");
            }
            else
            {
                for (int i = 0; i <= endIndexElement; i++)
                {
                    if (i == index)
                    {
                        for (int j = endIndexElement + 1; j > i; j--)
                        {
                            array[j] = array[j - 1];
                        }
                        array[i] = element;
                        endIndexElement++;
                    }
                }
            }
        }

        // В худшем случае придется перемещать почти все элементы, 
        //кроме удаляемого, но его тоже просматриваем, O(N), к туму же, еще есть и поиск
        //значит оба алгоритма: O(2*N*k), где k это кол-во повторов
        public void Remove(T element)
        {
            while (true)
            {
                int index = FindIndex(element);
                if (index != -1)
                {
                    for (int i = index; i < endIndexElement; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    endIndexElement--;
                }
                else
                {
                    break;
                }
            }            
        }
    }    
}
