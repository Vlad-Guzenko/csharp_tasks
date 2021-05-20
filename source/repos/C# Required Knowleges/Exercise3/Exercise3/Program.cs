using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число...");
            int n = int.Parse(Console.ReadLine());

            switch (n/100)
            {
                case 1:
                    Console.Write("Сто ");
                    break;
                case 2:
                    Console.Write("Двести ");
                    break;
                case 3:
                    Console.Write("Триста ");
                    break;
                case 4:
                    Console.Write("Четыреста ");
                    break;
                case 5:
                    Console.Write("Пятсот ");
                    break;
                case 6:
                    Console.Write("Шестьсот ");
                    break;
                case 7:
                    Console.Write("Семьсот ");
                    break;
                case 8:
                    Console.Write("Восемьсот ");
                    break;
                case 9:
                    Console.Write("Девятьсот ");
                    break;
                default:
                    break;
            }
            switch ((n % 100)/10)
            {
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
                case 7:
                    Console.Write("семьдесят ");
                    break;
                case 8:
                    Console.Write("восемьдесят ");
                    break;
                case 9:
                    Console.Write("девяносто ");
                    break;
                default:
                    break;
            }
            if (n%100>=10 && n%100<20)
            {
                switch (n%100)
                {
                    case 10:
                        Console.Write("десять");
                        break;
                    case 11:
                        Console.Write("одинадцать");
                        break;
                    case 12:
                        Console.Write("двенадцать");
                        break;
                    case 13:
                        Console.Write("тринадцать");
                        break;
                    case 14:
                        Console.Write("четырнадцать");
                        break;
                    case 15:
                        Console.Write("пятнадцать");
                        break;
                    case 16:
                        Console.Write("шестнадцать");
                        break;
                    case 17:
                        Console.Write("семнадцать");
                        break;
                    case 18:
                        Console.Write("восемнадцать");
                        break;
                    case 19:
                        Console.Write("девятнадцать");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (n%10)
                {
                    case 0:
                        Console.Write("ноль");
                        break;
                    case 1:
                        Console.Write("один");
                        break;
                    case 2:
                        Console.Write("два");
                        break;
                    case 3:
                        Console.Write("три");
                        break;
                    case 4:
                        Console.Write("четыре");
                        break;
                    case 5:
                        Console.Write("пять");
                        break;
                    case 6:
                        Console.Write("шесть");
                        break;
                    case 7:
                        Console.Write("семь");
                        break;
                    case 8:
                        Console.Write("восемь");
                        break;
                    case 9:
                        Console.Write("девять");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
