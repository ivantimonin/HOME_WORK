using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Stack
    {
        private int[] stack;
        private int stack_point = -1;
        private int maxSize;
        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            stack = new int[maxSize];
        }
        public void Push(int item)
        {
            try
            {
                stack_point++;
                stack[stack_point] = item;
            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception("Ошибка");
            }
        }
        public int Pop()
        {
            if (stack_point != -1)
            {
                Console.WriteLine(stack[stack_point]);
                return stack[stack_point];
            }
            else return (-1);           
        }

        public void Peek()
        {
            if (stack_point != -1)
            {
                Console.WriteLine(stack[stack_point]);                
            }
        }

        public void Display()
        {
            for (int i = stack_point; i >=0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
