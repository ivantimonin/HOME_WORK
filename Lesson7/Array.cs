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
            for (int i = 0; i <= array.Length; i++)
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
            throw new NotImplementedException();
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
