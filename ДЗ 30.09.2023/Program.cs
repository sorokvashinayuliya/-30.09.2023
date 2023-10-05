using System;

namespace ДЗ_30._09._2023
{
    internal class Program
    {
        static double MaxCh(double x, double y)
        {
            return Math.Max(x, y);
        }
        static void ChangeRef(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
        static bool factorial(ref int num)
        {
            int c = num;
            num = 1;
            for (int i=1; i < c+1; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch
                {
                    return false;
                }
            return true;
        }
        static ulong factor(ulong number)
        {
            try
            {
                if (number == 0)
                {
                    return 1;
                }
                else
                {
                    return number * factor(number - 1);
                }
            }
            catch (System.StackOverflowException)
            {
                return 0;
            }
        }
        static int nod(int a1,int b1)
        {
            while (b1 != 0)
            {
                int t = b1;
                b1 = a1 % b1;
                a1=t;
            }
            return a1;
        }
        static int nod(int a1,int b1,int c1)
        {
            return nod(a1, nod(b1, c1));
        }
        static int fibonachi(int k)
        {
            if (k == 1)
            {
                return 1;
            }
            if (k == 2)
            {
                return 1;
            }
            else
            {
                return fibonachi(k - 1) + fibonachi(k - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Написать метод, возвращающий наибольшее из двух чисел");
            try
            {
                Console.WriteLine("Введите два числа");
                double a3 = Convert.ToInt32(Console.ReadLine());
                double b3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Максимальное число:{MaxCh(a3, b3)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
            }
            Console.WriteLine("Написать метод, который меняет местами значения двух передаваемых параметров");
            try
            {
                Console.WriteLine("Введите два целых числа");
                int s1 = Convert.ToInt32(Console.ReadLine());
                int s2 = Convert.ToInt32(Console.ReadLine());
                ChangeRef(ref s1, ref s2);
                Console.WriteLine($"Первое число={s1} Второе число={s2}");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Вы ввели не число или число введено некорректно");
            }
            Console.WriteLine("Создать метод вычисления факториала");
            try
            {
                Console.WriteLine("Введите два целых числа");
                int chislo = Convert.ToInt32(Console.ReadLine());
                bool flag = factorial (ref chislo);
                Console.WriteLine(Convert.ToString(flag)+" "+chislo);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число или число введено некорректно");
            }
            Console.WriteLine("Написать рекурсивный метод вычисления факториала");
            try
            {
                Console.WriteLine("Введите два целых числа");
                ulong chislo1 = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine("Факториал="+factor(chislo1));
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число или число введено некорректно");
            }
            Console.WriteLine("Найти НОД трёх чисел");
            try
            {
                Console.WriteLine("Введите три целых числа");
                int a2 = Convert.ToInt32(Console.ReadLine());
                int b2 = Convert.ToInt32(Console.ReadLine());
                int c2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("НОД="+nod(a2,b2,c2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число или число введено некорректно");
            }
            Console.WriteLine("Написать рекурсивный метод, вычисляющий номер n-ого числа ряда Фибоначчи");
            try
            {
                Console.WriteLine("Введите целое число");
                int chislo2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fibonachi(chislo2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число или число введено некорректно");
            }
            
        }

    }
}
