namespace _03.Restaurant_Discount
{
    using System;

    public class RestaurantDiscount
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine().ToLower();

            //Final price per person in $;
            var resultPrice = 0m;

            //All price are in $;
            var smallHallPrice = 2500m;
            var terracePrice = 5000m;
            var greatHall = 7500m;

            //Discount price in %;
            var normalDiscount = 0.05m;
            var goldDiscount = 0.1m;
            var platinumDiscont = 0.15m;

            //Price for package type in $;
            var priceNormal= 500m; 
            var priceGold = 750m;
            var pricePlatinum = 1000m;

                var discountedPrice = 0m;
                var totalPrice = 0m;

                if (groupSize > 0 && groupSize <= 50)
                {

                    switch (packageType)
                    {
                        case "normal":
                            totalPrice = smallHallPrice + priceNormal;
                            discountedPrice = totalPrice - (totalPrice * normalDiscount);
                            resultPrice = discountedPrice / groupSize;
                        break;
                        case "gold":
                            totalPrice = smallHallPrice + priceGold;
                            discountedPrice = totalPrice - (totalPrice * goldDiscount);
                            resultPrice = discountedPrice / groupSize;
                            break;
                        case "platinum":
                            totalPrice = smallHallPrice + pricePlatinum;
                            discountedPrice = totalPrice - (totalPrice * platinumDiscont);
                            resultPrice = discountedPrice / groupSize;
                            break;
                    }
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {resultPrice:f2}$");
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    switch (packageType)
                    {
                        case "normal":
                            totalPrice = terracePrice + priceNormal;
                            discountedPrice = totalPrice - (totalPrice * normalDiscount);
                            resultPrice = discountedPrice / groupSize;
                            break;
                        case "gold":
                            totalPrice = terracePrice + priceGold;
                            discountedPrice = totalPrice - (totalPrice * goldDiscount);
                            resultPrice = discountedPrice / groupSize;
                            break;
                        case "platinum":
                            totalPrice = terracePrice + pricePlatinum;
                            discountedPrice = totalPrice - (totalPrice * platinumDiscont);
                            resultPrice = discountedPrice / groupSize;
                            break;
                    }
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {resultPrice:f2}$");

                }
                else if (groupSize > 100 && groupSize <= 120)
                {

                    switch (packageType)
                    {
                        case "normal":
                            totalPrice = greatHall + priceNormal;
                            discountedPrice = totalPrice - (totalPrice * normalDiscount);
                            resultPrice = discountedPrice / groupSize;
                            break;
                        case "gold":
                            totalPrice = greatHall + priceGold;
                            discountedPrice = totalPrice - (totalPrice * goldDiscount);
                            resultPrice = discountedPrice / groupSize;
                            break;
                        case "platinum":
                            totalPrice = greatHall+ pricePlatinum;
                            discountedPrice = totalPrice - (totalPrice * platinumDiscont);
                            resultPrice = discountedPrice / groupSize;
                            break;
                    }
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {resultPrice:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
