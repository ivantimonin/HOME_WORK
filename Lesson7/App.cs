using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class App
    {
        enum TypeArray
        {
            sort_array,
            simple_array,
            obj_array
        }

        static void Main(string[] args)
        {
            
            TypeArray variant;
            variant = TypeArray.simple_array;// sort_array /simple_array/ obj_array
            Choice(variant);

            
            
                    
            
           
            Console.ReadLine();

            void Choice(TypeArray vr)
            {
                switch (vr)
                {
                    case TypeArray.sort_array:
                        Sort_array objArray_sort = new Sort_array(8);
                        objArray_sort.Add(5);
                        objArray_sort.Add(0);
                        objArray_sort.Add(9);
                        objArray_sort.Add(100);
                        objArray_sort.Add(534);
                        
                        objArray_sort.Display();
                        break;
                    case TypeArray.simple_array:
                        Simple_array objArray_simple = new Simple_array(10);
                        objArray_simple.Add(1);
                        objArray_simple.Add(1);
                        objArray_simple.Add(8);
                        objArray_simple.Add(3);
                        objArray_simple.Add(8);
                        objArray_simple.Add(8);
                        objArray_simple.Add(11);
                        objArray_simple.Add(2);
                        objArray_simple.Add(4);
                        //objArray_simple.Insert(2, 3);//элемент, индекс
                        //objArray_simple.Remove(2);
                        Console.WriteLine("Исходный массив");
                        objArray_simple.Display();
                        /*
                        SortArray.Bubl_sort(objArray_simple.array, objArray_simple.endIndexElement);
                        Console.WriteLine("");
                        Console.WriteLine("Массив после пузырьковой сортировки");
                        objArray_simple.Display();
                        */

                        /*
                        SortArray.Select_sort(objArray_simple.array, objArray_simple.endIndexElement);
                        Console.WriteLine("");
                        Console.WriteLine("Массив после сортировки методом выбора");
                        objArray_simple.Display();
                        break;
                        */
                        SortArray.Insert_sort(objArray_simple.array, objArray_simple.endIndexElement);
                        Console.WriteLine("");
                        Console.WriteLine("Массив после сортировки методом вставки");
                        objArray_simple.Display();
                        break;

                    case TypeArray.obj_array:
                        Person Person_1 = new Person("Тимонин", "Иван", 25);
                        Person Person_2 = new Person("Иванов", "Сергей", 29);
                        Person Person_3 = new Person("Сидоров", "Петр", 15);
                        Person Person_4 = new Person("Тимонин", "Иван", 25);
                        Person Person_5 = new Person("Петров", "Александр", 20);
                        Obj_array array_of_person = new Obj_array(10);
                        array_of_person.Add(Person_1);
                        array_of_person.Add(Person_2);
                        array_of_person.Add(Person_3);
                        array_of_person.Add(Person_4);
                        array_of_person.Add(Person_5);
                        array_of_person.Remove("Сидоров");
                        array_of_person.Remove("Петров");
                        array_of_person.Insert(Person_2, 0);
                        array_of_person.Display();
                        break;
                } 
            }

        }
    }
}