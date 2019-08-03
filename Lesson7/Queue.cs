using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Queue
    {
        private int[] queu;
        private int aquare_point = -1;
        private int maxSize;
        private int begin;
        private int end;

        public Queue(int maxSize)
        {
            this.maxSize = maxSize;
            queu = new int[maxSize];
        }
        public void Push(int item)
        {
            try
            {
                aquare_point++;
                queu[aquare_point] = item;
                end = aquare_point;
                begin = aquare_point--;
            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception("Ошибка");
            }
        }
        public int Pop()
        {
            aquare_point--;
            return queu[begin];
        }

        public int Peek()
        {
            return queu[begin];
        }
    }
}
