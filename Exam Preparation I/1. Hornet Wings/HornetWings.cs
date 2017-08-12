namespace _1.Hornet_Wings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            int flapsPerSecond = 100;
            int movePerFiveMeters = 1000;
            int restBreak = 5;

            double theDistance = (wingFlaps / movePerFiveMeters) * distance;
            int hornetFlaps = wingFlaps / flapsPerSecond;
            int hornetRest = (wingFlaps / endurance) * restBreak;
            int finalTime = hornetFlaps + hornetRest;

            Console.WriteLine($"{theDistance:f2} m.");
            Console.WriteLine($"{finalTime} s.");
        }
    }
}
