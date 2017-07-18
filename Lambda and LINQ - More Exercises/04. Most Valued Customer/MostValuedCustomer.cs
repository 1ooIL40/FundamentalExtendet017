namespace _04.Most_Valued_Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostValuedCustomer
    {
        public static void Main()
        {
            var shopStore = new Dictionary<string, decimal>();
            string inputLine = Console.ReadLine();

            while (inputLine != "Shop is open")
            {
                string[] tokes = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string productName = tokes[0];
                decimal productPrice = decimal.Parse(tokes[1]);


                if (!shopStore.ContainsKey(productName))
                {
                    shopStore[productName] = 0;
                }
                shopStore[productName] = productPrice;

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            var customerBuying = new Dictionary<string, List<string>>();

            while (inputLine != "Print")
            {
                if (inputLine != "Discount")
                {
                    string[] tokes = inputLine
                        .Split(":, ".ToCharArray(),
                        StringSplitOptions.RemoveEmptyEntries);

                    string customerName = tokes[0];
                    List<string> productsName = tokes
                        .Skip(1)
                        .ToList();

                    if (!customerBuying.ContainsKey(customerName))
                    {
                        customerBuying[customerName] = productsName;
                    }
                }
                else
                {
                    //Order by the value
                    shopStore = shopStore
                        .OrderByDescending(v => v.Value)
                        .ToDictionary(k => k.Key, v => v.Value);

                    //Discount Method
                    DiscountAdd(shopStore);
                }

                inputLine = Console.ReadLine();
            }

            var totalBuyPerPerson = new Dictionary<string, decimal>();

            FindMostValuedClient(totalBuyPerPerson, customerBuying, shopStore);

            //Take the top 1 client
            totalBuyPerPerson = totalBuyPerPerson
                .OrderByDescending(v => v.Value)
                .Take(1)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var name in totalBuyPerPerson)
            {
                var clientName = name.Key;
                var totalSum = name.Value;

                List<string> productsName = customerBuying[clientName]
                    .Distinct()
                    .ToList();

                var outputDictionary = new Dictionary<string, decimal>();
                foreach (var product in productsName)
                {
                    outputDictionary[product] = shopStore[product];
                }

                outputDictionary = outputDictionary
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);


                Console.WriteLine($"Biggest spender: {clientName}");
                Console.WriteLine($"^Products bought:");
                //TODO order by price

                foreach (var product in outputDictionary)
                {
                    Console.WriteLine($"^^^{product.Key}: {product.Value:f2}");
                }

                Console.WriteLine($"Total: {totalSum:f2}");
            }

        }

        #region Sort by the total sum of the cliet products
        static void FindMostValuedClient(Dictionary<string, decimal> totalBuyPerPerson, 
            Dictionary<string, List<string>> customerBuying,
            Dictionary<string, decimal> shopStore)
        {
            foreach (var name in customerBuying)
            {
                string clientname = name.Key;

                var productsList = name.Value
                    .ToList();

                decimal totalSum = 0m;

                foreach (var product in productsList)
                {
                    totalSum += shopStore[product];
                }

                totalBuyPerPerson[clientname] = totalSum;

            }

        }
        #endregion
    
        #region Discount the top 3 products with 10%
        static void DiscountAdd(Dictionary<string, decimal> shopStore)
        {
            var discountProducts = shopStore
                .Take(3)
                .ToDictionary(k => k.Key, v => (v.Value - (v.Value * (decimal)0.1)));


            foreach (var product in discountProducts)
            {
                shopStore[product.Key] = product.Value;
            }

        }
        #endregion
    }
}