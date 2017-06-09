namespace _04.Hotel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hotel
    {
        public static void Main()
        {
            var months = Console.ReadLine();
            var nigthsCount = int.Parse(Console.ReadLine());

            //Price per night
            var studioRoom = 0d;
            var doubleRoom = 0d;
            var suiteRoom = 0d;

            var finalPriceStudio = 0d;
            var finalPriceDouble = 0d;
            var finalPriceSuite = 0d;



            //May, June, July, August, September, October or December
            
            if (months == "May" || months == "October")
            {
                studioRoom = 50d;
                doubleRoom = 65d;
                suiteRoom = 75d;

                var studioDiscuont = 0.05;

                finalPriceDouble = nigthsCount * doubleRoom;
                finalPriceSuite = nigthsCount * suiteRoom;

                if (nigthsCount <= 7 && nigthsCount > 0)
                {
                    finalPriceStudio = nigthsCount * studioRoom;
                }
                else
                {
                    if (months == "October")
                    {
                        finalPriceStudio = (nigthsCount - 1) * (studioRoom - (studioRoom * studioDiscuont));
                    }
                    else
                    {
                        finalPriceStudio = nigthsCount * (studioRoom - (studioRoom * studioDiscuont));
                    }
                }



            }
            else if (months == "June" || months == "September")
            {
                studioRoom = 60d;
                doubleRoom = 72d;
                suiteRoom = 82d;

                var doubleDiscuont = 0.1;


                    finalPriceStudio = nigthsCount * studioRoom;
                    finalPriceDouble = nigthsCount * doubleRoom;
                    finalPriceSuite = nigthsCount * suiteRoom;

                if (nigthsCount > 7)
                {
                    if (months == "September")
                    {
                        finalPriceStudio = ((nigthsCount - 1) * studioRoom);
                    }
                    else
                    {
                        finalPriceStudio = nigthsCount * studioRoom;
                    }
                }
                else if (nigthsCount > 14)
                {
                    finalPriceDouble = nigthsCount * (doubleRoom - (doubleRoom * doubleDiscuont));
                }

            }
            else if (months == "July" || months == "August" || months == "December")
            {
                studioRoom = 68d;
                doubleRoom = 77d;
                suiteRoom = 89d;

                var suiteDiscount = 0.15;


                finalPriceDouble = nigthsCount * doubleRoom;
                finalPriceStudio = nigthsCount * studioRoom;

                if (nigthsCount <= 14 && nigthsCount > 0)
                {
                    finalPriceSuite = nigthsCount * suiteRoom;
                }
                else
                {
                    finalPriceSuite = nigthsCount * (suiteRoom - (suiteRoom * suiteDiscount));
                }
            }

            Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {finalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {finalPriceSuite:f2} lv.");
        }
    }
}
