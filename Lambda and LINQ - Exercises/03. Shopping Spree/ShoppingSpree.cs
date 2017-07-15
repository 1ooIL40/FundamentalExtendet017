namespace _03.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingSpree
    {
        public static void Main()
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            decimal budget = decimal.Parse(Console.ReadLine());

            string[] inputLine = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "end")
            {

                string product = inputLine[0];
                decimal productPrice = decimal.Parse(inputLine[1]);

                if (!products.ContainsKey(product))
                {
                    products[product] = productPrice;
                }
                else
                {
                    if(products[product] > productPrice)
                    {
                        products[product] = productPrice;
                    }
                }

                inputLine = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries);
            }

            decimal sum = products.Values.Sum();


            if(sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                products = products
                    .OrderByDescending(v => v.Value)
                    .ThenBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Key} costs {product.Value:f2}");
                }
            }
        }
    }
}
