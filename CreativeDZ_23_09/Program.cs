using System;
using System.Text.RegularExpressions;

namespace CreativeDZ_23_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Дана последовательность. Определить, является ли эта последовательность упорядоченной по возрастанию.");
            Random rand = new Random();
            int[] arr = new int[10];
            Console.WriteLine("Последовательность чисел:");
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = rand.Next(10);
                Console.Write( arr[j] + " ");
            }
            int i = 0;
            for (; i < arr.Length; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    break;
                }
            }
            if (i <arr.Length-1)
            {
                Console.WriteLine($"\nПоследовательность не упорядочена. Порядковый номер числа, которое нарушает последовательность: {i+1}") ;
            }
            else
            {
                Console.WriteLine("Последовательность упорядочена");
            }
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Задание 2: По заданному номеру карты k (6 <=k <= 14) определить достоинство\r\nсоответствующей карты. ");
            Console.WriteLine("Введите номер карты:");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 14)
                {
                    throw new ArgumentException("Неправильный номера карты. Номер должен быть от 1 до 14");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный номер. Должно быть число");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неправильный номера карты. Номер должен быть от 1 до 14");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
                return;
            }
            try
            {
                if (number ==14)
                {
                    Console.WriteLine("Достоинство карты: Туз");
                }
                else if (number == 13)
                {
                    Console.WriteLine("Достоинство карты: Король");
                }
                else if (number == 12)
                {
                    Console.WriteLine("Достоинство карты: Дама");
                }
                else if (number == 11)
                {
                    Console.WriteLine("Достоинство карты: Валет");
                }
                else
                {
                    Console.WriteLine($"Достоинство карты {number}");
                }
            } catch (Exception)
            {
                Console.WriteLine("Неизвестная ошибка");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
            Console.WriteLine("Задание 3: Сопоставление алкоголя или вывод пива ");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(str, @"(?i)^Jabroni$"))
                {
                    Console.WriteLine("Patron Tequila");
                }
                else if (Regex.IsMatch(str,@"(?i)^School Counselor$"))
                {
                    Console.WriteLine("Anything with Alcohol");
                }
                else if (Regex.IsMatch(str, @"(?i)^Programmer$"))
                {
                    Console.WriteLine("Hipster Craft Beer");
                }
                else if (Regex.IsMatch(str,@"(?i)^Bike Gang Member$"))
                {
                    Console.WriteLine("Moonshine");
                }
                else if (Regex.IsMatch(str, @"(?i)^Politician$"))
                {
                    Console.WriteLine("Your tax dollars");
                }
                else if (Regex.IsMatch(str, @"(?i)^Rapper$"))
                {
                    Console.WriteLine("Cristal");
                }
                else { Console.WriteLine("Beer"); }
            } catch (Exception)
            {
                Console.WriteLine("Неизвестная ошибка");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
            Console.WriteLine("Задание 4: Сопоставление дня недели и его названия ");
            Console.WriteLine("Введите день недели:");
            int day;
            try
            {
                day = int.Parse(Console.ReadLine());
                if (day < 1 || day > 7)
                {
                    throw new ArgumentException("Неправильное значение дня. Значение дня должно быть от 1 до 7");
                }
                if (day == 1)
                {
                    Console.WriteLine("Это Понедельник");
                }
                else if (day == 2)
                {
                    Console.WriteLine("Это Вторник");
                }
                else if (day == 3)
                {
                    Console.WriteLine("Это Среда");
                }
                else if (day == 4)
                {
                    Console.WriteLine("Это Четверг");
                }
                else if (day == 5)
                {
                    Console.WriteLine("Это Пятница");
                }
                else if (day == 6)
                {
                    Console.WriteLine("Это Суббота");
                }
                else { Console.WriteLine("Это Воскресенье"); }
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
            finally
            {
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
            Console.WriteLine("Задание 5: Поиск кукол в массиве ");
            string[] dolls = new string[] { "Hello Kitty", "Lego", "My little Pony", "Ninja Turtles", "Barbie doll", "Steve from Minecraft" };
            int count = 0;
            Console.WriteLine(dolls);
            foreach (string doll in dolls)
            {
                if (doll == "Hello Kitty" || doll == "Barbie doll")
                {
                    count++;
                }
            }
            Console.WriteLine($"Кол-во кукол в сумке {count}");

            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();



        }
    }
}
