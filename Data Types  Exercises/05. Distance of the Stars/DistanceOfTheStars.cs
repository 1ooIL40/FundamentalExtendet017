namespace _05.Distance_of_the_Stars
{
    using System;

    public class DistanceOfTheStars
    {
        public static void Main()
        {
            decimal oneLightYear = 9450000000000;

            decimal nearestStar = (decimal)4.22 * oneLightYear;
            decimal centerOfOurGalaxy = 26000 * oneLightYear;
            decimal milkyWay = 100000 * oneLightYear;
            decimal observedUniverse = 46500000000 * oneLightYear;

            Console.WriteLine($"{(float)nearestStar:#.##e+000}");
            Console.WriteLine($"{(double)centerOfOurGalaxy:#.##e+000}");
            Console.WriteLine($"{(double)milkyWay:#.##e+000}");
            Console.WriteLine($"{(double)observedUniverse:#.##e+000}");

        }
    }
}
