using System;

namespace Tank
{
    class PiggyBank
    {
        static void Main()
        {
            int tankPrice = Int32.Parse(Console.ReadLine());
            int partyDays = Int32.Parse(Console.ReadLine());
            if (partyDays < 9)
            {
                int savedMoney = (30-partyDays) * 2 - 5 * partyDays;
                double totalMounts = (double)tankPrice / savedMoney;
                int total = (int)Math.Ceiling(totalMounts);
                int takeYears = (int)total / 12;
                int takeMonths = (int)total % 12;
                Console.WriteLine("{0} years, {1} months", takeYears, takeMonths);
            }
            else 
            {
                Console.WriteLine("never");
            }
        }
    }
}
