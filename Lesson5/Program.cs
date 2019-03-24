using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    
    class Message
    {                
        public string text { get; private set; }
        public string adress { get; private set; }
        public bool status_open { get; private set; } = false;

        public Message(string text, string adress)
        {
            this.text = text;
            this.adress = adress;
        }

        public void Act_open()
        {
           status_open = true;
        }

        public void Act_read()
        {
            if (status_open == true)
            {
                Console.WriteLine("Читаем письмо...");
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Письмо запечатано");
            }                                            
        }
    }
   
    class Person
    {        
        private string fact_name;
        Message obj_Message;

        public Person (string fact_name)
        {
            this.fact_name = fact_name;            
        }
        
        public void Get_message(Message obj_Message)
        {
            this.obj_Message = obj_Message;
            if (this.obj_Message != null)
            {
                Console.WriteLine($"{fact_name}, вы взяли письмо оно адресовано {this.obj_Message.adress}у");
            }
            else
            {
                Console.WriteLine("Писем нет");
            }                 
        }

        public void Open_message()
        {
            if (fact_name == Convert.ToString(obj_Message.adress))
            {
                obj_Message.Act_open();
                Console.WriteLine("Конверт открыт");
            }
            else
            {                
                Console.WriteLine("Конверт не Ваш");
            }
        }
        public void Read_message()
        {           
            obj_Message.Act_read();                                         
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
            string Name = "Иванов";//Входные данные
            Message [] messages = new Message [Data_base.text.Length];

            for (int index = 0; index < Data_base.text.Length; index++)
            {                
                messages[index] = new Message(Data_base.text[index], Data_base.adress[index]);                           
            }

            for (int index = 0; index < Data_base.text.Length; index++)
            {
                Console.WriteLine();
                Person person = new Person(Name);
                person.Get_message(messages[index]);

                Console.WriteLine("Желаете вскртыть конверт? (Y/N)");
                string answer1 = Console.ReadLine();
                if (answer1 == "Y")
                {
                    person.Open_message();
                }
                else
                {
                    continue;
                }
                if (messages[index].status_open == true)
                {
                    Console.WriteLine("Желаете прочитать  конверт? (Y/N)");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "Y")
                    {
                        person.Read_message();
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
