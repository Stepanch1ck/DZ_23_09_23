using System;

namespace Tumakov_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Лабораторная Тумаков 4: Упр. 4.1,4.2, Домашнее задание 4.1"); // я совместил это, т.к. они дополняют друг друга😊
            Console.WriteLine("Введите год:");
            if (!int.TryParse(Console.ReadLine(), out int year)) 
            {
                Console.WriteLine("Неправильное значение года");
                return;
            }
            Console.WriteLine("Введите номер дня в году от 1 до 365:");
            int day;
            try
            {
                day = int.Parse(Console.ReadLine());
                if (day<1 || day > 365)
                {
                    throw new ArgumentException("Неправильное значение дня. Значение дня должно быть от 1 до 365");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильное значение дня. Должно быть число");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неправильное значение дня. Значение дня должно быть от 1 до 365");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
                return;
            }
            bool isLeapYear =(year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            int month = 0;
            if (isLeapYear)
            {
                while (day > 29)
                {
                    month++;
                    day -= 29;
                }
            }
            else
            {
                while (day > 28)
                {
                    month++;
                    day -= 28;
                }

            }
            Console.WriteLine($"День: {day}, месяц: {month}");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();


        }
    }
}
