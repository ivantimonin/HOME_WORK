using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Array : Array_action
    {
        private int count = -1;
        private int[] array;

        public void Insert_element(int index, int element)
        {
            if (count != -1 && index == array.Length)
            {
                Add_element(element);
            }
            else if (count == -1 && index == 0)
            {
                Add_element(element);
            }
            else if (count!=-1 && index<array.Length)
            {
                int[] temp_array = new int[array.Length + 1];
                int i_temp=0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        temp_array[i_temp] = element;
                        i_temp++;
                    }
                    temp_array[i_temp] = array[i];
                    i_temp++;                  
                }
                array = new int[temp_array.Length];
                array = temp_array;
            }
        }

        public void Add_element(int element)
        {
            count++;
            if (count == 0)
            {
                array = new int[1];
                array[0] = element;
            }
            else
            {                
                int[] temp_array = new int[count];
                temp_array = array;
                array = new int[count + 1];
                for (int i = 0; i <=array.Length-1; i++)
                {
                    if (i == array.Length-1)
                    {
                        array[i] = element;
                        break;
                    }
                    array[i] = temp_array[i];
                }
            }               
        }

        public int Find_element(int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return (i);
                }                    
            }
            return -1;            
        }

        public void Remove_element(int element)
        {
            while (true)
            {
                int index_of_find_element = Find_element(element);
                if (index_of_find_element != -1)
                {
                    for (int i = index_of_find_element; i < array.Length - 1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    int[] new_array = new int[array.Length - 1];
                    for (int i = 0; i < new_array.Length; i++)
                    {
                        new_array[i] = array[i];
                    }
                    array = new int[new_array.Length];
                    array = new_array;
                }
                else
                {
                    break;
                }
            }
            
            
        }

        public void Display_array()
        {
            if (count == -1)
            {
                Console.Write("Массив:[ ]");
            }
            else
            {
                Console.Write("Массив:[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]};");                    
                }
                Console.Write("]");
            }                   
        }
    }
}
