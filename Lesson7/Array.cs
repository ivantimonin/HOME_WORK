using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    abstract class Array
    {
        protected int[] array;
        protected int endIndexElement = -1;
        protected int maxSize;

        public Array(int maxSize)
        {
            this.maxSize = maxSize;
            array = new int [maxSize];
        }

        public void Display()
        {
            for (int i = 0; i <= endIndexElement; i++)
            {
                Console.Write($"{array[i]}   ");
            }
        }
    }
}
