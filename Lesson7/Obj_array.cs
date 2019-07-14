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

        public void Display()
        {
            for (int i = 0; i <= endIndexelement; i++)
            {
                Console.WriteLine($"{i}) {array[i].name} {array[i].surname} {array[i].age};");
            }
        }
    }
}
