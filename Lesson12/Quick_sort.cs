using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Quick_sort
    {
        private int[] array_for_sort { get; set; }
        
        public Quick_sort(int [] array_for_sort)
        {
            this.array_for_sort = array_for_sort;         
        }

        public int [] Quick_sorT_arr_()
        {
            int left_ptr = 0; // бегунок левого значения
            int right_ptr = array_for_sort.Length-2;
            Quick_sorT_arr(left_ptr, right_ptr);
            return array_for_sort;
        }

        private  void Quick_sorT_arr(int left_ptr, int right_ptr)
        {
            if (right_ptr - left_ptr < 0) { return; }
            else
            {
               int piv=Partition(left_ptr, right_ptr);
               Quick_sorT_arr(left_ptr, piv-1);
               Quick_sorT_arr(piv+1, right_ptr);
            }
        }

        private  int Partition(int left_ptr, int right_ptr)
        {
            int piv = right_ptr + 1;// опорное значение
            while (left_ptr<right_ptr)
            {
                while (array_for_sort[piv] > array_for_sort[left_ptr] && left_ptr<piv-1)
                {
                    left_ptr++;
                }
                while (array_for_sort[piv] < array_for_sort[right_ptr] && left_ptr != right_ptr)
                {
                    right_ptr--;
                }
                if (left_ptr != right_ptr)
                {
                    Swap(right_ptr, left_ptr, array_for_sort);
                    right_ptr--;
                    if (right_ptr != left_ptr)// иначе left_ptr будет больше right_ptr и граница будет найдена неправильно
                    {
                        left_ptr++;
                    }                    
                }                
            }
            if (array_for_sort[piv] < array_for_sort[right_ptr])
            {
                int tmp = array_for_sort[piv];
                for (int i = piv; i > left_ptr; i--)
                {
                    array_for_sort[i] = array_for_sort[i - 1];
                }
                array_for_sort[left_ptr] = tmp;
            }            
            return left_ptr;// граница
        }

        private void Swap(int right_ptr, int left_ptr, int [] array_for_sort)
        {
            int tmp = array_for_sort[right_ptr];
            array_for_sort[right_ptr] = array_for_sort[left_ptr];
            array_for_sort[left_ptr] = tmp;
        }        
    }
}
