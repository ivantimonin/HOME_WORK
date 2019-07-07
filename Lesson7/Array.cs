using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Array : ArrayPossibility
    {
        private int[] array;
        private int endIndexElement=-1;
        private int maxSize;

        public Array(int maxSize)
        {
            this.maxSize = maxSize;
            array = new int[maxSize];
        }
        
        // Вставка: время const (не зависит от кол-ва элементов)=> O(1) 
        public void Add(int elment)
        {
            endIndexElement++;
            if (maxSize < endIndexElement)
            {
                Console.WriteLine("Ошибка заполнения");            
            }
            else
            {
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
        public int FindIndex(int element)
        {
            for (int i = 0; i <= endIndexElement; i++)
            {
                if (array[i] == element)
                {
                    return (i);
                }
            }
            return (-1);
        }
        // В худшем случае придется перемещать все элементы. O(N)
        public void Insert(int element, int index)
        {
            if (index <= endIndexElement+1 && index>=0)
            {
                for (int i = endIndexElement; i >= index; i--)
                {
                    array[i+1] = array[i];                   
                }
                array[index] = element;
                endIndexElement++;
            }           
        }

        // В худшем случае придется перемещать почти все элементы, 
        //кроме удаляемого, но его тоже просматриваем, O(N), к туму же, еще есть и поиск
        //значит оба алгоритма: O(2*N*k), где k это кол-во повторов
        public void Remove(int element)
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
