using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Stack<T> : Structure_stack_queue<T>
    {
        public Stack(int capacity) : base(capacity) { }

        public void Push(T value)
        {
            try
            {
                up_of_stack_or_quae++;
                stack_or_queue[up_of_stack_or_quae] = value;
            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception("Попытка добавить значение в стек, когда он переполнен!");
            }
        }

        public void Pop()
        {
            if (up_of_stack_or_quae == -1)
            {
                throw new Exception("Попытка убрать значение из пустого стека!");
            }
            else
            {
                up_of_stack_or_quae--;
            }
        }

        public T Peak()
        {
            if (up_of_stack_or_quae == -1)
            {
                throw new Exception("Попытка просмотра верхнего значения пустого стека");
            }
            return stack_or_queue[up_of_stack_or_quae];
        }

        public static bool Checked_write(string value_for_check)
        {

            Stack<char> obj_stack = new Stack<char>(value_for_check.Length);
            foreach (char i in value_for_check)
            {
                if (i != '(' && i != ')')
                {
                    throw new Exception("Попытка ввести символ отличный от скобок!");
                }
                else if (i == '(')
                {
                    obj_stack.Push(i);
                }
                else if (i == ')')
                {
                    obj_stack.Pop();
                }
            }
            if (obj_stack.up_of_stack_or_quae == -1)
            {
                return true;
            }
            return false;
        }

        public static string Reverse(string line)
        {
            Stack<Char> obj_stack = new Stack<char>(line.Length);
            foreach (char symbol in line)
            {
                obj_stack.Push(symbol);
            }
            string revers_line = "";
            while (obj_stack.up_of_stack_or_quae >= 0)
            {
                revers_line +=obj_stack.Peak();
                obj_stack.Pop();
            }
            return revers_line;
           

        }
    }
}
