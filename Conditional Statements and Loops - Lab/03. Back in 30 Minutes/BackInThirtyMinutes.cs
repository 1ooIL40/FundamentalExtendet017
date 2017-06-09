namespace _03.Back_in_30_Minutes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BackInThirtyMinutes
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var timeToComeBack = TimeSpan.FromMinutes(((hours * 60) + minutes) + 30).ToString(@"h\:mm");
            
            Console.WriteLine($"{timeToComeBack}");
        }
    }
}
