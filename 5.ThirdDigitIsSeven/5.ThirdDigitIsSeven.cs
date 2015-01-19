using System;

namespace ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool isSeven = (n/100)%10 == 7;
            Console.WriteLine("Third digit is '7': {0}",isSeven);
        }
    }
}
