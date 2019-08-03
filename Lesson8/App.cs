using System;
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
                    var value = obj_stack.Peak();
                    Console.WriteLine($"Верхний элемент стека: {value}");

                    bool answer = Stack<string>.Checked_write("((()()))");
                    Console.WriteLine($"Расстановка скобок верна? {answer}");


                    break;
                case Variant_of_sructute.queue:

                    break;
            }
        }

    }
}