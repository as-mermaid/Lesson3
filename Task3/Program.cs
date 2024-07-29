using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст в диапазоне 20-69");
            int age = Convert.ToInt32(Console.ReadLine());

            int n1 = (age / 10) % 10;
            int n2 = age % 10;
            string ageText = null;

            if (age <20 || age > 69)
            {
                Console.WriteLine("Неверный диапазон");
            }
            else
            {
            switch (n1)
            {
                case 2:
                    {
                        ageText += "двадцать ";
                        break;
                    }
                case 3:
                    {
                        ageText += "тридцать ";
                        break;
                    }
                case 4:
                    {
                        ageText += "сорок ";
                        break;
                    }
                case 5:
                    {
                        ageText += "пядесят ";
                        break;
                    }
                case 6:
                    {
                        ageText += "шестьдесят ";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }


            }

            switch (n2)
            {
                case 0:
                    {
                        ageText += "лет";
                        break;
                    }
                case 1:
                    {
                        ageText += "один год";
                        break;
                    }
                case 2:
                    {
                        ageText += "два года";
                        break;
                    }
                case 3:
                    {
                        ageText += "три года";
                        break;
                    }
                case 4:
                    {
                        ageText += "четыре года";
                        break;
                    }
                case 5:
                    {
                        ageText += "пять лет";
                        break;
                    }
                case 6:
                    {
                        ageText += "шесть лет";
                        break;
                    }
                case 7:
                    {
                        ageText += "семь лет";
                        break;
                    }
                case 8:
                    {
                        ageText += "восемь лет";
                        break;
                    }
                case 9:
                    {
                        ageText += "девять лет";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            Console.WriteLine(ageText);
            }
            
            Console.ReadKey();
        }
    }
}
