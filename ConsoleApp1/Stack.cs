using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack<T> : Structure_stack_queue<T>
    {
        public Stack(int capacity) : base(capacity) { }

        public void Push(T value)
        {
            try
            {
                up_of_stack++;
                stack[up_of_stack] = value;
            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception("Попытка добавить значение в стек, когда он переполнен!");
            }
        }

        public void Pop()
        {
            if (up_of_stack == -1)
            {
                throw new Exception("Попытка убрать значение из пустого стека!");
            }
            else
            {
                up_of_stack--;
            }
        }

        public T Peak()
        {
            if (up_of_stack == -1)
            {
                throw new Exception("Попытка просмотра верхнего значения пустого стека");
            }
            return stack[up_of_stack];
        }

        public static bool Checked_write(string value_for_check)
        {
            
            Stack<char> obj_stack = new Stack <char>(value_for_check.Length);
            foreach (char i in value_for_check)
            {
                if (i != '(' && i != ')')
                {
                    throw new Exception("Попытка ввести символ отличный от скобок!");
                }
                else if (i=='(')
                {
                    obj_stack.Push(i);
                }
                else if (i == ')')
                {
                    obj_stack.Pop();
                }                
            }
            if (obj_stack.up_of_stack == -1)
            {
                return true;
            }
            return false;
        }
    }
}
