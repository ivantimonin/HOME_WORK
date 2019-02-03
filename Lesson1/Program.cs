using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор пункта домашнего задания");

            Console.WriteLine("2. Cоздать переменные всех базовых типов, присвоить им значения");
            Console.WriteLine("3. Сделать приведение типов");
            Console.WriteLine("4. Запросить ввод с консоли: Имя, Фамилия, Отчество");
            Console.WriteLine("5. Калькулятор");
            Console.WriteLine("6. Доп задание. Определить является ли год високосным.");
            Console.WriteLine("7. Доп задание. Какой четверти декартовых координат принадлежит точка.");
            Console.WriteLine("8. Доп задание. Попадает ли точка в окружность с центром(0; 0)");
            Console.WriteLine("9. Доп задание. Попадает ли точка в окружность с произвольным центром");
            Console.WriteLine("Введите 2 или 3 или 4 или 5 или 6 или 7 или 8 или 9...");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 2: Base_type(); break;
                case 3: Type_to_type(); break;
                case 4: SNP(); break;
                case 5: Calculation(); break;
                case 6: Tall_Year(); ; break;
                case 7: Def_qr(); ; break;
                case 8: Def_circle(); break;
                case 9: Def_circle_pro(); ; break;
            }
            Console.ReadKey();
        }

        static void Base_type()
        {
            Console.WriteLine("Вы выбрали задание 2 (Базовые типы)");
            byte a1 = 10;
            Console.WriteLine($"Размер типа {a1.GetType()} (byte) {sizeof(byte)} байт, значение {a1}");
            int a2 = 10;
            Console.WriteLine($"Размер типа {a2.GetType()} (int) {sizeof(int)} байт, значение {a2}");
            double a3 = 10.325486545;
            Console.WriteLine($"Размер типа {a3.GetType()} (double) {sizeof(double)} байт, значение {a3}");
            uint a4 = 10;
            Console.WriteLine($"Размер типа {a4.GetType()} (uint) {sizeof(uint)} байт, значение {a4}");
            char a5 = 'g';
            Console.WriteLine($"Размер типа {a5.GetType()} (char) {sizeof(char)} байт, значение {a5}");
            float a6 = 10.32f;
            Console.WriteLine($"Размер типа {a6.GetType()} (float) {sizeof(float)} байт, значение {a6}");
            long a7 = 5;
            Console.WriteLine($"Размер типа {a7.GetType()} (long) {sizeof(long)} байт, значение {a7}");
            sbyte a8 = 6;
            Console.WriteLine($"Размер типа {a8.GetType()} (sbyte) {sizeof(sbyte)} байт, значение {a8}");
            short a9 = 87;
            Console.WriteLine($"Размер типа {a9.GetType()} (short) {sizeof(short)} байт, значение {a9}");
            ushort a10 = 18;
            Console.WriteLine($"Размер типа {a10.GetType()} (ushort) {sizeof(ushort)} байт, значение {a10}");
            ulong a11 = 19;
            Console.WriteLine($"Размер типа {a11.GetType()} (ulong) {sizeof(ulong)} байт, значение {a11}");
            decimal a12 = 14.154448M;
            Console.WriteLine($"Размер типа {a12.GetType()} (decimal) {sizeof(decimal)} байт, значение {a12}");
        }
        static void Type_to_type()
        {
            Console.WriteLine("Вы выбрали задание 3 (Приведение типов)");
            byte a_0_bt = 10;
            Console.WriteLine($"a)Тип данных {a_0_bt} был: {a_0_bt.GetType()}");
            short a_1_sh = (short)a_0_bt;
            Console.WriteLine($"a)Тип данных {a_1_sh} стал: {a_1_sh.GetType()}");

            byte b_0_bt = 10;
            Console.WriteLine($"b)Тип данных {b_0_bt} был: {b_0_bt.GetType()}");
            int b_1_int = (int)b_0_bt;
            Console.WriteLine($"b)Тип данных {b_1_int} стал: {b_1_int.GetType()}");

            byte c_0_bt = 10;
            Console.WriteLine($"c)Тип данных {c_0_bt} был: {c_0_bt.GetType()}");
            long c_1_long = (long)c_0_bt;
            Console.WriteLine($"c)Тип данных {c_1_long} стал: {c_1_long.GetType()}");

            int d_0_int = 10;
            Console.WriteLine($"d)Тип данных {d_0_int} был: {d_0_int.GetType()}");
            short d_1_sh = (short)d_0_int;
            Console.WriteLine($"d)Тип данных {d_1_sh} стал: {d_1_sh.GetType()}");

            int e_0_int = 10;
            Console.WriteLine($"e)Тип данных {e_0_int} был: {e_0_int.GetType()}");
            long e_1_long = (long)e_0_int;
            Console.WriteLine($"e)Тип данных {e_1_long} стал: {e_1_long.GetType()}");

            uint f_0_uint = 10;
            Console.WriteLine($"f)Тип данных {f_0_uint} был: {f_0_uint.GetType()}");
            long f_1_long = (long)f_0_uint;
            Console.WriteLine($"f)Тип данных {f_1_long} стал: {f_1_long.GetType()}");

            double g_0_double = 10.325486545;
            Console.WriteLine($"g)Тип данных {g_0_double} был: {g_0_double.GetType()}");
            float g_1_float = (float)g_0_double;
            Console.WriteLine($"g)Тип данных {g_1_float} стал: {g_1_float.GetType()}");

            float h_0_float = 10.32f;
            Console.WriteLine($"h)Тип данных {h_0_float} был: {h_0_float.GetType()}");
            double h_1_double = (double)h_0_float;
            Console.WriteLine($"h)Тип данных {h_1_double} стал: {h_1_double.GetType()}");

            char i_0_char = 'g';
            Console.WriteLine($"i)Тип данных {i_0_char} был: {i_0_char.GetType()}");
            int i_1_int = (int)i_0_char;
            Console.WriteLine($"i)Тип данных {i_1_int} стал: {i_1_int.GetType()}");

            int j_0_int = 25;
            Console.WriteLine($"j)Тип данных {j_0_int} был: {j_0_int.GetType()}");
            char j_1_char = (char)j_0_int;
            Console.WriteLine($"j)Тип данных {j_1_char} стал: {j_1_char.GetType()}");
        }
        static void SNP()
        {
            Console.WriteLine("Вы выбрали задание 4 (ВВОД ФИО)");
            Console.WriteLine("Введите вашу фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите ваше имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string Patronymic = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать: {Surname} {Name} {Patronymic}");
        }
        static void Calculation()
        {
            Console.WriteLine("Вы выбрали задание 5 (Калькулятор)");
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            if (sign == ('*'))
            {
                Console.WriteLine($"Ответ:{a}*{b} = {a * b}");
            }
            if (sign == ('/'))
            {
                Console.WriteLine($"Ответ:{a}/{b} = {a / b}");
            }
            if (sign == ('+'))
            {
                Console.WriteLine($"Ответ:{a}+{b} = {a + b}");
            }
            if (sign == ('-'))
            {
                Console.WriteLine($"Ответ:{a}-{b} = {a - b}");
            }
        }
        static void Tall_Year()
        {
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Год высокосный");
            }
            else
            {
                Console.WriteLine("Неа), год не высокосный");
            }
        }

        static void Def_qr()
        {
            Console.WriteLine("Введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в первом квадранте");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во втором квадранте");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в третьем квадранте");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в четвертом квадранте");
            }
            if (x == 0 | y == 0)
            {
                Console.WriteLine("Точка находится на одной из осей");
            }
        }

        static void Def_circle()
        {
            Console.WriteLine("Радиус окружности");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
            {
                Console.WriteLine("Точка находится в окружности");
            }
            else
            {
                Console.WriteLine("Точка находится вне окружности");
            }
        }

        static void Def_circle_pro()
        {
            Console.WriteLine("Введите координату x_0 центра круга");
            double x_0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y_0 центра круга");
            double y_0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиус окружности");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x - x_0, 2) + Math.Pow(y - y_0, 2) <= Math.Pow(R, 2))
            {
                Console.WriteLine("Точка находится в окружности");
            }
            else
            {
                Console.WriteLine("Точка находится вне окружности");
            }
        }
    }
}
