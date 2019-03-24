using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        enum Tasks
        {
            Task_1 = 1,
            Task_2,
            Task_3,
            Task_4,
            Task_5
        }
        static void Main(string[] args)
        {
            
            Tasks choise = Tasks.Task_5;
            switch (choise)
            {
                case Tasks.Task_1:
                    Get_my_directory();
                    break;
                case Tasks.Task_2:
                    Calculation();
                    break;
                case Tasks.Task_3:
                    Notes();
                    
                    break;
                case Tasks.Task_4:
                    Notes_star();
                    break;
                case Tasks.Task_5:
                    Notes_two_star();
                    break;

            }
            Console.ReadLine();

        }
        static void Get_my_directory()
        {
            string Path = (@"D:\1");  // СЮДА ВВЕСТИ ТРЕБУЕМЫЙ КАТАЛОГ           
            DirectoryInfo base_dir = new DirectoryInfo(Path);
            Console.WriteLine($" * ***Название начального каталога****: {base_dir.FullName}");
            File_name(base_dir);
            Item_name(base_dir);

            void Item_name(DirectoryInfo dir)
            {
                foreach (var separ_dir in dir.GetDirectories())
                {
                    Console.WriteLine($"    ****Название подкаталога****:");
                    Console.WriteLine($"    {separ_dir.Name}");
                    File_name(separ_dir);
                    Item_name(separ_dir);
                }
            }

            void File_name(DirectoryInfo file)
            {
                Console.WriteLine($"        ****Название файла****:");
                foreach (var separ_file in file.GetFiles())
                {
                    Console.WriteLine($"        {separ_file.Name}");
                }
            }
        }

        static void Calculation()
        {
            {
                Console.Clear();
                Console.WriteLine("Вы выбрали задание 2 (Калькулятор)");

                Console.WriteLine("Введите знак производимой операции");
                while (true)
                {
                    string sign = Convert.ToString(Console.ReadLine());
                    if (sign != "+" && sign != "-" && sign != "*"
                        && sign != "/" && sign != "^" && sign != "^" && sign != "!")
                    {
                        Console.WriteLine("знак производимой операции не поддерживается");
                        Console.WriteLine("доступны следующие знаки");
                        Console.WriteLine("+ (Сумма)");
                        Console.WriteLine("- (Вычитание)");
                        Console.WriteLine("* (Умножение)");
                        Console.WriteLine("/ (Деление)");
                        Console.WriteLine("^ (Возведение в степень)");
                        Console.WriteLine("! (Факториал)");
                    }
                    else
                    {
                        if (sign == ("*"))
                        {
                            double a = Read_a_or_write_a();
                            Console.WriteLine("Введите число b");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double rezult = a * b;
                            Console.WriteLine($"Ответ:{a}*{b} = {rezult}");
                            Save_solution(rezult);
                        }
                        if (sign == ("/"))
                        {
                            double a = Read_a_or_write_a();
                            Console.WriteLine("Введите число b");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double rezult = a / b;
                            Console.WriteLine($"Ответ:{a}/{b} = {rezult}");
                            Save_solution(rezult);
                        }
                        if (sign == ("+"))
                        {
                            double a = Read_a_or_write_a();
                            Console.WriteLine("Введите число b");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double rezult = a + b;
                            Console.WriteLine($"Ответ:{a}+{b} = {rezult}");
                            Save_solution(rezult);
                        }
                        if (sign == ("-"))
                        {
                            double a = Read_a_or_write_a();
                            Console.WriteLine("Введите число b");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double rezult = a - b;
                            Console.WriteLine($"Ответ:{a}-{b} = {rezult}");
                            Save_solution(rezult);
                        }
                        if (sign == ("^"))
                        {
                            double a = Read_a_or_write_a();
                            Console.WriteLine("Введите показатель степени");
                            double b = Convert.ToDouble(Console.ReadLine());
                            double rezult = Math.Pow(a, b);
                            Console.WriteLine($"Ответ:{a}^{b} = {rezult}");
                            Save_solution(rezult);
                        }
                        if (sign == ("!"))
                        {
                            int a = Convert.ToInt32(Read_a_or_write_a());
                            int rezult = Factorial(a);
                            Console.WriteLine($"{a} != {rezult}");
                            Save_solution(rezult);
                            int Factorial(int a_0)
                            {
                                if (a_0 == 0)
                                {
                                    return 1;
                                }
                                else
                                {
                                    return a_0 * Factorial(a_0 - 1);
                                }
                            }
                            break;
                        }
                        break;
                    }
                }
                void Save_solution(double rezult)
                {
                    Console.WriteLine("Желаете сохранить решение в файл Y/N?");
                    char answer = Convert.ToChar(Console.ReadLine());
                    if (answer == 'Y')
                    {
                        string path = @"..\rezult.txt";
                        if (!File.Exists(path))
                        {
                            File.Create(path);
                        }
                        StreamWriter write_rez = new StreamWriter(@"..\rezult.txt");
                        write_rez.WriteLine(rezult);
                        write_rez.Close();
                    }
                }
                double Read_a_or_write_a()
                {
                    Console.WriteLine("Желаете чтобы переменная a имела сохраненное решение Y/N?");
                    char answer = Convert.ToChar(Console.ReadLine());
                    double rez = 0;
                    if (answer == 'Y')
                    {
                        string path = @"..\rezult.txt";
                        if (!File.Exists(path))
                        {
                            Console.WriteLine("Сохраненного решения нет");
                        }
                        else
                        {
                            rez = Convert.ToDouble(File.ReadAllText(path));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите число a");
                        rez = Convert.ToDouble(Console.ReadLine());
                    }
                    return rez;

                }
            }

        }

        static void Notes()
        {
            string Path = "D:\\notes.txt";//Куда сохранять заметку
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();
            // Запись в файл
            FileStream fstream = new FileStream(Path, FileMode.OpenOrCreate);
            //Преобразуем строку в байты
            byte[] arr = System.Text.Encoding.Default.GetBytes(text);
            fstream.Write(arr, 0, arr.Length);
            // Закрываем поток
            fstream.Close();
        }
        static void Notes_star()
        {
            string User_path = @"D:\Заметки\";// куда пользователь хочет сохранять заметки
            if (!Directory.Exists(User_path))
            {
                Directory.CreateDirectory(User_path);                
            }
            if (Directory.GetFiles(User_path).Length == 0)
            {
                Write_to_file();
            }
            else
            {
                List_notes();                                
                Read_file();
            }

            void Write_to_file()
            {
                int i = 0;
                while (true)
                {
                    Console.WriteLine("Введите строку для записи в файл:");
                    string text = Console.ReadLine();
                    string Path = $@"{User_path}Заметка_{Convert.ToString(i)}.txt";
                    FileStream fstream = File.OpenWrite(Path);
                    //Преобразуем строку в байты
                    byte[] arr = System.Text.Encoding.Default.GetBytes(text);
                    fstream.Write(arr, 0, arr.Length);
                    // Закрываем поток
                    fstream.Close();
                    i++;
                    Console.WriteLine();
                    Console.WriteLine("Cделать еще заметку (Y/N)");
                    string answer = Console.ReadLine();
                    if (answer == "N")
                    {
                        break;
                    }
                }
            }
            void Read_file()
            {
                Console.WriteLine("Введите номер файла для чтения");
                int vibor = Convert.ToInt32(Console.ReadLine());
                string Path = $@"{User_path}Заметка_{Convert.ToString(vibor)}.txt";
                //Чтение из файла                
                FileStream fstream = File.OpenRead(Path);
                byte[] arr = new byte[fstream.Length];
                //Считываем данные
                fstream.Read(arr, 0, arr.Length);
                // Декодируем из байтов в строку
                string textFromFile = System.Text.Encoding.Default.GetString(arr);
                // Закрываем поток
                fstream.Close();
                Console.WriteLine($"Текс из файла: {textFromFile}");
                Console.Read();
            }

            void List_notes()
            {
                string Path = User_path;            
                DirectoryInfo base_dir = new DirectoryInfo(Path);
                Console.WriteLine($" * ***Название начального каталога****: {base_dir.FullName}");
                File_name(base_dir);
                Item_name(base_dir);

                void Item_name(DirectoryInfo dir)
                {
                    foreach (var separ_dir in dir.GetDirectories())
                    {
                        Console.WriteLine($"    ****Название подкаталога****:");
                        Console.WriteLine($"    {separ_dir.Name}");
                        File_name(separ_dir);
                        Item_name(separ_dir);
                    }
                }

                void File_name(DirectoryInfo file)
                {
                    Console.WriteLine($"        ****Название файла****:");
                    foreach (var separ_file in file.GetFiles())
                    {
                        Console.WriteLine($"        {separ_file.Name}");
                    }
                }
            }            
        }

        static void Notes_two_star()
        {
            string User_path = @"D:\Заметки\";// куда пользователь хочет сохранять заметки
            if (!Directory.Exists(User_path))
            {
                Directory.CreateDirectory(User_path);
            }
            Write_to_file();
            Read_file();


            void Write_to_file()
            {
                int number_note=1;
                if (File.Exists(($"{User_path}Заметки.txt")))
                {
                    number_note = Number_note();
                }             

                
                using (StreamWriter sw = new StreamWriter(($"{User_path}Заметки.txt"), true, System.Text.Encoding.Default))
                {                    
                    while (true)
                    {
                        Console.WriteLine("Введите заметку");
                        string User_text = Console.ReadLine();
                        sw.WriteLine($"Заметка {number_note}:{User_text}");
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
            void Read_file()
            {                
                using (StreamReader sr = new StreamReader(($"{User_path}Заметки.txt"), System.Text.Encoding.Default))
                {
                    string line;
                    Console.WriteLine("Введите номер заметки для чтения");
                    int number = Convert.ToInt32(Console.ReadLine());
                    for ( int i=1; (line = sr.ReadLine()) != null; i++)
                    {
                        if (number == i)
                        {
                            Console.WriteLine(line);
                        }                 
                    }
                }
            }
        }
    }    
}
