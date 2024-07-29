using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение точки А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение точки B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение точки C");
            double c = Convert.ToDouble(Console.ReadLine());

            double ab = Math.Abs(a - b);
            double ac = Math.Abs(a - c);
            
            if (ab == 0 || ac == 0)
            {
                Console.WriteLine("Одна (или обе) из точек совпадает с точкой А");
            }
            else if (ab == ac)
            {
                Console.WriteLine("Точки В и С равноудалены от точки А");
            }
            else if (ab > ac)
            {
                Console.WriteLine("Точка С ближе к точке А");
            }
            else
            {
                Console.WriteLine("Точка В ближе к точке А");
            }
            
            Console.ReadKey();

        }
    }
}
