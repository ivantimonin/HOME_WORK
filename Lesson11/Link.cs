using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Link: IComparable<Node>
    {
        private Node first, last;

        public void Sort2()
        {
            Node current = first;
            int number_element=0;
            if (first == null)
            {
                throw new Exception("Для сортировки нет элеметов");
            }

            while (current.next != null)
            {
                number_element++;
                current = current.next;
            }
            
            for (int i=number_element;i>0;i--)
            {
                current = first;
                for (int j=0;j<i;j++)
                {
                    int value = CompareTo(current);
                    if (value > 0)
                    {
                        Person tmp = current.obj_per;
                        current.obj_per = current.next.obj_per;
                        current.next.obj_per = tmp;
                    }
                    current = current.next;
                }                
            }
        }        

        public int CompareTo(Node current_person)// Почему тут не может быть private???
        {
            return current_person.obj_per.name.CompareTo(current_person.next.obj_per.name);
        }


        public void Insert_begin2(Person person)
        {
            Node new_element = new Node(person);           
            
            if (first == null)
            {
                last = new_element;
                first = new_element;
            }
            else
            {
                new_element.next = first;
                new_element.next.preveos = new_element;
                first = new_element;
            }                
        }

        public void Insert_end2(Person person)
        {
            Node new_element = new Node(person);
            if (last == null)
            {
                first = new_element;
                last = new_element;
            }
            else
            {
                new_element.preveos = last;
                new_element.preveos.next = new_element;
                last = new_element;                
            }            
        }

        public void Del_first2()
        {
            if (first == null)
            {
                throw new Exception("Нельзя удалять из пустого списка!");
            }
            else if (first.next == null)
            {
                first = null;
                last = null;
            }
            else
            {
                first.next.preveos = null;
                first = first.next;
            }
        }

        public void Del_last2()
        {
            if (first == null)
            {
                throw new Exception("Нельзя удалять из пустого списка!");
            }
            else if (last.preveos == null)
            {
                first = null;
                last = null;
            }
            else
            {
                last.preveos.next = null;
                last = last.preveos;
            }
        }

        public void Del_node_with_key(string Name)
        {
            Node node_for_del = Find_this_node(Name);
            if (node_for_del == null)
            {
                throw new Exception("Узел для удаления не найден");
            }
            else if (node_for_del.preveos == null) {Del_first2();}
            else if (node_for_del.next == null) {Del_last2();}
            else
            {
                node_for_del.preveos.next = node_for_del.next;
                node_for_del.next.preveos = node_for_del.preveos;
            }

        }

        public void Insert_after2(string Name, Person new_person)
        {
            Node new_element = new Node(new_person);
            Node after_this_key = Find_this_node(Name);
            if (after_this_key == null)
            {
                throw new Exception("Не найден элемент после которого требуется вставить узел");
            }
            else if (after_this_key.next == null)
            {
                Insert_end2(new_person);
            }
            else
            {
                after_this_key.next.preveos = new_element;
                new_element.next = after_this_key.next;
                after_this_key.next = new_element;
                new_element.preveos = after_this_key;
            }            
        }        

        private Node Find_this_node(string key)
        {
            Node current = first;
            while (current.next != null)
            {
                if (current.obj_per.name == key) { return current; }
                current = current.next;
            }
            if (current.obj_per.name == key) { return current; }
            return null;
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

