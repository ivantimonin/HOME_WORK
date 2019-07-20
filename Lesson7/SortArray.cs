using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class SortArray
    {         

        public static void Bubl_sort(int [] array, int endIndexElement)
        {
            
            for (int i = endIndexElement; i > 0; i--)
            {
                for (int j = 0; j< i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            
        }

        public static void Select_sort(int[] array, int endIndexElement)
        {
            
            for (int j = endIndexElement; j > 0; j--)
            {
                int index_max = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (array[i] > array[index_max])
                    {
                        index_max = i;
                    }
                }
                int tmp = array[index_max];
                array[index_max] = array[j];
                array[j] = tmp;
            }
        }

        public static void Insert_sort(int[] array, int endIndexElement)
        {
            
            for (int i = 0; i <= endIndexElement; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int index_element_ins = i+1;
                    for (int j = index_element_ins-1; j >= 0; j--)
                    {
                        if (array[j] < array[index_element_ins])
                        {
                            int index_element_for_ins = j+1;
                            array = Insert(index_element_for_ins, index_element_ins, array);                       
                            break;
                        }
                    }                   
                }
            }
            int[] Insert(int index_element_for_ins, int index_element_ins, int[] array_tmp)
            {
                int tmp = array_tmp[index_element_ins];
                for (int i = index_element_ins - 1; i >= index_element_for_ins; i--)
                {
                    array[i + 1] = array[i];
                }
                array_tmp[index_element_for_ins] = tmp;
                return array_tmp;
            }
        }             
    }  
}
