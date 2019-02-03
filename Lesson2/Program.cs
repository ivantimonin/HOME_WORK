using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор пункта домашнего задания");
            Console.WriteLine("1.Найти сумму чётных цифр натурального числа.");
            Console.WriteLine("2.Сделать умножение чисел друг на друга через сумму.");
            Console.WriteLine("3.Игра угадайка.");
            Console.WriteLine("4.Определить из каких цифр состоит число.");
            Console.WriteLine("5.Перевернуть число.");
            Console.WriteLine("Введите 1 или 2 или 3 или 4 или 5...");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Find_sum(); break;
                case 2: Mul_from_add(); break;
                case 3: Guess_the_number(); break;
                case 4: Deter_number(); break;
                case 5: Rotate_number(); break;
            }
            Console.Read();
        }

        static void Find_sum()
        {
            Console.WriteLine("Ведите любое натуральное число");
            string number = Console.ReadLine();
            int sum_of_num = 0;
            foreach (char num in number)
            {
                int str_to_int = (int)Char.GetNumericValue(num);
                if (str_to_int % 2 == 0)
                {
                    sum_of_num += str_to_int;
                }
            }
            Console.WriteLine($"Сумма четных чисел введенного числа {sum_of_num}");
        }

        static void Mul_from_add()
        {
            Console.WriteLine("Введите первый множитель");
            int a_mul_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй множитель");
            int a_mul_2 = Convert.ToInt32(Console.ReadLine());
            int rezult_mul = 0;
            int i = 1;
            while (i <= Math.Abs(a_mul_1))
            {
                rezult_mul += Math.Abs(a_mul_2);
                i++;
            }
            if (a_mul_1 < 0 && a_mul_2 > 0 || a_mul_1 > 0 && a_mul_2 < 0)
            {
                rezult_mul = -rezult_mul;
            }
            Console.WriteLine($"Результат:{rezult_mul}");
        }

        static void Guess_the_number()
        {
            int from = -10;
            int to = 10;
            Random rnd = new Random();
            int random_number = rnd.Next(from, to);
            Console.WriteLine("Компьютер загадал число от-10 до 10, угадай его.\nДля выхода введи 'выход'");
            string user_input;
            bool right_enter = false;
            int input_number;
            while (true)
            {
                user_input = Console.ReadLine();
                right_enter = int.TryParse(user_input, out input_number);
                if (right_enter == true && input_number == random_number)
                {
                    Console.WriteLine("Число угадано!)");
                    break;
                }
                if (user_input == "выход")
                {
                    Console.WriteLine("Игра завершена");
                    break;
                }
                else
                {
                    Console.WriteLine("Число не угадано");
                }
            }
        }

        static void Deter_number()
        {
            Console.WriteLine("Ведите любое целое число");
            string number = Console.ReadLine();
            foreach (char num in number)
            {
                Console.Write($"{num};");
            }
        }

        static void Rotate_number()
        {
            Console.WriteLine("Введите любое число");
            string number = Console.ReadLine();
            int len_number = 0;
            foreach (char num in number)
            {
                len_number++;
            }
            char[] array = new char[len_number];
            int i = 0;
            foreach (char num in number)
            {
                array[i] = num;
                i++;
            }
            for (i = len_number - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
        }
    }
}

