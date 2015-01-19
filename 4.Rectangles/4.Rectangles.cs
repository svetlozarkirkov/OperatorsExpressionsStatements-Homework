using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("a = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2d*width + 2d*height;
            double area = width*height;
            Console.WriteLine("Perimeter: {0}\nArea: {1}",perimeter,area);
        }
    }
}
