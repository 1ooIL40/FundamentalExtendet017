namespace _08.Calories_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CaloriesCounter
    {
        public static void Main()
        {
            var numberOfIngredients = int.Parse(Console.ReadLine());

            var ingradientsCalories = new Dictionary<string, int>();
            var totalCaloriesAmount = 0;

            ingradientsCalories["cheese"] = 500;
            ingradientsCalories["tomato sauce"] = 150;
            ingradientsCalories["salami"] = 600;
            ingradientsCalories["pepper"] = 50;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                var ingradient = Console.ReadLine().ToLower();

                if (ingradientsCalories.ContainsKey(ingradient))
                {
                    totalCaloriesAmount += ingradientsCalories[ingradient];
                }
            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
