namespace _04.Grocery_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class GroceryShop
    {
        public static Dictionary<string, decimal> groceryShop = new Dictionary<string, decimal>();

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex productAndPrice = new Regex(@"(?<product>^[A-Z][a-z]+):(?<price>[0-9]+\.[0-9]{1,2}$)");

            while (inputLine != "bill")
            {
                var matches = productAndPrice.Matches(inputLine);
                string productName = string.Empty;
                decimal productPrice = 0m;

                foreach (Match match in matches)
                {
                    productName = match.Groups["product"].Value;
                    productPrice = decimal.Parse(match.Groups["price"].Value);
                }

                if (!groceryShop.ContainsKey(productName))
                {
                    groceryShop[productName] = 0m;
                }
                groceryShop[productName] = productPrice;


                inputLine = Console.ReadLine();
            }

            groceryShop = groceryShop
                .Where(k => k.Key != string.Empty)
                .OrderByDescending(v => v.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var product in groceryShop)
            {
                Console.WriteLine($"{product.Key} costs {product.Value}");
            }
        }
    }
}
