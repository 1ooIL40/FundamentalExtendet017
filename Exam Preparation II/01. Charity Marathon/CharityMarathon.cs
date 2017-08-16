namespace _01.Charity_Marathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            decimal runers = decimal.Parse(Console.ReadLine());
            int avgLapsPerRuner = int.Parse(Console.ReadLine());
            decimal lenghtOfTrack = decimal.Parse(Console.ReadLine());
            int capacityOfTrack = int.Parse(Console.ReadLine());
            decimal donationPerKilometer = decimal.Parse(Console.ReadLine());

            decimal totalRuners = 0m;
            decimal runersPerDay = capacityOfTrack * days;
            if(runersPerDay > runers)
            {
                totalRuners = runers;
            }
            else
            {
                totalRuners = runersPerDay;
            }

            decimal totalMeters = totalRuners * avgLapsPerRuner * lenghtOfTrack;
            decimal totalKilometers = totalMeters / 1000;
            decimal totalMoney = totalKilometers * donationPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
