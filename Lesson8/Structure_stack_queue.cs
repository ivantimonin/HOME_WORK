using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    abstract class Structure_stack_queue<T>
    {
        protected T[] stack_or_queue;
        protected int up_of_stack_or_quae = -1;


        public Structure_stack_queue(int capacity)
        {
            stack_or_queue = new T[capacity];
        }

    }
}