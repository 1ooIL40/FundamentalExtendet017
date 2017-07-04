namespace _04.Exam_Shopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExamShopping
    {
        public static void Main()
        {
            Dictionary<string, int> shopProductsAndQuantities = new Dictionary<string, int>();

            string[] userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            //For adding stuffs
            while (userInput[0] != "shopping")
            {
                string productName = userInput[1];
                int quantiti = int.Parse(userInput[2]);

                if (!shopProductsAndQuantities.ContainsKey(productName))
                {
                    shopProductsAndQuantities[productName] = 0;
                }
                shopProductsAndQuantities[productName] += quantiti;


                userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            //For buyng stuffs
            userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            while (userInput[0] != "exam")
            {

                string productName = userInput[1];
                int quantiti = int.Parse(userInput[2]);

                //if the product dosnt exeist
                if (!shopProductsAndQuantities.ContainsKey(productName))
                {
                    Console.WriteLine($"{productName} doesn't exist");
                }
                else
                {
                    if(shopProductsAndQuantities[productName] > 0)
                    {
                        shopProductsAndQuantities[productName] -= quantiti;
                    }
                    else if(shopProductsAndQuantities[productName] <= 0)
                    {
                        shopProductsAndQuantities[productName] = 0;
                        Console.WriteLine($"{productName} out of stock");
                    }
                }

                userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }


            shopProductsAndQuantities = shopProductsAndQuantities
                .Where(v => v.Value > 0)
                .ToDictionary(k => k.Key, v => v.Value);


            foreach (var prduct in shopProductsAndQuantities)
            {
                Console.WriteLine($"{prduct.Key} -> {prduct.Value}");
            }
        }
    }
}
