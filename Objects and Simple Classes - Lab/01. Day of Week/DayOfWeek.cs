namespace _01.Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class DayOfWeek
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            DateTime date = DateTime.ParseExact(inputLine, 
                "d-M-yyyy", 
                CultureInfo.InvariantCulture);

            string dayOfTheWeek = date.DayOfWeek.ToString();

            Console.WriteLine(dayOfTheWeek);
        }
    }
}
