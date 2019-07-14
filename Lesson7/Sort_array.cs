using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Sort_array : Array, Isort_array
    {
        public Sort_array(int maxSize) : base(maxSize) { }        
       
        public void Add(int element)
        {
            if (maxSize < endIndexElement)
            {
                Console.WriteLine("Ошибка заполнения");
            }
            else
            {
                if (endIndexElement == -1)
                {
                    array[0] = element;
                    endIndexElement++;
                }
                else
                {
                    for (int i = 0; i <= endIndexElement; i++)
                    {
                        if (array[i] <= element)
                        {
                            if (i == endIndexElement)
                            {
                                array[endIndexElement + 1] = element;
                                endIndexElement++;
                                break;
                            }
                            continue;
                        }
                        else
                        {
                            for (int j = endIndexElement + 1; j > i; j--)
                            {
                                array[j] = array[j - 1];
                            }
                            array[i] = element;
                            endIndexElement++;
                            break;
                        }
                    }
                }
            }

        }

        public void Find(int element)
        {
            if (endIndexElement >= 0)
            {
                if (element < array[0] || element > array[endIndexElement])
                {
                    Console.WriteLine("Искомого элемента в массиве нет");
                }
                else
                {
                    int middle;
                    int up = endIndexElement;
                    int down = 0;
                    while (true)
                    {
                        middle = (up + down) / 2;
                        if (element == array[middle])
                        {
                            Console.WriteLine($"Искомый индекс {middle}");
                            break;
                        }
                        if (element > array[middle])
                        {
                            down = middle + 1;
                        }
                        if (element < array[middle])
                        {
                            up = middle - 1;
                        }
                        if (up < down)
                        {
                            Console.WriteLine("Искомого элемента в массиве нет");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Массив пуст");
            }
        }
    }
}
