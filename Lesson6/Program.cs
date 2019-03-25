using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Note
    {
        public int number_note { get; private set; }
        public string text_note { get; private set; }
        private string User_path; //место хранения заметок
        
        public Note(string User_path)
        {
            this.User_path = User_path;
        }        
                
        public void Create_directory()
        {            
            if (!Directory.Exists(User_path))
            {
                Directory.CreateDirectory(User_path);
            }
        }

        public void Append_note()
        {
            Create_directory();
            if (!File.Exists(($"{User_path}Заметки.txt")))
            {
                Console.WriteLine($"Файла с заметками еще нет!");
            }
            else
            {
                int number = Number_note();

                int Number_note()
                {
                    using (StreamReader sr = new StreamReader(($"{User_path}Заметки.txt"), System.Text.Encoding.Default))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            number_note++;
                        }
                    }
                    return number_note;
                }

                string[] array_line = new string[number];
                Console.WriteLine("Какую заметку хотите дописать?");
                number_note = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите текст заметки:");
                text_note = Console.ReadLine();
                //сначала весь файл нужно считать
                using (StreamReader sr = new StreamReader(($"{User_path}Заметки.txt"), System.Text.Encoding.Default))
                {
                    string line;
                    for (int i = 1; (line = sr.ReadLine()) != null; i++)
                    {
                        array_line[i - 1] = line;
                        if (i == number_note)
                        {
                            array_line[i - 1] = $"{line} {text_note}";
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(($"{User_path}Заметки.txt"), false, System.Text.Encoding.Default))
                {
                    for (int i = 1; i < array_line.Length+1; i++)
                    {
                        sw.WriteLine($"{array_line[i - 1]}");
                    }
                }
            }            
        }

        public void Write_note()
        {           

            Create_directory();
            int number_note = 1;
            if (File.Exists(($"{User_path}Заметки.txt")))
            {
                number_note = Number_note();
            }

            using (StreamWriter sw = new StreamWriter(($"{User_path}Заметки.txt"), true, System.Text.Encoding.Default))
            {
                while (true)
                {
                    Console.WriteLine("Введите текст заметки:");
                    text_note = Console.ReadLine();
                    sw.WriteLine($"Заметка {number_note}:{text_note}");
                    Console.WriteLine("Продолжить вводить заметки?(Y/N)");
                    string answer = Console.ReadLine();
                    number_note++;
                    if (answer == "N")
                    {
                        break;
                    }
                }
            }
            int Number_note()
            {
                using (StreamReader sr = new StreamReader(($"{User_path}Заметки.txt"), System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        number_note++;
                    }
                }
                return number_note;
            }

        }

        public void Read_note()
        {
            Create_directory();
            if (!File.Exists(($"{User_path}Заметки.txt")))
            {
                Console.WriteLine($"Файла с заметками еще нет!");
            }
            else
            {
                using (StreamReader sr = new StreamReader(($"{User_path}Заметки.txt"), System.Text.Encoding.Default))
                {
                    string line;
                    Console.WriteLine("Какую заметку хотите читать?");
                    number_note = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; (line = sr.ReadLine()) != null; i++)
                    {
                        if (number_note == i)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            
        }
    }

    class User
    {        
        public Note note { get; private set; }
        public string name { get; private set; }

        public User(Note note, string name)
        {
            this.note = note;
            this.name = name;
            Choose_act();
        }        

        public void Choose_act()
        {
            Console.WriteLine($"Дорогой,{name}, выберете действие: \n" +
                                $"1-Дописать заметку \n" +
                                $"2-Написать новую заметку \n" +
                                $"3-Читать сущестующую заметку");
            int vibor=Convert.ToInt32(Console.ReadLine());
            switch (vibor)
            {
                case 1: Append_note(); break;
                case 2: Write_note(); break;
                case 3: Read_note(); break;                
            }            
        }        

        public void Append_note()
        {
            note.Append_note();
        }

        public void Write_note()
        {            
            note.Write_note();   
        }

        public void Read_note()
        {
            note.Read_note();
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            string user_path = @"D:\Заметки\";
            Note obj_note1 = new Note(user_path);

            string user_name = "Иван";
            User obj_user1 = new User(obj_note1, user_name);

            Console.ReadLine();
        }
    }
}
