using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    
    class Message
    {
        public static int count = 0;
        
        public static string text { get; private set; }
        public string adress { get; private set; }
        public static bool status_open;

        public Message(string Text)
        {
            text = Text;
            status_open = false;
        }

        public static void Act_open()
        {
           status_open = true;
        }

        public static void Act_read()
        {
            if (status_open == true)
            {
                Console.WriteLine("Читаем письмо...");
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Конверт закрыт! Он не Ваш.");
            }                        
        }
    }
   
    class Person
    {
        
        private string Name;       

        public Person (string Name)
        {
            this.Name = Name;            
        }
        
        public void Get_message()
        {
            Console.WriteLine($"{Name}, вы взяли письмо");                 
        }

        public void Open_message()
        {
            if (Data_base.adress[Message.count-1] == Name)
            {
                Message.Act_open();
                Console.WriteLine("Конверт открыт");
            }
            else
            {                
                Console.WriteLine("Конверт не Ваш");
            }
        }

        public void Read_message()
        {
            
            Message.Act_read();
                        
        }
       
    }
    class Data_base
    {
        public static string[] adress { get; private set; } = { "Петров",
                                                                "Иванов",
                                                                "Смирнов",
                                                                "Иванов" };
        public static string[] text { get; private set; } = { "Петров, привет",
                                                              "Иванов, привет",
                                                              "Смирнов, Вас приветсвует казино Вулкан",
                                                              "Иванов, опять я, привет" };
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иванов");
            foreach (string message_text in Data_base.text)
            {
                Console.WriteLine();
                Message det_masseg = new Message(message_text);
                Message.count++;//ко-во объектов
                                
                person.Get_message();//взять конверт

                Console.WriteLine("Желаете вскртыть конверт? (Y/N)");
                string answer1 = Console.ReadLine();
                if (answer1 == "Y")
                {
                    person.Open_message();//вскрыть конверт
                }
                else
                {
                    continue;
                }
                if (Message.status_open == true)
                {
                    Console.WriteLine("Желаете прочитать  конверт? (Y/N)");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "Y")
                    {
                        person.Read_message();//прочитать содержимое 
                    }
                    else
                    {
                        continue;
                    }
                }

                
            }
            Console.Read();            
        }
    }
}
