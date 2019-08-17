using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(25,"Иван");
            Person person2 = new Person(30,"Дмитрий");
            Person person3 = new Person(48, "Коля");
            Person person4 = new Person(45, "Вадим");
            Person person5 = new Person(125, "Олег");
            Person person6 = new Person(125, "Михаил");


            Link my_list = new Link(person1);
            my_list.Add(person2);
            my_list.Add(person3);
            my_list.Add(person4);
            my_list.Delete("Иван");
            my_list.Insert(person5, "Дмитрий");
            my_list.Add(person6);
            my_list.Delete("Олег");

            my_list.Display();

            Console.ReadLine();
        }
    }
}
