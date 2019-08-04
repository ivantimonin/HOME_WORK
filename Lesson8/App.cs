﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{

    class App
    {
        enum Variant_of_sructute
        {
            stack,
            queue
        }
        static void Main(string[] args)
        {
            Variant_of_sructute choise = Variant_of_sructute.stack;
            Choise(choise);
            Console.ReadLine();

        }
        static void Choise(Variant_of_sructute choise)
        {
            switch (choise)
            {
                case Variant_of_sructute.stack:
                    Stack<int> obj_stack = new Stack<int>(10);
                    obj_stack.Push(10);
                    obj_stack.Push(11);
                    obj_stack.Push(1);
                    obj_stack.Push(8);
                    obj_stack.Pop();
                    obj_stack.Pop();
                    obj_stack.Push(88);
                    obj_stack.Pop();
                    var value_stack = obj_stack.Peak();
                    Console.WriteLine($"Верхний элемент стека: {value_stack}");

                    bool answer = Stack<string>.Checked_write("((()()))");
                    Console.WriteLine($"Расстановка скобок верна? {answer}");

                    string reverse_line = Stack<string>.Reverse("1 2 3 4 5 6");
                    Console.WriteLine($"Реверс строки {reverse_line}");

                    break;
                case Variant_of_sructute.queue:
                    Queue<int> obj_queue = new Queue<int>(3);

                    obj_queue.Push(1);
                    obj_queue.Push(2);
                    obj_queue.Push(3);


                    obj_queue.Pop();
                    obj_queue.Push(5);
                    obj_queue.Pop();
                    obj_queue.Pop();
                    obj_queue.Push(6);
                    obj_queue.Push(7);
                    obj_queue.Pop();
                    obj_queue.Push(8);
                    obj_queue.Pop();
                    obj_queue.Pop();
                    obj_queue.Push(9);
                    obj_queue.Pop();
                    obj_queue.Pop();






                    //obj_queue.Push(5);


                    //obj_queue.Pop();
                    var value_queue=obj_queue.Peak();
                    Console.WriteLine($"Первый элемент очереди: {value_queue}");
                    break;
            }
        }

    }
}