namespace _06.Theatre_Promotion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheatrePromotion
    {
        public static void Main()
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());


            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else if (age < 19)
            {
                if(day == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("5$");
                }

            }
            else if(age < 65)
            {

                if (day == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else
            {

                if (day == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
