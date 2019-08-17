using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    class Link
    {
        private Node first;

        public Link(Person person)
        {
            first = new Node(person);
        }

        public void Delete()
        {
            first = first.next;
        }

        public void Delete(string name_for_del)
        {
            Node current = first;
            Node previosly = first;
            while (name_for_del != current.obj_per.name)
            {
                previosly = current;
                current = current.next;
                if (current == null)
                {
                    throw new Exception("Узел для удаления не найден");
                }
            }
            if (current == previosly)
            {
                first = first.next;
            }
            else
            {
                previosly.next = current.next;
            }           
        }

        public void Insert(Person person, string ins_after_name)
        {
            Node new_element = new Node(person);            
            Node left_near_node = Find_near_left_node(ins_after_name);
            Node tmp = left_near_node.next;
            left_near_node.next = new_element;
            new_element.next = tmp;
        }

        public Node  Find_near_left_node(string name)
        {
            Node current = first;            
            while (current.obj_per.name != name)
            {
                current = current.next;
                if (current == null)
                {
                    throw new Exception("Узел,  не найден");
                }
            }
            return current;
        }

      

        public void Add(Person person)
        {
            Node new_element = new Node(person);
            new_element.next = first;
            first = new_element;
        }

        public void Display()
        {
            Node current = first;
            while (current != null)
            {
                Console.WriteLine($"Имя:{current.obj_per.name} Возраст:{current.obj_per.age}");
                current = current.next;
            }
        }
    }
}

