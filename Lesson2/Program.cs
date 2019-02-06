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
            Console.WriteLine("6.Найти сумму чётных цифр натурального числа NEW.");
            Console.WriteLine("7.Определить из каких цифр состоит число NEW.");
            Console.WriteLine("8.Сортировка массива");
            Console.WriteLine("Введите 1 или 2 или 3 или 4 или 5 или 6 или 7 или 8...");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Find_sum(); break;
                case 2: Mul_from_add(); break;
                case 3: Guess_the_number(); break;
                case 4: Deter_number(); break;
                case 5: Rotate_number(); break;
                case 6: Find_sum_new(); break;
                case 7: Deter_number_new(); break;
                case 8: Sort_array(); break;
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
            int sign = 1;
            if (a_mul_1<0 && a_mul_2>0 || a_mul_1>0 && a_mul_2 < 0)
            {
                sign = -1;
            }
            while (i <=Math.Abs(a_mul_1))
            {
                rezult_mul += Math.Abs(a_mul_2);
                i++;
            }
            
            Console.WriteLine($"Результат:{sign*rezult_mul}");
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
            bool isGame = true;
            while (isGame == true)
            {
                user_input = Console.ReadLine();
                right_enter = int.TryParse(user_input, out input_number);
                if (right_enter == true && input_number == random_number)
                {
                    Console.WriteLine("Число угадано!)");
                    isGame = false;
                }
                if (user_input == "выход")
                {
                    Console.WriteLine("Игра завершена");
                    isGame = false;
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

        static void Find_sum_new()
        {
            Console.WriteLine("Ведите любое натуральное число");
            int number = Convert.ToInt16(Console.ReadLine());
            int numeral_of_number;
            int sum_of_num = 0;
            int tag = 1;
            while (number % tag != number)
            {
                numeral_of_number = number / tag % 10;                
                tag *= 10;
                if (numeral_of_number % 2 == 0)
                {
                    sum_of_num += numeral_of_number;
                }
            }
            Console.WriteLine($"Сумма четных чисел введенного числа {sum_of_num}");
        }

        static void Deter_number_new()
        {
            Console.WriteLine("Ведите любое натуральное число");
            int number = Convert.ToInt16(Console.ReadLine());
            int numeral_of_number;
            int tag = 1;
            while (number % tag != number)
            {
                numeral_of_number = number / tag % 10;
                tag *= 10;
                Console.Write($"{numeral_of_number};");
            }           
        }

        static void Sort_array()
        {
            int[] array = { 1,-10,0,3,-11 ,3, -8, 25, -11};
            Console.WriteLine($"До сортировки:");
            foreach (int element in array)
            {
                Console.WriteLine($" {element};");
            }
            int exchange_variable;
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0+i; j < array.Length-1; j++)
                {
                    if (array[i] > array[j + 1])
                    {
                        exchange_variable = array[i];
                        array[i] = array[j + 1];
                        array[j + 1] = exchange_variable;
                    }
                }
            Console.WriteLine($"После сортировки:");
            foreach (int element in array)
            {
                Console.WriteLine($"{element};");
            }
        }        
    }
}

