using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Obj_array 
    {
        private Person[] array;
        private int maxsize;
        private int endIndexelement = -1;
        public Obj_array(int maxsize)
        {
            this.maxsize = maxsize;
            array = new Person[maxsize];            
        }

        public void Add(Person element)
        {
            if (endIndexelement < maxsize)
            {
                endIndexelement++;
                array[endIndexelement] = element;
            }
            else
            {
                Console.WriteLine("Ошибка заполнения");
            }
        }

        public int FindIndex(string Surname)
        {
            for (int i = 0; i <= endIndexelement; i++)
            {
                if (array[i].surname.Equals(Surname))
                {
                    return (i);
                }
            }
            return (-1); //объект с такой фамилией не найден
        }

        public void Insert(Person element, int index)
        {
            if (endIndexelement == -1 || index==endIndexelement+1)
            {
                Add(element);
            }
            else if (index > endIndexelement+1 || index < -1)
            {
                Console.WriteLine("Ошибка заполнения");
            }
            else
            {
                for (int i = 0; i <= endIndexelement; i++)
                {
                    if (i == index)
                    {
                        for (int j = endIndexelement + 1; j > i; j--)
                        {
                            array[j] = array[j - 1];
                        }
                        array[i] = element;
                        endIndexelement++;
                    }
                }
            }
        }       

        //Перестановка и сравнение O(N^2) 
        public void Bubl_sort()
        {
            int number_transposition = 0;
            int number_compare = 0;
            for (int i = endIndexelement; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    number_compare++;
                    if (array[j].age > array[j + 1].age)
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
            for (int j = endIndexelement; j > 0; j--)
            {
                int index_max = 0;
                for (int i = 1; i <= j; i++)
                {
                    number_compare++;
                    if (array[i].age > array[index_max].age)
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

            for (int i = 1; i <= endIndexelement; i++)
            {
                Person tmp = array[i];
                int j = i;
                for (; j > 0 && array[j - 1].age >= tmp.age; j--)
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
        public void Remove(string element)
        {
            int index = FindIndex(element);
            if (index == -1)
            {
                Console.WriteLine("Элемент для удаления не найден");
            }
            else
            {
                for (int i = index; i < endIndexelement; i++)
                {
                    array[i] = array[i + 1];

                }
                endIndexelement--;
            }
        }
        private void Swap(ref Person a, ref Person b)
        {
            Person tmp = a;
            a = b;
            b = tmp;
        }   


        public void Display()
        {
            for (int i = 0; i <= endIndexelement; i++)
            {
                Console.WriteLine($"{i}) {array[i].name} {array[i].surname} {array[i].age};");
            }
        }
    }
}
