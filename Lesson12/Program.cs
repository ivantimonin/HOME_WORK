using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Recurs.Factorial(4);
            //Console.WriteLine(number);
            /*
            int[] arr = {1,4,5,100};
            int[] arr1 = {2,10,88,99};
            */

            //int index = Recurs.Binary_find(arr, 555);
            //Console.WriteLine($"Индекс={index}");
            //int [] new_arr=Merge.Merge_f_2(arr, arr1);

            int[] arr = { 11, 4, 2, 100,45,18,2 };
            int[] sort_arr = Merge.Merge_sort(arr);
            //Merge.Srez_after_midl(2,arr);
            //Merge.Srez_till_midl(2, arr);

            Dispalay(sort_arr);
            Console.ReadLine();
        }

        static void Dispalay(int[] arr_new)
        {
            foreach (int value in arr_new)
            {
               
                Console.Write($"{value};");

            }
        }



    }
}
