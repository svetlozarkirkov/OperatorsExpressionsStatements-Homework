using System;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                Console.WriteLine("Prime: {0}",isPrime(n));
            }
            else
            {
                Console.WriteLine("Prime: False");
            }
        }
        public static bool isPrime(int number)
        {
            double boundary = Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
