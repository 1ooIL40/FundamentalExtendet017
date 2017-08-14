namespace _01.Softuni_Coffee_Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricerPerCapsule = decimal.Parse(Console.ReadLine());
                string[] data = Console.ReadLine()
                    .Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                int month = int.Parse(data[1]);
                int year = int.Parse(data[2]);

                decimal capsuleCount = decimal.Parse(Console.ReadLine());

                int daysInTheMonth = DateTime.DaysInMonth(year, month);

                decimal orderPricer = daysInTheMonth * capsuleCount * pricerPerCapsule;
                totalPrice += orderPricer;
                Console.WriteLine($"The price for the coffee is: ${orderPricer:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
