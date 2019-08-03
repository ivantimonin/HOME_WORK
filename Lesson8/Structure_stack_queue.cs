using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    abstract class Structure_stack_queue<T>
    {
        protected T[] stack;
        protected int up_of_stack = -1;

        public Structure_stack_queue(int capacity)
        {
            stack = new T[capacity];
        }

    }
}