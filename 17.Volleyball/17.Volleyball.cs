using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string typeYear = Console.ReadLine();
            decimal p = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            decimal totalWeekends = 48;

            decimal normalWeekends = (totalWeekends - h);
            decimal AtWork = normalWeekends * 1 / 4;
            decimal gamesPlayednormal = normalWeekends + (p * 2 / 3) + h;
            decimal gamesPlayedtotal = gamesPlayednormal - AtWork;

            decimal gamesPlayedLeap = ((gamesPlayedtotal * 15) / 100);
            decimal gamesPlayedLeapTotal = (gamesPlayedtotal + gamesPlayedLeap);

            if (typeYear == "leap")
            {
                int gamesplayedLeapAll = Convert.ToInt32(Math.Truncate(gamesPlayedLeapTotal));
                Console.WriteLine(gamesplayedLeapAll);
            }
            else
            {
                int gamesplayedNormalAll = Convert.ToInt32(Math.Truncate(gamesPlayedtotal));
                Console.WriteLine(gamesplayedNormalAll);
            }
        }
    }
}
