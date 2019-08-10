using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Deck
    {
        private int down=0;
        private int up=0;
        private int[] deck;
        private int capacity;
        public Deck(int capacity)
        {
            deck = new int[capacity];
            this.capacity = capacity;
        }

        public void Push(int element)
        {
            if (up > capacity)
            {
                throw new Exception("Дек переполнен");
            }
            deck[up] = element;
            up++;
        }

        public void Peak_up()
        {
            if (up == 0)
            {
                throw new Exception("Попытка просмотреть элемент пустого дека");
            }
            up++;
        }

        public void Peak_down()
        {
            if (up == 0)
            {
                throw new Exception("Попытка просмотреть элемент пустого дека");
            }
            down++;
        }

        public void Pop_up()
        {
            if (up == 0)
            {
                throw new Exception("Попытка удалить элемент из пустого стека");
            }
            up--;
        }
        public void Pop_down()
        {
            if (down == up)
            {
                throw new Exception("Попытка удалить элемент из пустого стека");
            }
            down++;
        }

        public void Show_info()
        {
            for (int i = up-1; i >= down; i--)
            {
                Console.WriteLine(deck[i]);
            }
        }







    }
}
