using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор пункта домашнего задания");
            
            Console.WriteLine("Введите 1 или 2 или 3 или 4 или 5 или 6 или 7 или 8...");
            Console.WriteLine("1 - Фибоначчи");
            Console.WriteLine("2 - Калькулятор");
            Console.WriteLine("3 - Площадь");
            Console.WriteLine("4 - Найти среднефармфитическое значение массива");
            Console.WriteLine("5 - Найти N-тое простое число");
            Console.WriteLine("6 - Значение суммы по столбцам и по строчкам");
            Console.WriteLine("7 - *Игра крестики нолики для двоих");
            Console.WriteLine("8 - **Игра крестики нолики c компьютером");

            int choice = Convert.ToInt32(Console.ReadLine());            
            switch (choice)
            {
                case 1: Namber_FB(); break;
                case 2: Calculation(); break;
                case 3: Area(); break;
                case 4: Arithmetical_mean(); break;
                case 5: Simple_number(); break;
                case 6: Sum_row_line(); break;
                case 7: Tic_tac_toe(); break;
                case 8: Tic_tac_toe_with_comp(); break;
            }
            Console.Read();
        }
        static void Namber_FB()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали задание 2 (Фибоначчи)");
            Console.WriteLine("Введите порядковый номер числа Фибоначчи");
            int number = Convert.ToInt32(Console.ReadLine());
            int number_i=Find_namber_FB(number-1);
            Console.WriteLine($"Число Фибонначи по порядковому номеру {number} равен {number_i}");
            int Find_namber_FB(int number_0)           
            {
                if (number_0 < 2)
                {
                    return 1;
                }
                else
                {
                    return Find_namber_FB(number_0 - 1) + Find_namber_FB(number_0 - 2);
                }                
            }                         
        }

        static void Calculation()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали задание 2 (Калькулятор)");

            Console.WriteLine("Введите знак производимой операции");
            while (true)
            {
                string sign = Convert.ToString (Console.ReadLine());
                if (sign != "+" && sign != "-" && sign != "*" 
                    && sign != "/" && sign !="^" && sign != "^" && sign != "!")
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
                        Console.WriteLine("Введите число a");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите число b");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Ответ:{a}*{b} = {a * b}");
                    }
                    if (sign == ("/"))
                    {
                        Console.WriteLine("Введите число a");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите число b");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Ответ:{a}/{b} = {a / b}");
                    }
                    if (sign == ("+"))
                    {
                        Console.WriteLine("Введите число a");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите число b");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Ответ:{a}+{b} = {a + b}");
                    }
                    if (sign == ("-"))
                    {
                        Console.WriteLine("Введите число a");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите число b");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Ответ:{a}-{b} = {a - b}");
                    }
                    if (sign == ("^"))
                    {
                        Console.WriteLine("Введите число которое хотите возвести в степень");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите показатель степени");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Ответ:{a}^{b} = {Math.Pow(a, b)}");
                    }
                    if (sign == ("!"))
                    {
                        Console.WriteLine("Введите число для взятие факториала");
                        int a =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} != {Factorial(a)}");
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
                }
            }
        }

        static void Area()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали задание расчета площади");
            Console.WriteLine("Выберете геометрическую фигуру");
            Console.WriteLine("1 - Квадрат ");
            Console.WriteLine("2 - Прямоугольник ");
            Console.WriteLine("3 - Треугоьник");
            Console.WriteLine("4 - Круг ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Square(); break;
                case 2: Rectangle(); break;
                case 3: Triangle(); break;
                case 4: Circle(); break;
            }
            void Circle()
            {
                Console.WriteLine("Введите радиус круга в мм ");
                double R = Convert.ToDouble (Console.ReadLine());
                Console.WriteLine($"Площадь круга {3.14*R*R} мм^2");
            }

            void Triangle()
            {
                Console.WriteLine("Введите высоту треугольника в мм ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны на которую опирается высота в мм ");
                double basis = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Площадь треугольника {0.5 * h * basis} мм^2");
            }

            void Rectangle()
            {
                Console.WriteLine("Введите cторону прямоугольника в мм ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите другую cторону прямоугольника в мм ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Площадь прямоугольника {a*b} мм^2");
            }

            void Square()
            {
                Console.WriteLine("Введите cторону квадрата в мм ");
                double a = Convert.ToDouble(Console.ReadLine());               
                Console.WriteLine($"Площадь квадрата {a * a} мм^2");
            }
        }

        static void Arithmetical_mean()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(-10,10);
                Console.WriteLine($"Элемент массива [{i}]:{arr[i]}");
                sum += arr[i];                
            }
            Console.WriteLine($"Среднее арифметическое элементов массива {sum / arr.Length}");
        }

        static void Sum_row_line()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали задание поиска суммы по столбцам и строкам");
            int number_line = 2;//const
            int number_row = 4;
            int[,] matrix = new int [number_line, number_row];
            Random rnd = new Random();
            for (int i = 0; i < number_line; i++)
            {
                for (int j = 0; j < number_row; j++)
                {
                    matrix[i,j] = rnd.Next(-10, 10);
                    Console.WriteLine($"Элемент массива [{i},{j}]:{matrix[i,j]}");                    
                }
            }
            int Sum_row;
            for (int j = 0; j < number_row; j++)
            {
                Sum_row = 0;
                for (int i = 0; i < number_line; i++)
                {
                    Sum_row += matrix[i, j];                   
                }
                Console.WriteLine($"Cумма {j+1}-го столбца {Sum_row}");
            }
            int Sum_line;
            for (int i = 0; i < number_line; i++)
            {
                Sum_line = 0;
                for (int j = 0; j < number_row; j++)
                {
                    Sum_line += matrix[i, j];
                }
                Console.WriteLine($"Cумма {i + 1}-й строки {Sum_line}");
            }
        }

        static void Simple_number()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали задание поиска прстого число");
            Console.WriteLine("Введите N-номер простого числа для поиска");
            int position_num = Convert.ToInt32(Console.ReadLine());
            if (position_num > 5000)
            {
                Console.WriteLine("При вводе числа больше 5000 требуется длительное время поиска...");
                Console.WriteLine("Хотя все зависит от вашего железа)...");
            }
            int number_dividers = 0;
            int position_num_all = 0;
            for (int i = 1; 0 < 1; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    if (i % j==0)
                    {
                        number_dividers++;                        
                    }                    
                }
                if (number_dividers == 2)
                {
                    position_num_all++;
                    if (position_num_all == position_num)
                    {
                        Console.WriteLine($"{position_num}-ым простым числом является число {i}");
                    }                    
                }
                number_dividers = 0;
            }
        }

        static void Tic_tac_toe()
        {
            Console.Clear();
            char[,] matrix = new char[3, 3];
            matrix[0, 0] = '7';
            matrix[0, 1] = '8';
            matrix[0, 2] = '9';
            matrix[1, 0] = '4';
            matrix[1, 1] = '5';
            matrix[1, 2] = '6';
            matrix[2, 0] = '1';
            matrix[2, 1] = '2';
            matrix[2, 2] = '3';
            write_sign(matrix);
            void write_sign(char[,] matrix_0)
            {                
                Console.Clear();                   
                Console.WriteLine("Игра крестики-нолики");                
                Console.WriteLine($"   {matrix_0[0, 0]}|{matrix_0[0, 1]}|{matrix_0[0, 2]}");
                Console.WriteLine("   ------");
                Console.WriteLine($"   {matrix_0[1, 0]}|{matrix_0[1, 1]}|{matrix_0[1, 2]}");
                Console.WriteLine("   ------");
                Console.WriteLine($"   {matrix_0[2, 0]}|{matrix_0[2, 1]}|{matrix_0[2, 2]}");                
            }
            bool win_or_lose = false;
            int number_moves = 0;
            while (win_or_lose==false)
            {                
                Console.WriteLine("Игрок 1: введите координату");
                char coord_player1 = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == coord_player1)
                        {
                            matrix[i, j] = 'X';
                            write_sign(matrix);
                            win_or_lose = who_win(matrix);
                            number_moves++;
                            if (win_or_lose == true)
                            {
                                Console.WriteLine("Игрок 1: победил!");
                                break;
                            }                            
                        }
                    }                    
                }
                if (win_or_lose == true)
                {
                    break;
                }
                if (number_moves == 9 && win_or_lose == false)
                {
                    Console.WriteLine("Ничья");
                    break;
                }
                Console.WriteLine("Игрок 2: введите координату");
                char coord_player2 = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == coord_player2)
                        {
                            matrix[i, j] = '0';
                            write_sign(matrix);
                            win_or_lose=who_win(matrix);
                            number_moves++;
                            if (win_or_lose==true)
                            {
                                Console.WriteLine("Игрок 2: победил!");
                                break;
                            }                            
                        }
                    }                    
                }                
                bool who_win(char[,] matrix_0)
                {                    
                    if ((matrix_0[0, 0] == matrix_0[0, 1] && matrix_0[0, 1] == matrix_0[0, 2]
                        || matrix_0[1, 0] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[1, 2]
                        || matrix_0[2, 0] == matrix_0[2, 1] && matrix_0[2, 1] == matrix_0[2, 2])
                        ||(matrix_0[0, 0]== matrix_0[1, 0] && matrix_0[1, 0] == matrix_0[2, 0]
                        || matrix_0[0, 1] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[2, 1]
                        || matrix_0[0, 2] == matrix_0[1, 2] && matrix_0[1, 2] == matrix_0[2, 2])
                        ||(matrix_0[0, 0]== matrix_0[1, 1] && matrix_0[1, 1]== matrix_0[2, 2])
                        ||(matrix_0[0, 2] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[2, 0]))
                    {
                        win_or_lose = true;
                    }                    
                    return win_or_lose;
                }
            }
        }

        static void Tic_tac_toe_with_comp()
        {
            Console.Clear();
            char[,] matrix = new char[3, 3];
            matrix[0, 0] = '7';
            matrix[0, 1] = '8';
            matrix[0, 2] = '9';
            matrix[1, 0] = '4';
            matrix[1, 1] = '5';
            matrix[1, 2] = '6';
            matrix[2, 0] = '1';
            matrix[2, 1] = '2';
            matrix[2, 2] = '3';
            write_sign(matrix);
            void write_sign(char[,] matrix_0)
            {
                Console.Clear();
                Console.WriteLine("Игра крестики-нолики c компьютером");
                Console.WriteLine($"   {matrix_0[0, 0]}|{matrix_0[0, 1]}|{matrix_0[0, 2]}");
                Console.WriteLine("   ------");
                Console.WriteLine($"   {matrix_0[1, 0]}|{matrix_0[1, 1]}|{matrix_0[1, 2]}");
                Console.WriteLine("   ------");
                Console.WriteLine($"   {matrix_0[2, 0]}|{matrix_0[2, 1]}|{matrix_0[2, 2]}");
            }
            bool win_or_lose = false;
            int number_moves = 0;
            char [] coord_players=new char [9];
            int index = 0;
            while (win_or_lose == false)
            {
                Console.WriteLine("Игрок 1: введите координату");
                char coord_player1 = Convert.ToChar(Console.ReadLine());
                coord_players[index] = coord_player1;
                index++;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == coord_player1)
                        {
                            matrix[i, j] = 'X';
                            write_sign(matrix);
                            win_or_lose = who_win(matrix);
                            number_moves++;
                            if (win_or_lose == true)
                            {
                                Console.WriteLine("Игрок 1: победил!");
                                break;
                            }
                        }
                    }
                }
                if (win_or_lose == true)
                {
                    break;
                }
                if (number_moves == 9 && win_or_lose == false)
                {
                    Console.WriteLine("Ничья");
                    break;
                }
                char coord_p2 = 'z';
                Random rnd = new Random();
                int value = rnd.Next(1, 9);
                while (true)
                {
                    int i = rnd.Next(1, 9);
                    if (matrix[0, 0] == matrix[0, 1] && matrix[0, 2]!= '0')
                    {
                        i = 9;
                    }
                    if (matrix[0, 0] == matrix[0, 2] && matrix[0, 1] != '0')
                    {
                        i = 8;
                    }
                    if (matrix[0, 1] == matrix[0, 2] && matrix[0, 3] != '0')
                    {
                        i = 7;
                    }
                    if (matrix[1, 0] == matrix[1, 1] && matrix[1, 2] != '0')
                    {
                        i = 6;
                    }
                    if (matrix[1, 0] == matrix[1, 2] && matrix[1, 1] != '0')
                    {
                        i = 5;
                    }
                    if (matrix[1, 1] == matrix[1, 2] && matrix[1, 0] != '0')
                    {
                        i = 4;
                    }
                    if (matrix[2, 0] == matrix[2, 1] && matrix[2, 2] != '0')
                    {
                        i = 3;
                    }
                    if (matrix[2, 0] == matrix[2, 2] && matrix[2, 1] != '0')
                    {
                        i = 2;
                    }
                    if (matrix[2, 1] == matrix[2, 2] && matrix[2, 0] != '0')
                    {
                        i = 1;
                    }
                    if (matrix[0, 0] == matrix[1, 1] && matrix[2, 2] != '0')
                    {
                        i = 3;
                    }
                    if (matrix[0, 0] == matrix[2, 2] && matrix[1, 1] != '0')
                    {
                        i = 5;
                    }
                    if (matrix[1, 1] == matrix[2, 2] && matrix[0, 0] != '0')
                    {
                        i = 7;
                    }
                    if (matrix[2, 0] == matrix[1, 1] && matrix[0, 2] != '0')
                    {
                        i = 9;
                    }
                    if (matrix[2, 0] == matrix[0, 2] && matrix[1, 1] != '0')
                    {
                        i = 5;
                    }
                    if (matrix[1, 1] == matrix[0, 2] && matrix[2, 0] != '0')
                    {
                        i = 1;
                    }
                    coord_p2 = Convert.ToChar(i.ToString());
                    if (coord_p2 == coord_players[0]
                        || coord_p2 == coord_players[1]
                        || coord_p2 == coord_players[2]
                        || coord_p2 == coord_players[3]
                        || coord_p2 == coord_players[4]
                        || coord_p2 == coord_players[5]
                        || coord_p2 == coord_players[6]
                        || coord_p2 == coord_players[7]
                        || coord_p2 == coord_players[8])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }                
                char coord_player2 = coord_p2;
                Console.WriteLine($"Координата второго игрока {coord_player2}");
                coord_players[index] = coord_player2;
                index++;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == coord_player2)
                        {
                            matrix[i, j] = '0';
                            write_sign(matrix);
                            win_or_lose = who_win(matrix);
                            number_moves++;
                            if (win_or_lose == true)
                            {
                                Console.WriteLine("Игрок 2: победил!");
                                break;
                            }
                        }
                    }
                }
                bool who_win(char[,] matrix_0)
                {
                    if ((matrix_0[0, 0] == matrix_0[0, 1] && matrix_0[0, 1] == matrix_0[0, 2]
                        || matrix_0[1, 0] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[1, 2]
                        || matrix_0[2, 0] == matrix_0[2, 1] && matrix_0[2, 1] == matrix_0[2, 2])
                        || (matrix_0[0, 0] == matrix_0[1, 0] && matrix_0[1, 0] == matrix_0[2, 0]
                        || matrix_0[0, 1] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[2, 1]
                        || matrix_0[0, 2] == matrix_0[1, 2] && matrix_0[1, 2] == matrix_0[2, 2])
                        || (matrix_0[0, 0] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[2, 2])
                        || (matrix_0[0, 2] == matrix_0[1, 1] && matrix_0[1, 1] == matrix_0[2, 0]))
                    {
                        win_or_lose = true;
                    }
                    return win_or_lose;
                }
            }
        }
    }    
}
