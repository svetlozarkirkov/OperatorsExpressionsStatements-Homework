using System;

namespace InsideCircleOutsideRectangle
{
    class InsideCircleOutsideRectangle
    {
        public const double radius = 1.5;
        public const double position = 1;
        public struct Point
        {
            public double X, Y;
        }
        public static bool InsideCircle(Point point)
        {
            bool isInCircle = (point.X-position) * (point.X-position) + 
                (point.Y-position) * (point.Y-position) <= (radius * radius);
            return isInCircle;
        }
        public static bool InsideRectangle(Point point)
        {
            bool isInsideRectangle = (point.X >= -1 && point.X <= 5) && (point.Y >= -1 && point.Y <= 1);
            return isInsideRectangle;
        }
        static void Main()
        {
            Point test = new Point();
            Console.Write("x = ");
            test.X = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            test.Y = double.Parse(Console.ReadLine());
            bool valid = InsideCircle(test) == true && InsideRectangle(test) == false;
            Console.WriteLine("Inside circle and outside rectangle: {0}",valid ? "Yes" : "No");
        }
    }
}
