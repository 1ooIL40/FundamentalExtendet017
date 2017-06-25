namespace _02.Integer_Insertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(int.Parse)
                .ToList();

            var stringInput = Console.ReadLine();
            numbers = Insertion(numbers, stringInput);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> Insertion(List<int> numbers, string stringInput)
        {
            while (stringInput != "end")
            {
                var insertIndex = int.Parse(stringInput[0].ToString());
                var number = int.Parse(stringInput);

                numbers.Insert(insertIndex, number);

                stringInput = Console.ReadLine();
            }

            return numbers;
        }
    }
}
