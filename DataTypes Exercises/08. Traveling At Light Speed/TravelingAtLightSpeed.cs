namespace _08.Traveling_At_Light_Speed
{
    using System;

    public class TravelingAtLightSpeed
    {
        public static void Main()
        {
            var years = double.Parse(Console.ReadLine());

            var lightYear = years * 9450000000000;      //km
            var lightSpeed = 300000;            //km/sec

            var time = lightYear / lightSpeed;

            var timeFromSeconds = TimeSpan.FromSeconds(time);

            var weeks = timeFromSeconds.Days/ 7;
            var days = timeFromSeconds.Days % 7;
            var hours = timeFromSeconds.Hours;
            var minutes = timeFromSeconds.Minutes;
            var seconds = timeFromSeconds.Seconds;

            Console.WriteLine($"{weeks:f0} weeks");
            Console.WriteLine($"{days:f0} days");
            Console.WriteLine($"{hours:f0} hours");
            Console.WriteLine($"{minutes:f0} minutes");
            Console.WriteLine($"{seconds:f0} seconds");

        }
    }
}
