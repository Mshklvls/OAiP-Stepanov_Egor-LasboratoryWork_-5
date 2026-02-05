using Lab5._2Program;
using System;
using System.Drawing;

namespace Lab5true
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте, уважаемый пользователь. Это программа создана для работы с точками (обычно 1 или 2). Для начала, введите координаты для певрой точки (можно десятичные).");
            PointA point1 = new PointA(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("Укажите на сколько переместить первую точку по координате x");
            point1.xMove();

            Console.WriteLine("Укажите на сколько переместить первую точку по координате y");
            point1.yMove();

            Console.WriteLine("Сейчас программа выведет расстояние от первой точки до начала координат");
            point1.getDistance();

            Console.WriteLine("А теперь введите координаты второй точки");
            PointA point2 = new PointA(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("Расстояние между двумя точками равно: ");
            Console.WriteLine(point1.DistantTo(point2));
        }
    }
}