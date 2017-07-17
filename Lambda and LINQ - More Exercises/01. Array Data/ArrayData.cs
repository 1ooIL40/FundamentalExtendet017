namespace _01.Array_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayData
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //Take the numbers bigger or equal to the average
            numbers = numbers
                .Where(num => num >= numbers.Average())
                .OrderBy(num => num)
                .ToList();

            string commands = Console.ReadLine();
            
            switch (commands)
            {
                case "Max":
                    Console.WriteLine(numbers.Max());
                    break;
                case "Min":
                    Console.WriteLine(numbers.Min());
                    break;
                case "All":
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
            }
        }
    }
}
