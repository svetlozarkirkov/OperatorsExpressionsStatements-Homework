using System;

namespace DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool isValid = n%5 == 0 && n%7 == 0;
            Console.WriteLine("Dividable by 5 and 7: {0}",isValid);
        }
    }
}
