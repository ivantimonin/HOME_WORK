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
            int [] arr = Some_array(5);// кол-во элементов массива
            Console.WriteLine("Массив до сортировки");
            Dispalay(arr);              
           
            Quick_sort arr1 = new Quick_sort(arr);
            int [] array_after_sort=arr1.Quick_sorT_arr_();
            Console.WriteLine("Массив после сортировки");
            Dispalay(array_after_sort);

            Console.ReadLine();
        }
        static int[] Some_array(int number_element)
        {
            Random rnd = new Random();
            int[] arr = new int[number_element];
            for (int i = 0; i < number_element; i++)
            {
                arr[i] = rnd.Next(100);
            }
            return arr;
        }

        static void Dispalay(int [] arr)
        {            
            foreach (int value in arr)
            {               
                Console.Write($"{value};");               
            }
            Console.WriteLine();
        }






    }
}
