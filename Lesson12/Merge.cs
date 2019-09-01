using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Merge
    {
        public static int[] Merge_f(int[] arr, int[] arr1)// 1 вариант метода
        {
            bool check_array = Check_array(arr, arr1);
            if (check_array == false)
            {
                throw new Exception("Массивы должны быть отсортированы по возрастанию");
            }
            int[] arr_new = new int[arr.Length + arr1.Length];
            int count = 0;
            int index_arr = 0;
            int index_arr1 = 0;
            while (count < arr_new.Length)
            {
                try
                {
                    if (arr[index_arr] < arr1[index_arr1])
                    {
                        arr_new[count] = arr[index_arr];
                        index_arr++;
                        count++;
                    }

                    else if (arr[index_arr] > arr1[index_arr1])
                    {
                        arr_new[count] = arr1[index_arr1];
                        index_arr1++;
                        count++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    if (index_arr1 > index_arr || arr.Length > arr1.Length)
                    {
                        while (count < arr_new.Length)
                        {
                            arr_new[count] = arr[index_arr];
                            index_arr++;
                            count++;
                        }
                        break;
                    }
                    if (index_arr1 < index_arr || arr1.Length > arr.Length)
                    {
                        while (count < arr_new.Length)
                        {
                            arr_new[count] = arr1[index_arr1];
                            index_arr1++;
                            count++;
                        }
                        break;
                    }
                }
            }
            return (arr_new);
        }

        public static int[] Merge_f_2(int[] arr1, int[] arr2)// 2 вариант метода
        {
            bool check_array = Check_array(arr1, arr2);
            if (check_array == false)
            {
                throw new Exception("Массивы должны быть отсортированы по возрастанию");
            }
            int index_arr1 = 0, index_arr2 = 0;
            int[] new_arr = new int[arr1.Length+arr2.Length];
            while (index_arr1 < arr1.Length && index_arr2 < arr2.Length)
            {
                if (arr1[index_arr1] < arr2[index_arr2])
                {
                    new_arr[index_arr1 + index_arr2] = arr1[index_arr1++];
                }
                else
                {
                    new_arr[index_arr1 + index_arr2] = arr2[index_arr2++];
                }
            }
            while (index_arr1 < arr1.Length)
            {
                new_arr[index_arr1 + index_arr2] = arr1[index_arr1++];
            }
            while (index_arr2 < arr2.Length)
            {
                new_arr[index_arr1 + index_arr2] = arr2[index_arr2++];
            }
            return (new_arr);
        }      


        public static int[] Merge_sort(int [] arr_for_sort)
        {
            
            if (arr_for_sort.Length < 2)
            {
                return arr_for_sort;
            }
            else
            {
                int midl =arr_for_sort.Length / 2;
                int[] sort_left = Merge_sort(Srez_after_midl(midl, arr_for_sort));
                int[] sort_right = Merge_sort(Srez_till_midl(midl, arr_for_sort));
                return Merge_f_2(sort_left, sort_right);
            }
        }

        public static int [] Srez_after_midl(int midl, int[] arr )// отбросить все что после midl
        {
            int[] new_arr = new int [midl];
            for (int j = 0; j < new_arr.Length; j++)
            {
                new_arr[j] = arr[j];                
            }
            foreach (int value in new_arr)
            {
                Console.Write($" { value};");
            }
            Console.WriteLine();
            return new_arr;
        }

        public static int[] Srez_till_midl(int midl, int[] arr)// отбросить все что перед midl и сам мидл
        {
            int[] new_arr = new int[arr.Length-midl];
            int count = 0;
            for (int j = midl; j < arr.Length; j++)
            {
                new_arr[count++] = arr[j];
            }
            foreach (int value in new_arr)
            {                
                Console.Write($" { value}; ");
            }
            Console.WriteLine();
            
            return new_arr;
        }



        private static bool Check_array(int [] arr, int [] arr1)
        {            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] < 0)
                {
                    return (false);
                }
            }

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i + 1] - arr1[i] < 0)
                {
                    return (false);
                }
            }
            return true;
        }
    }
}
        




