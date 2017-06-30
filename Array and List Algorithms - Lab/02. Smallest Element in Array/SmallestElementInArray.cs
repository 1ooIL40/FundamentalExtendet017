namespace _02.Smallest_Element_in_Array
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            int numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                .Min();

            Console.WriteLine(numbers);
        }
    }
}
