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


        public void Rnd_array(int begin = 0, int end=100)//случайный массив
        {
           
            int count_size = maxSize;
            Random rnd = new Random();
            while (count_size > 0)
            {                
                int rnd_value = rnd.Next(begin, end);
                Add(rnd_value);
                count_size--;                
            }
        }

        public void Part_sort(int till_index, int begin = 0, int end = 100)//частично сорт массив
        {
            int count_size = maxSize;
            Random rnd = new Random();
            int right = end;
            int left = begin;
            while (count_size > 0)
            {                
                if (endIndexElement >= till_index)
                {
                    int rnd_value = rnd.Next(begin, end);
                    Add(rnd_value);
                    count_size--;
                }
                else
                {                    
                    int rnd_value = rnd.Next(left, right);
                    Add(rnd_value);
                    left = rnd_value;
                    if (left > right)
                    {
                        left = right;
                    }                   
                    
                    count_size--;
                }
            }
        }
        // Вставка: время const (не зависит от кол-ва элементов)=> O(1) 
        public void Add(int elment)
        {
            try
            {
                endIndexElement++;
                array[endIndexElement] = elment;

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка заполнения");
                Console.ReadLine();
                Environment.Exit(0);
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
        public void Bubl_sort_upgrade()//шейкерная сортировкка
        {
            int number_transposition = 0;
            int number_compare = 0;

            int i_up = endIndexElement;
            int j_down = 0;

            while(i_up>j_down)
            {
                
                int right=Direct_move(j_down, i_up);
                if (right == 0) { break; }
                i_up= right;

                int left=Revers_move(j_down, i_up);
                if (left == 0) { break; }
                j_down = left;                               
            }

            int Revers_move(int end, int begin)
            {
                int bound=0;
                for (int j = begin; j > end; j--)
                {
                    number_compare++;
                    if (array[j] < array[j-1])
                    {
                        Swap(ref array[j], ref array[j -1]);               
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Display();
                        Console.WriteLine("<------");
                        number_transposition++;
                        bound=j;
                    }
                }
                return bound;
            }

            int Direct_move(int begin, int end)
            {
                int bound=0;
                for (int j = begin; j < end; j++)
                {
                    number_compare++;
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);                                              
                        
                        Console.ForegroundColor = ConsoleColor.Red; ;
                        Display();
                        Console.WriteLine("------>");
                        number_transposition++;
                        bound=j;
                    }
                }
                return bound;
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Шейкерная");
            Console.WriteLine($"Число перестановок={number_transposition}");
            Console.WriteLine($"Число сравнений={number_compare}");
        }
        public void Bubl_sort()
        {
            int number_transposition = 0;
            int number_compare = 0;
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
