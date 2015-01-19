using System;

namespace PointInCircle
{
    class PointInCircle
    {
        public const int radius = 2;
        public struct Point
        {
            public double X, Y;
        }
        public static bool InsideCircle(Point point)
        {
            bool isInCircle = point.X*point.X + point.Y*point.Y <= (radius*radius);
            return isInCircle;
        }
        static void Main()
        {
            Point test = new Point();
            Console.Write("x = ");
            test.X = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            test.Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Point is in circle: {0}",InsideCircle(test));
        }
    }
}
