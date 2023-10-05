using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Часть_2
{
    internal class Program
    {
        public static void About_Array(ref double sum, ref double increase, out double average, params double[] array)
        {
            average = sum = 0;
            increase = 1;
            foreach (double number in array)
            {
                sum += number;
                increase *= number;
            }
            average = sum / array.Length;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Введите число от 0 до 9 или exit/закрыть для завершения программы");
            string str = Console.ReadLine();
            if (str == "exit" || str == "закрыть")
            {
                System.Environment.Exit(0);
            }
            try
            {
                if (int.TryParse(str, out int num))
                {
                    if (num < 0 || num > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Введённое число не удовлетворяет условию");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                    else
                    {
                        if (num == 0)
                        {
                            Console.WriteLine(" #");
                            Console.WriteLine("# #");
                            Console.WriteLine("# #");
                            Console.WriteLine(" #");
                        }
                        if (num == 1)
                        {
                            Console.WriteLine(" #");
                            Console.WriteLine("##");
                            Console.WriteLine(" #");
                            Console.WriteLine("###");
                        }
                        if (num == 2)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("###");
                            Console.WriteLine("#");
                            Console.WriteLine("###");
                        }
                        if (num == 3)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("###");
                        }
                        if (num == 4)
                        {
                            Console.WriteLine("# #");
                            Console.WriteLine("# #");
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                        }
                        if (num == 5)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("# ");
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("###");
                        }
                        if (num == 6)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("# ");
                            Console.WriteLine("###");
                            Console.WriteLine("# #");
                            Console.WriteLine("###");
                        }
                        if (num == 7)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                        }
                        if (num == 8)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("# #");
                            Console.WriteLine("###");
                            Console.WriteLine("# #");
                            Console.WriteLine("###");
                        }
                        if (num == 9)
                        {
                            Console.WriteLine("###");
                            Console.WriteLine("# #");
                            Console.WriteLine("###");
                            Console.WriteLine("  #");
                            Console.WriteLine("###");
                        }
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректно введено число");
            }

            Console.WriteLine("Упражнение 1.Переставить числа в массиве");
            int[] numbers = new int[20];
            Random random = new Random();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("Введите номера индексы чисел, которые хотите переставить в массиве");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp = numbers[num1 - 1];
            numbers[num1 - 1] = numbers[num2 - 1];
            numbers[num2 - 1] = temp;
            Console.WriteLine("Изменённый массив");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Упр 2");
            Console.WriteLine("Рабоота с массивом");
            Console.WriteLine("Укажите длинну массива");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int len))
                {
                    double[] Array_2 = new double[len];
                    if (len == 0)
                    {
                        Console.WriteLine("Пустой массив");
                    }
                    else
                    {
                        for (int i = 0; i < len; i++)
                        {
                            Console.Write($"Введите элемент массива номер {i + 1}: ");
                            double num = double.Parse(Console.ReadLine());
                            Array_2[i] = num;
                        }
                    }
                    double increase = 1;
                    double average;
                    double sum = 0;
                    About_Array(ref sum, ref increase, out average, Array_2);
                    Console.WriteLine("Сумма элементов: {0}", sum);
                    Console.WriteLine("Произведение элементов: {0}", increase);
                    Console.WriteLine("Среднее значение: {0}", average);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
        }
    }
}

