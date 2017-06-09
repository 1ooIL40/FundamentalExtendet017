namespace _04.Month_Printer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MonthPrinter
    {
        public static void Main()
        {
            var month = int.Parse(Console.ReadLine());

            var monthsName = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            if (month > 12 || month <= 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(monthsName[month - 1]);
            }
        }
    }
}
