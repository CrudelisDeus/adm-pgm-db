/*
    Швиденко Дмитро Юрійович (ІШІ-501)

    task_1:
    Використовуючи VisualStudio, створіть проект за шаблоном
    ConsoleApplication. Напишіть програму визначення щодо попадання
    вказаного користувачем числа від 0 до 100 у числовий діапазон
    [0-14] [15-35] [36-50] [50-100]. Якщо так, то вкажіть, в який саме.
    Якщо користувач вказує число, яке не входить в жоден з наявних
    числових діапазонів, то виводиться відповідне повідомлення.

    task_2:
    Є N клієнтів, яким компанія виробник повинна поставити товар. Скільки існує можливих
    маршрутів постачання товару, з врахуванням того, що товар буде постачати одна машина?
    Використовуючи VisualStudio, створіть проект за шаблоном ConsoleApplication.
    Напишіть програму, яка буде розраховувати та виводити на екран кількість можливих
    варіантів доставки товару. Для розв’язку задачі, використайте факторіал
    N!, який розраховується за допомогою цикла do-while.

    task_3:
    23 в списку був / 3 - варіант
    Використовуючи VisualStudio, створити проєкт за шаблоном ConsoleApplication.
    Написати метод, який приймає три дійсні аргументи та повертає їх суму.
    Результат вивести на екран.
*/

using System;

namespace task
{
    class Program
    {
        // task_1
        static void task_1(string[] args)
        {
            Console.Clear();

            int userInput;

            Console.WriteLine("[>] Enter a number 0-100:\n");
            bool isValidNumber = int.TryParse(Console.ReadLine(), out userInput);
            if (isValidNumber && userInput >= 0 && userInput <= 100)
            {
                if (userInput >= 0 && userInput <= 14)
                {
                    Console.WriteLine("\n[>] Number in the range [0-14]");
                }
                else if (userInput >= 15 && userInput <= 35)
                {
                    Console.WriteLine("\n[>] Number in the range [15-35]");
                }
                else if (userInput >= 36 && userInput <= 50)
                {
                    Console.WriteLine("\n[>] Number in the range [36-50]");
                }
                else if (userInput > 50 && userInput <= 100)
                {
                    Console.WriteLine("\n[>] Number in the range [50-100]");
                }
            }
            else
            {
                Console.WriteLine("\n[!] You entered an incorrect value");
            }
        }

        // task_2
        static void task_2(string[] args)
        {
            Console.Clear();

            int userInput;

            Console.WriteLine("[>] Number of clients: \n");
            bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);

            if (isValidInput && userInput >= 0)
            {
                int factorial = 1;
                int i = 1;

                do
                {
                    factorial *= i;
                    i++;
                } while (i <= userInput);

                Console.WriteLine($"\n[>] Number of routes: {factorial}");
            }
        }

        // task_3
        static void task_3(string[] args)
        {
            Console.Clear();

            double a = 2.5;
            double b = 3.7;
            double c = 1.2;

            double sum = task_3_calc_sum(a, b, c);

            Console.WriteLine($"Sum number {a}, {b}, {c} = {sum}");
        }

        static double task_3_calc_sum(double x, double y, double z)
        {
            return x + y + z;
        }

        // Main menu
        static void Main(string[] args)
        {
            Console.WriteLine("[>]Choose a program: \n");
            Console.WriteLine("[1] task_1");
            Console.WriteLine("[2] task_2");
            Console.WriteLine("[2] task_3\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    task_1(args);
                    break;
                case "2":
                    task_2(args);
                    break;
                case "3":
                    task_3(args);
                    break;
                default:
                    Console.WriteLine("\n[!] You entered an incorrect value. Use nubmer 1-3.");
                    break;
            }
            Console.ReadLine();
        }
    }
}