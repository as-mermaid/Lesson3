using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне 100-999");
            int number = Convert.ToInt32(Console.ReadLine());

            int n1 = (number / 100) % 100;
            int n2 = (number / 10) % 10;
            int n3 = number % 10;
            int n23 = number % 100;
            string numberText = null;

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Неверный диапазон");
            }
            else
            {
                switch (n1)
                {
                    case 1:
                        {
                            numberText += "сто ";
                            break;
                        }
                    case 2:
                        {
                            numberText += "двести ";
                            break;
                        }
                    case 3:
                        {
                            numberText += "триста ";
                            break;
                        }
                    case 4:
                        {
                            numberText += "четыерста ";
                            break;
                        }
                    case 5:
                        {
                            numberText += "пятьсот ";
                            break;
                        }
                    case 6:
                        {
                            numberText += "шестьсот ";
                            break;
                        }
                    case 7:
                        {
                            numberText += "семьсот ";
                            break;
                        }
                    case 8:
                        {
                            numberText += "восемьсот ";
                            break;
                        }
                    case 9:
                        {
                            numberText += "девятьсот ";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                if (n23 >= 11 && n23 <= 19)
                {
                    switch (n23)
                    {
                        case 11:
                            {
                                numberText += "одиннадцать";
                                break;
                            }
                        case 12:
                            {
                                numberText += "двенадцать";
                                break;
                            }
                        case 13:
                            {
                                numberText += "тринадцать";
                                break;
                            }
                        case 14:
                            {
                                numberText += "четыернадцать";
                                break;
                            }
                        case 15:
                            {
                                numberText += "пятнадцать";
                                break;
                            }
                        case 16:
                            {
                                numberText += "шестнадцать";
                                break;
                            }
                        case 17:
                            {
                                numberText += "семнадцать";
                                break;
                            }
                        case 18:
                            {
                                numberText += "восемнадцать";
                                break;
                            }
                        case 19:
                            {
                                numberText += "девятнадцать";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else
                {
                    switch (n2)
                    {
                        case 2:
                            {
                                numberText += "двадцать ";
                                break;
                            }
                        case 3:
                            {
                                numberText += "тридцать ";
                                break;
                            }
                        case 4:
                            {
                                numberText += "сорок ";
                                break;
                            }
                        case 5:
                            {
                                numberText += "пятьдесят";
                                break;
                            }
                        case 6:
                            {
                                numberText += "шестьдесят ";
                                break;
                            }
                        case 7:
                            {
                                numberText += "семдесят ";
                                break;
                            }
                        case 8:
                            {
                                numberText += "восемьдесят ";
                                break;
                            }
                        case 9:
                            {
                                numberText += "девяносто ";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    switch (n3)
                    {

                        case 1:
                            {
                                numberText += "один";
                                break;
                            }
                        case 2:
                            {
                                numberText += "два";
                                break;
                            }
                        case 3:
                            {
                                numberText += "три";
                                break;
                            }
                        case 4:
                            {
                                numberText += "четыре";
                                break;
                            }
                        case 5:
                            {
                                numberText += "пять";
                                break;
                            }
                        case 6:
                            {
                                numberText += "шесть";
                                break;
                            }
                        case 7:
                            {
                                numberText += "семь";
                                break;
                            }
                        case 8:
                            {
                                numberText += "восемь";
                                break;
                            }
                        case 9:
                            {
                                numberText += "девять";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                Console.WriteLine(numberText);
            }
            Console.ReadKey();
        }
    }
}
