namespace _01.Time_Since_Birthday
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TimeSinceBirthday
    {
        public static void Main()
        {
            var yearsInput = int.Parse(Console.ReadLine());

            var days = yearsInput * 365;
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine($"{yearsInput} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}
