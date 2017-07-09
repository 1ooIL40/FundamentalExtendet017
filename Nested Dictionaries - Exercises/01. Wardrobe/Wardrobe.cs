namespace _01.Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Wardrobe
    {
        public static void Main()
        {

            var dresses = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            AddCloths(dresses, n);

            string[] userWish = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            PrintCloths(dresses,userWish);
        }

        static void PrintCloths(Dictionary<string, Dictionary<string, int>> dresses, string[] userWish)
        {
            string color = userWish[0];
            string clothItem = userWish[1];


            foreach (var dress in dresses)
            {
                Console.WriteLine($"{dress.Key} clothes:");

                foreach (var type in dress.Value)
                {
                    if (dress.Key == color && type.Key == clothItem)
                    {
                        Console.WriteLine($"* {type.Key} - {type.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {type.Key} - {type.Value}");
                    }
                }
            }
        }

        static void AddCloths(Dictionary<string, Dictionary<string, int>> dresses, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] cloths = Console.ReadLine()
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string color = cloths[0];

                if (!dresses.ContainsKey(color))
                {
                    dresses[color] = new Dictionary<string, int>();
                }

                string[] clothes = cloths[1].Split(',');

                foreach (var cloth in clothes)
                {
                    if (!dresses[color].ContainsKey(cloth))
                    {
                        dresses[color][cloth] = 0;
                    }
                    dresses[color][cloth]++;
                }
            }
        }
    }
}
