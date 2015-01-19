using System;

namespace OddEvenIntegers
{
    class OddEvenIntegers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool isOdd = n%2 != 0;
            Console.WriteLine("Odd? = {0}",isOdd);
        }
    }
}
