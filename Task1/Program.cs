using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершины 1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты вершины 2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты вершины 3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            int x4, y4;

            if (x1 == x2)
            {
                if (y1 == y3 || y2 == y3)
                {
                    x4 = x3;
                    y4 = (y1 == y3) ? y2 : y1;
                    Console.WriteLine("Координаты четвертой вершины {0}, {1}", x4, y4);
                }
            }
            else if (x3 == x2)
            {
                if (y3 == y1 || y2 == y1)
                {
                    x4 = x1;
                    y4 = (y3 == y1) ? y2 : y3;
                    Console.WriteLine("Координаты четвертой вершины {0}, {1}", x4, y4);
                }
            }
            else if (x3 == x1)
            {
                if (y3 == y2 || y1 == y2)
                {
                    x4 = x2;
                    y4 = (y3 == y2) ? y1 : y3;
                    Console.WriteLine("Координаты четвертой вершины {0}, {1}", x4, y4);
                }
            }
            else
            {
                Console.WriteLine("Не возможно построить прямоугольник со сторонами параллельными OX и OY");
            }
            Console.ReadKey();
        }
    }
}
