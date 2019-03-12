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
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор задания");
            Tasks choise = Tasks.Task_1;
            switch (choise)
            {
                case Tasks.Task_1:
                    Get_my_directory();
                    break;
                case Tasks.Task_2:
                    Calculation();
                    break;
                case Tasks.Task_3:
                    break;
                case Tasks.Task_4:
                    break;
            }
            Console.ReadLine();

        }
        static void Get_my_directory()
        {
            string Path = (@"D:\1");  // СЮДА ВВЕСТИ ТРЕБУЕМЫЙ КАТАЛОГ.            
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
    }
}
