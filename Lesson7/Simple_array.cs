using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Simple_array : Array, Isimple_array
    {
        public Simple_array(int maxSize) : base(maxSize) { }
        
        
        // Вставка: время const (не зависит от кол-ва элементов)=> O(1) 
        public void Add(int elment)
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
            for (int i = endIndexElement; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = element;
            endIndexElement++;                    
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

        //Перестановка и сравнение O(N^2) 
        public void Bubl_sort()
        {
            int number_transposition=0;
            int number_compare=0;
            for (int i = endIndexElement; i > 0; i--)
            {                
                for (int j = 0; j < i; j++)
                {
                    number_compare++;
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        number_transposition++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Пузырьковая");
            Console.WriteLine($"Число перестановок={number_transposition}");
            Console.WriteLine($"Число сравнений={number_compare}");
        }

        //Перестановка O(N), сравнение O(N^2) 
        public void Select_sort()
        {
            int number_transposition = 0;
            int number_compare = 0;
            for (int j = endIndexElement; j > 0; j--)
            {
                int index_max = 0;
                for (int i = 1; i <= j; i++)
                {
                    number_compare++;
                    if (array[i] > array[index_max])
                    {
                        index_max = i;
                    }
                }
                number_transposition++;
                Swap(ref array[index_max], ref array[j]);                
            }
            Console.WriteLine();
            Console.WriteLine("Методом выбора");
            Console.WriteLine($"Число перестановок={number_transposition}");
            Console.WriteLine($"Число сравнений={number_compare}");
        }

        //Перестановка O(N), сравнение O(N^2) 
        public void Insert_sort()
        {
            int number_transposition = 0;
            int number_compare = 0;
            
            for (int i = 1; i <= endIndexElement; i++)
            {
                int tmp = array[i];
                int j = i;
                for ( ; j > 0 && array[j-1] >= tmp; j--)
                {
                    number_compare++;
                    number_transposition++;
                    array[j] = array[j - 1];                    
                }
                array[j] = tmp;               
            }
            Console.WriteLine();
            Console.WriteLine("Метод вставки");
            Console.WriteLine($"Число перестановок={number_transposition}");
            Console.WriteLine($"Число сравнений={number_compare}");
        }
        private void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
