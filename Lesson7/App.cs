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
                        objArray_simple.Part_sort(6);                      

                        Console.WriteLine("Исходный массив");
                        objArray_simple.Display();
                        Console.WriteLine(" ");

                        objArray_simple.Bubl_sort_upgrade();

                        Console.WriteLine("");
                        Console.WriteLine("Массив после сортировки");
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
                        array_of_person.Insert(Person_2, 0);                        
                        Console.WriteLine("Исходный массив");
                        array_of_person.Display();
                      
                        Console.WriteLine("");
                        Console.WriteLine("Массив после сортировки");
                        //array_of_person.Insert_sort();
                        //array_of_person.Select_sort();
                        array_of_person.Bubl_sort();
                        array_of_person.Display();

                        break;
                } 
            }
        }
    }
}