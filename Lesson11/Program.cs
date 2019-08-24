using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(25, "Иван");
            Person person2 = new Person(30, "Дмитрий");
            Person person3 = new Person(69, "Коля");
            Person person4 = new Person(45, "Вадим");
            Person person5 = new Person(18, "Олег");
            Person person6 = new Person(12, "Михаил");
            Person person7 = new Person(177, "Анатолий");

            Link my_list = new Link();
            
            my_list.Insert_begin2(person1);
            my_list.Insert_begin2(person2);
            my_list.Insert_begin2(person3);
            my_list.Insert_end2(person4);
            my_list.Insert_end2(person5);
            my_list.Insert_end2(person6);
            my_list.Insert_end2(person7);

            my_list.Del_node_with_key("Коля");
          
            my_list.Display();
            Console.WriteLine("----После сортировки----");
            my_list.Sort2();
            
            my_list.Display();
            Console.ReadLine();
        }
    }
}
