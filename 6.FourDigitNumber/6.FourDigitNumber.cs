using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("n = ");
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += Convert.ToInt32(number[i].ToString());
            }
            Console.WriteLine("Sum of digits: {0}",sum);
            Console.Write("Reversed: ");
            for (int i =  number.Length-1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
            Console.Write("Last digit in first position: ");
            Console.Write(number[number.Length-1]);
            for (int i = 0; i < number.Length-1; i++)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
            Console.Write("Second and third digit exchanged: ");
            Console.Write("{0}{1}{2}{3}",number[0],number[2],number[1],number[3]);
            Console.WriteLine();
        }
    }
}
