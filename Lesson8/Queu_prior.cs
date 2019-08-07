using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Queu_prior 
    {
        private int [] queu_prior;
        private int number_value = 0;       
        private int capacity;
        
        public Queu_prior(int capacity)
        {
            this.capacity = capacity;
            queu_prior = new int[capacity];
        }

        public void Pop()
        {
            if (number_value >0)
            {                
                number_value--;
            }
            else
            {
                throw new Exception("Попытка удалить элемент из пустой очереди");
            }
        }
        public int Peak()
        {
            if (number_value == 0)
            {
                throw new Exception("Попытка посмотреть элемент пустой очереди");
            }
            return queu_prior[number_value];
        }
        public void Push(int value)
        {
            if (number_value > capacity)
            {
                throw new Exception("Очередь переполнена");
            }
            else
            {            
                queu_prior[number_value] = value;
                for (int i = number_value; i > 0; i--)
                {
                    if (queu_prior[i] > queu_prior[i-1])
                    {
                        int tmp = queu_prior[i];
                        queu_prior[i] = queu_prior[i-1];
                        queu_prior[i-1] = tmp;
                    }                    
                }
                number_value++;
            }
        }
        public void Display_in_console()
        {
            for (int i = 0; i < number_value; i++)
            {                
                Console.WriteLine($"Индекс {i}) {queu_prior[i]}");
            }
        }
    }
}
