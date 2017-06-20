namespace _05.Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            //split the list
            var leftHalf = numbers
                .Take(numbers.Count / 2)
                .ToList();

            var rightHalf = numbers
                .Skip(numbers.Count / 2)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < rightHalf.Count; i++)
            {
                //first numbers from each list
                var leftNum = leftHalf[i];
                var rightNum = rightHalf[i];

                //separete the number and get the first digit and last digit
                var first = rightNum / 10;
                var second = rightNum % 10;

                //add the numbers to the new list
                result.Add(first);
                result.Add(leftNum);
                result.Add(second);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
