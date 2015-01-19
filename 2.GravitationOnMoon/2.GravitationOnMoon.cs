using System;

namespace GravitationOnMoon
{
    class GravitationOnMoon
    {
        static void Main()
        {
            Console.Write("Weight on the Earth: ");
            double weight = double.Parse(Console.ReadLine());
            double weightOnMoon = (weight*17d)/100d;
            Console.WriteLine("Weight on the Moon: {0}",weightOnMoon);
        }
    }
}
