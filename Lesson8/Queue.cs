using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Queue<T> : Structure_stack_queue<T>
    {
        private int number_value = 0;
        private int first = 0;
        private int capacity;
        public Queue(int capacity) : base(capacity)
        {
            this.capacity = capacity;
        }

        public void Push(T value)
        {
            if (number_value < stack_or_queue.Length)
            {
                if (up_of_stack_or_quae + 1 >= stack_or_queue.Length)
                {
                    up_of_stack_or_quae = -1;
                }
                up_of_stack_or_quae++;
                stack_or_queue[up_of_stack_or_quae] = value;
                number_value++;
            }
            else
            {
                throw new Exception("Попытка вставить элемент в переполненную очередь");
            }
        }

        public void Pop()
        {
            if (number_value != 0)
            {
                if (first + 1 == stack_or_queue.Length)
                {
                    first = -1;
                }
                first++;
                number_value--;
            }
            else
            {
                throw new Exception("Попытка удалить элемент из пустой очереди");
            }
        }
        public T Peak()
        {
            if (number_value == 0)
            {
                throw new Exception("Попытка посмотреть элемент пустой очереди");
            }
            return stack_or_queue[first];
        }
    }
    

}
